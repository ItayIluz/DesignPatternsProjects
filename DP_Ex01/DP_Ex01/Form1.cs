using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP_Ex01
{
    public partial class Form1 : Form
    {
        private readonly string[] m_Permissions = {
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
        private User m_LoggedInUser;

        public Form1()
        {
            InitializeComponent();

            m_AppSettings = AppSettings.LoadFromFile();

            this.StartPosition = FormStartPosition.Manual;

            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkboxRememberMe.Checked = m_AppSettings.RememberUser;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

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
        }

        private void loginAndInit()
        {
            /// Owner: design.patterns
            LoginResult result = FacebookService.Login("1450160541956417", m_Permissions);
            
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
           /* if (m_LoggedInUser.Posts.Count > 0)
            {
                textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkboxRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
