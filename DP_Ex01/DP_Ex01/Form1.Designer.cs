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
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabLoginLogout = new System.Windows.Forms.TabPage();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelLoggedUserName = new System.Windows.Forms.Label();
            this.buttonLoginLogout = new System.Windows.Forms.Button();
            this.checkboxRememberMe = new System.Windows.Forms.CheckBox();
            this.tabFeed = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.tabAdditionalInfo = new System.Windows.Forms.TabPage();
            this.tabFeature1 = new System.Windows.Forms.TabPage();
            this.tabFeature2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.tabsControl.SuspendLayout();
            this.tabLoginLogout.SuspendLayout();
            this.tabFeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(9, 7);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(133, 123);
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.tabLoginLogout.Location = new System.Drawing.Point(4, 25);
            this.tabLoginLogout.Name = "tabLoginLogout";
            this.tabLoginLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginLogout.Size = new System.Drawing.Size(974, 424);
            this.tabLoginLogout.TabIndex = 0;
            this.tabLoginLogout.Text = "Login";
            this.tabLoginLogout.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(11, 13);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(497, 39);
            this.labelWelcome.TabIndex = 9;
            this.labelWelcome.Text = "Hello! Please login to Facebook";
            // 
            // labelLoggedUserName
            // 
            this.labelLoggedUserName.AutoSize = true;
            this.labelLoggedUserName.Location = new System.Drawing.Point(118, 78);
            this.labelLoggedUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoggedUserName.Name = "labelLoggedUserName";
            this.labelLoggedUserName.Size = new System.Drawing.Size(0, 17);
            this.labelLoggedUserName.TabIndex = 8;
            this.labelLoggedUserName.Visible = false;
            // 
            // buttonLoginLogout
            // 
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
            this.checkboxRememberMe.Location = new System.Drawing.Point(18, 103);
            this.checkboxRememberMe.Margin = new System.Windows.Forms.Padding(4);
            this.checkboxRememberMe.Name = "checkboxRememberMe";
            this.checkboxRememberMe.Size = new System.Drawing.Size(122, 21);
            this.checkboxRememberMe.TabIndex = 6;
            this.checkboxRememberMe.Text = "Remember Me";
            this.checkboxRememberMe.UseVisualStyleBackColor = true;
            // 
            // tabFeed
            // 
            this.tabFeed.Controls.Add(this.button1);
            this.tabFeed.Controls.Add(this.profilePictureBox);
            this.tabFeed.Location = new System.Drawing.Point(4, 25);
            this.tabFeed.Name = "tabFeed";
            this.tabFeed.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeed.Size = new System.Drawing.Size(974, 424);
            this.tabFeed.TabIndex = 1;
            this.tabFeed.Text = "Feed";
            this.tabFeed.UseVisualStyleBackColor = true;
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
            // tabProfile
            // 
            this.tabProfile.Location = new System.Drawing.Point(4, 25);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(974, 424);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // tabAlbums
            // 
            this.tabAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlbums.Size = new System.Drawing.Size(974, 424);
            this.tabAlbums.TabIndex = 3;
            this.tabAlbums.Text = "Albums";
            this.tabAlbums.UseVisualStyleBackColor = true;
            // 
            // tabAdditionalInfo
            // 
            this.tabAdditionalInfo.Location = new System.Drawing.Point(4, 25);
            this.tabAdditionalInfo.Name = "tabAdditionalInfo";
            this.tabAdditionalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdditionalInfo.Size = new System.Drawing.Size(974, 424);
            this.tabAdditionalInfo.TabIndex = 4;
            this.tabAdditionalInfo.Text = "Additional Info";
            this.tabAdditionalInfo.UseVisualStyleBackColor = true;
            // 
            // tabFeature1
            // 
            this.tabFeature1.Location = new System.Drawing.Point(4, 25);
            this.tabFeature1.Name = "tabFeature1";
            this.tabFeature1.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeature1.Size = new System.Drawing.Size(974, 424);
            this.tabFeature1.TabIndex = 5;
            this.tabFeature1.Text = "Feature 1";
            this.tabFeature1.UseVisualStyleBackColor = true;
            // 
            // tabFeature2
            // 
            this.tabFeature2.Location = new System.Drawing.Point(4, 25);
            this.tabFeature2.Name = "tabFeature2";
            this.tabFeature2.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeature2.Size = new System.Drawing.Size(974, 424);
            this.tabFeature2.TabIndex = 6;
            this.tabFeature2.Text = "Feature 2";
            this.tabFeature2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.tabsControl.ResumeLayout(false);
            this.tabLoginLogout.ResumeLayout(false);
            this.tabLoginLogout.PerformLayout();
            this.tabFeed.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox profilePictureBox;
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
        private System.Windows.Forms.Button button1;
    }
}

