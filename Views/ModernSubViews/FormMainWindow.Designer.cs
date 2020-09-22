namespace OsuDesktop.Views.ModernSubViews
{
    partial class FormMainWindow
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
            this.BeatmapImage = new System.Windows.Forms.PictureBox();
            this.DownloadBtn = new OsuDesktop.Scripts.RoundButton();
            this.BeatmapID = new OsuDesktop.Scripts.RoundRectangle();
            this.roundRectangle1 = new OsuDesktop.Scripts.RoundRectangle();
            this.TitleText = new System.Windows.Forms.Label();
            this.ArtistText = new System.Windows.Forms.Label();
            this.CreatorText = new System.Windows.Forms.Label();
            this.DifficultyText = new System.Windows.Forms.Label();
            this.PassTriedText = new System.Windows.Forms.Label();
            this.DrainLengthText = new System.Windows.Forms.Label();
            this.BPMText = new System.Windows.Forms.Label();
            this.SubmitDateText = new System.Windows.Forms.Label();
            this.StarsText = new System.Windows.Forms.Label();
            this.LanguageText = new System.Windows.Forms.Label();
            this.CircleSliderText = new System.Windows.Forms.Label();
            this.PlaySoundBtn = new OsuDesktop.Scripts.RoundButton();
            this.NextLvlBtn = new OsuDesktop.Scripts.RoundButton();
            this.PreviousLvlBtn = new OsuDesktop.Scripts.RoundButton();
            this.NextBeatmapBtn = new OsuDesktop.Scripts.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BeatmapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BeatmapImage
            // 
            this.BeatmapImage.BackgroundImage = global::OsuDesktop.Properties.Resources.triangles_combined;
            this.BeatmapImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BeatmapImage.InitialImage = null;
            this.BeatmapImage.Location = new System.Drawing.Point(578, 1);
            this.BeatmapImage.Name = "BeatmapImage";
            this.BeatmapImage.Size = new System.Drawing.Size(650, 195);
            this.BeatmapImage.TabIndex = 0;
            this.BeatmapImage.TabStop = false;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.BorderColor = System.Drawing.Color.Snow;
            this.DownloadBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DownloadBtn.FlatAppearance.BorderSize = 0;
            this.DownloadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DownloadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadBtn.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBtn.Location = new System.Drawing.Point(91, 493);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.DownloadBtn.OnHoverButtonColor = System.Drawing.Color.Silver;
            this.DownloadBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DownloadBtn.Size = new System.Drawing.Size(296, 75);
            this.DownloadBtn.TabIndex = 1;
            this.DownloadBtn.Text = "DOWNLOAD";
            this.DownloadBtn.TextColor = System.Drawing.Color.White;
            this.DownloadBtn.UseVisualStyleBackColor = true;
            // 
            // BeatmapID
            // 
            this.BeatmapID.BorderColor = System.Drawing.Color.Silver;
            this.BeatmapID.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BeatmapID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeatmapID.Location = new System.Drawing.Point(393, 493);
            this.BeatmapID.Name = "BeatmapID";
            this.BeatmapID.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BeatmapID.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.BeatmapID.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BeatmapID.Size = new System.Drawing.Size(145, 72);
            this.BeatmapID.TabIndex = 2;
            this.BeatmapID.Text = "Beatmap ID";
            this.BeatmapID.TextColor = System.Drawing.Color.White;
            // 
            // roundRectangle1
            // 
            this.roundRectangle1.BorderColor = System.Drawing.Color.Silver;
            this.roundRectangle1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundRectangle1.Location = new System.Drawing.Point(12, 493);
            this.roundRectangle1.Name = "roundRectangle1";
            this.roundRectangle1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundRectangle1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundRectangle1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundRectangle1.Size = new System.Drawing.Size(73, 72);
            this.roundRectangle1.TabIndex = 3;
            this.roundRectangle1.TextColor = System.Drawing.Color.White;
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.Color.Snow;
            this.TitleText.Location = new System.Drawing.Point(13, 9);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(81, 37);
            this.TitleText.TabIndex = 7;
            this.TitleText.Text = "Title: ";
            // 
            // ArtistText
            // 
            this.ArtistText.AutoSize = true;
            this.ArtistText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistText.ForeColor = System.Drawing.Color.Snow;
            this.ArtistText.Location = new System.Drawing.Point(13, 46);
            this.ArtistText.Name = "ArtistText";
            this.ArtistText.Size = new System.Drawing.Size(86, 37);
            this.ArtistText.TabIndex = 8;
            this.ArtistText.Text = "Artist:";
            // 
            // CreatorText
            // 
            this.CreatorText.AutoSize = true;
            this.CreatorText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorText.ForeColor = System.Drawing.Color.Snow;
            this.CreatorText.Location = new System.Drawing.Point(13, 83);
            this.CreatorText.Name = "CreatorText";
            this.CreatorText.Size = new System.Drawing.Size(119, 37);
            this.CreatorText.TabIndex = 9;
            this.CreatorText.Text = "Creator: ";
            // 
            // DifficultyText
            // 
            this.DifficultyText.AutoSize = true;
            this.DifficultyText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyText.ForeColor = System.Drawing.Color.Snow;
            this.DifficultyText.Location = new System.Drawing.Point(13, 120);
            this.DifficultyText.Name = "DifficultyText";
            this.DifficultyText.Size = new System.Drawing.Size(213, 37);
            this.DifficultyText.TabIndex = 10;
            this.DifficultyText.Text = "Difficulty Name: ";
            // 
            // PassTriedText
            // 
            this.PassTriedText.AutoSize = true;
            this.PassTriedText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTriedText.ForeColor = System.Drawing.Color.Snow;
            this.PassTriedText.Location = new System.Drawing.Point(13, 157);
            this.PassTriedText.Name = "PassTriedText";
            this.PassTriedText.Size = new System.Drawing.Size(149, 37);
            this.PassTriedText.TabIndex = 11;
            this.PassTriedText.Text = "Pass/Tried: ";
            // 
            // DrainLengthText
            // 
            this.DrainLengthText.AutoSize = true;
            this.DrainLengthText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrainLengthText.ForeColor = System.Drawing.Color.Snow;
            this.DrainLengthText.Location = new System.Drawing.Point(13, 194);
            this.DrainLengthText.Name = "DrainLengthText";
            this.DrainLengthText.Size = new System.Drawing.Size(187, 37);
            this.DrainLengthText.TabIndex = 12;
            this.DrainLengthText.Text = "Drain/Length: ";
            // 
            // BPMText
            // 
            this.BPMText.AutoSize = true;
            this.BPMText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPMText.ForeColor = System.Drawing.Color.Snow;
            this.BPMText.Location = new System.Drawing.Point(13, 231);
            this.BPMText.Name = "BPMText";
            this.BPMText.Size = new System.Drawing.Size(77, 37);
            this.BPMText.TabIndex = 13;
            this.BPMText.Text = "BPM:";
            // 
            // SubmitDateText
            // 
            this.SubmitDateText.AutoSize = true;
            this.SubmitDateText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitDateText.ForeColor = System.Drawing.Color.Snow;
            this.SubmitDateText.Location = new System.Drawing.Point(13, 268);
            this.SubmitDateText.Name = "SubmitDateText";
            this.SubmitDateText.Size = new System.Drawing.Size(177, 37);
            this.SubmitDateText.TabIndex = 14;
            this.SubmitDateText.Text = "Submit Date: ";
            // 
            // StarsText
            // 
            this.StarsText.AutoSize = true;
            this.StarsText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarsText.ForeColor = System.Drawing.Color.Snow;
            this.StarsText.Location = new System.Drawing.Point(13, 305);
            this.StarsText.Name = "StarsText";
            this.StarsText.Size = new System.Drawing.Size(86, 37);
            this.StarsText.TabIndex = 15;
            this.StarsText.Text = "Stars: ";
            // 
            // LanguageText
            // 
            this.LanguageText.AutoSize = true;
            this.LanguageText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageText.ForeColor = System.Drawing.Color.Snow;
            this.LanguageText.Location = new System.Drawing.Point(13, 342);
            this.LanguageText.Name = "LanguageText";
            this.LanguageText.Size = new System.Drawing.Size(147, 37);
            this.LanguageText.TabIndex = 16;
            this.LanguageText.Text = "Language: ";
            // 
            // CircleSliderText
            // 
            this.CircleSliderText.AutoSize = true;
            this.CircleSliderText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleSliderText.ForeColor = System.Drawing.Color.Snow;
            this.CircleSliderText.Location = new System.Drawing.Point(13, 379);
            this.CircleSliderText.Name = "CircleSliderText";
            this.CircleSliderText.Size = new System.Drawing.Size(246, 37);
            this.CircleSliderText.TabIndex = 17;
            this.CircleSliderText.Text = "Circle/Slider Count:";
            // 
            // PlaySoundBtn
            // 
            this.PlaySoundBtn.BorderColor = System.Drawing.Color.Snow;
            this.PlaySoundBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PlaySoundBtn.FlatAppearance.BorderSize = 0;
            this.PlaySoundBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PlaySoundBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PlaySoundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaySoundBtn.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaySoundBtn.Location = new System.Drawing.Point(873, 490);
            this.PlaySoundBtn.Name = "PlaySoundBtn";
            this.PlaySoundBtn.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.PlaySoundBtn.OnHoverButtonColor = System.Drawing.Color.Silver;
            this.PlaySoundBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PlaySoundBtn.Size = new System.Drawing.Size(75, 75);
            this.PlaySoundBtn.TabIndex = 18;
            this.PlaySoundBtn.Text = "⏵";
            this.PlaySoundBtn.TextColor = System.Drawing.Color.White;
            this.PlaySoundBtn.UseVisualStyleBackColor = true;
            // 
            // NextLvlBtn
            // 
            this.NextLvlBtn.BorderColor = System.Drawing.Color.Snow;
            this.NextLvlBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NextLvlBtn.FlatAppearance.BorderSize = 0;
            this.NextLvlBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NextLvlBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NextLvlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextLvlBtn.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextLvlBtn.Location = new System.Drawing.Point(954, 490);
            this.NextLvlBtn.Name = "NextLvlBtn";
            this.NextLvlBtn.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.NextLvlBtn.OnHoverButtonColor = System.Drawing.Color.Silver;
            this.NextLvlBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NextLvlBtn.Size = new System.Drawing.Size(132, 75);
            this.NextLvlBtn.TabIndex = 19;
            this.NextLvlBtn.Text = "⏩";
            this.NextLvlBtn.TextColor = System.Drawing.Color.White;
            this.NextLvlBtn.UseVisualStyleBackColor = true;
            // 
            // PreviousLvlBtn
            // 
            this.PreviousLvlBtn.BorderColor = System.Drawing.Color.Snow;
            this.PreviousLvlBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PreviousLvlBtn.FlatAppearance.BorderSize = 0;
            this.PreviousLvlBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PreviousLvlBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PreviousLvlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousLvlBtn.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousLvlBtn.Location = new System.Drawing.Point(735, 490);
            this.PreviousLvlBtn.Name = "PreviousLvlBtn";
            this.PreviousLvlBtn.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.PreviousLvlBtn.OnHoverButtonColor = System.Drawing.Color.Silver;
            this.PreviousLvlBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PreviousLvlBtn.Size = new System.Drawing.Size(132, 75);
            this.PreviousLvlBtn.TabIndex = 20;
            this.PreviousLvlBtn.Text = "⏪";
            this.PreviousLvlBtn.TextColor = System.Drawing.Color.White;
            this.PreviousLvlBtn.UseVisualStyleBackColor = true;
            // 
            // NextBeatmapBtn
            // 
            this.NextBeatmapBtn.BorderColor = System.Drawing.Color.Snow;
            this.NextBeatmapBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NextBeatmapBtn.FlatAppearance.BorderSize = 0;
            this.NextBeatmapBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NextBeatmapBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NextBeatmapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBeatmapBtn.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBeatmapBtn.Location = new System.Drawing.Point(1092, 490);
            this.NextBeatmapBtn.Name = "NextBeatmapBtn";
            this.NextBeatmapBtn.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.NextBeatmapBtn.OnHoverButtonColor = System.Drawing.Color.Silver;
            this.NextBeatmapBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NextBeatmapBtn.Size = new System.Drawing.Size(75, 75);
            this.NextBeatmapBtn.TabIndex = 21;
            this.NextBeatmapBtn.Text = "⟳";
            this.NextBeatmapBtn.TextColor = System.Drawing.Color.White;
            this.NextBeatmapBtn.UseVisualStyleBackColor = true;
            this.NextBeatmapBtn.Click += new System.EventHandler(this.NextBeatmapBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(580, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Top 5 Players and Your Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(999, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Combo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(1087, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "PP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(1146, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mods";
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1240, 580);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextBeatmapBtn);
            this.Controls.Add(this.PreviousLvlBtn);
            this.Controls.Add(this.NextLvlBtn);
            this.Controls.Add(this.PlaySoundBtn);
            this.Controls.Add(this.CircleSliderText);
            this.Controls.Add(this.LanguageText);
            this.Controls.Add(this.StarsText);
            this.Controls.Add(this.SubmitDateText);
            this.Controls.Add(this.BPMText);
            this.Controls.Add(this.DrainLengthText);
            this.Controls.Add(this.PassTriedText);
            this.Controls.Add(this.DifficultyText);
            this.Controls.Add(this.CreatorText);
            this.Controls.Add(this.ArtistText);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.roundRectangle1);
            this.Controls.Add(this.BeatmapID);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.BeatmapImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainWindow";
            this.Text = "FormMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.BeatmapImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BeatmapImage;
        private Scripts.RoundButton DownloadBtn;
        private Scripts.RoundRectangle BeatmapID;
        private Scripts.RoundRectangle roundRectangle1;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Label ArtistText;
        private System.Windows.Forms.Label CreatorText;
        private System.Windows.Forms.Label DifficultyText;
        private System.Windows.Forms.Label PassTriedText;
        private System.Windows.Forms.Label DrainLengthText;
        private System.Windows.Forms.Label BPMText;
        private System.Windows.Forms.Label SubmitDateText;
        private System.Windows.Forms.Label StarsText;
        private System.Windows.Forms.Label LanguageText;
        private System.Windows.Forms.Label CircleSliderText;
        private Scripts.RoundButton PlaySoundBtn;
        private Scripts.RoundButton NextLvlBtn;
        private Scripts.RoundButton PreviousLvlBtn;
        private Scripts.RoundButton NextBeatmapBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}