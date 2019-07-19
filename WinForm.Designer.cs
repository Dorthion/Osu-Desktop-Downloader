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
            this.RandomButtom = new System.Windows.Forms.Button();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.SongImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BeatmapText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RngNumText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SongImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RandomButtom
            // 
            this.RandomButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(84)))));
            this.RandomButtom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomButtom.BackgroundImage")));
            this.RandomButtom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RandomButtom.Location = new System.Drawing.Point(738, 12);
            this.RandomButtom.Name = "RandomButtom";
            this.RandomButtom.Size = new System.Drawing.Size(100, 100);
            this.RandomButtom.TabIndex = 0;
            this.RandomButtom.UseVisualStyleBackColor = false;
            this.RandomButtom.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(84)))));
            this.DownloadBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownloadBtn.BackgroundImage")));
            this.DownloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownloadBtn.Location = new System.Drawing.Point(738, 117);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(100, 100);
            this.DownloadBtn.TabIndex = 1;
            this.DownloadBtn.UseVisualStyleBackColor = false;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // SongImg
            // 
            this.SongImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.SongImg.Location = new System.Drawing.Point(12, 12);
            this.SongImg.Name = "SongImg";
            this.SongImg.Size = new System.Drawing.Size(720, 200);
            this.SongImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SongImg.TabIndex = 3;
            this.SongImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.RngNumText);
            this.panel1.Location = new System.Drawing.Point(738, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 4;
            // 
            // BeatmapText
            // 
            this.BeatmapText.AutoSize = true;
            this.BeatmapText.ForeColor = System.Drawing.SystemColors.Window;
            this.BeatmapText.Location = new System.Drawing.Point(762, 445);
            this.BeatmapText.Name = "BeatmapText";
            this.BeatmapText.Size = new System.Drawing.Size(54, 34);
            this.BeatmapText.TabIndex = 5;
            this.BeatmapText.Text = "  ODR\r\nVer 1.0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel2.Location = new System.Drawing.Point(12, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 268);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(738, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 100);
            this.panel3.TabIndex = 7;
            // 
            // RngNumText
            // 
            this.RngNumText.AutoSize = true;
            this.RngNumText.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RngNumText.Location = new System.Drawing.Point(18, 35);
            this.RngNumText.Name = "RngNumText";
            this.RngNumText.Size = new System.Drawing.Size(60, 29);
            this.RngNumText.TabIndex = 0;
            this.RngNumText.Text = "Rng";
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(846, 502);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BeatmapText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SongImg);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.RandomButtom);
            this.Name = "WinForm";
            this.Text = "Osu! Desktop Randomizer";
            ((System.ComponentModel.ISupportInitialize)(this.SongImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}