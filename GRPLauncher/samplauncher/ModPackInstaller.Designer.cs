namespace GRPLauncher
{
    partial class ModPackInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModPackInstaller));
            this.lStatus = new System.Windows.Forms.Label();
            this.bInstall = new System.Windows.Forms.Button();
            this.pbFileProgess = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lStatus
            // 
            this.lStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.lStatus.Location = new System.Drawing.Point(12, 54);
            this.lStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(365, 22);
            this.lStatus.TabIndex = 2;
            this.lStatus.Text = "Готово к установке";
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bInstall
            // 
            this.bInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bInstall.FlatAppearance.BorderSize = 0;
            this.bInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInstall.ForeColor = System.Drawing.Color.Black;
            this.bInstall.Location = new System.Drawing.Point(16, 81);
            this.bInstall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bInstall.Name = "bInstall";
            this.bInstall.Size = new System.Drawing.Size(361, 28);
            this.bInstall.TabIndex = 3;
            this.bInstall.Text = "Установить";
            this.bInstall.UseVisualStyleBackColor = false;
            this.bInstall.Click += new System.EventHandler(this.bInstall_Click);
            // 
            // pbFileProgess
            // 
            this.pbFileProgess.Location = new System.Drawing.Point(17, 16);
            this.pbFileProgess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbFileProgess.Name = "pbFileProgess";
            this.pbFileProgess.Size = new System.Drawing.Size(360, 28);
            this.pbFileProgess.TabIndex = 4;
            this.pbFileProgess.Click += new System.EventHandler(this.pbFileProgess_Click);
            // 
            // ModPackInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(395, 124);
            this.Controls.Add(this.pbFileProgess);
            this.Controls.Add(this.bInstall);
            this.Controls.Add(this.lStatus);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModPackInstaller";
            this.Text = "Установка модпака";
            this.Load += new System.EventHandler(this.ModPackInstaller_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button bInstall;
        private System.Windows.Forms.ProgressBar pbFileProgess;
    }
}