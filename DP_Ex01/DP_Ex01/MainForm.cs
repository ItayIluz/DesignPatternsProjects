﻿using System;
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
        private bool m_profileDataLoaded = false;

        public MainForm()
        {
            InitializeComponent();

            m_AppSettings = AppSettings.LoadFromFile();

            this.StartPosition = FormStartPosition.Manual;

            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkboxRememberMe.Checked = m_AppSettings.RememberUser;

            enableTabsControlsIfUserLoggedIn();
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
            PleaseWaitDialog pleaseWaitDialog = new PleaseWaitDialog(this);

            if (selectedTab == tabProfile && !m_profileDataLoaded)
            {
                pleaseWaitDialog.Show();
                populateProfileData();
                pleaseWaitDialog.Hide();
            }

            if (selectedTab == tabFeed)
            {
                pleaseWaitDialog.Show();
                populateFeedData();
                pleaseWaitDialog.Hide();
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

            foreach (Album album in m_LoggedInUser.Albums)
            {
                Console.WriteLine(album.Name);
            }
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
                m_profileDataLoaded = true;
            }
            
            /* if (m_LoggedInUser.Posts.Count > 0)
             {
                 textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
             }*/
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                listBoxEvents.Items.Add("No Events to retrieve :(");
            }
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                listBoxFriends.Items.Add("No Friends to retrieve :(");
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

        private void pictureBox1_Click(object i_Sender, EventArgs i_EventArgs)
        {

        }

        private void buttonLoginLogout_Click_1(object i_Sender, EventArgs i_EventArgs)
        {

        }

        private void label1_Click(object i_Sender, EventArgs i_EventArgs)
        {

        }

        private void tabProfile_Click(object i_Sender, EventArgs i_EventArgs)
        {

        }
    }
}