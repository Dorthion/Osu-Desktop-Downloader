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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.separator1 = new OsuDesktop.Scripts.Separator();
            this.UnderMainButtonsBtn = new OsuDesktop.Scripts.RoundButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(35, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
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
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
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
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(12, 102);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1240, 580);
            this.MainPanel.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(241, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 21;
            this.button3.Text = "User Stats";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(447, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 22;
            this.button4.Text = "History";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.Snow;
            this.SettingsBtn.Location = new System.Drawing.Point(880, 24);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(200, 50);
            this.SettingsBtn.TabIndex = 23;
            this.SettingsBtn.Text = "Options";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
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
            // UnderMainButtonsBtn
            // 
            this.UnderMainButtonsBtn.BorderColor = System.Drawing.Color.Snow;
            this.UnderMainButtonsBtn.ButtonColor = System.Drawing.Color.Snow;
            this.UnderMainButtonsBtn.FlatAppearance.BorderSize = 0;
            this.UnderMainButtonsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnderMainButtonsBtn.Location = new System.Drawing.Point(35, 80);
            this.UnderMainButtonsBtn.Name = "UnderMainButtonsBtn";
            this.UnderMainButtonsBtn.OnHoverBorderColor = System.Drawing.Color.Snow;
            this.UnderMainButtonsBtn.OnHoverButtonColor = System.Drawing.Color.Snow;
            this.UnderMainButtonsBtn.OnHoverTextColor = System.Drawing.Color.Snow;
            this.UnderMainButtonsBtn.Size = new System.Drawing.Size(200, 10);
            this.UnderMainButtonsBtn.TabIndex = 24;
            this.UnderMainButtonsBtn.TextColor = System.Drawing.Color.Snow;
            this.UnderMainButtonsBtn.UseVisualStyleBackColor = true;
            // 
            // WinFormModern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.UnderMainButtonsBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.MainPanel);
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
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button SettingsBtn;
        private Scripts.RoundButton UnderMainButtonsBtn;
    }
}