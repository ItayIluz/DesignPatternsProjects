﻿namespace DP_Ex01
{
    partial class MainForm
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
            this.pictureBoxFeed = new System.Windows.Forms.PictureBox();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabLoginLogout = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonLoginLogout = new System.Windows.Forms.Button();
            this.checkboxRememberMe = new System.Windows.Forms.CheckBox();
            this.labelLoggedUserName = new System.Windows.Forms.Label();
            this.tabFeed = new System.Windows.Forms.TabPage();
            this.listBoxLatestPostComments = new System.Windows.Forms.ListBox();
            this.listBoxLatestsPosts = new System.Windows.Forms.ListBox();
            this.labelLatestsPosts = new System.Windows.Forms.Label();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelBirthdayValue = new System.Windows.Forms.Label();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.labelNumOfFriends = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.listViewAlbums = new System.Windows.Forms.ListView();
            this.tabAdditionalInfo = new System.Windows.Forms.TabPage();
            this.labelShowActions = new System.Windows.Forms.Label();
            this.dataGridShowActions = new System.Windows.Forms.DataGridView();
            this.comboBoxShowActions = new System.Windows.Forms.ComboBox();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.labelCheckins = new System.Windows.Forms.Label();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.tabFeature1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wordUsagePostsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.wordUsageDataPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.showWordStatisticsButton = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFeature2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).BeginInit();
            this.tabsControl.SuspendLayout();
            this.tabLoginLogout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabFeed.SuspendLayout();
            this.tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabAlbums.SuspendLayout();
            this.tabAdditionalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowActions)).BeginInit();
            this.tabFeature1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxFeed
            // 
            this.pictureBoxFeed.Location = new System.Drawing.Point(67, 19);
            this.pictureBoxFeed.Name = "pictureBoxFeed";
            this.pictureBoxFeed.Size = new System.Drawing.Size(100, 100);
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
            this.tabsControl.Controls.Add(this.tabFeature1);
            this.tabsControl.Controls.Add(this.tabFeature2);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.tabsControl.Location = new System.Drawing.Point(0, 0);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(1026, 535);
            this.tabsControl.TabIndex = 5;
            // 
            // tabLoginLogout
            // 
            this.tabLoginLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabLoginLogout.Controls.Add(this.panel1);
            this.tabLoginLogout.Controls.Add(this.labelLoggedUserName);
            this.tabLoginLogout.Location = new System.Drawing.Point(4, 24);
            this.tabLoginLogout.Margin = new System.Windows.Forms.Padding(2);
            this.tabLoginLogout.Name = "tabLoginLogout";
            this.tabLoginLogout.Padding = new System.Windows.Forms.Padding(2);
            this.tabLoginLogout.Size = new System.Drawing.Size(1018, 507);
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
            this.panel1.Location = new System.Drawing.Point(267, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 154);
            this.panel1.TabIndex = 11;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(45, 26);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(398, 38);
            this.labelWelcome.TabIndex = 9;
            this.labelWelcome.Text = "Hello! Please login to Facebook";
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonLoginLogout.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.buttonLoginLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoginLogout.Location = new System.Drawing.Point(196, 75);
            this.buttonLoginLogout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoginLogout.Name = "buttonLoginLogout";
            this.buttonLoginLogout.Size = new System.Drawing.Size(97, 32);
            this.buttonLoginLogout.TabIndex = 5;
            this.buttonLoginLogout.Text = "Login";
            this.buttonLoginLogout.UseVisualStyleBackColor = false;
            this.buttonLoginLogout.Click += new System.EventHandler(this.buttonLoginLogout_Click);
            // 
            // checkboxRememberMe
            // 
            this.checkboxRememberMe.AutoSize = true;
            this.checkboxRememberMe.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.checkboxRememberMe.Location = new System.Drawing.Point(196, 110);
            this.checkboxRememberMe.Name = "checkboxRememberMe";
            this.checkboxRememberMe.Size = new System.Drawing.Size(97, 19);
            this.checkboxRememberMe.TabIndex = 6;
            this.checkboxRememberMe.Text = "Remember Me";
            this.checkboxRememberMe.UseVisualStyleBackColor = true;
            // 
            // labelLoggedUserName
            // 
            this.labelLoggedUserName.AutoSize = true;
            this.labelLoggedUserName.Location = new System.Drawing.Point(88, 63);
            this.labelLoggedUserName.Name = "labelLoggedUserName";
            this.labelLoggedUserName.Size = new System.Drawing.Size(0, 15);
            this.labelLoggedUserName.TabIndex = 8;
            this.labelLoggedUserName.Visible = false;
            // 
            // tabFeed
            // 
            this.tabFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabFeed.Controls.Add(this.panel5);
            this.tabFeed.Location = new System.Drawing.Point(4, 24);
            this.tabFeed.Margin = new System.Windows.Forms.Padding(2);
            this.tabFeed.Name = "tabFeed";
            this.tabFeed.Padding = new System.Windows.Forms.Padding(2);
            this.tabFeed.Size = new System.Drawing.Size(1018, 507);
            this.tabFeed.TabIndex = 1;
            this.tabFeed.Text = "Feed";
            // 
            // listBoxLatestPostComments
            // 
            this.listBoxLatestPostComments.FormattingEnabled = true;
            this.listBoxLatestPostComments.ItemHeight = 15;
            this.listBoxLatestPostComments.Location = new System.Drawing.Point(419, 162);
            this.listBoxLatestPostComments.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLatestPostComments.Name = "listBoxLatestPostComments";
            this.listBoxLatestPostComments.Size = new System.Drawing.Size(344, 334);
            this.listBoxLatestPostComments.TabIndex = 14;
            // 
            // listBoxLatestsPosts
            // 
            this.listBoxLatestsPosts.FormattingEnabled = true;
            this.listBoxLatestsPosts.ItemHeight = 15;
            this.listBoxLatestsPosts.Location = new System.Drawing.Point(67, 162);
            this.listBoxLatestsPosts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLatestsPosts.Name = "listBoxLatestsPosts";
            this.listBoxLatestsPosts.Size = new System.Drawing.Size(344, 334);
            this.listBoxLatestsPosts.TabIndex = 13;
            this.listBoxLatestsPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxLatestsPosts_SelectedIndexChanged);
            // 
            // labelLatestsPosts
            // 
            this.labelLatestsPosts.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelLatestsPosts.Location = new System.Drawing.Point(63, 122);
            this.labelLatestsPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLatestsPosts.Name = "labelLatestsPosts";
            this.labelLatestsPosts.Size = new System.Drawing.Size(700, 38);
            this.labelLatestsPosts.TabIndex = 12;
            this.labelLatestsPosts.Text = "Latests Posts";
            this.labelLatestsPosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonPostStatus.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.buttonPostStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPostStatus.Location = new System.Drawing.Point(688, 47);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 30);
            this.buttonPostStatus.TabIndex = 4;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = false;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.textBoxPostStatus.Location = new System.Drawing.Point(289, 47);
            this.textBoxPostStatus.MaximumSize = new System.Drawing.Size(393, 72);
            this.textBoxPostStatus.Multiline = true;
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(393, 30);
            this.textBoxPostStatus.TabIndex = 3;
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelPostStatus.Location = new System.Drawing.Point(185, 50);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(98, 23);
            this.labelPostStatus.TabIndex = 2;
            this.labelPostStatus.Text = "Post Status:";
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabProfile.Controls.Add(this.panel4);
            this.tabProfile.Location = new System.Drawing.Point(4, 24);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(2);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(2);
            this.tabProfile.Size = new System.Drawing.Size(1018, 507);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Profile";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 15;
            this.listBoxEvents.Location = new System.Drawing.Point(539, 103);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(189, 334);
            this.listBoxEvents.TabIndex = 12;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 15;
            this.listBoxFriends.Location = new System.Drawing.Point(312, 103);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(189, 334);
            this.listBoxFriends.TabIndex = 11;
            // 
            // labelBirthdayValue
            // 
            this.labelBirthdayValue.AutoSize = true;
            this.labelBirthdayValue.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelBirthdayValue.Location = new System.Drawing.Point(107, 235);
            this.labelBirthdayValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthdayValue.Name = "labelBirthdayValue";
            this.labelBirthdayValue.Padding = new System.Windows.Forms.Padding(2);
            this.labelBirthdayValue.Size = new System.Drawing.Size(4, 23);
            this.labelBirthdayValue.TabIndex = 10;
            // 
            // labelNameValue
            // 
            this.labelNameValue.AutoSize = true;
            this.labelNameValue.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelNameValue.Location = new System.Drawing.Point(86, 203);
            this.labelNameValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Padding = new System.Windows.Forms.Padding(2);
            this.labelNameValue.Size = new System.Drawing.Size(4, 23);
            this.labelNameValue.TabIndex = 9;
            // 
            // labelNumOfFriends
            // 
            this.labelNumOfFriends.AutoSize = true;
            this.labelNumOfFriends.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelNumOfFriends.Location = new System.Drawing.Point(35, 265);
            this.labelNumOfFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumOfFriends.Name = "labelNumOfFriends";
            this.labelNumOfFriends.Padding = new System.Windows.Forms.Padding(2);
            this.labelNumOfFriends.Size = new System.Drawing.Size(105, 23);
            this.labelNumOfFriends.TabIndex = 8;
            this.labelNumOfFriends.Text = "Has 0 Friends";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelBirthday.Location = new System.Drawing.Point(35, 240);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Padding = new System.Windows.Forms.Padding(2);
            this.labelBirthday.Size = new System.Drawing.Size(73, 23);
            this.labelBirthday.TabIndex = 7;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelName.Location = new System.Drawing.Point(35, 214);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(2);
            this.labelName.Size = new System.Drawing.Size(54, 23);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name:";
            // 
            // labelEvents
            // 
            this.labelEvents.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelEvents.Location = new System.Drawing.Point(539, 63);
            this.labelEvents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(188, 38);
            this.labelEvents.TabIndex = 5;
            this.labelEvents.Text = "Events";
            this.labelEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFriends
            // 
            this.labelFriends.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelFriends.Location = new System.Drawing.Point(311, 63);
            this.labelFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(188, 38);
            this.labelFriends.TabIndex = 3;
            this.labelFriends.Text = "Friends";
            this.labelFriends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(39, 38);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(150, 162);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabAlbums
            // 
            this.tabAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabAlbums.Controls.Add(this.listViewAlbums);
            this.tabAlbums.Location = new System.Drawing.Point(4, 24);
            this.tabAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Padding = new System.Windows.Forms.Padding(2);
            this.tabAlbums.Size = new System.Drawing.Size(1018, 507);
            this.tabAlbums.TabIndex = 3;
            this.tabAlbums.Text = "Albums";
            // 
            // listViewAlbums
            // 
            this.listViewAlbums.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewAlbums.Location = new System.Drawing.Point(94, -4);
            this.listViewAlbums.Name = "listViewAlbums";
            this.listViewAlbums.Size = new System.Drawing.Size(830, 515);
            this.listViewAlbums.TabIndex = 1;
            this.listViewAlbums.UseCompatibleStateImageBehavior = false;
            this.listViewAlbums.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewAlbums_ItemSelectionChanged);
            // 
            // tabAdditionalInfo
            // 
            this.tabAdditionalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabAdditionalInfo.Controls.Add(this.panel3);
            this.tabAdditionalInfo.Location = new System.Drawing.Point(4, 24);
            this.tabAdditionalInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabAdditionalInfo.Name = "tabAdditionalInfo";
            this.tabAdditionalInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tabAdditionalInfo.Size = new System.Drawing.Size(1018, 507);
            this.tabAdditionalInfo.TabIndex = 4;
            this.tabAdditionalInfo.Text = "Additional Info";
            this.tabAdditionalInfo.Click += new System.EventHandler(this.tabAdditionalInfo_Click);
            // 
            // labelShowActions
            // 
            this.labelShowActions.AutoSize = true;
            this.labelShowActions.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labelShowActions.Location = new System.Drawing.Point(60, 39);
            this.labelShowActions.Name = "labelShowActions";
            this.labelShowActions.Size = new System.Drawing.Size(105, 19);
            this.labelShowActions.TabIndex = 26;
            this.labelShowActions.Text = "Show Actions:";
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
            this.dataGridShowActions.Location = new System.Drawing.Point(64, 73);
            this.dataGridShowActions.Name = "dataGridShowActions";
            this.dataGridShowActions.ReadOnly = true;
            this.dataGridShowActions.Size = new System.Drawing.Size(355, 426);
            this.dataGridShowActions.TabIndex = 25;
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
            this.comboBoxShowActions.Location = new System.Drawing.Point(171, 39);
            this.comboBoxShowActions.Name = "comboBoxShowActions";
            this.comboBoxShowActions.Size = new System.Drawing.Size(165, 23);
            this.comboBoxShowActions.TabIndex = 24;
            this.comboBoxShowActions.SelectedValueChanged += new System.EventHandler(this.comboBoxShowActions_SelectedValueChanged);
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 15;
            this.listBoxCheckins.Location = new System.Drawing.Point(548, 330);
            this.listBoxCheckins.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(229, 169);
            this.listBoxCheckins.TabIndex = 19;
            // 
            // labelCheckins
            // 
            this.labelCheckins.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelCheckins.Location = new System.Drawing.Point(547, 290);
            this.labelCheckins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCheckins.Name = "labelCheckins";
            this.labelCheckins.Size = new System.Drawing.Size(228, 38);
            this.labelCheckins.TabIndex = 18;
            this.labelCheckins.Text = "Checkins";
            this.labelCheckins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 15;
            this.listBoxLikedPages.Location = new System.Drawing.Point(546, 64);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(229, 214);
            this.listBoxLikedPages.TabIndex = 17;
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelLikedPages.Location = new System.Drawing.Point(545, 24);
            this.labelLikedPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(228, 38);
            this.labelLikedPages.TabIndex = 16;
            this.labelLikedPages.Text = "Liked Pages";
            this.labelLikedPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabFeature1
            // 
            this.tabFeature1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabFeature1.Controls.Add(this.panel2);
            this.tabFeature1.Location = new System.Drawing.Point(4, 24);
            this.tabFeature1.Margin = new System.Windows.Forms.Padding(2);
            this.tabFeature1.Name = "tabFeature1";
            this.tabFeature1.Padding = new System.Windows.Forms.Padding(2);
            this.tabFeature1.Size = new System.Drawing.Size(1018, 507);
            this.tabFeature1.TabIndex = 5;
            this.tabFeature1.Text = "Feature 1";
            this.tabFeature1.Click += new System.EventHandler(this.tabFeature1_Click);
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
            this.panel2.Location = new System.Drawing.Point(94, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 515);
            this.panel2.TabIndex = 5;
            // 
            // wordUsagePostsPanel
            // 
            this.wordUsagePostsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordUsagePostsPanel.Location = new System.Drawing.Point(451, 133);
            this.wordUsagePostsPanel.Name = "wordUsagePostsPanel";
            this.wordUsagePostsPanel.Size = new System.Drawing.Size(258, 340);
            this.wordUsagePostsPanel.TabIndex = 6;
            // 
            // wordUsageDataPanel
            // 
            this.wordUsageDataPanel.AutoScroll = true;
            this.wordUsageDataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordUsageDataPanel.Location = new System.Drawing.Point(121, 133);
            this.wordUsageDataPanel.Name = "wordUsageDataPanel";
            this.wordUsageDataPanel.Size = new System.Drawing.Size(258, 340);
            this.wordUsageDataPanel.TabIndex = 5;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(204, 30);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 23);
            this.startDatePicker.TabIndex = 0;
            this.startDatePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // showWordStatisticsButton
            // 
            this.showWordStatisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.showWordStatisticsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showWordStatisticsButton.Location = new System.Drawing.Point(321, 77);
            this.showWordStatisticsButton.Name = "showWordStatisticsButton";
            this.showWordStatisticsButton.Size = new System.Drawing.Size(189, 30);
            this.showWordStatisticsButton.TabIndex = 4;
            this.showWordStatisticsButton.Text = "Show Word Usage Statistics";
            this.showWordStatisticsButton.UseVisualStyleBackColor = false;
            this.showWordStatisticsButton.Click += new System.EventHandler(this.showWordStatisticsButton_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(494, 30);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 23);
            this.endDatePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "End Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabFeature2
            // 
            this.tabFeature2.Location = new System.Drawing.Point(4, 24);
            this.tabFeature2.Margin = new System.Windows.Forms.Padding(2);
            this.tabFeature2.Name = "tabFeature2";
            this.tabFeature2.Padding = new System.Windows.Forms.Padding(2);
            this.tabFeature2.Size = new System.Drawing.Size(1018, 507);
            this.tabFeature2.TabIndex = 6;
            this.tabFeature2.Text = "Feature 2";
            this.tabFeature2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Words Usage Data (click to see posts)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Posts";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.panel3.Location = new System.Drawing.Point(94, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 515);
            this.panel3.TabIndex = 27;
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
            this.panel4.Location = new System.Drawing.Point(94, -4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(830, 515);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.textBoxPostStatus);
            this.panel5.Controls.Add(this.listBoxLatestPostComments);
            this.panel5.Controls.Add(this.pictureBoxFeed);
            this.panel5.Controls.Add(this.listBoxLatestsPosts);
            this.panel5.Controls.Add(this.labelPostStatus);
            this.panel5.Controls.Add(this.labelLatestsPosts);
            this.panel5.Controls.Add(this.buttonPostStatus);
            this.panel5.Location = new System.Drawing.Point(94, -4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(830, 515);
            this.panel5.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 535);
            this.Controls.Add(this.tabsControl);
            this.Name = "MainForm";
            this.Text = "Facebook App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).EndInit();
            this.tabsControl.ResumeLayout(false);
            this.tabLoginLogout.ResumeLayout(false);
            this.tabLoginLogout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFeed.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabAlbums.ResumeLayout(false);
            this.tabAdditionalInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowActions)).EndInit();
            this.tabFeature1.ResumeLayout(false);
            this.tabFeature1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}

