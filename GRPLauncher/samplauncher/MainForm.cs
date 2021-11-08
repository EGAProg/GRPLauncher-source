using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SampQueryApi;

namespace SAMPLauncher
{
    public partial class MainForm : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;

        public MainForm()
        {
            InitializeComponent();
            ClientInfoSave cis = new ClientInfoSave();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            SampQuery api = new SampQuery("176.31.233.153", 1493, 'i');
            var response = api.read();
            
            var players = response["Players"];
            lbOnline.Text = players;


            try
            {
                using (StreamReader sw = new StreamReader(Directory.GetCurrentDirectory() + "/settings.json"))
                {

                    string json = sw.ReadToEnd();
                    cis = JsonConvert.DeserializeObject<ClientInfoSave>(json);
                    ClientInfo.nickname = cis.nickname;
                    ClientInfo.path = cis.path;
                    ClientInfo.modpackstatus = cis.modpackstatus;
                    ClientInfo.exitonstart = cis.exitonstart;
                    sw.Close();
                }
            }
            catch
            {

            }
            tbNickname.Text = ClientInfo.nickname;

            this.Text = ServerInfo.servername + " launcher";
            bModpack.Enabled = ServerInfo.allowInstallModPack;
            if (!ServerInfo.allowInstallModPack) bModpack.Hide();

        }




        private void bPlay_Click(object sender, EventArgs e)
        {
            if (tbNickname.Text.Length >= 3 && tbNickname.Text.Length <= 32 || tbNickname.Text == "Nickname")
            {
                ClientInfo.nickname = tbNickname.Text;
                try
                {
                    Process.Start(ClientInfo.path + "/samp.exe", ServerInfo.ip + ":" + ServerInfo.port + " -n" + ClientInfo.nickname);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /*try
                {
                    if (ClientInfo.exitonstart)// Вызывает ошибку
                    {
                        Application.Exit();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
            else
            {
                MessageBox.Show("Длинный или не подходяший никнейм", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bModpack_Click(object sender, EventArgs e)
        {
            ModPackInstaller formMPI = new ModPackInstaller();
            formMPI.ShowDialog();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            Settings formSettings = new Settings();
            
            formSettings.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClientInfoSave cis = new ClientInfoSave();
            cis.nickname = ClientInfo.nickname;
            cis.path = ClientInfo.path;
            cis.modpackstatus = ClientInfo.modpackstatus;
            cis.exitonstart = ClientInfo.exitonstart;
            string serialized = JsonConvert.SerializeObject(cis);
            using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "/settings.json"))
            {
                sw.Write(serialized);
                sw.Close();
            }
        }

        private void pbVK_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/"+ServerInfo.group);
        }

        private void pbSite_Click(object sender, EventArgs e)
        {
            Process.Start(ServerInfo.site);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tbNickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }        

        private void lErrorReport_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/" + ServerInfo.group);
        }

        private void pbSupport_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/im?sel=-208029309");
        }

        
           
}

    static class ServerInfo
    {
        public static readonly string servername = "CRMP";
        public static readonly string ip = "176.31.233.153";
        public static readonly string port = "1439";
        public static readonly string group = "grinch_rp_crmp";
        public static readonly string site = "https://vk.com/grinch_rp_crmp"; // Сайт, когда появится, добавить
        public static readonly string ytube = ""; // YouTube канал, когда появится, добавить
        public static readonly bool allowInstallSamp = true;
        public static readonly bool allowInstallModPack = true;
    }

    static public class ClientInfo
    {
        public static string nickname = "Nickname";
        public static string path = " ";
        public static int modpackstatus = 0;
        public static bool exitonstart = false;
    }

    public class ClientInfoSave
    {
        public string nickname = "Nickname";
        public string path = " ";
        public int modpackstatus = 0;
        public bool exitonstart = false;
    }

   
}
