﻿namespace OsuDesktop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RngNumText = new System.Windows.Forms.Label();
            this.BeatmapText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TitleText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SongImg = new System.Windows.Forms.PictureBox();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.RandomButtom = new System.Windows.Forms.Button();
            this.ArtistText = new System.Windows.Forms.Label();
            this.CreatorText = new System.Windows.Forms.Label();
            this.DiffNameText = new System.Windows.Forms.Label();
            this.PassTriedText = new System.Windows.Forms.Label();
            this.PlayTimeText = new System.Windows.Forms.Label();
            this.BPMText = new System.Windows.Forms.Label();
            this.SubmitDateText = new System.Windows.Forms.Label();
            this.StarsText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.RngNumText);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // RngNumText
            // 
            resources.ApplyResources(this.RngNumText, "RngNumText");
            this.RngNumText.Name = "RngNumText";
            // 
            // BeatmapText
            // 
            resources.ApplyResources(this.BeatmapText, "BeatmapText");
            this.BeatmapText.ForeColor = System.Drawing.SystemColors.Window;
            this.BeatmapText.Name = "BeatmapText";
            this.BeatmapText.Click += new System.EventHandler(this.BeatmapText_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.StarsText);
            this.panel2.Controls.Add(this.SubmitDateText);
            this.panel2.Controls.Add(this.BPMText);
            this.panel2.Controls.Add(this.PlayTimeText);
            this.panel2.Controls.Add(this.PassTriedText);
            this.panel2.Controls.Add(this.DiffNameText);
            this.panel2.Controls.Add(this.CreatorText);
            this.panel2.Controls.Add(this.ArtistText);
            this.panel2.Controls.Add(this.TitleText);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // TitleText
            // 
            resources.ApplyResources(this.TitleText, "TitleText");
            this.TitleText.Name = "TitleText";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(84)))));
            this.panel3.BackgroundImage = global::OsuDesktop.Properties.Resources.ikona3;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // SongImg
            // 
            this.SongImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.SongImg.BackgroundImage = global::OsuDesktop.Properties.Resources.triangles_combined;
            this.SongImg.ErrorImage = global::OsuDesktop.Properties.Resources.NoImage;
            resources.ApplyResources(this.SongImg, "SongImg");
            this.SongImg.Name = "SongImg";
            this.SongImg.TabStop = false;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.DownloadBtn, "DownloadBtn");
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.UseVisualStyleBackColor = false;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // RandomButtom
            // 
            this.RandomButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.RandomButtom, "RandomButtom");
            this.RandomButtom.Name = "RandomButtom";
            this.RandomButtom.UseVisualStyleBackColor = false;
            this.RandomButtom.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // ArtistText
            // 
            resources.ApplyResources(this.ArtistText, "ArtistText");
            this.ArtistText.Name = "ArtistText";
            // 
            // CreatorText
            // 
            resources.ApplyResources(this.CreatorText, "CreatorText");
            this.CreatorText.Name = "CreatorText";
            // 
            // DiffNameText
            // 
            resources.ApplyResources(this.DiffNameText, "DiffNameText");
            this.DiffNameText.Name = "DiffNameText";
            // 
            // PassTriedText
            // 
            resources.ApplyResources(this.PassTriedText, "PassTriedText");
            this.PassTriedText.Name = "PassTriedText";
            // 
            // PlayTimeText
            // 
            resources.ApplyResources(this.PlayTimeText, "PlayTimeText");
            this.PlayTimeText.Name = "PlayTimeText";
            // 
            // BPMText
            // 
            resources.ApplyResources(this.BPMText, "BPMText");
            this.BPMText.Name = "BPMText";
            // 
            // SubmitDateText
            // 
            resources.ApplyResources(this.SubmitDateText, "SubmitDateText");
            this.SubmitDateText.Name = "SubmitDateText";
            // 
            // StarsText
            // 
            resources.ApplyResources(this.StarsText, "StarsText");
            this.StarsText.Name = "StarsText";
            // 
            // WinForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BeatmapText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SongImg);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.RandomButtom);
            this.Name = "WinForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomButtom;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.PictureBox SongImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BeatmapText;
        private System.Windows.Forms.Label RngNumText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Label SubmitDateText;
        private System.Windows.Forms.Label BPMText;
        private System.Windows.Forms.Label PlayTimeText;
        private System.Windows.Forms.Label PassTriedText;
        private System.Windows.Forms.Label DiffNameText;
        private System.Windows.Forms.Label CreatorText;
        private System.Windows.Forms.Label ArtistText;
        private System.Windows.Forms.Label StarsText;
    }
}