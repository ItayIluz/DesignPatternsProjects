using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP_Ex02
{
    public partial class FacebookApplication : Form
    {
        private readonly string r_WelcomeMessage = "Hello! Please login to Facebook";
        private readonly string r_ConnectionErrorMessage = "Error - Could not connect to facebook.";
        private FBDataHandler m_FBDataHandler;
        private Thread m_InitializingThread;

        public FacebookApplication()
        {
            m_FBDataHandler = FBDataHandler.Instance;
            m_FBDataHandler.LoadAppSettingsFromFile();

            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;

            this.Size = m_FBDataHandler.AppSettings.LastWindowSize;
            this.Location = m_FBDataHandler.AppSettings.LastWindowLocation;
            this.checkboxRememberMe.Checked = m_FBDataHandler.AppSettings.RememberUser;

            enableTabsControlsIfUserLoggedIn();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            try
            {
                m_InitializingThread = new Thread(initializeUserData);
                m_FBDataHandler.ConnectToFacebookIfThereIsAnAccessTokenAndInitUserData(() => m_InitializingThread.Start());
            }
            catch (Facebook.WebExceptionWrapper exception)
            {
                MessageBox.Show(r_ConnectionErrorMessage);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Wait for initializing thread to finish in case the user closed the application when other operations did not finish
            m_InitializingThread.Join();

            base.OnFormClosing(e);

            m_FBDataHandler.SaveAppSettingsToFile(this.Size, this.Location, this.checkboxRememberMe.Checked);
        }

        private void buttonLoginLogout_Click(object sender, EventArgs e)
        {
            if (m_FBDataHandler.LoggedInUser != null)
            {
                m_FBDataHandler.LogoutFromFacebook(() =>
                {
                    tabLoginLogout.Text = "Login";
                    buttonLoginLogout.Text = "Login";
                    checkboxRememberMe.Show();
                    labelWelcome.Text = r_WelcomeMessage;
                    enableTabsControlsIfUserLoggedIn();
                });
            }
            else
            {
                m_InitializingThread = new Thread(initializeUserData);
                m_FBDataHandler.LoginToFacebookAndInitUserData(() => m_InitializingThread.Start());
            }
        }

        private void listBoxLatestsPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtendedPost selectedPost = m_FBDataHandler.ExtendedPosts[listBoxLatestsPosts.SelectedIndex];
            extendedPostBindingSource.DataSource = selectedPost;
            if (selectedPost.Post.Comments.Count > 0)
            {
                listBoxLatestPostComments.Invoke(new Action(() =>
                {
                    listBoxLatestPostComments.DisplayMember = "Message";
                    listBoxLatestPostComments.DataSource = selectedPost.Post.Comments;
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

        private void listViewAlbums_Click(object sender, EventArgs e)
        {
            new Thread(populateAlbumPhotosData).Start();
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_FBDataHandler.LoggedInUser.PostStatus(textBoxPostStatus.Text);
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
            showWordStatisticsButton.Invoke(new Action(() => 
            {
                showWordStatisticsButton.Text = "Fetching...";
                showWordStatisticsButton.Enabled = false;
            }));

            List<KeyValuePair<string, WordUsageStatistics.WordUsageData>> orderedWordsUsageData = m_FBDataHandler.WordUsageStatistics.GetWordUsageStatisticsOfPosts(startDatePicker.Value, endDatePicker.Value);
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
            if (buttonCalculateFriendsUserLikesMost.InvokeRequired)
            {
                buttonCalculateFriendsUserLikesMost.Invoke(new Action(() =>
                {
                    buttonCalculateFriendsUserLikesMost.Text = "Fetching...";
                    buttonCalculateFriendsUserLikesMost.Enabled = false;
                }));
            }

            m_FBDataHandler.MostLikedFeature.CalculateMostLikedFriends();
            populateDataGridViewForMostLikedFeature(dataGridViewFriendsUserLikesMost, m_FBDataHandler.MostLikedFeature.MostLikedFriends);
            if(buttonCalculateFriendsUserLikesMost.InvokeRequired)
            {
                buttonCalculateFriendsUserLikesMost.Invoke(new Action(() =>
                {
                    buttonCalculateFriendsUserLikesMost.Enabled = true;
                    buttonCalculateFriendsUserLikesMost.Text = "Fetch";
                }));
            }
        }

        private void buttonCalculateFriendsWhoLikeUserMost_Click(object sender, EventArgs e)
        {
            new Thread(runCalculateFriendsWhoLikeUserMost).Start();
        }

        private void runCalculateFriendsWhoLikeUserMost()
        {
            if (buttonCalculateMostLikedByFriends.InvokeRequired)
            {
                buttonCalculateMostLikedByFriends.Invoke(new Action(() =>
                {
                    buttonCalculateMostLikedByFriends.Text = "Fetching...";
                    buttonCalculateMostLikedByFriends.Enabled = false;
                }));
            }

            m_FBDataHandler.MostLikedFeature.CalculateFriendsWhoLikeUserMost();
            populateDataGridViewForMostLikedFeature(dataGridViewFriendsWhoLikeUserMost, m_FBDataHandler.MostLikedFeature.FriendsWhoLikesUserMost);
            if(buttonCalculateMostLikedByFriends.InvokeRequired)
            {
                buttonCalculateMostLikedByFriends.Invoke(new Action(() =>
                {
                    buttonCalculateMostLikedByFriends.Enabled = true;
                    buttonCalculateMostLikedByFriends.Text = "Fetch";
                }));
            }
        }

        private void populateDataGridViewForMostLikedFeature(DataGridView i_GridViewToPopulate, Dictionary<string, int> i_DataSource)
        {
            if(i_DataSource.Count != 0)
            {
                List<KeyValuePair<string, int>> sortedResultList = i_DataSource.ToList();
                sortedResultList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
                if(i_GridViewToPopulate.InvokeRequired)
                {
                    i_GridViewToPopulate.Invoke(new Action(() =>
                    {
                        i_GridViewToPopulate.DataSource = sortedResultList;
                        i_GridViewToPopulate.Columns[0].HeaderText = "Friend";
                        i_GridViewToPopulate.Columns[1].HeaderText = "Total Likes";
                    }));
                }
            }
            else
            {
                MessageBox.Show("No data found :(");
            }
        }

        private void initializeUserData()
        {
            if (!string.IsNullOrEmpty(m_FBDataHandler.LoginResult.AccessToken))
            {
                tabLoginLogout.Invoke(new Action(() => tabLoginLogout.Text = "Logout"));
                buttonLoginLogout.Invoke(new Action(() => buttonLoginLogout.Text = "Logout"));
                checkboxRememberMe.Invoke(new Action(() => checkboxRememberMe.Hide()));
                labelWelcome.Invoke(new Action(() => labelWelcome.Text = string.Format("Hello {0}!", m_FBDataHandler.LoggedInUser.Name)));
                tabsControl.Invoke(new Action(() => tabsControl.SelectedTab = tabFeed));
                new Thread(populateProfileData).Start();
                new Thread(populateFeedData).Start();
                new Thread(populateAdditionalInfo).Start();
                new Thread(populateAlbumsData).Start();
                enableTabsControlsIfUserLoggedIn();
            }
            else
            {
                MessageBox.Show(m_FBDataHandler.LoginResult.ErrorMessage);
            }
        }

        private void enableTabsControlsIfUserLoggedIn()
        {
            foreach (TabPage page in tabsControl.TabPages)
            {
                if (page != tabLoginLogout)
                {
                    foreach (Control control in page.Controls)
                    {
                        if (control.InvokeRequired)
                        {
                            control.Invoke(new Action(() => control.Enabled = m_FBDataHandler.LoggedInUser != null));
                        }
                        else
                        {
                            control.Enabled = m_FBDataHandler.LoggedInUser != null;
                        }
                    }
                }
            }
        }

        private void populateAlbumsData()
        {
            if (m_FBDataHandler.LoggedInUser != null)
            {
                ImageList albumList = new ImageList();
                albumList.ImageSize = new Size(128, 128);
                int i = 0;

                buttonGoBackToAlbums.Invoke(new Action(() => buttonGoBackToAlbums.Enabled = false));
                listViewAlbums.Invoke(new Action(() =>
                {
                    listViewAlbums.Clear();
                    if (listViewAlbums.LargeImageList != null)
                    {
                        listViewAlbums.LargeImageList.Dispose();
                    }
                }));

                foreach (Album album in m_FBDataHandler.LoggedInUser.Albums)
                {
                    string albumKey = "album" + i;
                    albumList.Images.Add(albumKey, album.ImageThumb);
                    if (listViewAlbums.InvokeRequired)
                    {
                        listViewAlbums.Invoke(new Action(() =>
                        {
                            ListViewItem item = listViewAlbums.Items.Add(album.Name);
                            item.ImageKey = albumKey;
                            item.ImageIndex = i;
                        }));
                        i++;
                    }
                }

                if (listViewAlbums.InvokeRequired)
                {
                    listViewAlbums.Invoke(new Action(() => listViewAlbums.LargeImageList = albumList));
                }
            }
        }

        private void populateAlbumPhotosData()
        {
            Album album = null;
            dynamic selectedAlbum = null;
            listViewAlbums.Invoke(new Action(() =>
            {
                selectedAlbum = listViewAlbums.SelectedItems[0];
            }));
            album = m_FBDataHandler.LoggedInUser.Albums.Find(albumToFind => albumToFind.Name.Equals(selectedAlbum.Text));

            if (album != null)
            {
                ImageList photosList = new ImageList();
                photosList.ImageSize = new Size(128, 128);
                int i = 0;

                buttonGoBackToAlbums.Invoke(new Action(() => buttonGoBackToAlbums.Enabled = true));
                listViewAlbums.Invoke(new Action(() =>
                {
                    listViewAlbums.Clear();
                    listViewAlbums.LargeImageList.Dispose();
                }));

                foreach (Photo photo in album.Photos)
                {
                    string imageKey = album.Name + "Image" + i;
                    photosList.Images.Add(imageKey, photo.ImageNormal);
                    listViewAlbums.Invoke(new Action(() =>
                    {
                        ListViewItem item = listViewAlbums.Items.Add(photo.Name);
                        item.ImageKey = imageKey;
                        item.ImageIndex = i;
                    }));
                    i++;
                }

                listViewAlbums.Invoke(new Action(() => listViewAlbums.LargeImageList = photosList));
            }
        }

        private void populateFeedData()
        {
            if (m_FBDataHandler.LoggedInUser != null)
            {
                pictureBoxFeed.LoadAsync(m_FBDataHandler.LoggedInUser.PictureNormalURL);
                fetchPosts();
            }
        }

        private void populateProfileData()
        {
            if (m_FBDataHandler.LoggedInUser != null)
            {
                pictureBoxProfile.LoadAsync(m_FBDataHandler.LoggedInUser.PictureNormalURL);
                labelNameValue.Invoke(new Action(() => labelNameValue.Text = m_FBDataHandler.LoggedInUser.Name));
                labelBirthdayValue.Invoke(new Action(() => labelBirthdayValue.Text = m_FBDataHandler.LoggedInUser.Birthday));
                labelNumOfFriends.Invoke(new Action(() => labelNumOfFriends.Text = string.Format("Has {0} friends.", m_FBDataHandler.LoggedInUser.Friends.Count)));
                fetchFriends();
                fetchEvents();
            }
        }

        private void populateAdditionalInfo()
        {
            if (m_FBDataHandler.LoggedInUser != null)
            {
                fetchCheckins();
                fetchLikedPages();
            }
        }

        private void fetchEvents()
        {
            listBoxEvents.Invoke(new Action(() =>
            {
                listBoxEvents.Items.Clear();
                listBoxEvents.DisplayMember = "Name";
            }));

            if (m_FBDataHandler.LoggedInUser.Events.Count == 0)
            {
                foreach (Event fbEvent in m_FBDataHandler.LoggedInUser.Events)
                {
                    listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(fbEvent)));
                }
            }
            else
            {
                listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add("No Events to retrieve :(")));
            }
        }

        private void fetchFriends()
        {
            listBoxFriends.Invoke(new Action(() =>
            {
                listBoxFriends.Items.Clear();
                listBoxFriends.DisplayMember = "Name";
            }));

            if (m_FBDataHandler.LoggedInUser.Friends.Count != 0)
            {
                foreach (User friend in m_FBDataHandler.LoggedInUser.Friends)
                {
                    listBoxFriends.Invoke(new Action(() =>
                    {
                        listBoxFriends.Items.Add(friend);
                    }));
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
            else
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add("No Friends to retrieve :(")));
            }
        }

        private void fetchPosts()
        {
            listBoxLatestsPosts.Invoke(new Action(() => listBoxLatestsPosts.Items.Clear()));
            listBoxLatestPostComments.Invoke(new Action(() => listBoxLatestPostComments.Items.Clear()));

            if (m_FBDataHandler.LoggedInUser.Posts.Count != 0)
            {
                foreach (ExtendedPost post in m_FBDataHandler.ExtendedPosts)
                {
                    if(listBoxLatestsPosts.InvokeRequired)
                    {
                        listBoxLatestsPosts.Invoke(new Action(() =>
                        {
                            if (post.Post.Message != null)
                            {
                                listBoxLatestsPosts.Items.Add(post.Post.Message);
                            }
                            else if (post.Post.Caption != null)
                            {
                                listBoxLatestsPosts.Items.Add(post.Post.Caption);
                            }
                            else
                            {
                                listBoxLatestsPosts.Items.Add(string.Format("[{0}]", post.Post.Type));
                            }
                        }));
                    }
                }

                if (listBoxLatestsPosts.InvokeRequired)
                {
                    listBoxLatestPostComments.Invoke(new Action(() => listBoxLatestPostComments.Items.Add("Click on a post to see its comments.")));
                }
            }
            else
            {
                if (listBoxLatestsPosts.InvokeRequired)
                {
                    listBoxLatestsPosts.Invoke(new Action(() => listBoxLatestsPosts.Items.Add("No Posts to retrieve :(")));
                }
            }
        }

        private void fetchCheckins()
        {
            if (listBoxCheckins.InvokeRequired)
            {
                listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Clear()));
            }

            if (m_FBDataHandler.LoggedInUser.Checkins.Count != 0)
            {
                foreach (Checkin checkin in m_FBDataHandler.LoggedInUser.Checkins)
                {
                    if (listBoxCheckins.InvokeRequired)
                    {
                        listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add(checkin.Place.Name)));
                    }
                }
            }
            else
            {
                if (listBoxCheckins.InvokeRequired)
                {
                    listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add("No Checkins to retrieve :(")));
                }
            }
        }

        private void fetchLikedPages()
        {
            if(listBoxLikedPages.InvokeRequired)
            {
                listBoxLikedPages.Invoke(new Action(() =>
                {
                    listBoxLikedPages.Items.Clear();
                    listBoxLikedPages.DisplayMember = "Name";
                }));
            }

            if (m_FBDataHandler.LoggedInUser.LikedPages.Count != 0)
            {
                foreach (Page page in m_FBDataHandler.LoggedInUser.LikedPages)
                {
                    if (listBoxLikedPages.InvokeRequired)
                    {
                        listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add(page)));
                    }
                }
            }
            else
            {
                if (listBoxLikedPages.InvokeRequired)
                {
                    listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add("No liked pages to retrieve :(")));
                }
            }
        }
    }
}
