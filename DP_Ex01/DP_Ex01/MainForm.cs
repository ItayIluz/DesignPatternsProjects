using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP_Ex01
{
    public partial class MainForm : Form
    {
        private readonly string r_WelcomeMessage = "Hello! Please login to Facebook";
        private readonly string[] r_Permissions = 
        {
            "public_profile",
            "email",
            "publish_to_groups",
            "user_birthday",
            "user_age_range",
            "user_gender",
            "user_link",
            "user_tagged_places",
            "user_videos",
            "publish_to_groups",
            "groups_access_member_info",
            "user_friends",
            "user_events",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_hometown"
        };

        private AppSettings m_AppSettings;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser = null;
        private bool m_ProfileDataLoaded = false;
        private bool m_FeedDataLoaded = false;
        private bool m_AdditionalInfoDataLoaded = false;
        private readonly PleaseWaitDialog r_PleaseWaitDialog;

        public MainForm()
        {
            InitializeComponent();

            m_AppSettings = AppSettings.LoadFromFile();

            this.StartPosition = FormStartPosition.Manual;

            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkboxRememberMe.Checked = m_AppSettings.RememberUser;

            enableTabsControlsIfUserLoggedIn();
            r_PleaseWaitDialog = new PleaseWaitDialog(this);
        }

        private void enableTabsControlsIfUserLoggedIn()
        {
            foreach (TabPage page in tabsControl.TabPages)
            {
                if (page != tabLoginLogout)
                {
                    foreach (Control control in page.Controls)
                    {
                        control.Enabled = m_LoggedInUser != null;
                    }
                }
            }
        }

        protected override void OnShown(EventArgs i_EventArgs)
        {
            base.OnShown(i_EventArgs);

            if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                initializeUserData();
            }

            tabsControl.Selected += new TabControlEventHandler(onTabControlSelect);
        }

        private void onTabControlSelect(object i_Sender, TabControlEventArgs i_Args)
        {
            TabPage selectedTab = (i_Sender as TabControl).SelectedTab;

            if (selectedTab == tabProfile && !m_ProfileDataLoaded)
            {
                r_PleaseWaitDialog.Show();
                populateProfileData();
                r_PleaseWaitDialog.Hide();
            }

            if (selectedTab == tabFeed && !m_FeedDataLoaded)
            {
                r_PleaseWaitDialog.Show();
                populateFeedData();
                r_PleaseWaitDialog.Hide();
            }

            if (selectedTab == tabAdditionalInfo && !m_AdditionalInfoDataLoaded)
            {
                r_PleaseWaitDialog.Show();
                populateAdditionalInfo();
                r_PleaseWaitDialog.Hide();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs i_EventArgs)
        {
            base.OnFormClosing(i_EventArgs);

            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.RememberUser = this.checkboxRememberMe.Checked;
            if(m_AppSettings.RememberUser)
            {
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.LastAccessToken = null;
            }

            m_AppSettings.SaveToFile();
        }

        private void initializeUserData()
        {
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;     
                tabLoginLogout.Text = "Logout";
                buttonLoginLogout.Text = "Logout";
                checkboxRememberMe.Hide();
                labelWelcome.Text = string.Format("Hello {0}!", m_LoggedInUser.Name);
                tabsControl.SelectedTab = tabFeed;
                populateFeedData();
                enableTabsControlsIfUserLoggedIn();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }

        private void populateFeedData()
        {
            pictureBoxFeed.LoadAsync(m_LoggedInUser.PictureNormalURL);
            fetchPosts();
            m_FeedDataLoaded = true;
           /* foreach (Album album in m_LoggedInUser.Albums)
            {
                Console.WriteLine(album.Name);
            }*/
        }

        private void populateProfileData()
        {
            if(m_LoggedInUser != null)
            {
                pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
                labelNameValue.Text = m_LoggedInUser.Name;
                labelBirthdayValue.Text = m_LoggedInUser.Birthday;
                labelNumOfFriends.Text = string.Format("Has {0} friends.", m_LoggedInUser.Friends.Count);
                fetchFriends();
                fetchEvents();
                m_ProfileDataLoaded = true;
            }
            
            /* if (m_LoggedInUser.Posts.Count > 0)
             {
                 textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
             }*/
        }

        private void populateAdditionalInfo()
        {
            fetchCheckins();
            fetchLikedPages();
            m_AdditionalInfoDataLoaded = true;
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";

            if (m_LoggedInUser.Events.Count == 0)
            {
                foreach (Event fbEvent in m_LoggedInUser.Events)
                {
                    listBoxEvents.Items.Add(fbEvent);
                }
            }
            else
            {
                listBoxEvents.Items.Add("No Events to retrieve :(");

            }
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";

            if (m_LoggedInUser.Friends.Count != 0)
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    listBoxFriends.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
            else
            {
                listBoxFriends.Items.Add("No Friends to retrieve :(");
            }
        }

        private void fetchPosts()
        {
            if (m_LoggedInUser.Posts.Count != 0)
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxLatestsPosts.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        listBoxLatestsPosts.Items.Add(post.Caption);
                    }
                    else
                    {
                        listBoxLatestsPosts.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }
                listBoxLatestPostComments.Items.Add("Click on a post to see its comments.");
            }
            else
            {
                listBoxLatestsPosts.Items.Add("No Posts to retrieve :(");
            }
        }

        private void listBoxLatestsPosts_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            Post selectedPost = m_LoggedInUser.Posts[listBoxLatestsPosts.SelectedIndex];
            if (selectedPost.Comments.Count > 0)
            {
                listBoxLatestPostComments.DisplayMember = "Message";
                listBoxLatestPostComments.DataSource = selectedPost.Comments;
            }
            else
            {
                listBoxLatestPostComments.Items.Clear();
                listBoxLatestPostComments.Items.Add("No comments.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void logout()
        {
            FacebookService.Logout(() => 
                {
                    tabLoginLogout.Text = "Login";
                    buttonLoginLogout.Text = "Login";
                    checkboxRememberMe.Show();
                    labelWelcome.Text = r_WelcomeMessage;
                    m_LoggedInUser = null;
                    m_LoginResult = null;
                    enableTabsControlsIfUserLoggedIn();
                }
            );
            
        }

        private void buttonLoginLogout_Click(object i_Sender, EventArgs i_EventArgs)
        {
            if(m_LoggedInUser != null)
            {
                logout();
            }
            else
            {
                /// Owner: design.patterns
                m_LoginResult = FacebookService.Login("1450160541956417", r_Permissions);
                initializeUserData();
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_LoggedInUser.PostStatus(textBoxPostStatus.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        private void fetchCheckins()
        {
            if (m_LoggedInUser.Checkins.Count != 0)
            {
                foreach (Checkin checkin in m_LoggedInUser.Checkins)
                {
                    listBoxCheckins.Items.Add(checkin.Place.Name);
                }
            }
            else
            {
                listBoxCheckins.Items.Add("No Checkins to retrieve :(");
            }
        }

        private void comboBoxShowActions_SelectedValueChanged(object i_Sender, EventArgs i_EventArgs)
        {
            string actionType = comboBoxShowActions.SelectedItem.ToString();
            FacebookObjectCollection<Page> actions = FacebookService.GetCollection<Page>(actionType);
            dynamic actionsData = FacebookService.GetDynamicData(actionType);
            dataGridShowActions.DataSource = actions;
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            if (m_LoggedInUser.LikedPages.Count != 0)
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxLikedPages.Items.Add(page);
                }
            }
            else            
            {
                listBoxLikedPages.Items.Add("No liked pages to retrieve :(");
            }
        }
    }
}
