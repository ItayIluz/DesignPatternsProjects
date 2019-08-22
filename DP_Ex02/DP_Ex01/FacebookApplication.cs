using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;

namespace DP_Ex02
{
    public partial class FacebookApplication : Form
    {
        private readonly string r_WelcomeMessage = "Hello! Please login to Facebook";
        private readonly string r_ConnectionErrorMessage = "Error - Could not connect to facebook.";
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
        private MostLikedFeature m_MostLikedFeature;
        private WordUsageStatistics m_WordUsageStatistics;

        public FacebookApplication()
        {
            m_AppSettings = AppSettings.LoadFromFile();

            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;

            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkboxRememberMe.Checked = m_AppSettings.RememberUser;

            enableTabsControlsIfUserLoggedIn();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                try
                {
                    m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                    new Thread(initializeUserData).Start();
                }
                catch (Facebook.WebExceptionWrapper exception)
                {
                    MessageBox.Show(r_ConnectionErrorMessage);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.RememberUser = this.checkboxRememberMe.Checked;
            if (m_LoginResult != null && m_AppSettings.RememberUser)
            {
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.LastAccessToken = null;
            }

            m_AppSettings.SaveToFile();
        }

        private void listBoxLatestsPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selectedPost = m_LoggedInUser.Posts[listBoxLatestsPosts.SelectedIndex];
            if (selectedPost.Comments.Count > 0)
            {
                listBoxLatestPostComments.Invoke(new Action(() =>
                {
                    listBoxLatestPostComments.DisplayMember = "Message";
                    listBoxLatestPostComments.DataSource = selectedPost.Comments;
                }));
            }
            else
            {
                listBoxLatestPostComments.Invoke(new Action(() =>
                {
                    listBoxLatestPostComments.Items.Clear();
                    listBoxLatestPostComments.Items.Add("No comments.");
                }));
            }
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
            });
        }

        private void listViewAlbums_Click(object sender, EventArgs e)
        {
            new Thread(populateAlbumPhotosData).Start();
        }

        private void buttonLoginLogout_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                logout();
            }
            else
            {
                /// Owner: design.patterns
                m_LoginResult = FacebookService.Login("1450160541956417", r_Permissions);
                new Thread(initializeUserData).Start();
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_LoggedInUser.PostStatus(textBoxPostStatus.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        private void comboBoxShowActions_SelectedValueChanged(object sender, EventArgs e)
        {
            string actionType = comboBoxShowActions.SelectedItem.ToString();
            FacebookObjectCollection<Page> actions = FacebookService.GetCollection<Page>(actionType);
            dynamic actionsData = FacebookService.GetDynamicData(actionType);
            dataGridShowActions.DataSource = actions;
        }

        private void showWordStatisticsButton_Click(object sender, EventArgs e)
        {
            new Thread(showWordStatistics).Start();
        }

        private void showWordStatistics()
        {
            int wordPanelWidth = 0;
            showWordStatisticsButton.Invoke(new Action(()=> 
            {
                showWordStatisticsButton.Text = "Fetching...";
                showWordStatisticsButton.Enabled = false;
            }));

            List<KeyValuePair<string, WordUsageStatistics.WordUsageData>> orderedWordsUsageData = m_WordUsageStatistics.GetWordUsageStatisticsOfPosts(startDatePicker.Value, endDatePicker.Value);
            wordUsageDataPanel.Invoke(new Action(() =>
            {
                wordUsageDataPanel.Controls.Clear();
                wordPanelWidth = wordUsageDataPanel.ClientSize.Width - 25;
            }));
            
            foreach (KeyValuePair<string, WordUsageStatistics.WordUsageData> wordUsageData in orderedWordsUsageData)
            {
                WordUsageDataPanel wordPanel = new WordUsageDataPanel();
                Label wordLabel = new Label();
                Label infoLable = new Label();

                wordPanel.BackColor = Color.FromArgb(230, 230, 250);
                wordPanel.Size = new Size(wordPanelWidth, 65);
                wordPanel.BorderStyle = BorderStyle.FixedSingle;
                wordPanel.Posts = wordUsageData.Value.Posts;

                wordLabel.Text = wordUsageData.Key;
                wordLabel.Font = new Font(wordLabel.Font, FontStyle.Bold);
                wordLabel.Top = 5;
                wordLabel.Left = 15;
                wordPanel.Controls.Add(wordLabel);

                infoLable.Text = string.Format("used {0} times{1}in {2} posts", wordUsageData.Value.OccurrencesCount, Environment.NewLine, wordUsageData.Value.Posts.Count);
                infoLable.Top = 25;
                infoLable.Left = 15;
                infoLable.Height = 30;
                wordPanel.Controls.Add(infoLable);
                wordUsageDataPanel.Invoke(new Action(() => wordUsageDataPanel.Controls.Add(wordPanel)));

                wordPanel.Click += showPostsWithSelectedWord;
            }

            showWordStatisticsButton.Invoke(new Action(() =>
            {
                showWordStatisticsButton.Enabled = true;
                showWordStatisticsButton.Text = "Show Word Usage Statistics";
            }));
        }

        private void showPostsWithSelectedWord(object sender, EventArgs e)
        {
            WordUsageDataPanel wordPanel = sender as WordUsageDataPanel;

            wordUsagePostsPanel.Controls.Clear();
            int postPanelWidth = wordUsagePostsPanel.ClientSize.Width - 25;
            foreach (string post in wordPanel.Posts)
            {
                Panel panel = new Panel();
                Label postText = new Label();
                postText.Text = post;
                postText.AutoSize = true;
                postText.MaximumSize = new Size(postPanelWidth, int.MaxValue);

                panel.BackColor = Color.FromArgb(230, 230, 250);
                panel.Size = new Size(postPanelWidth, 65);
                panel.MaximumSize = new Size(postPanelWidth, int.MaxValue);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(postText);

                wordUsagePostsPanel.Controls.Add(panel);
            }
        }

        private void buttonGoBackToAlbums_Click(object sender, EventArgs e)
        {
            new Thread(populateAlbumsData).Start();
        }

        private void buttonCalculateFriendsUserLikesMost_Click(object sender, EventArgs e)
        {
            new Thread(runCalculateFriendsUserLikesMost).Start();
        }

        private void runCalculateFriendsUserLikesMost()
        {
            buttonCalculateFriendsUserLikesMost.Invoke(new Action(() =>
            {
                buttonCalculateFriendsUserLikesMost.Text = "Fetching...";
                buttonCalculateFriendsUserLikesMost.Enabled = false;
            }));

            m_MostLikedFeature.CalculateMostLikedFriends();
            populateDataGridViewForMostLikedFeature(dataGridViewFriendsUserLikesMost, m_MostLikedFeature.MostLikedFriends);
            buttonCalculateFriendsUserLikesMost.Invoke(new Action(() =>
            {
                buttonCalculateFriendsUserLikesMost.Enabled = true;
                buttonCalculateFriendsUserLikesMost.Text = "Fetch";
            }));
        }

        private void buttonCalculateFriendsWhoLikeUserMost_Click(object sender, EventArgs e)
        {
            new Thread(runCalculateFriendsWhoLikeUserMost).Start();
        }

        private void runCalculateFriendsWhoLikeUserMost()
        {
            buttonCalculateMostLikedByFriends.Invoke(new Action(() => 
            {
                buttonCalculateMostLikedByFriends.Text = "Fetching...";
                buttonCalculateMostLikedByFriends.Enabled = false;
            }));

            m_MostLikedFeature.CalculateFriendsWhoLikeUserMost();
            populateDataGridViewForMostLikedFeature(dataGridViewFriendsWhoLikeUserMost, m_MostLikedFeature.FriendsWhoLikesUserMost);
            buttonCalculateMostLikedByFriends.Invoke(new Action(() =>
            {
                buttonCalculateMostLikedByFriends.Enabled = true;
                buttonCalculateMostLikedByFriends.Text = "Fetch";
            }));
        }

        private void populateDataGridViewForMostLikedFeature(DataGridView i_GridViewToPopulate, Dictionary<string, int> i_DataSource)
        {
            if(i_DataSource.Count != 0)
            {
                List<KeyValuePair<string, int>> sortedResultList = i_DataSource.ToList();
                sortedResultList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
                i_GridViewToPopulate.Invoke(new Action(() => 
                {
                    i_GridViewToPopulate.DataSource = sortedResultList;
                    i_GridViewToPopulate.Columns[0].HeaderText = "Friend";
                    i_GridViewToPopulate.Columns[1].HeaderText = "Total Likes";
                }));
            }
            else
            {
                MessageBox.Show("No data found :(");
            }
        } 
    }
}
