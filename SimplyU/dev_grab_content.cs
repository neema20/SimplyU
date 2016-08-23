using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
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
            File.Delete(cd + "\\Package.zip");
            lbl_content.Text = "Performing Magic...";
        }

        private void wait_Tick(object sender, EventArgs e)
        {
            //Decide whether to have Self-hosting Enabled, and Install
            //Recommended Homebrew.

            if (Properties.Settings.Default.dev_install_rec == "1")
            {
                using (var get_hb = new WebClient())
                {
                    string sd = Properties.Settings.Default.dev_target;
                    get_hb.DownloadFile("https://raw.githubusercontent.com/zoltx23/SimplyU/master/Common/Homebrew/dev_full_package.zip", cd + "\\Package.zip");
                    prg_1.Value = 50;

                    try
                    {
                        ZipFile zip = new ZipFile();

                        String TargetDirectory = sd;
                        using (ZipFile zp = ZipFile.Read(cd + "\\Package.zip"))
                        {
                            zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                            zp.ExtractAll(TargetDirectory);
                        }
                    }
                    catch
                    {
                    }
                    prg_1.Value = 100;
                }
                if (Properties.Settings.Default.dev_self_host == "1")
                {
                }
                wait.Stop();
            }
        }
    }
}