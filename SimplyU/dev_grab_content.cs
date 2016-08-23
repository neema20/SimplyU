using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyU
{
    public partial class dev_grab_content : Form
    {
        private string cd = Application.StartupPath;

        public dev_grab_content()
        {
            InitializeComponent();
        }

        private void dev_grab_content_Load(object sender, EventArgs e)

        {
            //Create the Following Directories
            Directory.CreateDirectory(cd + "\\On SD Card");
            Directory.CreateDirectory(cd + "\\Common");
            Directory.CreateDirectory(cd + "\\Common\\Downloading");

            //Decide whether to have Self-hosting Enabled, and Install
            //Recommended Homebrew.
            if (Properties.Settings.Default.dev_install_rec == "1")
            {
                lbl_content.Text = "Grabbing Homebrew...";
                using (var get_hb = new WebClient())
                {
                    get_hb.DownloadFile("https://github.com/dimok789/homebrew_launcher/releases/download/v1.2_RC3/homebrew_launcher.v1.2_RC3.zip", cd + "\\Common\\Downloading\\Homebrew Launcher\\001.zip");
                    //get_hb.DownloadFile("https://github.com/dimok789/loadiine_gx2/releases/download/Loadiine-nightly-16c5045/loadiine_gx2_16c5045.zip", cd + "\\Common\\Downloading\\Loadiine_GX2\\001.zip");
                    //get_hb.DownloadFile("https://github.com/vgmoose/hbas/releases/download/v1.0/hbas.zip", cd + "\\Common\\Downloading\\App_Store\\001.zip");
                }
                if (Properties.Settings.Default.dev_self_host == "1")
                {
                }
            }
        }

        private void get_hb_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            lbl_content.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
            prg_1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
    }
}