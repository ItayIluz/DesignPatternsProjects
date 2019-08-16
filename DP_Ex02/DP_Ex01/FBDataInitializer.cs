using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DP_Ex02
{
    public partial class FacebookApplication
    {
        private void initializeUserData()
        {
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                m_MostLikedFeature = new MostLikedFeature(m_LoggedInUser);
                tabLoginLogout.Invoke(new Action(() => tabLoginLogout.Text = "Logout"));
                buttonLoginLogout.Invoke(new Action(() => buttonLoginLogout.Text = "Logout"));
                checkboxRememberMe.Invoke(new Action(() => checkboxRememberMe.Hide()));
                labelWelcome.Invoke(new Action(() => labelWelcome.Text = string.Format("Hello {0}!", m_LoggedInUser.Name)));
                tabsControl.Invoke(new Action(() => tabsControl.SelectedTab = tabFeed));
                new Thread(populateProfileData).Start();
                new Thread(populateFeedData).Start();
                new Thread(populateAdditionalInfo).Start();
                new Thread(populateAlbumsData).Start();
                enableTabsControlsIfUserLoggedIn();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
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
                            control.Invoke(new Action(() => control.Enabled = m_LoggedInUser != null));
                        }
                        else
                        {
                            control.Enabled = m_LoggedInUser != null;
                        }
                    }
                }
            }
        }

        private void populateAlbumsData()
        {
            if (m_LoggedInUser != null)
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

                foreach (Album album in m_LoggedInUser.Albums)
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
            album = m_LoggedInUser.Albums.Find(albumToFind => albumToFind.Name.Equals(selectedAlbum.Text));

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
            if (m_LoggedInUser != null)
            {
                pictureBoxFeed.LoadAsync(m_LoggedInUser.PictureNormalURL);
                fetchPosts();
            }
        }

        private void populateProfileData()
        {
            if (m_LoggedInUser != null)
            {
                pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
                labelNameValue.Invoke(new Action(() => labelNameValue.Text = m_LoggedInUser.Name));
                labelBirthdayValue.Invoke(new Action(() => labelBirthdayValue.Text = m_LoggedInUser.Birthday));
                labelNumOfFriends.Invoke(new Action(() => labelNumOfFriends.Text = string.Format("Has {0} friends.", m_LoggedInUser.Friends.Count)));
                fetchFriends();
                fetchEvents();
            }
        }

        private void populateAdditionalInfo()
        {
            if (m_LoggedInUser != null)
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

            if (m_LoggedInUser.Events.Count == 0)
            {
                foreach (Event fbEvent in m_LoggedInUser.Events)
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

            if (m_LoggedInUser.Friends.Count != 0)
            {
                foreach (User friend in m_LoggedInUser.Friends)
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

            if (m_LoggedInUser.Posts.Count != 0)
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    listBoxLatestsPosts.Invoke(new Action(() =>
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
                    }));
                }

                listBoxLatestPostComments.Invoke(new Action(() => listBoxLatestPostComments.Items.Add("Click on a post to see its comments.")));
            }
            else
            {
                listBoxLatestsPosts.Invoke(new Action(() => listBoxLatestsPosts.Items.Add("No Posts to retrieve :(")));
            }
        }

        private void fetchCheckins()
        {
            listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Clear()));

            if (m_LoggedInUser.Checkins.Count != 0)
            {
                foreach (Checkin checkin in m_LoggedInUser.Checkins)
                {
                    listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add(checkin.Place.Name)));
                }
            }
            else
            {
                listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add("No Checkins to retrieve :(")));
            }
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Invoke(new Action(() =>
            {
                listBoxLikedPages.Items.Clear();
                listBoxLikedPages.DisplayMember = "Name";
            }));

            if (m_LoggedInUser.LikedPages.Count != 0)
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add(page)));
                }
            }
            else
            {
                listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add("No liked pages to retrieve :(")));
            }
        }
    }
}
