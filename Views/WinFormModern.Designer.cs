namespace OsuDesktop.Views
{
    partial class WinFormModern
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MinimalBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.separator1 = new OsuDesktop.Scripts.Separator();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 69);
            this.button1.TabIndex = 15;
            this.button1.Text = "Main Window";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Snow;
            this.ExitBtn.Location = new System.Drawing.Point(1212, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(40, 40);
            this.ExitBtn.TabIndex = 16;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // MinimalBtn
            // 
            this.MinimalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimalBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimalBtn.ForeColor = System.Drawing.Color.Snow;
            this.MinimalBtn.Location = new System.Drawing.Point(1120, 12);
            this.MinimalBtn.Name = "MinimalBtn";
            this.MinimalBtn.Size = new System.Drawing.Size(40, 40);
            this.MinimalBtn.TabIndex = 17;
            this.MinimalBtn.Text = "__";
            this.MinimalBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(1166, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "▢";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // separator1
            // 
            this.separator1.ForeColor = System.Drawing.SystemColors.Window;
            this.separator1.isVertical = false;
            this.separator1.Location = new System.Drawing.Point(12, 73);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(1089, 23);
            this.separator1.TabIndex = 19;
            this.separator1.Text = "separator1";
            this.separator1.Thickness = 1;
            // 
            // WinFormModern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MinimalBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinFormModern";
            this.ShowIcon = false;
            this.Text = "WinFormModern";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinimalBtn;
        private System.Windows.Forms.Button button2;
        private Scripts.Separator separator1;
    }
}