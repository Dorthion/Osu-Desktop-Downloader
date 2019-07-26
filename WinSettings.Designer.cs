namespace OsuDesktop
{
    partial class WinSettings
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
            this.CheckGrave = new System.Windows.Forms.CheckBox();
            this.CheckPen = new System.Windows.Forms.CheckBox();
            this.CheckQual = new System.Windows.Forms.CheckBox();
            this.CheckLove = new System.Windows.Forms.CheckBox();
            this.CheckRanked = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.RadioBtnModern = new System.Windows.Forms.RadioButton();
            this.RadioBtnClassic = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LanguageList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckGrave
            // 
            this.CheckGrave.AutoSize = true;
            this.CheckGrave.Location = new System.Drawing.Point(163, 144);
            this.CheckGrave.Name = "CheckGrave";
            this.CheckGrave.Size = new System.Drawing.Size(97, 21);
            this.CheckGrave.TabIndex = 23;
            this.CheckGrave.Text = "Graveyard";
            this.CheckGrave.UseVisualStyleBackColor = true;
            // 
            // CheckPen
            // 
            this.CheckPen.AutoSize = true;
            this.CheckPen.Location = new System.Drawing.Point(163, 171);
            this.CheckPen.Name = "CheckPen";
            this.CheckPen.Size = new System.Drawing.Size(82, 21);
            this.CheckPen.TabIndex = 22;
            this.CheckPen.Text = "Pending";
            this.CheckPen.UseVisualStyleBackColor = true;
            // 
            // CheckQual
            // 
            this.CheckQual.AutoSize = true;
            this.CheckQual.Location = new System.Drawing.Point(12, 198);
            this.CheckQual.Name = "CheckQual";
            this.CheckQual.Size = new System.Drawing.Size(86, 21);
            this.CheckQual.TabIndex = 21;
            this.CheckQual.Text = "Qualified";
            this.CheckQual.UseVisualStyleBackColor = true;
            // 
            // CheckLove
            // 
            this.CheckLove.AutoSize = true;
            this.CheckLove.Location = new System.Drawing.Point(13, 171);
            this.CheckLove.Name = "CheckLove";
            this.CheckLove.Size = new System.Drawing.Size(98, 21);
            this.CheckLove.TabIndex = 20;
            this.CheckLove.Text = "Love State";
            this.CheckLove.UseVisualStyleBackColor = true;
            // 
            // CheckRanked
            // 
            this.CheckRanked.AutoSize = true;
            this.CheckRanked.Location = new System.Drawing.Point(13, 144);
            this.CheckRanked.Name = "CheckRanked";
            this.CheckRanked.Size = new System.Drawing.Size(79, 21);
            this.CheckRanked.TabIndex = 19;
            this.CheckRanked.Text = "Ranked";
            this.CheckRanked.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Beatmap Types";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(108, 230);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(105, 44);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // RadioBtnModern
            // 
            this.RadioBtnModern.AutoSize = true;
            this.RadioBtnModern.Location = new System.Drawing.Point(200, 31);
            this.RadioBtnModern.Name = "RadioBtnModern";
            this.RadioBtnModern.Size = new System.Drawing.Size(112, 21);
            this.RadioBtnModern.TabIndex = 16;
            this.RadioBtnModern.Text = "Modern Style";
            this.RadioBtnModern.UseVisualStyleBackColor = true;
            // 
            // RadioBtnClassic
            // 
            this.RadioBtnClassic.AutoSize = true;
            this.RadioBtnClassic.Location = new System.Drawing.Point(12, 31);
            this.RadioBtnClassic.Name = "RadioBtnClassic";
            this.RadioBtnClassic.Size = new System.Drawing.Size(108, 21);
            this.RadioBtnClassic.TabIndex = 15;
            this.RadioBtnClassic.Text = "Classic Style";
            this.RadioBtnClassic.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Style";
            // 
            // LanguageList
            // 
            this.LanguageList.FormattingEnabled = true;
            this.LanguageList.Items.AddRange(new object[] {
            "English",
            "Polski"});
            this.LanguageList.Location = new System.Drawing.Point(12, 84);
            this.LanguageList.Name = "LanguageList";
            this.LanguageList.Size = new System.Drawing.Size(300, 24);
            this.LanguageList.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Language";
            // 
            // WinSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 284);
            this.Controls.Add(this.CheckGrave);
            this.Controls.Add(this.CheckPen);
            this.Controls.Add(this.CheckQual);
            this.Controls.Add(this.CheckLove);
            this.Controls.Add(this.CheckRanked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.RadioBtnModern);
            this.Controls.Add(this.RadioBtnClassic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LanguageList);
            this.Controls.Add(this.label1);
            this.Name = "WinSettings";
            this.Text = "BR Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinSettings_FormClosed);
            this.Load += new System.EventHandler(this.WinSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckGrave;
        private System.Windows.Forms.CheckBox CheckPen;
        private System.Windows.Forms.CheckBox CheckQual;
        private System.Windows.Forms.CheckBox CheckLove;
        private System.Windows.Forms.CheckBox CheckRanked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.RadioButton RadioBtnModern;
        private System.Windows.Forms.RadioButton RadioBtnClassic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LanguageList;
        private System.Windows.Forms.Label label1;
    }
}