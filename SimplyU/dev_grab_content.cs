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
            File.Delete(cd + "\\wiiu.zip");
            File.Delete(cd + "\\hosting.zip");
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
                    get_hb.DownloadFile("https://raw.githubusercontent.com/zoltx23/SimplyU/master/Common/Homebrew/wiiu.zip", cd + "\\wiiu.zip");
                    get_hb.DownloadFile("https://raw.githubusercontent.com/zoltx23/SimplyU/master/Common/Homebrew/hosting.zip", cd + "\\hosting.zip");
                    prg_1.Value = 50;

                    try
                    {
                        ZipFile zip = new ZipFile();

                        String TargetDirectory = sd;
                        using (ZipFile zp = ZipFile.Read(cd + "\\wiiu.zip"))
                        {
                            zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                            zp.ExtractAll(TargetDirectory);
                        }
                    }
                    catch
                    {
                    }
                    prg_1.Value = 60;
                    try
                    {
                        ZipFile zip = new ZipFile();

                        String TargetDirectory = cd + "\\Common\\Hosting";
                        using (ZipFile zp = ZipFile.Read(cd + "\\hosting.zip"))
                        {
                            zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                            zp.ExtractAll(TargetDirectory);
                        }
                    }
                    catch
                    {
                    }
                    prg_1.Value = 100;
                    lbl_content.Text = "";
                    lbl_ext_desc.Text = "";
                    lbl_pls_wait.Text = "And Presto!";
                    dev_presto.Start();
                }
                if (Properties.Settings.Default.dev_self_host == "1")
                {
                }
                wait.Stop();
            }
        }

        private void dev_presto_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using this Program! \r\nThe version you're using is 0.2 x86 Pre-Alpha. \r\n \r\nCreated by Dr.Hacknik 2016", "About:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}