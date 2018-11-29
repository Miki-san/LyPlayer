namespace LyPlayer__ver._2._31_
{
    partial class LyPlayer_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LyPlayer_main));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Music_bar = new System.Windows.Forms.ProgressBar();
            this.Time_box = new System.Windows.Forms.TextBox();
            this.Previous_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.Playlist_box = new System.Windows.Forms.ListBox();
            this.NowPlaying_label = new System.Windows.Forms.Label();
            this.NPBox = new System.Windows.Forms.TextBox();
            this.AddTrack_button = new System.Windows.Forms.Button();
            this.Album_picture = new System.Windows.Forms.PictureBox();
            this.Pause_button = new System.Windows.Forms.Button();
            this.Play_button = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Volume_Bar = new System.Windows.Forms.TrackBar();
            this.Time_track_timer = new System.Windows.Forms.Timer(this.components);
            this.Volume = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Album_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(580, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Music_bar
            // 
            this.Music_bar.Location = new System.Drawing.Point(12, 355);
            this.Music_bar.Name = "Music_bar";
            this.Music_bar.Size = new System.Drawing.Size(556, 10);
            this.Music_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Music_bar.TabIndex = 1;
            // 
            // Time_box
            // 
            this.Time_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Time_box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Time_box.Location = new System.Drawing.Point(12, 375);
            this.Time_box.Name = "Time_box";
            this.Time_box.ReadOnly = true;
            this.Time_box.Size = new System.Drawing.Size(556, 13);
            this.Time_box.TabIndex = 2;
            // 
            // Previous_button
            // 
            this.Previous_button.BackgroundImage = global::LyPlayer__ver._2._31_.Properties.Resources.Previous;
            this.Previous_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Previous_button.Location = new System.Drawing.Point(12, 317);
            this.Previous_button.Name = "Previous_button";
            this.Previous_button.Size = new System.Drawing.Size(32, 32);
            this.Previous_button.TabIndex = 3;
            this.Previous_button.UseVisualStyleBackColor = true;
            this.Previous_button.Click += new System.EventHandler(this.Previous_button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.BackgroundImage = global::LyPlayer__ver._2._31_.Properties.Resources.Stop;
            this.Stop_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop_button.Location = new System.Drawing.Point(50, 317);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(32, 32);
            this.Stop_button.TabIndex = 4;
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // Next_button
            // 
            this.Next_button.BackgroundImage = global::LyPlayer__ver._2._31_.Properties.Resources.Next;
            this.Next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next_button.Location = new System.Drawing.Point(164, 317);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(32, 32);
            this.Next_button.TabIndex = 7;
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Playlist_box
            // 
            this.Playlist_box.FormattingEnabled = true;
            this.Playlist_box.Location = new System.Drawing.Point(348, 27);
            this.Playlist_box.Name = "Playlist_box";
            this.Playlist_box.Size = new System.Drawing.Size(220, 316);
            this.Playlist_box.TabIndex = 9;
            this.Playlist_box.SelectedIndexChanged += new System.EventHandler(this.Playlist_box_SelectedIndexChanged);
            // 
            // NowPlaying_label
            // 
            this.NowPlaying_label.AutoSize = true;
            this.NowPlaying_label.Location = new System.Drawing.Point(9, 234);
            this.NowPlaying_label.Name = "NowPlaying_label";
            this.NowPlaying_label.Size = new System.Drawing.Size(69, 13);
            this.NowPlaying_label.TabIndex = 11;
            this.NowPlaying_label.Text = "Now Playing:";
            // 
            // NPBox
            // 
            this.NPBox.Location = new System.Drawing.Point(84, 231);
            this.NPBox.Name = "NPBox";
            this.NPBox.ReadOnly = true;
            this.NPBox.Size = new System.Drawing.Size(250, 20);
            this.NPBox.TabIndex = 12;
            // 
            // AddTrack_button
            // 
            this.AddTrack_button.BackgroundImage = global::LyPlayer__ver._2._31_.Properties.Resources.Upload;
            this.AddTrack_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddTrack_button.Location = new System.Drawing.Point(310, 27);
            this.AddTrack_button.Name = "AddTrack_button";
            this.AddTrack_button.Size = new System.Drawing.Size(32, 32);
            this.AddTrack_button.TabIndex = 10;
            this.AddTrack_button.UseVisualStyleBackColor = true;
            this.AddTrack_button.Click += new System.EventHandler(this.AddTrack_button_Click);
            // 
            // Album_picture
            // 
            this.Album_picture.Image = global::LyPlayer__ver._2._31_.Properties.Resources._1;
            this.Album_picture.Location = new System.Drawing.Point(12, 27);
            this.Album_picture.Name = "Album_picture";
            this.Album_picture.Size = new System.Drawing.Size(192, 192);
            this.Album_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Album_picture.TabIndex = 8;
            this.Album_picture.TabStop = false;
            // 
            // Pause_button
            // 
            this.Pause_button.BackgroundImage = global::LyPlayer__ver._2._31_.Properties.Resources.Pause;
            this.Pause_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pause_button.Location = new System.Drawing.Point(126, 317);
            this.Pause_button.Name = "Pause_button";
            this.Pause_button.Size = new System.Drawing.Size(32, 32);
            this.Pause_button.TabIndex = 6;
            this.Pause_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Pause_button.UseVisualStyleBackColor = true;
            this.Pause_button.Click += new System.EventHandler(this.Pause_button_Click);
            // 
            // Play_button
            // 
            this.Play_button.BackgroundImage = global::LyPlayer__ver._2._31_.Properties.Resources.Play;
            this.Play_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play_button.Location = new System.Drawing.Point(88, 317);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(32, 32);
            this.Play_button.TabIndex = 5;
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(210, 65);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(132, 25);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.AxWindowsMediaPlayer1_PlayStateChange);
            // 
            // Volume_Bar
            // 
            this.Volume_Bar.LargeChange = 10;
            this.Volume_Bar.Location = new System.Drawing.Point(202, 304);
            this.Volume_Bar.Maximum = 100;
            this.Volume_Bar.Name = "Volume_Bar";
            this.Volume_Bar.RightToLeftLayout = true;
            this.Volume_Bar.Size = new System.Drawing.Size(135, 45);
            this.Volume_Bar.SmallChange = 10;
            this.Volume_Bar.TabIndex = 14;
            this.Volume_Bar.TickFrequency = 10;
            this.Volume_Bar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Volume_Bar.Value = 100;
            this.Volume_Bar.Scroll += new System.EventHandler(this.Volume_Bar_Scroll);
            // 
            // Time_track_timer
            // 
            this.Time_track_timer.Enabled = true;
            this.Time_track_timer.Interval = 1000;
            this.Time_track_timer.Tick += new System.EventHandler(this.Time_track_timer_Tick);
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Location = new System.Drawing.Point(207, 288);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(45, 13);
            this.Volume.TabIndex = 15;
            this.Volume.Text = "Volume:";
            // 
            // LyPlayer_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(580, 407);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Volume_Bar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.NPBox);
            this.Controls.Add(this.NowPlaying_label);
            this.Controls.Add(this.AddTrack_button);
            this.Controls.Add(this.Playlist_box);
            this.Controls.Add(this.Album_picture);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Pause_button);
            this.Controls.Add(this.Play_button);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Previous_button);
            this.Controls.Add(this.Time_box);
            this.Controls.Add(this.Music_bar);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "LyPlayer_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LyPlayer";
            this.Load += new System.EventHandler(this.LyPlayer_main_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Album_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ProgressBar Music_bar;
        private System.Windows.Forms.TextBox Time_box;
        private System.Windows.Forms.Button Previous_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Button Pause_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.PictureBox Album_picture;
        private System.Windows.Forms.ListBox Playlist_box;
        private System.Windows.Forms.Button AddTrack_button;
        private System.Windows.Forms.Label NowPlaying_label;
        private System.Windows.Forms.TextBox NPBox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar Volume_Bar;
        private System.Windows.Forms.Timer Time_track_timer;
        private System.Windows.Forms.Label Volume;
    }
}

