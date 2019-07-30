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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.checkboxRememberMe = new System.Windows.Forms.CheckBox();
            this.labelLoggedUser = new System.Windows.Forms.Label();
            this.labelLoggedUserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(206, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(12, 12);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(100, 100);
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkboxRememberMe
            // 
            this.checkboxRememberMe.AutoSize = true;
            this.checkboxRememberMe.Location = new System.Drawing.Point(287, 16);
            this.checkboxRememberMe.Name = "checkboxRememberMe";
            this.checkboxRememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkboxRememberMe.TabIndex = 2;
            this.checkboxRememberMe.Text = "Remember Me";
            this.checkboxRememberMe.UseVisualStyleBackColor = true;
            this.checkboxRememberMe.CheckedChanged += new System.EventHandler(this.checkboxRememberMe_CheckedChanged);
            // 
            // labelLoggedUser
            // 
            this.labelLoggedUser.AutoSize = true;
            this.labelLoggedUser.Location = new System.Drawing.Point(129, 17);
            this.labelLoggedUser.Name = "labelLoggedUser";
            this.labelLoggedUser.Size = new System.Drawing.Size(71, 13);
            this.labelLoggedUser.TabIndex = 3;
            this.labelLoggedUser.Text = "Logged User:";
            // 
            // labelLoggedUserName
            // 
            this.labelLoggedUserName.AutoSize = true;
            this.labelLoggedUserName.Location = new System.Drawing.Point(207, 16);
            this.labelLoggedUserName.Name = "labelLoggedUserName";
            this.labelLoggedUserName.Size = new System.Drawing.Size(0, 13);
            this.labelLoggedUserName.TabIndex = 4;
            this.labelLoggedUserName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 628);
            this.Controls.Add(this.labelLoggedUserName);
            this.Controls.Add(this.labelLoggedUser);
            this.Controls.Add(this.checkboxRememberMe);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.CheckBox checkboxRememberMe;
        private System.Windows.Forms.Label labelLoggedUser;
        private System.Windows.Forms.Label labelLoggedUserName;
    }
}

