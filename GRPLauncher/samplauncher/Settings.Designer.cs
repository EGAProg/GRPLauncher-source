namespace GRPLauncher
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
            resources.ApplyResources(this.tbPath, "tbPath");
            this.tbPath.Name = "tbPath";
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // lPath
            // 
            resources.ApplyResources(this.lPath, "lPath");
            this.lPath.Name = "lPath";
            // 
            // bPath
            // 
            this.bPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bPath.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.bPath, "bPath");
            this.bPath.ForeColor = System.Drawing.Color.Black;
            this.bPath.Name = "bPath";
            this.bPath.UseVisualStyleBackColor = false;
            this.bPath.Click += new System.EventHandler(this.bPath_Click);
            // 
            // bDone
            // 
            this.bDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bDone.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.bDone, "bDone");
            this.bDone.ForeColor = System.Drawing.Color.Black;
            this.bDone.Name = "bDone";
            this.bDone.UseVisualStyleBackColor = false;
            this.bDone.Click += new System.EventHandler(this.bDone_Click);
            // 
            // cbExitOnStart
            // 
            resources.ApplyResources(this.cbExitOnStart, "cbExitOnStart");
            this.cbExitOnStart.Name = "cbExitOnStart";
            this.cbExitOnStart.UseVisualStyleBackColor = true;
            this.cbExitOnStart.CheckedChanged += new System.EventHandler(this.cbExitOnStart_CheckedChanged);
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ControlBox = false;
            this.Controls.Add(this.cbExitOnStart);
            this.Controls.Add(this.bDone);
            this.Controls.Add(this.bPath);
            this.Controls.Add(this.lPath);
            this.Controls.Add(this.tbPath);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
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