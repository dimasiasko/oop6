namespace MusicAppv1
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.IblLogo = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelChoosing = new System.Windows.Forms.Label();
            this.timerPlaying = new System.Windows.Forms.Timer(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.downButton = new System.Windows.Forms.PictureBox();
            this.upButton = new System.Windows.Forms.PictureBox();
            this.mixTracksButton = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.PictureBox();
            this.PreviousButton = new System.Windows.Forms.PictureBox();
            this.PauseButton = new System.Windows.Forms.PictureBox();
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixTracksButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.buttonExit);
            this.TopPanel.Controls.Add(this.IblLogo);
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(289, 51);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // IblLogo
            // 
            this.IblLogo.AutoSize = true;
            this.IblLogo.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblLogo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.IblLogo.Location = new System.Drawing.Point(12, 9);
            this.IblLogo.Name = "IblLogo";
            this.IblLogo.Size = new System.Drawing.Size(96, 15);
            this.IblLogo.TabIndex = 0;
            this.IblLogo.Text = "Music Player";
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.AllowDrop = true;
            this.listBoxSongs.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 16;
            this.listBoxSongs.Location = new System.Drawing.Point(15, 188);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(255, 260);
            this.listBoxSongs.TabIndex = 1;
            this.listBoxSongs.Click += new System.EventHandler(this.listBoxSongs_Click);
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            this.listBoxSongs.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxSongs_DragEnter);
            this.listBoxSongs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxSongs_MouseDown);
            this.listBoxSongs.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listBoxSongs_PreviewKeyDown);
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSelectSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectSongs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSelectSongs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnSelectSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSongs.ForeColor = System.Drawing.Color.White;
            this.btnSelectSongs.Location = new System.Drawing.Point(16, 476);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(261, 38);
            this.btnSelectSongs.TabIndex = 2;
            this.btnSelectSongs.Text = "Выбрать файлы";
            this.btnSelectSongs.UseVisualStyleBackColor = false;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // axWindowsMediaPlayerMusic
            // 
            this.axWindowsMediaPlayerMusic.Enabled = true;
            this.axWindowsMediaPlayerMusic.Location = new System.Drawing.Point(-8, 50);
            this.axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            this.axWindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusic.OcxState")));
            this.axWindowsMediaPlayerMusic.Size = new System.Drawing.Size(297, 135);
            this.axWindowsMediaPlayerMusic.TabIndex = 3;
            this.axWindowsMediaPlayerMusic.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayerMusic_PlayStateChange);
            // 
            // labelChoosing
            // 
            this.labelChoosing.AllowDrop = true;
            this.labelChoosing.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelChoosing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelChoosing.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoosing.Location = new System.Drawing.Point(32, 188);
            this.labelChoosing.Name = "labelChoosing";
            this.labelChoosing.Size = new System.Drawing.Size(255, 260);
            this.labelChoosing.TabIndex = 5;
            this.labelChoosing.Text = "Нажмите кнопку \"Выбрать файлы\"";
            this.labelChoosing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChoosing.DragEnter += new System.Windows.Forms.DragEventHandler(this.label1_DragEnter);
            this.labelChoosing.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // timerPlaying
            // 
            this.timerPlaying.Tick += new System.EventHandler(this.timerPlaying_Tick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonDelete});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(119, 26);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(118, 22);
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.downButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.downButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downButton.Image = global::MusicAppv1.Properties.Resources.DownButton;
            this.downButton.Location = new System.Drawing.Point(203, 448);
            this.downButton.Margin = new System.Windows.Forms.Padding(0);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(32, 27);
            this.downButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.downButton.TabIndex = 12;
            this.downButton.TabStop = false;
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.upButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upButton.Image = global::MusicAppv1.Properties.Resources.Upbutton;
            this.upButton.Location = new System.Drawing.Point(175, 448);
            this.upButton.Margin = new System.Windows.Forms.Padding(0);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(28, 27);
            this.upButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upButton.TabIndex = 11;
            this.upButton.TabStop = false;
            // 
            // mixTracksButton
            // 
            this.mixTracksButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mixTracksButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mixTracksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mixTracksButton.Image = global::MusicAppv1.Properties.Resources.icons8_перемешать_64;
            this.mixTracksButton.Location = new System.Drawing.Point(235, 451);
            this.mixTracksButton.Margin = new System.Windows.Forms.Padding(0);
            this.mixTracksButton.Name = "mixTracksButton";
            this.mixTracksButton.Size = new System.Drawing.Size(42, 22);
            this.mixTracksButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mixTracksButton.TabIndex = 10;
            this.mixTracksButton.TabStop = false;
            this.mixTracksButton.Click += new System.EventHandler(this.mixTracksButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.NextButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Image = global::MusicAppv1.Properties.Resources.icons8_шеврон_вправо_в_круге_96;
            this.NextButton.Location = new System.Drawing.Point(247, 155);
            this.NextButton.Margin = new System.Windows.Forms.Padding(0);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(42, 30);
            this.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NextButton.TabIndex = 9;
            this.NextButton.TabStop = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.NextButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NextButton_MouseDown);
            this.NextButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NextButton_MouseUp);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.PreviousButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousButton.Image = global::MusicAppv1.Properties.Resources.icons8_шеврон_влево_в_круге_96;
            this.PreviousButton.Location = new System.Drawing.Point(205, 155);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(0);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(42, 30);
            this.PreviousButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviousButton.TabIndex = 8;
            this.PreviousButton.TabStop = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            this.PreviousButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PreviousButton_MouseDown);
            this.PreviousButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PreviousButton_MouseUp);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.PauseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseButton.Image = global::MusicAppv1.Properties.Resources.icons8_пауза_в_кружке_96;
            this.PauseButton.Location = new System.Drawing.Point(57, 153);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(0);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(42, 32);
            this.PauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PauseButton.TabIndex = 7;
            this.PauseButton.TabStop = false;
            this.PauseButton.Click += new System.EventHandler(this.StopButton_Click);
            this.PauseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StopButton_MouseDown);
            this.PauseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopButton_MouseUp);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.PlayButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Image = global::MusicAppv1.Properties.Resources.icons8_начало_96;
            this.PlayButton.Location = new System.Drawing.Point(0, 153);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(57, 32);
            this.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayButton.TabIndex = 6;
            this.PlayButton.TabStop = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            this.PlayButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayButton_MouseDown);
            this.PlayButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayButton_MouseUp);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(260, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(26, 24);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonExit.TabIndex = 1;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(289, 526);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.mixTracksButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.labelChoosing);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.axWindowsMediaPlayerMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MusicPlayerApp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MusicPlayerApp_MouseMove);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixTracksButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox buttonExit;
        private System.Windows.Forms.Label IblLogo;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button btnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private System.Windows.Forms.Label labelChoosing;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.PictureBox PauseButton;
        private System.Windows.Forms.PictureBox PreviousButton;
        private System.Windows.Forms.PictureBox NextButton;
        private System.Windows.Forms.Timer timerPlaying;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem buttonDelete;
        private System.Windows.Forms.PictureBox mixTracksButton;
        private System.Windows.Forms.PictureBox upButton;
        private System.Windows.Forms.PictureBox downButton;
    }
}

