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
            //Directory.Delete(cd + "\\Common"); 
            lbl_content.Text = "Performing Magic...";
        }

        private void wait_Tick(object sender, EventArgs e)
        {
            Directory.CreateDirectory(cd + "\\Common");
            Directory.CreateDirectory(cd + "\\Common\\Downloading");
            //Decide whether to have Self-hosting Enabled, and Install
            //Recommended Homebrew.

            if (Properties.Settings.Default.dev_install_rec == "1")
            {
                using (var get_hb = new WebClient())
                {
                    string sd = Properties.Settings.Default.dev_target;
                    get_hb.DownloadFile("https://raw.githubusercontent.com/zoltx23/SimplyU/master/Common/Homebrew/wiiu.zip", cd + "\\wiiu.zip");
                    get_hb.DownloadFile("https://raw.githubusercontent.com/zoltx23/SimplyU/master/Common/Homebrew/hosting.zip", cd + "\\hosting.zip");
                    if (Properties.Settings.Default.inst_ddd == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/ddd.zip", cd + "\\Common\\Downloading\\ddd.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\ddd.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_sd_caffiine == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/SDcafiine.zip", cd + "\\Common\\Downloading\\sd_caf.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\sd_caf.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_sav == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/saviine.zip", cd + "\\Common\\Downloading\\saviine.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\saviine.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_pong == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/pong.zip", cd + "\\Common\\Downloading\\pong.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\pong.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_gac == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/gacubeboy.zip", cd + "\\Common\\Downloading\\gac.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\gac.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_tic == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/tictactoe.zip", cd + "\\Common\\Downloading\\tic.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\tic.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_pac == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/pacman.zip", cd + "\\Common\\Downloading\\pac.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\pac.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_u_paint == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/u-paint.zip", cd + "\\Common\\Downloading\\paint.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\paint.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_ftp == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/ftpiiu.zip", cd + "\\Common\\Downloading\\ftp.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\ftp.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_ast == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/asturoids.zip", cd + "\\Common\\Downloading\\ast.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\ast.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_nnu == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/nnupatcher.zip", cd + "\\Common\\Downloading\\nnu.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\nnu.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_geck == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/geckiine.zip", cd + "\\Common\\Downloading\\geck.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\geck.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_gbiine == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/gbiine.zip", cd + "\\Common\\Downloading\\gbiine.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\gbiine.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_tcp == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/geckiine.zip", cd + "\\Common\\Downloading\\tcp.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\tcp.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_hid == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/hidtovpad.zip", cd + "\\Common\\Downloading\\hid.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\hid.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_snake == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/snake.zip", cd + "\\Common\\Downloading\\snake.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\snake.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_cave == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/cave.zip", cd + "\\Common\\Downloading\\cave.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\cave.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_chip == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/CHIP8.zip", cd + "\\Common\\Downloading\\chip.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\chip.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_wiiu_key == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/keyboard_example.zip", cd + "\\Common\\Downloading\\key.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\key.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_wup == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/wupinstaller.zip", cd + "\\Common\\Downloading\\wup.zip");
                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd + "\\wiiu";
                            using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\wup.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                        }
                        catch
                        {
                        }
                    }
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

                        String TargetDirectory = cd + "\\Common";
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
            dev_presto.Stop();
            MessageBox.Show("Thanks for using this Program! \r\nThe version you're using is " + Application.ProductVersion + " x86 Pre-Alpha. \r\n \r\nCreated by Dr.Hacknik 2016 \r\n \r\nThanks to all the Creators for making their Homebrew for the Wii U & to you, my Fellow user, for your Support!", "About:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Properties.Settings.Default.dev_self_host == "1")
            {
                Hide();
                dev_hosting dh = new dev_hosting();
                dh.ShowDialog();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
