﻿using System;
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
        private readonly string r_WelcomeMessage = "Hello! Please login to Facebook";
        private readonly string[] r_Permissions = {
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

        public Form1()
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
                if (page.Name != "tabLoginLogout")
                {
                    foreach (Control control in page.Controls)
                    {
                        control.Enabled = m_LoggedInUser != null;
                    }
                }
            }
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

            m_AppSettings.SaveToFile();
        }

        private void loginAndInit()
        {
            /// Owner: design.patterns
            LoginResult result = FacebookService.Login("1450160541956417", r_Permissions);
            
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
                tabLoginLogout.Text = "Logout";
                buttonLoginLogout.Text = "Logout";
                checkboxRememberMe.Hide();
                labelWelcome.Text = string.Format("Hello {0}!", m_LoggedInUser.Name);
                tabsControl.SelectedTab = tabFeed;
                enableTabsControlsIfUserLoggedIn();
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

        private void logout()
        {
            tabLoginLogout.Text = "Login";   
            buttonLoginLogout.Text = "Login";
            checkboxRememberMe.Show();
            labelWelcome.Text = r_WelcomeMessage;
            m_LoggedInUser = null;
            m_LoginResult = null;
            FacebookService.Logout(() => {});
            enableTabsControlsIfUserLoggedIn();
        }

        private void buttonLoginLogout_Click(object sender, EventArgs e)
        {
            if(m_LoggedInUser != null)
            {
                logout();
            }
            else
            {
                loginAndInit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoginLogout_Click_1(object sender, EventArgs e)
        {

        }
    }
}
