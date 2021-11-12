namespace SAMPLauncher
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lPath = new System.Windows.Forms.Label();
            this.bPath = new System.Windows.Forms.Button();
            this.bDone = new System.Windows.Forms.Button();
            this.cbExitOnStart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(16, 41);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(256, 22);
            this.tbPath.TabIndex = 0;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.Location = new System.Drawing.Point(13, 20);
            this.lPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(47, 17);
            this.lPath.TabIndex = 1;
            this.lPath.Text = "Путь: ";
            // 
            // bPath
            // 
            this.bPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bPath.FlatAppearance.BorderSize = 0;
            this.bPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPath.ForeColor = System.Drawing.Color.Black;
            this.bPath.Location = new System.Drawing.Point(289, 40);
            this.bPath.Margin = new System.Windows.Forms.Padding(4);
            this.bPath.Name = "bPath";
            this.bPath.Size = new System.Drawing.Size(53, 25);
            this.bPath.TabIndex = 2;
            this.bPath.Text = "...";
            this.bPath.UseVisualStyleBackColor = false;
            this.bPath.Click += new System.EventHandler(this.bPath_Click);
            // 
            // bDone
            // 
            this.bDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bDone.FlatAppearance.BorderSize = 0;
            this.bDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDone.ForeColor = System.Drawing.Color.Black;
            this.bDone.Location = new System.Drawing.Point(125, 71);
            this.bDone.Margin = new System.Windows.Forms.Padding(4);
            this.bDone.Name = "bDone";
            this.bDone.Size = new System.Drawing.Size(100, 28);
            this.bDone.TabIndex = 3;
            this.bDone.Text = "Готово";
            this.bDone.UseVisualStyleBackColor = false;
            this.bDone.Click += new System.EventHandler(this.bDone_Click);
            // 
            // cbExitOnStart
            // 
            this.cbExitOnStart.AutoSize = true;
            this.cbExitOnStart.Location = new System.Drawing.Point(16, 107);
            this.cbExitOnStart.Margin = new System.Windows.Forms.Padding(4);
            this.cbExitOnStart.Name = "cbExitOnStart";
            this.cbExitOnStart.Size = new System.Drawing.Size(255, 21);
            this.cbExitOnStart.TabIndex = 6;
            this.cbExitOnStart.Text = "Закрыть приложение при запуске";
            this.cbExitOnStart.UseVisualStyleBackColor = true;
            this.cbExitOnStart.CheckedChanged += new System.EventHandler(this.cbExitOnStart_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(355, 143);
            this.Controls.Add(this.cbExitOnStart);
            this.Controls.Add(this.bDone);
            this.Controls.Add(this.bPath);
            this.Controls.Add(this.lPath);
            this.Controls.Add(this.tbPath);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lPath;
        private System.Windows.Forms.Button bPath;
        private System.Windows.Forms.Button bDone;
        private System.Windows.Forms.CheckBox cbExitOnStart;
    }
}