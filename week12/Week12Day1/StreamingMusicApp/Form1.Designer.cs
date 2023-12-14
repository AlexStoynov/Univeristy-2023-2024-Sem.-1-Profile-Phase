using System.Runtime.CompilerServices;

namespace StreamingMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ShowUsersBtn = new Button();
            ViewAllUsersLB = new ListBox();
            CreateUserGB = new GroupBox();
            UserAddress = new TextBox();
            UserName = new TextBox();
            CreateUserBtn = new Button();
            label3 = new Label();
            UserEMail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            ShowSongsBtn = new Button();
            ViewAllSongsLB = new ListBox();
            groupBox1 = new GroupBox();
            IDSong = new NumericUpDown();
            label7 = new Label();
            SongGenre = new ComboBox();
            SongID = new Label();
            SongDuration = new NumericUpDown();
            SongArtist = new TextBox();
            CreateSongBtn = new Button();
            label4 = new Label();
            SongTitle = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            RemoveSongBtn = new Button();
            ShowInfoBtn = new Button();
            AddSongToUserBtn = new Button();
            groupBox3 = new GroupBox();
            SongsManageLb = new ListBox();
            groupBox2 = new GroupBox();
            UsersManageLb = new ListBox();
            tabPage4 = new TabPage();
            UserSongsTb = new TextBox();
            groupBox4 = new GroupBox();
            showUsersDisplayBtn = new Button();
            ShowUsersFinalLb = new ListBox();
            ShowUserFavSongsBtn = new Button();
            cbUsers = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            CreateUserGB.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IDSong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SongDuration).BeginInit();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(683, 810);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ShowUsersBtn);
            tabPage1.Controls.Add(ViewAllUsersLB);
            tabPage1.Controls.Add(CreateUserGB);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(667, 756);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create User";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ShowUsersBtn
            // 
            ShowUsersBtn.Location = new Point(6, 639);
            ShowUsersBtn.Name = "ShowUsersBtn";
            ShowUsersBtn.Size = new Size(655, 46);
            ShowUsersBtn.TabIndex = 12;
            ShowUsersBtn.Text = "Show all users";
            ShowUsersBtn.UseVisualStyleBackColor = true;
            ShowUsersBtn.Click += ShowUsersBtn_Click;
            // 
            // ViewAllUsersLB
            // 
            ViewAllUsersLB.FormattingEnabled = true;
            ViewAllUsersLB.ItemHeight = 32;
            ViewAllUsersLB.Location = new Point(6, 364);
            ViewAllUsersLB.Name = "ViewAllUsersLB";
            ViewAllUsersLB.Size = new Size(655, 260);
            ViewAllUsersLB.TabIndex = 11;
            // 
            // CreateUserGB
            // 
            CreateUserGB.Controls.Add(UserAddress);
            CreateUserGB.Controls.Add(UserName);
            CreateUserGB.Controls.Add(CreateUserBtn);
            CreateUserGB.Controls.Add(label3);
            CreateUserGB.Controls.Add(UserEMail);
            CreateUserGB.Controls.Add(label2);
            CreateUserGB.Controls.Add(label1);
            CreateUserGB.Location = new Point(6, 6);
            CreateUserGB.Name = "CreateUserGB";
            CreateUserGB.Size = new Size(655, 288);
            CreateUserGB.TabIndex = 10;
            CreateUserGB.TabStop = false;
            CreateUserGB.Text = "Create User";
            // 
            // UserAddress
            // 
            UserAddress.Location = new Point(116, 158);
            UserAddress.Name = "UserAddress";
            UserAddress.Size = new Size(278, 39);
            UserAddress.TabIndex = 7;
            // 
            // UserName
            // 
            UserName.Location = new Point(96, 38);
            UserName.Name = "UserName";
            UserName.Size = new Size(298, 39);
            UserName.TabIndex = 2;
            // 
            // CreateUserBtn
            // 
            CreateUserBtn.Location = new Point(7, 222);
            CreateUserBtn.Name = "CreateUserBtn";
            CreateUserBtn.Size = new Size(387, 46);
            CreateUserBtn.TabIndex = 1;
            CreateUserBtn.Text = "Create User";
            CreateUserBtn.UseVisualStyleBackColor = true;
            CreateUserBtn.Click += CreateUserBtn_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 161);
            label3.Name = "label3";
            label3.Size = new Size(103, 32);
            label3.TabIndex = 6;
            label3.Text = "Address:";
            // 
            // UserEMail
            // 
            UserEMail.Location = new Point(96, 98);
            UserEMail.Name = "UserEMail";
            UserEMail.Size = new Size(298, 39);
            UserEMail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 97);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 5;
            label2.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 41);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ShowSongsBtn);
            tabPage2.Controls.Add(ViewAllSongsLB);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(667, 756);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Create Song";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ShowSongsBtn
            // 
            ShowSongsBtn.Location = new Point(6, 653);
            ShowSongsBtn.Name = "ShowSongsBtn";
            ShowSongsBtn.Size = new Size(655, 46);
            ShowSongsBtn.TabIndex = 14;
            ShowSongsBtn.Text = "Show all songs";
            ShowSongsBtn.UseVisualStyleBackColor = true;
            ShowSongsBtn.Click += ShowSongsBtn_Click;
            // 
            // ViewAllSongsLB
            // 
            ViewAllSongsLB.FormattingEnabled = true;
            ViewAllSongsLB.ItemHeight = 32;
            ViewAllSongsLB.Location = new Point(6, 402);
            ViewAllSongsLB.Name = "ViewAllSongsLB";
            ViewAllSongsLB.Size = new Size(655, 228);
            ViewAllSongsLB.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IDSong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(SongGenre);
            groupBox1.Controls.Add(SongID);
            groupBox1.Controls.Add(SongDuration);
            groupBox1.Controls.Add(SongArtist);
            groupBox1.Controls.Add(CreateSongBtn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SongTitle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 390);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Song";
            // 
            // IDSong
            // 
            IDSong.Location = new Point(57, 38);
            IDSong.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            IDSong.Name = "IDSong";
            IDSong.Size = new Size(240, 39);
            IDSong.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 279);
            label7.Name = "label7";
            label7.Size = new Size(83, 32);
            label7.TabIndex = 16;
            label7.Text = "Genre:";
            // 
            // SongGenre
            // 
            SongGenre.FormattingEnabled = true;
            SongGenre.Items.AddRange(new object[] { "CLASSIC", "DANCE", "POP", "ROCK" });
            SongGenre.Location = new Point(98, 276);
            SongGenre.Name = "SongGenre";
            SongGenre.Size = new Size(242, 40);
            SongGenre.TabIndex = 15;
            // 
            // SongID
            // 
            SongID.AutoSize = true;
            SongID.Location = new Point(9, 40);
            SongID.Name = "SongID";
            SongID.Size = new Size(42, 32);
            SongID.TabIndex = 14;
            SongID.Text = "ID:";
            // 
            // SongDuration
            // 
            SongDuration.Location = new Point(205, 214);
            SongDuration.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            SongDuration.Name = "SongDuration";
            SongDuration.Size = new Size(123, 39);
            SongDuration.TabIndex = 13;
            // 
            // SongArtist
            // 
            SongArtist.Location = new Point(98, 93);
            SongArtist.Name = "SongArtist";
            SongArtist.Size = new Size(298, 39);
            SongArtist.TabIndex = 2;
            // 
            // CreateSongBtn
            // 
            CreateSongBtn.Location = new Point(9, 322);
            CreateSongBtn.Name = "CreateSongBtn";
            CreateSongBtn.Size = new Size(387, 46);
            CreateSongBtn.TabIndex = 1;
            CreateSongBtn.Text = "Create Song";
            CreateSongBtn.UseVisualStyleBackColor = true;
            CreateSongBtn.Click += CreateSongBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 216);
            label4.Name = "label4";
            label4.Size = new Size(190, 32);
            label4.TabIndex = 6;
            label4.Text = "Duration in secs:";
            // 
            // SongTitle
            // 
            SongTitle.Location = new Point(98, 153);
            SongTitle.Name = "SongTitle";
            SongTitle.Size = new Size(298, 39);
            SongTitle.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 152);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 5;
            label5.Text = "Title:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 96);
            label6.Name = "label6";
            label6.Size = new Size(74, 32);
            label6.TabIndex = 4;
            label6.Text = "Artist:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(RemoveSongBtn);
            tabPage3.Controls.Add(ShowInfoBtn);
            tabPage3.Controls.Add(AddSongToUserBtn);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(667, 756);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Manage Songs";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // RemoveSongBtn
            // 
            RemoveSongBtn.Location = new Point(27, 689);
            RemoveSongBtn.Name = "RemoveSongBtn";
            RemoveSongBtn.Size = new Size(598, 46);
            RemoveSongBtn.TabIndex = 4;
            RemoveSongBtn.Text = "Remove song from user";
            RemoveSongBtn.UseVisualStyleBackColor = true;
            RemoveSongBtn.Click += RemoveSongBtn_Click;
            // 
            // ShowInfoBtn
            // 
            ShowInfoBtn.Location = new Point(27, 585);
            ShowInfoBtn.Name = "ShowInfoBtn";
            ShowInfoBtn.Size = new Size(598, 46);
            ShowInfoBtn.TabIndex = 3;
            ShowInfoBtn.Text = "Show items";
            ShowInfoBtn.UseVisualStyleBackColor = true;
            ShowInfoBtn.Click += ShowInfoBtn_Click;
            // 
            // AddSongToUserBtn
            // 
            AddSongToUserBtn.Location = new Point(27, 637);
            AddSongToUserBtn.Name = "AddSongToUserBtn";
            AddSongToUserBtn.Size = new Size(598, 46);
            AddSongToUserBtn.TabIndex = 2;
            AddSongToUserBtn.Text = "Add song to user";
            AddSongToUserBtn.UseVisualStyleBackColor = true;
            AddSongToUserBtn.Click += AddSongToUserBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SongsManageLb);
            groupBox3.Location = new Point(333, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(309, 572);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Songs";
            // 
            // SongsManageLb
            // 
            SongsManageLb.FormattingEnabled = true;
            SongsManageLb.ItemHeight = 32;
            SongsManageLb.Location = new Point(6, 38);
            SongsManageLb.Name = "SongsManageLb";
            SongsManageLb.Size = new Size(297, 516);
            SongsManageLb.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(UsersManageLb);
            groupBox2.Location = new Point(21, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 572);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Users";
            // 
            // UsersManageLb
            // 
            UsersManageLb.FormattingEnabled = true;
            UsersManageLb.ItemHeight = 32;
            UsersManageLb.Location = new Point(17, 38);
            UsersManageLb.Name = "UsersManageLb";
            UsersManageLb.Size = new Size(283, 516);
            UsersManageLb.TabIndex = 6;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(UserSongsTb);
            tabPage4.Controls.Add(groupBox4);
            tabPage4.Location = new Point(8, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(667, 756);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Display User Info";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // UserSongsTb
            // 
            UserSongsTb.Location = new Point(328, 19);
            UserSongsTb.Multiline = true;
            UserSongsTb.Name = "UserSongsTb";
            UserSongsTb.Size = new Size(312, 620);
            UserSongsTb.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(showUsersDisplayBtn);
            groupBox4.Controls.Add(ShowUsersFinalLb);
            groupBox4.Controls.Add(ShowUserFavSongsBtn);
            groupBox4.Location = new Point(4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(291, 636);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Users";
            // 
            // showUsersDisplayBtn
            // 
            showUsersDisplayBtn.Location = new Point(15, 528);
            showUsersDisplayBtn.Name = "showUsersDisplayBtn";
            showUsersDisplayBtn.Size = new Size(266, 46);
            showUsersDisplayBtn.TabIndex = 4;
            showUsersDisplayBtn.Text = "Show users";
            showUsersDisplayBtn.UseVisualStyleBackColor = true;
            showUsersDisplayBtn.Click += showUsersDisplayLb_Click;
            // 
            // ShowUsersFinalLb
            // 
            ShowUsersFinalLb.FormattingEnabled = true;
            ShowUsersFinalLb.ItemHeight = 32;
            ShowUsersFinalLb.Location = new Point(15, 38);
            ShowUsersFinalLb.Name = "ShowUsersFinalLb";
            ShowUsersFinalLb.Size = new Size(266, 484);
            ShowUsersFinalLb.TabIndex = 2;
            // 
            // ShowUserFavSongsBtn
            // 
            ShowUserFavSongsBtn.Location = new Point(15, 580);
            ShowUserFavSongsBtn.Name = "ShowUserFavSongsBtn";
            ShowUserFavSongsBtn.Size = new Size(266, 46);
            ShowUserFavSongsBtn.TabIndex = 1;
            ShowUserFavSongsBtn.Text = "Show favourite songs";
            ShowUserFavSongsBtn.UseVisualStyleBackColor = true;
            ShowUserFavSongsBtn.Click += ShowUserFavSongsBtn_Click_1;
            // 
            // cbUsers
            // 
            cbUsers.Location = new Point(0, 0);
            cbUsers.Name = "cbUsers";
            cbUsers.Size = new Size(121, 40);
            cbUsers.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 822);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            CreateUserGB.ResumeLayout(false);
            CreateUserGB.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IDSong).EndInit();
            ((System.ComponentModel.ISupportInitialize)SongDuration).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox CreateUserGB;
        private TextBox UserName;
        private Button CreateUserBtn;
        private Label label3;
        private TextBox UserEMail;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private Label label7;
        private ComboBox cbUsers;
        private ComboBox SongGenre;
        private Label SongID;
        private NumericUpDown SongDuration;
        private TextBox SongArtist;
        private Button CreateSongBtn;
        private Label label4;
        private TextBox SongTitle;
        private Label label5;
        private Label label6;
        private ListBox ViewAllUsersLB;
        private Button ShowUsersBtn;
        private TextBox UserAddress;
        private Button ShowSongsBtn;
        private ListBox ViewAllSongsLB;
        private NumericUpDown IDSong;
        private Button AddSongToUserBtn;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button ShowInfoBtn;
        private Button RemoveSongBtn;
        private GroupBox groupBox4;
        private Button ShowUserFavSongsBtn;
        private TextBox UserSongsTb;
        private ListBox SongsManageLb;
        private ListBox UsersManageLb;
        private ListBox ShowUsersFinalLb;
        private Button showUsersDisplayBtn;
    }
}