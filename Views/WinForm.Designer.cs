namespace OsuDesktop
{
    partial class WinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.BeatmapText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ListCountText = new System.Windows.Forms.Label();
            this.BtnLeftList = new System.Windows.Forms.Button();
            this.StarsText = new System.Windows.Forms.Label();
            this.BtnRigthList = new System.Windows.Forms.Button();
            this.SubmitDateText = new System.Windows.Forms.Label();
            this.BPMText = new System.Windows.Forms.Label();
            this.DrainLengthText = new System.Windows.Forms.Label();
            this.PassTriedText = new System.Windows.Forms.Label();
            this.DiffNameText = new System.Windows.Forms.Label();
            this.CreatorText = new System.Windows.Forms.Label();
            this.ArtistText = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RngNumText = new System.Windows.Forms.Label();
            this.SongImg = new System.Windows.Forms.PictureBox();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.RandomButtom = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(84)))));
            this.panel3.BackgroundImage = global::OsuDesktop.Properties.Resources.ikona2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(552, 266);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 81);
            this.panel3.TabIndex = 14;
            // 
            // BeatmapText
            // 
            this.BeatmapText.AutoSize = true;
            this.BeatmapText.ForeColor = System.Drawing.SystemColors.Window;
            this.BeatmapText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BeatmapText.Location = new System.Drawing.Point(570, 362);
            this.BeatmapText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BeatmapText.Name = "BeatmapText";
            this.BeatmapText.Size = new System.Drawing.Size(41, 26);
            this.BeatmapText.TabIndex = 12;
            this.BeatmapText.Text = "    BR\r\nVer 0.1";
            this.BeatmapText.Click += new System.EventHandler(this.BeatmapText_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.BtnLeftList);
            this.panel2.Controls.Add(this.StarsText);
            this.panel2.Controls.Add(this.BtnRigthList);
            this.panel2.Controls.Add(this.SubmitDateText);
            this.panel2.Controls.Add(this.BPMText);
            this.panel2.Controls.Add(this.DrainLengthText);
            this.panel2.Controls.Add(this.PassTriedText);
            this.panel2.Controls.Add(this.DiffNameText);
            this.panel2.Controls.Add(this.CreatorText);
            this.panel2.Controls.Add(this.ArtistText);
            this.panel2.Controls.Add(this.TitleText);
            this.panel2.Location = new System.Drawing.Point(8, 180);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 218);
            this.panel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(79)))));
            this.panel4.Controls.Add(this.ListCountText);
            this.panel4.Location = new System.Drawing.Point(474, 192);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 20);
            this.panel4.TabIndex = 17;
            // 
            // ListCountText
            // 
            this.ListCountText.AutoSize = true;
            this.ListCountText.ForeColor = System.Drawing.SystemColors.Window;
            this.ListCountText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListCountText.Location = new System.Drawing.Point(0, 0);
            this.ListCountText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListCountText.MaximumSize = new System.Drawing.Size(38, 20);
            this.ListCountText.MinimumSize = new System.Drawing.Size(38, 20);
            this.ListCountText.Name = "ListCountText";
            this.ListCountText.Size = new System.Drawing.Size(38, 20);
            this.ListCountText.TabIndex = 12;
            this.ListCountText.Text = "0/0";
            this.ListCountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLeftList
            // 
            this.BtnLeftList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnLeftList.Location = new System.Drawing.Point(451, 192);
            this.BtnLeftList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLeftList.Name = "BtnLeftList";
            this.BtnLeftList.Size = new System.Drawing.Size(19, 20);
            this.BtnLeftList.TabIndex = 16;
            this.BtnLeftList.Text = "<";
            this.BtnLeftList.UseVisualStyleBackColor = true;
            this.BtnLeftList.Click += new System.EventHandler(this.BtnLeftList_Click);
            // 
            // StarsText
            // 
            this.StarsText.AutoSize = true;
            this.StarsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.StarsText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StarsText.Location = new System.Drawing.Point(268, 163);
            this.StarsText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StarsText.MaximumSize = new System.Drawing.Size(266, 26);
            this.StarsText.MinimumSize = new System.Drawing.Size(266, 26);
            this.StarsText.Name = "StarsText";
            this.StarsText.Size = new System.Drawing.Size(266, 26);
            this.StarsText.TabIndex = 8;
            this.StarsText.Text = "Stars:";
            this.StarsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnRigthList
            // 
            this.BtnRigthList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnRigthList.Location = new System.Drawing.Point(516, 192);
            this.BtnRigthList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRigthList.Name = "BtnRigthList";
            this.BtnRigthList.Size = new System.Drawing.Size(19, 20);
            this.BtnRigthList.TabIndex = 15;
            this.BtnRigthList.Text = ">";
            this.BtnRigthList.UseVisualStyleBackColor = true;
            this.BtnRigthList.Click += new System.EventHandler(this.BtnRigthList_Click);
            // 
            // SubmitDateText
            // 
            this.SubmitDateText.AutoSize = true;
            this.SubmitDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.SubmitDateText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SubmitDateText.Location = new System.Drawing.Point(2, 189);
            this.SubmitDateText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubmitDateText.MaximumSize = new System.Drawing.Size(532, 26);
            this.SubmitDateText.MinimumSize = new System.Drawing.Size(532, 26);
            this.SubmitDateText.Name = "SubmitDateText";
            this.SubmitDateText.Size = new System.Drawing.Size(532, 26);
            this.SubmitDateText.TabIndex = 7;
            this.SubmitDateText.Text = "Submit Date:";
            this.SubmitDateText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BPMText
            // 
            this.BPMText.AutoSize = true;
            this.BPMText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.BPMText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BPMText.Location = new System.Drawing.Point(2, 163);
            this.BPMText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BPMText.MaximumSize = new System.Drawing.Size(266, 26);
            this.BPMText.MinimumSize = new System.Drawing.Size(266, 26);
            this.BPMText.Name = "BPMText";
            this.BPMText.Size = new System.Drawing.Size(266, 26);
            this.BPMText.TabIndex = 6;
            this.BPMText.Text = "BPM:";
            this.BPMText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DrainLengthText
            // 
            this.DrainLengthText.AutoSize = true;
            this.DrainLengthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.DrainLengthText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DrainLengthText.Location = new System.Drawing.Point(2, 137);
            this.DrainLengthText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DrainLengthText.MaximumSize = new System.Drawing.Size(532, 26);
            this.DrainLengthText.MinimumSize = new System.Drawing.Size(532, 26);
            this.DrainLengthText.Name = "DrainLengthText";
            this.DrainLengthText.Size = new System.Drawing.Size(532, 26);
            this.DrainLengthText.TabIndex = 5;
            this.DrainLengthText.Text = "Drain/Length:";
            this.DrainLengthText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassTriedText
            // 
            this.PassTriedText.AutoSize = true;
            this.PassTriedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.PassTriedText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PassTriedText.Location = new System.Drawing.Point(2, 111);
            this.PassTriedText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassTriedText.MaximumSize = new System.Drawing.Size(532, 26);
            this.PassTriedText.MinimumSize = new System.Drawing.Size(532, 26);
            this.PassTriedText.Name = "PassTriedText";
            this.PassTriedText.Size = new System.Drawing.Size(532, 26);
            this.PassTriedText.TabIndex = 4;
            this.PassTriedText.Text = "Pass/Tried:";
            this.PassTriedText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DiffNameText
            // 
            this.DiffNameText.AutoSize = true;
            this.DiffNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.DiffNameText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DiffNameText.Location = new System.Drawing.Point(2, 85);
            this.DiffNameText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiffNameText.MaximumSize = new System.Drawing.Size(532, 26);
            this.DiffNameText.MinimumSize = new System.Drawing.Size(532, 26);
            this.DiffNameText.Name = "DiffNameText";
            this.DiffNameText.Size = new System.Drawing.Size(532, 26);
            this.DiffNameText.TabIndex = 3;
            this.DiffNameText.Text = "Difficulty Name:";
            this.DiffNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreatorText
            // 
            this.CreatorText.AutoSize = true;
            this.CreatorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.CreatorText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CreatorText.Location = new System.Drawing.Point(2, 59);
            this.CreatorText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreatorText.MaximumSize = new System.Drawing.Size(532, 26);
            this.CreatorText.MinimumSize = new System.Drawing.Size(532, 26);
            this.CreatorText.Name = "CreatorText";
            this.CreatorText.Size = new System.Drawing.Size(532, 26);
            this.CreatorText.TabIndex = 2;
            this.CreatorText.Text = "Creator:";
            this.CreatorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ArtistText
            // 
            this.ArtistText.AutoSize = true;
            this.ArtistText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.ArtistText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ArtistText.Location = new System.Drawing.Point(2, 33);
            this.ArtistText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ArtistText.MaximumSize = new System.Drawing.Size(532, 26);
            this.ArtistText.MinimumSize = new System.Drawing.Size(532, 26);
            this.ArtistText.Name = "ArtistText";
            this.ArtistText.Size = new System.Drawing.Size(532, 26);
            this.ArtistText.TabIndex = 1;
            this.ArtistText.Text = "Artist:";
            this.ArtistText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.TitleText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TitleText.Location = new System.Drawing.Point(2, 7);
            this.TitleText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleText.MaximumSize = new System.Drawing.Size(532, 26);
            this.TitleText.MinimumSize = new System.Drawing.Size(532, 26);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(532, 26);
            this.TitleText.TabIndex = 0;
            this.TitleText.Text = "Title:";
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.RngNumText);
            this.panel1.Location = new System.Drawing.Point(552, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 81);
            this.panel1.TabIndex = 11;
            // 
            // RngNumText
            // 
            this.RngNumText.AutoSize = true;
            this.RngNumText.Font = new System.Drawing.Font("Verdana", 14F);
            this.RngNumText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RngNumText.Location = new System.Drawing.Point(0, 21);
            this.RngNumText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RngNumText.MinimumSize = new System.Drawing.Size(75, 32);
            this.RngNumText.Name = "RngNumText";
            this.RngNumText.Size = new System.Drawing.Size(75, 32);
            this.RngNumText.TabIndex = 0;
            this.RngNumText.Text = "Rng";
            this.RngNumText.Click += new System.EventHandler(this.RngNumText_Click);
            // 
            // SongImg
            // 
            this.SongImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.SongImg.BackgroundImage = global::OsuDesktop.Properties.Resources.triangles_combined;
            this.SongImg.ErrorImage = global::OsuDesktop.Properties.Resources.NoImage;
            this.SongImg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SongImg.Location = new System.Drawing.Point(8, 10);
            this.SongImg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SongImg.Name = "SongImg";
            this.SongImg.Size = new System.Drawing.Size(540, 162);
            this.SongImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SongImg.TabIndex = 10;
            this.SongImg.TabStop = false;
            this.SongImg.Click += new System.EventHandler(this.SongImg_Click);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.DownloadBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownloadBtn.BackgroundImage")));
            this.DownloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownloadBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DownloadBtn.Location = new System.Drawing.Point(552, 95);
            this.DownloadBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(75, 81);
            this.DownloadBtn.TabIndex = 9;
            this.DownloadBtn.UseVisualStyleBackColor = false;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // RandomButtom
            // 
            this.RandomButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.RandomButtom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomButtom.BackgroundImage")));
            this.RandomButtom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RandomButtom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RandomButtom.Location = new System.Drawing.Point(552, 10);
            this.RandomButtom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RandomButtom.Name = "RandomButtom";
            this.RandomButtom.Size = new System.Drawing.Size(75, 81);
            this.RandomButtom.TabIndex = 8;
            this.RandomButtom.UseVisualStyleBackColor = false;
            this.RandomButtom.Click += new System.EventHandler(this.RandomButtom_Click);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(634, 408);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BeatmapText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SongImg);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.RandomButtom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beatmap Randomizer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label BeatmapText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label StarsText;
        private System.Windows.Forms.Label SubmitDateText;
        private System.Windows.Forms.Label BPMText;
        private System.Windows.Forms.Label DrainLengthText;
        private System.Windows.Forms.Label PassTriedText;
        private System.Windows.Forms.Label DiffNameText;
        private System.Windows.Forms.Label CreatorText;
        private System.Windows.Forms.Label ArtistText;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RngNumText;
        private System.Windows.Forms.PictureBox SongImg;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.Button RandomButtom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ListCountText;
        private System.Windows.Forms.Button BtnLeftList;
        private System.Windows.Forms.Button BtnRigthList;
    }
}