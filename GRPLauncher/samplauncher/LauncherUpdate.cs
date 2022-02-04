using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;

namespace GRPLauncher
{
    public partial class LauncherUpdate : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;

        public string versionUrl = "https://github.com/EGAProg/test-txt-download/blob/main/version.txt";

        public LauncherUpdate()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            using (WebClient versionClient = new WebClient())
            {
                try
                {
                    Stream stream = versionClient.OpenRead(versionUrl);
                    StreamReader reader = new StreamReader(stream);

                    string content = reader.ReadToEnd();

                    StringBuilder sb = new StringBuilder(content.Length);
                    foreach (char i in content)
                    {
                        if (i == '\n')
                        {
                            sb.Append(Environment.NewLine);
                        }
                        else if (i != '\r' && i != '\t')
                            sb.Append(i);
                    }

                    content = sb.ToString();
                    try
                    {
                        versionClient.DownloadFile(versionUrl, Directory.GetCurrentDirectory() + @"/version.txt");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
                

            }
        }

        private void LauncherUpdate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void LauncherUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void LauncherUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void LauncherUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void bDone(object sender, EventArgs e)
        {
            Close();
        }
    }
}
