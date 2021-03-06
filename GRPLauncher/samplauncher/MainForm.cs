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
using System.Threading;
using System.Windows.Forms;


// Other libs
using System.Net;


// Non System libs
using Newtonsoft.Json;
using SampQueryApi;

namespace GRPLauncher
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

            Thread onlineCheckThread = new Thread(new ThreadStart(onlineCheck));
            onlineCheckThread.Start();
            
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
        void onlineCheck()
        {
            try
            {
                SampQuery sq = new SampQuery("176.9.247.229", 7171);
                SampServerInfoData data = sq.GetServerInfo();

                while (true)
                {
                    lbOnline.Text = $"Текущий онлайн: {data.Players}/{data.MaxPlayers}";
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void bPlay_Click(object sender, EventArgs e)
        {
            if (tbNickname.Text.Contains("_") && tbNickname.Text.Length <= 32 && tbNickname.Text.Length >= 3)
            {
                ClientInfo.nickname = tbNickname.Text;
            
                try
                {
                    Process.Start(ClientInfo.path + "/samp.exe", ServerInfo.ip + ":" + ServerInfo.port + " -n" + ClientInfo.nickname);

                    if (ClientInfo.exitonstart == true)// Вызывает ошибку
                    {
                        Application.Exit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Введен не действительный никнейм", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
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
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
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
            Close();

        }        

        private void lErrorReport_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/im?sel=-208029309");
        }

        private void pbSupport_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/im?sel=-208029309");
        }

        private void bLauncher(object sender, EventArgs e)
        {
            LauncherUpdate lUpdate = new LauncherUpdate();

            lUpdate.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

    static class ServerInfo
    {
        public static readonly string servername = "CRMP";
        public static readonly string ip = "176.9.247.229";
        public static readonly string port = "7171";
        public static readonly string group = "grinch_rp_crmp";
        public static readonly string site = "http://grinch-rp.ml/?i=1";
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
