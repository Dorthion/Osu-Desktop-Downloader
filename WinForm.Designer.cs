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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SongImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SongImg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 99);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wylosowana Liczba";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // SongImg
            // 
            this.SongImg.Location = new System.Drawing.Point(12, 26);
            this.SongImg.Name = "SongImg";
            this.SongImg.Size = new System.Drawing.Size(163, 165);
            this.SongImg.TabIndex = 3;
            this.SongImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(649, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 99);
            this.panel1.TabIndex = 4;
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SongImg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "WinForm";
            this.Text = "Osu! Desktop Downloader";
            this.Load += new System.EventHandler(this.WinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SongImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SongImg;
        private System.Windows.Forms.Panel panel1;
    }
}