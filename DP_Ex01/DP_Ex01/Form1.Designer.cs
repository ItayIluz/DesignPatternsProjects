namespace DP_Ex01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxFeed = new System.Windows.Forms.PictureBox();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabLoginLogout = new System.Windows.Forms.TabPage();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelLoggedUserName = new System.Windows.Forms.Label();
            this.buttonLoginLogout = new System.Windows.Forms.Button();
            this.checkboxRememberMe = new System.Windows.Forms.CheckBox();
            this.tabFeed = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.labelFriends = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.listViewFriends = new System.Windows.Forms.ListView();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.tabAdditionalInfo = new System.Windows.Forms.TabPage();
            this.tabFeature1 = new System.Windows.Forms.TabPage();
            this.tabFeature2 = new System.Windows.Forms.TabPage();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelNumOfFriends = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.labelBirthdayValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).BeginInit();
            this.tabsControl.SuspendLayout();
            this.tabLoginLogout.SuspendLayout();
            this.tabFeed.SuspendLayout();
            this.tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFeed
            // 
            this.pictureBoxFeed.Location = new System.Drawing.Point(9, 7);
            this.pictureBoxFeed.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFeed.Name = "pictureBoxFeed";
            this.pictureBoxFeed.Size = new System.Drawing.Size(133, 123);
            this.pictureBoxFeed.TabIndex = 1;
            this.pictureBoxFeed.TabStop = false;
            this.pictureBoxFeed.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabLoginLogout);
            this.tabsControl.Controls.Add(this.tabFeed);
            this.tabsControl.Controls.Add(this.tabProfile);
            this.tabsControl.Controls.Add(this.tabAlbums);
            this.tabsControl.Controls.Add(this.tabAdditionalInfo);
            this.tabsControl.Controls.Add(this.tabFeature1);
            this.tabsControl.Controls.Add(this.tabFeature2);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.tabsControl.Location = new System.Drawing.Point(0, 0);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(982, 453);
            this.tabsControl.TabIndex = 5;
            // 
            // tabLoginLogout
            // 
            this.tabLoginLogout.Controls.Add(this.labelWelcome);
            this.tabLoginLogout.Controls.Add(this.labelLoggedUserName);
            this.tabLoginLogout.Controls.Add(this.buttonLoginLogout);
            this.tabLoginLogout.Controls.Add(this.checkboxRememberMe);
            this.tabLoginLogout.Location = new System.Drawing.Point(4, 28);
            this.tabLoginLogout.Name = "tabLoginLogout";
            this.tabLoginLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginLogout.Size = new System.Drawing.Size(974, 421);
            this.tabLoginLogout.TabIndex = 0;
            this.tabLoginLogout.Text = "Login";
            this.tabLoginLogout.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(11, 13);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(503, 47);
            this.labelWelcome.TabIndex = 9;
            this.labelWelcome.Text = "Hello! Please login to Facebook";
            // 
            // labelLoggedUserName
            // 
            this.labelLoggedUserName.AutoSize = true;
            this.labelLoggedUserName.Location = new System.Drawing.Point(118, 78);
            this.labelLoggedUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoggedUserName.Name = "labelLoggedUserName";
            this.labelLoggedUserName.Size = new System.Drawing.Size(0, 19);
            this.labelLoggedUserName.TabIndex = 8;
            this.labelLoggedUserName.Visible = false;
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.buttonLoginLogout.Location = new System.Drawing.Point(29, 67);
            this.buttonLoginLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoginLogout.Name = "buttonLoginLogout";
            this.buttonLoginLogout.Size = new System.Drawing.Size(100, 28);
            this.buttonLoginLogout.TabIndex = 5;
            this.buttonLoginLogout.Text = "Login";
            this.buttonLoginLogout.UseVisualStyleBackColor = true;
            this.buttonLoginLogout.Click += new System.EventHandler(this.buttonLoginLogout_Click);
            // 
            // checkboxRememberMe
            // 
            this.checkboxRememberMe.AutoSize = true;
            this.checkboxRememberMe.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.checkboxRememberMe.Location = new System.Drawing.Point(18, 103);
            this.checkboxRememberMe.Margin = new System.Windows.Forms.Padding(4);
            this.checkboxRememberMe.Name = "checkboxRememberMe";
            this.checkboxRememberMe.Size = new System.Drawing.Size(125, 23);
            this.checkboxRememberMe.TabIndex = 6;
            this.checkboxRememberMe.Text = "Remember Me";
            this.checkboxRememberMe.UseVisualStyleBackColor = true;
            // 
            // tabFeed
            // 
            this.tabFeed.Controls.Add(this.button1);
            this.tabFeed.Controls.Add(this.pictureBoxFeed);
            this.tabFeed.Location = new System.Drawing.Point(4, 28);
            this.tabFeed.Name = "tabFeed";
            this.tabFeed.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeed.Size = new System.Drawing.Size(974, 421);
            this.tabFeed.TabIndex = 1;
            this.tabFeed.Text = "Feed";
            this.tabFeed.UseVisualStyleBackColor = true;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.labelBirthdayValue);
            this.tabProfile.Controls.Add(this.labelNameValue);
            this.tabProfile.Controls.Add(this.labelNumOfFriends);
            this.tabProfile.Controls.Add(this.labelBirthday);
            this.tabProfile.Controls.Add(this.labelName);
            this.tabProfile.Controls.Add(this.labelEvents);
            this.tabProfile.Controls.Add(this.listViewEvents);
            this.tabProfile.Controls.Add(this.labelFriends);
            this.tabProfile.Controls.Add(this.pictureBoxProfile);
            this.tabProfile.Controls.Add(this.listViewFriends);
            this.tabProfile.Location = new System.Drawing.Point(4, 28);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(974, 421);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            this.tabProfile.Click += new System.EventHandler(this.tabProfile_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 211);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(10);
            this.labelName.Size = new System.Drawing.Size(70, 39);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name:";
            // 
            // labelEvents
            // 
            this.labelEvents.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelEvents.Location = new System.Drawing.Point(634, 44);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(251, 47);
            this.labelEvents.TabIndex = 5;
            this.labelEvents.Text = "Events";
            this.labelEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewEvents
            // 
            this.listViewEvents.Location = new System.Drawing.Point(635, 94);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(251, 216);
            this.listViewEvents.TabIndex = 4;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            // 
            // labelFriends
            // 
            this.labelFriends.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelFriends.Location = new System.Drawing.Point(331, 44);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(251, 47);
            this.labelFriends.TabIndex = 3;
            this.labelFriends.Text = "Friends";
            this.labelFriends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFriends.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(7, 7);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // listViewFriends
            // 
            this.listViewFriends.Location = new System.Drawing.Point(332, 94);
            this.listViewFriends.Name = "listViewFriends";
            this.listViewFriends.Size = new System.Drawing.Size(251, 216);
            this.listViewFriends.TabIndex = 0;
            this.listViewFriends.UseCompatibleStateImageBehavior = false;
            // 
            // tabAlbums
            // 
            this.tabAlbums.Location = new System.Drawing.Point(4, 28);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlbums.Size = new System.Drawing.Size(974, 421);
            this.tabAlbums.TabIndex = 3;
            this.tabAlbums.Text = "Albums";
            this.tabAlbums.UseVisualStyleBackColor = true;
            // 
            // tabAdditionalInfo
            // 
            this.tabAdditionalInfo.Location = new System.Drawing.Point(4, 28);
            this.tabAdditionalInfo.Name = "tabAdditionalInfo";
            this.tabAdditionalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdditionalInfo.Size = new System.Drawing.Size(974, 421);
            this.tabAdditionalInfo.TabIndex = 4;
            this.tabAdditionalInfo.Text = "Additional Info";
            this.tabAdditionalInfo.UseVisualStyleBackColor = true;
            // 
            // tabFeature1
            // 
            this.tabFeature1.Location = new System.Drawing.Point(4, 28);
            this.tabFeature1.Name = "tabFeature1";
            this.tabFeature1.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeature1.Size = new System.Drawing.Size(974, 421);
            this.tabFeature1.TabIndex = 5;
            this.tabFeature1.Text = "Feature 1";
            this.tabFeature1.UseVisualStyleBackColor = true;
            // 
            // tabFeature2
            // 
            this.tabFeature2.Location = new System.Drawing.Point(4, 28);
            this.tabFeature2.Name = "tabFeature2";
            this.tabFeature2.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeature2.Size = new System.Drawing.Size(974, 421);
            this.tabFeature2.TabIndex = 6;
            this.tabFeature2.Text = "Feature 2";
            this.tabFeature2.UseVisualStyleBackColor = true;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(6, 250);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Padding = new System.Windows.Forms.Padding(10);
            this.labelBirthday.Size = new System.Drawing.Size(89, 39);
            this.labelBirthday.TabIndex = 7;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelNumOfFriends
            // 
            this.labelNumOfFriends.AutoSize = true;
            this.labelNumOfFriends.Location = new System.Drawing.Point(6, 289);
            this.labelNumOfFriends.Name = "labelNumOfFriends";
            this.labelNumOfFriends.Padding = new System.Windows.Forms.Padding(10);
            this.labelNumOfFriends.Size = new System.Drawing.Size(121, 39);
            this.labelNumOfFriends.TabIndex = 8;
            this.labelNumOfFriends.Text = "Has 0 Friends";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelNameValue
            // 
            this.labelNameValue.AutoSize = true;
            this.labelNameValue.Location = new System.Drawing.Point(70, 211);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Padding = new System.Windows.Forms.Padding(10);
            this.labelNameValue.Size = new System.Drawing.Size(20, 39);
            this.labelNameValue.TabIndex = 9;
            // 
            // labelBirthdayValue
            // 
            this.labelBirthdayValue.AutoSize = true;
            this.labelBirthdayValue.Location = new System.Drawing.Point(97, 250);
            this.labelBirthdayValue.Name = "labelBirthdayValue";
            this.labelBirthdayValue.Padding = new System.Windows.Forms.Padding(10);
            this.labelBirthdayValue.Size = new System.Drawing.Size(20, 39);
            this.labelBirthdayValue.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.tabsControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Facebook App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).EndInit();
            this.tabsControl.ResumeLayout(false);
            this.tabLoginLogout.ResumeLayout(false);
            this.tabLoginLogout.PerformLayout();
            this.tabFeed.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFeed;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabFeed;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabAlbums;
        private System.Windows.Forms.TabPage tabAdditionalInfo;
        private System.Windows.Forms.TabPage tabFeature1;
        private System.Windows.Forms.TabPage tabFeature2;
        private System.Windows.Forms.TabPage tabLoginLogout;
        private System.Windows.Forms.Label labelLoggedUserName;
        private System.Windows.Forms.Button buttonLoginLogout;
        private System.Windows.Forms.CheckBox checkboxRememberMe;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListView listViewFriends;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumOfFriends;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelBirthdayValue;
        private System.Windows.Forms.Label labelNameValue;
    }
}

