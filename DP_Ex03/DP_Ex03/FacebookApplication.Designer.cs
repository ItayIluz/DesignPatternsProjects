namespace DP_Ex03
{
    public partial class FacebookApplication
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label favoriteLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label messageLabel;
            this.pictureBoxFeed = new System.Windows.Forms.PictureBox();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabLoginLogout = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonLoginLogout = new System.Windows.Forms.Button();
            this.checkboxRememberMe = new System.Windows.Forms.CheckBox();
            this.labelLoggedUserName = new System.Windows.Forms.Label();
            this.tabFeed = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoriteCheckBox = new System.Windows.Forms.CheckBox();
            this.postExtenderFavoriteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.postExtenderNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.listBoxLatestPostComments = new System.Windows.Forms.ListBox();
            this.listBoxLatestsPosts = new System.Windows.Forms.ListBox();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.labelLatestsPosts = new System.Windows.Forms.Label();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelBirthdayValue = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumOfFriends = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listViewAlbums = new System.Windows.Forms.ListView();
            this.buttonGoBackToAlbums = new System.Windows.Forms.Button();
            this.tabAdditionalInfo = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.labelShowActions = new System.Windows.Forms.Label();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.dataGridShowActions = new System.Windows.Forms.DataGridView();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.comboBoxShowActions = new System.Windows.Forms.ComboBox();
            this.labelCheckins = new System.Windows.Forms.Label();
            this.tabWordUsageStatistics = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wordUsagePostsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.wordUsageDataPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.showWordStatisticsButton = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMostLiked = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonCalculateMostLikedByFriends = new System.Windows.Forms.Button();
            this.buttonCalculateFriendsUserLikesMost = new System.Windows.Forms.Button();
            this.labelFriendsUserLikesMost = new System.Windows.Forms.Label();
            this.labelFriendsWhoLikeUserMost = new System.Windows.Forms.Label();
            this.dataGridViewFriendsUserLikesMost = new System.Windows.Forms.DataGridView();
            this.dataGridViewFriendsWhoLikeUserMost = new System.Windows.Forms.DataGridView();
            favoriteLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).BeginInit();
            this.tabsControl.SuspendLayout();
            this.tabLoginLogout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabFeed.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postExtenderFavoriteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postExtenderNoteBindingSource)).BeginInit();
            this.tabProfile.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabAlbums.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabAdditionalInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowActions)).BeginInit();
            this.tabWordUsageStatistics.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabMostLiked.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendsUserLikesMost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendsWhoLikeUserMost)).BeginInit();
            this.SuspendLayout();
            // 
            // favoriteLabel
            // 
            favoriteLabel.AutoSize = true;
            favoriteLabel.Location = new System.Drawing.Point(555, 241);
            favoriteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            favoriteLabel.Name = "favoriteLabel";
            favoriteLabel.Size = new System.Drawing.Size(69, 19);
            favoriteLabel.TabIndex = 14;
            favoriteLabel.Text = "Favorite:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(555, 277);
            noteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(53, 19);
            noteLabel.TabIndex = 16;
            noteLabel.Text = "Notes:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(555, 204);
            messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(78, 19);
            messageLabel.TabIndex = 17;
            messageLabel.Text = "Post Text:";
            // 
            // pictureBoxFeed
            // 
            this.pictureBoxFeed.Location = new System.Drawing.Point(89, 23);
            this.pictureBoxFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxFeed.Name = "pictureBoxFeed";
            this.pictureBoxFeed.Size = new System.Drawing.Size(133, 123);
            this.pictureBoxFeed.TabIndex = 1;
            this.pictureBoxFeed.TabStop = false;
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabLoginLogout);
            this.tabsControl.Controls.Add(this.tabFeed);
            this.tabsControl.Controls.Add(this.tabProfile);
            this.tabsControl.Controls.Add(this.tabAlbums);
            this.tabsControl.Controls.Add(this.tabAdditionalInfo);
            this.tabsControl.Controls.Add(this.tabWordUsageStatistics);
            this.tabsControl.Controls.Add(this.tabMostLiked);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.tabsControl.Location = new System.Drawing.Point(0, 0);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(1368, 658);
            this.tabsControl.TabIndex = 5;
            // 
            // tabLoginLogout
            // 
            this.tabLoginLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabLoginLogout.Controls.Add(this.panel1);
            this.tabLoginLogout.Controls.Add(this.labelLoggedUserName);
            this.tabLoginLogout.Location = new System.Drawing.Point(4, 28);
            this.tabLoginLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLoginLogout.Name = "tabLoginLogout";
            this.tabLoginLogout.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLoginLogout.Size = new System.Drawing.Size(1360, 626);
            this.tabLoginLogout.TabIndex = 0;
            this.tabLoginLogout.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelWelcome);
            this.panel1.Controls.Add(this.buttonLoginLogout);
            this.panel1.Controls.Add(this.checkboxRememberMe);
            this.panel1.Location = new System.Drawing.Point(356, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 190);
            this.panel1.TabIndex = 11;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(60, 32);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(503, 47);
            this.labelWelcome.TabIndex = 9;
            this.labelWelcome.Text = "Hello! Please login to Facebook";
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonLoginLogout.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.buttonLoginLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoginLogout.Location = new System.Drawing.Point(261, 92);
            this.buttonLoginLogout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoginLogout.Name = "buttonLoginLogout";
            this.buttonLoginLogout.Size = new System.Drawing.Size(129, 39);
            this.buttonLoginLogout.TabIndex = 5;
            this.buttonLoginLogout.Text = "Login";
            this.buttonLoginLogout.UseVisualStyleBackColor = false;
            this.buttonLoginLogout.Click += new System.EventHandler(this.buttonLoginLogout_Click);
            // 
            // checkboxRememberMe
            // 
            this.checkboxRememberMe.AutoSize = true;
            this.checkboxRememberMe.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.checkboxRememberMe.Location = new System.Drawing.Point(261, 135);
            this.checkboxRememberMe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkboxRememberMe.Name = "checkboxRememberMe";
            this.checkboxRememberMe.Size = new System.Drawing.Size(125, 23);
            this.checkboxRememberMe.TabIndex = 6;
            this.checkboxRememberMe.Text = "Remember Me";
            this.checkboxRememberMe.UseVisualStyleBackColor = true;
            // 
            // labelLoggedUserName
            // 
            this.labelLoggedUserName.AutoSize = true;
            this.labelLoggedUserName.Location = new System.Drawing.Point(117, 78);
            this.labelLoggedUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoggedUserName.Name = "labelLoggedUserName";
            this.labelLoggedUserName.Size = new System.Drawing.Size(0, 19);
            this.labelLoggedUserName.TabIndex = 8;
            this.labelLoggedUserName.Visible = false;
            // 
            // tabFeed
            // 
            this.tabFeed.AutoScroll = true;
            this.tabFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabFeed.Controls.Add(this.panel5);
            this.tabFeed.Location = new System.Drawing.Point(4, 28);
            this.tabFeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFeed.Name = "tabFeed";
            this.tabFeed.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFeed.Size = new System.Drawing.Size(1360, 626);
            this.tabFeed.TabIndex = 1;
            this.tabFeed.Text = "Feed";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(messageLabel);
            this.panel5.Controls.Add(this.messageTextBox);
            this.panel5.Controls.Add(favoriteLabel);
            this.panel5.Controls.Add(this.favoriteCheckBox);
            this.panel5.Controls.Add(noteLabel);
            this.panel5.Controls.Add(this.noteTextBox);
            this.panel5.Controls.Add(this.textBoxPostStatus);
            this.panel5.Controls.Add(this.listBoxLatestPostComments);
            this.panel5.Controls.Add(this.pictureBoxFeed);
            this.panel5.Controls.Add(this.listBoxLatestsPosts);
            this.panel5.Controls.Add(this.labelPostStatus);
            this.panel5.Controls.Add(this.labelLatestsPosts);
            this.panel5.Controls.Add(this.buttonPostStatus);
            this.panel5.Location = new System.Drawing.Point(125, -5);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1107, 635);
            this.panel5.TabIndex = 15;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(635, 201);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(381, 27);
            this.messageTextBox.TabIndex = 18;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // favoriteCheckBox
            // 
            this.favoriteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.postExtenderFavoriteBindingSource, "IsFavorite", true));
            this.favoriteCheckBox.Location = new System.Drawing.Point(635, 236);
            this.favoriteCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.favoriteCheckBox.Name = "favoriteCheckBox";
            this.favoriteCheckBox.Size = new System.Drawing.Size(21, 30);
            this.favoriteCheckBox.TabIndex = 15;
            this.favoriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // postExtenderFavoriteBindingSource
            // 
            this.postExtenderFavoriteBindingSource.DataSource = typeof(DP_Ex03.PostExtenderFavorite);
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postExtenderNoteBindingSource, "Note", true));
            this.noteTextBox.Location = new System.Drawing.Point(633, 273);
            this.noteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(383, 85);
            this.noteTextBox.TabIndex = 17;
            // 
            // postExtenderNoteBindingSource
            // 
            this.postExtenderNoteBindingSource.DataSource = typeof(DP_Ex03.PostExtenderNote);
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.textBoxPostStatus.Location = new System.Drawing.Point(385, 58);
            this.textBoxPostStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPostStatus.MaximumSize = new System.Drawing.Size(523, 88);
            this.textBoxPostStatus.Multiline = true;
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(523, 36);
            this.textBoxPostStatus.TabIndex = 3;
            // 
            // listBoxLatestPostComments
            // 
            this.listBoxLatestPostComments.FormattingEnabled = true;
            this.listBoxLatestPostComments.ItemHeight = 19;
            this.listBoxLatestPostComments.Location = new System.Drawing.Point(559, 384);
            this.listBoxLatestPostComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLatestPostComments.Name = "listBoxLatestPostComments";
            this.listBoxLatestPostComments.Size = new System.Drawing.Size(457, 213);
            this.listBoxLatestPostComments.TabIndex = 14;
            // 
            // listBoxLatestsPosts
            // 
            this.listBoxLatestsPosts.DisplayMember = "Caption";
            this.listBoxLatestsPosts.FormattingEnabled = true;
            this.listBoxLatestsPosts.ItemHeight = 19;
            this.listBoxLatestsPosts.Location = new System.Drawing.Point(89, 199);
            this.listBoxLatestsPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLatestsPosts.Name = "listBoxLatestsPosts";
            this.listBoxLatestsPosts.Size = new System.Drawing.Size(457, 403);
            this.listBoxLatestsPosts.TabIndex = 13;
            this.listBoxLatestsPosts.ValueMember = "Caption";
            this.listBoxLatestsPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxLatestsPosts_SelectedIndexChanged);
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelPostStatus.Location = new System.Drawing.Point(247, 62);
            this.labelPostStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(123, 28);
            this.labelPostStatus.TabIndex = 2;
            this.labelPostStatus.Text = "Post Status:";
            // 
            // labelLatestsPosts
            // 
            this.labelLatestsPosts.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelLatestsPosts.Location = new System.Drawing.Point(84, 150);
            this.labelLatestsPosts.Name = "labelLatestsPosts";
            this.labelLatestsPosts.Size = new System.Drawing.Size(933, 47);
            this.labelLatestsPosts.TabIndex = 12;
            this.labelLatestsPosts.Text = "Latests Posts";
            this.labelLatestsPosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonPostStatus.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.buttonPostStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPostStatus.Location = new System.Drawing.Point(917, 58);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(100, 37);
            this.buttonPostStatus.TabIndex = 4;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = false;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabProfile.Controls.Add(this.panel4);
            this.tabProfile.Location = new System.Drawing.Point(4, 28);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProfile.Size = new System.Drawing.Size(1360, 626);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Profile";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.listBoxFriends);
            this.panel4.Controls.Add(this.listBoxEvents);
            this.panel4.Controls.Add(this.pictureBoxProfile);
            this.panel4.Controls.Add(this.labelFriends);
            this.panel4.Controls.Add(this.labelBirthdayValue);
            this.panel4.Controls.Add(this.labelEvents);
            this.panel4.Controls.Add(this.labelNameValue);
            this.panel4.Controls.Add(this.labelName);
            this.panel4.Controls.Add(this.labelNumOfFriends);
            this.panel4.Controls.Add(this.labelBirthday);
            this.panel4.Location = new System.Drawing.Point(125, -5);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1107, 634);
            this.panel4.TabIndex = 13;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 19;
            this.listBoxFriends.Location = new System.Drawing.Point(416, 127);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(251, 403);
            this.listBoxFriends.TabIndex = 11;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 19;
            this.listBoxEvents.Location = new System.Drawing.Point(719, 127);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(251, 403);
            this.listBoxEvents.TabIndex = 12;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(52, 47);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(200, 199);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelFriends
            // 
            this.labelFriends.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelFriends.Location = new System.Drawing.Point(415, 78);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(251, 47);
            this.labelFriends.TabIndex = 3;
            this.labelFriends.Text = "Friends";
            this.labelFriends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBirthdayValue
            // 
            this.labelBirthdayValue.AutoSize = true;
            this.labelBirthdayValue.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelBirthdayValue.Location = new System.Drawing.Point(143, 289);
            this.labelBirthdayValue.Name = "labelBirthdayValue";
            this.labelBirthdayValue.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelBirthdayValue.Size = new System.Drawing.Size(6, 28);
            this.labelBirthdayValue.TabIndex = 10;
            // 
            // labelEvents
            // 
            this.labelEvents.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelEvents.Location = new System.Drawing.Point(719, 78);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(251, 47);
            this.labelEvents.TabIndex = 5;
            this.labelEvents.Text = "Events";
            this.labelEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameValue
            // 
            this.labelNameValue.AutoSize = true;
            this.labelNameValue.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelNameValue.Location = new System.Drawing.Point(115, 250);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelNameValue.Size = new System.Drawing.Size(6, 28);
            this.labelNameValue.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelName.Location = new System.Drawing.Point(47, 263);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelName.Size = new System.Drawing.Size(67, 28);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name:";
            // 
            // labelNumOfFriends
            // 
            this.labelNumOfFriends.AutoSize = true;
            this.labelNumOfFriends.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelNumOfFriends.Location = new System.Drawing.Point(47, 326);
            this.labelNumOfFriends.Name = "labelNumOfFriends";
            this.labelNumOfFriends.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelNumOfFriends.Size = new System.Drawing.Size(125, 28);
            this.labelNumOfFriends.TabIndex = 8;
            this.labelNumOfFriends.Text = "Has 0 Friends";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelBirthday.Location = new System.Drawing.Point(47, 295);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelBirthday.Size = new System.Drawing.Size(89, 28);
            this.labelBirthday.TabIndex = 7;
            this.labelBirthday.Text = "Birthday:";
            // 
            // tabAlbums
            // 
            this.tabAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabAlbums.Controls.Add(this.panel6);
            this.tabAlbums.Location = new System.Drawing.Point(4, 28);
            this.tabAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlbums.Size = new System.Drawing.Size(1360, 626);
            this.tabAlbums.TabIndex = 3;
            this.tabAlbums.Text = "Albums";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.listViewAlbums);
            this.panel6.Controls.Add(this.buttonGoBackToAlbums);
            this.panel6.Location = new System.Drawing.Point(99, 18);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1179, 766);
            this.panel6.TabIndex = 6;
            // 
            // listViewAlbums
            // 
            this.listViewAlbums.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewAlbums.Location = new System.Drawing.Point(4, 55);
            this.listViewAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewAlbums.Name = "listViewAlbums";
            this.listViewAlbums.Size = new System.Drawing.Size(1169, 702);
            this.listViewAlbums.TabIndex = 1;
            this.listViewAlbums.UseCompatibleStateImageBehavior = false;
            this.listViewAlbums.Click += new System.EventHandler(this.listViewAlbums_Click);
            // 
            // buttonGoBackToAlbums
            // 
            this.buttonGoBackToAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonGoBackToAlbums.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.buttonGoBackToAlbums.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBackToAlbums.Location = new System.Drawing.Point(4, 11);
            this.buttonGoBackToAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGoBackToAlbums.Name = "buttonGoBackToAlbums";
            this.buttonGoBackToAlbums.Size = new System.Drawing.Size(232, 37);
            this.buttonGoBackToAlbums.TabIndex = 5;
            this.buttonGoBackToAlbums.Text = "Go Back To Albums";
            this.buttonGoBackToAlbums.UseVisualStyleBackColor = false;
            this.buttonGoBackToAlbums.Click += new System.EventHandler(this.buttonGoBackToAlbums_Click);
            // 
            // tabAdditionalInfo
            // 
            this.tabAdditionalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabAdditionalInfo.Controls.Add(this.panel3);
            this.tabAdditionalInfo.Location = new System.Drawing.Point(4, 28);
            this.tabAdditionalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdditionalInfo.Name = "tabAdditionalInfo";
            this.tabAdditionalInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdditionalInfo.Size = new System.Drawing.Size(1360, 626);
            this.tabAdditionalInfo.TabIndex = 4;
            this.tabAdditionalInfo.Text = "Additional Info";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.listBoxCheckins);
            this.panel3.Controls.Add(this.labelShowActions);
            this.panel3.Controls.Add(this.labelLikedPages);
            this.panel3.Controls.Add(this.dataGridShowActions);
            this.panel3.Controls.Add(this.listBoxLikedPages);
            this.panel3.Controls.Add(this.comboBoxShowActions);
            this.panel3.Controls.Add(this.labelCheckins);
            this.panel3.Location = new System.Drawing.Point(125, -5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1107, 634);
            this.panel3.TabIndex = 27;
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 19;
            this.listBoxCheckins.Location = new System.Drawing.Point(731, 406);
            this.listBoxCheckins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(304, 194);
            this.listBoxCheckins.TabIndex = 19;
            // 
            // labelShowActions
            // 
            this.labelShowActions.AutoSize = true;
            this.labelShowActions.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labelShowActions.Location = new System.Drawing.Point(80, 48);
            this.labelShowActions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowActions.Name = "labelShowActions";
            this.labelShowActions.Size = new System.Drawing.Size(129, 25);
            this.labelShowActions.TabIndex = 26;
            this.labelShowActions.Text = "Show Actions:";
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelLikedPages.Location = new System.Drawing.Point(727, 30);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(304, 47);
            this.labelLikedPages.TabIndex = 16;
            this.labelLikedPages.Text = "Liked Pages";
            this.labelLikedPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridShowActions
            // 
            this.dataGridShowActions.AllowUserToAddRows = false;
            this.dataGridShowActions.AllowUserToDeleteRows = false;
            this.dataGridShowActions.AllowUserToOrderColumns = true;
            this.dataGridShowActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridShowActions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridShowActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShowActions.Location = new System.Drawing.Point(85, 90);
            this.dataGridShowActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridShowActions.Name = "dataGridShowActions";
            this.dataGridShowActions.ReadOnly = true;
            this.dataGridShowActions.Size = new System.Drawing.Size(473, 524);
            this.dataGridShowActions.TabIndex = 25;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 19;
            this.listBoxLikedPages.Location = new System.Drawing.Point(728, 79);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(304, 251);
            this.listBoxLikedPages.TabIndex = 17;
            // 
            // comboBoxShowActions
            // 
            this.comboBoxShowActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowActions.FormattingEnabled = true;
            this.comboBoxShowActions.Items.AddRange(new object[] {
            "music",
            "television",
            "movies",
            "books",
            "books.reads",
            "books.wants_to_read",
            "books.rates",
            "books.quotes",
            "fitness.runs",
            "fitness.walks",
            "fitness.bikes",
            "music.listens",
            "music.playlists",
            "news.reads",
            "news.publishes",
            "video.watches",
            "video.rates",
            "videos.wants_to_watch"});
            this.comboBoxShowActions.Location = new System.Drawing.Point(228, 48);
            this.comboBoxShowActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxShowActions.Name = "comboBoxShowActions";
            this.comboBoxShowActions.Size = new System.Drawing.Size(219, 27);
            this.comboBoxShowActions.TabIndex = 24;
            this.comboBoxShowActions.SelectedValueChanged += new System.EventHandler(this.comboBoxShowActions_SelectedValueChanged);
            // 
            // labelCheckins
            // 
            this.labelCheckins.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelCheckins.Location = new System.Drawing.Point(729, 357);
            this.labelCheckins.Name = "labelCheckins";
            this.labelCheckins.Size = new System.Drawing.Size(304, 47);
            this.labelCheckins.TabIndex = 18;
            this.labelCheckins.Text = "Checkins";
            this.labelCheckins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabWordUsageStatistics
            // 
            this.tabWordUsageStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabWordUsageStatistics.Controls.Add(this.panel2);
            this.tabWordUsageStatistics.Location = new System.Drawing.Point(4, 28);
            this.tabWordUsageStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabWordUsageStatistics.Name = "tabWordUsageStatistics";
            this.tabWordUsageStatistics.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabWordUsageStatistics.Size = new System.Drawing.Size(1360, 626);
            this.tabWordUsageStatistics.TabIndex = 5;
            this.tabWordUsageStatistics.Text = "Word Usage Statistics";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.wordUsagePostsPanel);
            this.panel2.Controls.Add(this.wordUsageDataPanel);
            this.panel2.Controls.Add(this.startDatePicker);
            this.panel2.Controls.Add(this.showWordStatisticsButton);
            this.panel2.Controls.Add(this.endDatePicker);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(125, -5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 634);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Posts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Words Usage Data (click to see posts)";
            // 
            // wordUsagePostsPanel
            // 
            this.wordUsagePostsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordUsagePostsPanel.Location = new System.Drawing.Point(601, 164);
            this.wordUsagePostsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wordUsagePostsPanel.Name = "wordUsagePostsPanel";
            this.wordUsagePostsPanel.Size = new System.Drawing.Size(343, 418);
            this.wordUsagePostsPanel.TabIndex = 6;
            // 
            // wordUsageDataPanel
            // 
            this.wordUsageDataPanel.AutoScroll = true;
            this.wordUsageDataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordUsageDataPanel.Location = new System.Drawing.Point(161, 164);
            this.wordUsageDataPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wordUsageDataPanel.Name = "wordUsageDataPanel";
            this.wordUsageDataPanel.Size = new System.Drawing.Size(343, 418);
            this.wordUsageDataPanel.TabIndex = 5;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(272, 37);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(265, 27);
            this.startDatePicker.TabIndex = 0;
            this.startDatePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // showWordStatisticsButton
            // 
            this.showWordStatisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.showWordStatisticsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showWordStatisticsButton.Location = new System.Drawing.Point(428, 95);
            this.showWordStatisticsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showWordStatisticsButton.Name = "showWordStatisticsButton";
            this.showWordStatisticsButton.Size = new System.Drawing.Size(252, 37);
            this.showWordStatisticsButton.TabIndex = 4;
            this.showWordStatisticsButton.Text = "Show Word Usage Statistics";
            this.showWordStatisticsButton.UseVisualStyleBackColor = false;
            this.showWordStatisticsButton.Click += new System.EventHandler(this.showWordStatisticsButton_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(659, 37);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(265, 27);
            this.endDatePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "End Date:";
            // 
            // tabMostLiked
            // 
            this.tabMostLiked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabMostLiked.Controls.Add(this.panel7);
            this.tabMostLiked.Location = new System.Drawing.Point(4, 28);
            this.tabMostLiked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMostLiked.Name = "tabMostLiked";
            this.tabMostLiked.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMostLiked.Size = new System.Drawing.Size(1360, 626);
            this.tabMostLiked.TabIndex = 6;
            this.tabMostLiked.Text = "Most Liked";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.AutoSize = true;
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.buttonCalculateMostLikedByFriends);
            this.panel7.Controls.Add(this.buttonCalculateFriendsUserLikesMost);
            this.panel7.Controls.Add(this.labelFriendsUserLikesMost);
            this.panel7.Controls.Add(this.labelFriendsWhoLikeUserMost);
            this.panel7.Controls.Add(this.dataGridViewFriendsUserLikesMost);
            this.panel7.Controls.Add(this.dataGridViewFriendsWhoLikeUserMost);
            this.panel7.Location = new System.Drawing.Point(125, -5);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1107, 634);
            this.panel7.TabIndex = 6;
            // 
            // buttonCalculateMostLikedByFriends
            // 
            this.buttonCalculateMostLikedByFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonCalculateMostLikedByFriends.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalculateMostLikedByFriends.Location = new System.Drawing.Point(927, 50);
            this.buttonCalculateMostLikedByFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalculateMostLikedByFriends.Name = "buttonCalculateMostLikedByFriends";
            this.buttonCalculateMostLikedByFriends.Size = new System.Drawing.Size(117, 30);
            this.buttonCalculateMostLikedByFriends.TabIndex = 6;
            this.buttonCalculateMostLikedByFriends.Text = "Fetch!";
            this.buttonCalculateMostLikedByFriends.UseVisualStyleBackColor = false;
            this.buttonCalculateMostLikedByFriends.Click += new System.EventHandler(this.buttonCalculateFriendsWhoLikeUserMost_Click);
            // 
            // buttonCalculateFriendsUserLikesMost
            // 
            this.buttonCalculateFriendsUserLikesMost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonCalculateFriendsUserLikesMost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalculateFriendsUserLikesMost.Location = new System.Drawing.Point(397, 50);
            this.buttonCalculateFriendsUserLikesMost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalculateFriendsUserLikesMost.Name = "buttonCalculateFriendsUserLikesMost";
            this.buttonCalculateFriendsUserLikesMost.Size = new System.Drawing.Size(117, 30);
            this.buttonCalculateFriendsUserLikesMost.TabIndex = 5;
            this.buttonCalculateFriendsUserLikesMost.Text = "Fetch!";
            this.buttonCalculateFriendsUserLikesMost.UseVisualStyleBackColor = false;
            this.buttonCalculateFriendsUserLikesMost.Click += new System.EventHandler(this.buttonCalculateFriendsUserLikesMost_Click);
            // 
            // labelFriendsUserLikesMost
            // 
            this.labelFriendsUserLikesMost.AutoSize = true;
            this.labelFriendsUserLikesMost.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelFriendsUserLikesMost.Location = new System.Drawing.Point(136, 50);
            this.labelFriendsUserLikesMost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendsUserLikesMost.Name = "labelFriendsUserLikesMost";
            this.labelFriendsUserLikesMost.Size = new System.Drawing.Size(229, 25);
            this.labelFriendsUserLikesMost.TabIndex = 3;
            this.labelFriendsUserLikesMost.Text = "Friends you like the most:";
            // 
            // labelFriendsWhoLikeUserMost
            // 
            this.labelFriendsWhoLikeUserMost.AutoSize = true;
            this.labelFriendsWhoLikeUserMost.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelFriendsWhoLikeUserMost.Location = new System.Drawing.Point(624, 50);
            this.labelFriendsWhoLikeUserMost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendsWhoLikeUserMost.Name = "labelFriendsWhoLikeUserMost";
            this.labelFriendsWhoLikeUserMost.Size = new System.Drawing.Size(267, 25);
            this.labelFriendsWhoLikeUserMost.TabIndex = 2;
            this.labelFriendsWhoLikeUserMost.Text = "Friends who like you the most:";
            // 
            // dataGridViewFriendsUserLikesMost
            // 
            this.dataGridViewFriendsUserLikesMost.AllowUserToAddRows = false;
            this.dataGridViewFriendsUserLikesMost.AllowUserToDeleteRows = false;
            this.dataGridViewFriendsUserLikesMost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriendsUserLikesMost.Location = new System.Drawing.Point(141, 87);
            this.dataGridViewFriendsUserLikesMost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFriendsUserLikesMost.Name = "dataGridViewFriendsUserLikesMost";
            this.dataGridViewFriendsUserLikesMost.ReadOnly = true;
            this.dataGridViewFriendsUserLikesMost.Size = new System.Drawing.Size(380, 418);
            this.dataGridViewFriendsUserLikesMost.TabIndex = 1;
            // 
            // dataGridViewFriendsWhoLikeUserMost
            // 
            this.dataGridViewFriendsWhoLikeUserMost.AllowUserToAddRows = false;
            this.dataGridViewFriendsWhoLikeUserMost.AllowUserToDeleteRows = false;
            this.dataGridViewFriendsWhoLikeUserMost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriendsWhoLikeUserMost.Location = new System.Drawing.Point(645, 87);
            this.dataGridViewFriendsWhoLikeUserMost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFriendsWhoLikeUserMost.Name = "dataGridViewFriendsWhoLikeUserMost";
            this.dataGridViewFriendsWhoLikeUserMost.ReadOnly = true;
            this.dataGridViewFriendsWhoLikeUserMost.Size = new System.Drawing.Size(380, 418);
            this.dataGridViewFriendsWhoLikeUserMost.TabIndex = 0;
            // 
            // FacebookApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 658);
            this.Controls.Add(this.tabsControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FacebookApplication";
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).EndInit();
            this.tabsControl.ResumeLayout(false);
            this.tabLoginLogout.ResumeLayout(false);
            this.tabLoginLogout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFeed.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postExtenderFavoriteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postExtenderNoteBindingSource)).EndInit();
            this.tabProfile.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabAlbums.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabAdditionalInfo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowActions)).EndInit();
            this.tabWordUsageStatistics.ResumeLayout(false);
            this.tabWordUsageStatistics.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabMostLiked.ResumeLayout(false);
            this.tabMostLiked.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendsUserLikesMost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendsWhoLikeUserMost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFeed;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabFeed;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabAlbums;
        private System.Windows.Forms.TabPage tabAdditionalInfo;
        private System.Windows.Forms.TabPage tabWordUsageStatistics;
        private System.Windows.Forms.TabPage tabMostLiked;
        private System.Windows.Forms.TabPage tabLoginLogout;
        private System.Windows.Forms.Label labelLoggedUserName;
        private System.Windows.Forms.Button buttonLoginLogout;
        private System.Windows.Forms.CheckBox checkboxRememberMe;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumOfFriends;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelBirthdayValue;
        private System.Windows.Forms.Label labelNameValue;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.ListBox listBoxLatestsPosts;
        private System.Windows.Forms.Label labelLatestsPosts;
        private System.Windows.Forms.ListBox listBoxLatestPostComments;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.Label labelCheckins;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.ComboBox comboBoxShowActions;
        private System.Windows.Forms.DataGridView dataGridShowActions;
        private System.Windows.Forms.Label labelShowActions;
        private System.Windows.Forms.ListView listViewAlbums;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Button showWordStatisticsButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel wordUsagePostsPanel;
        private System.Windows.Forms.FlowLayoutPanel wordUsageDataPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonGoBackToAlbums;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelFriendsWhoLikeUserMost;
        private System.Windows.Forms.DataGridView dataGridViewFriendsUserLikesMost;
        private System.Windows.Forms.DataGridView dataGridViewFriendsWhoLikeUserMost;
        private System.Windows.Forms.Label labelFriendsUserLikesMost;
        private System.Windows.Forms.Button buttonCalculateFriendsUserLikesMost;
        private System.Windows.Forms.Button buttonCalculateMostLikedByFriends;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.CheckBox favoriteCheckBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.BindingSource postExtenderFavoriteBindingSource;
        private System.Windows.Forms.BindingSource postExtenderNoteBindingSource;
        private System.Windows.Forms.BindingSource postBindingSource;
    }
}