using Ionic.Zip;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace SimplyU
{
    public partial class dev_grab_content : MaterialForm
    {
        private string dr = Properties.Settings.Default.sd_form_drive;
        private string al = Properties.Settings.Default.sd_form_cluster;
        private string sd = Properties.Settings.Default.dev_target;
        private string cd = Application.StartupPath;
        private string lg = Properties.Settings.Default.dev_log_state;
        private string lgs = Properties.Settings.Default.dev_log_dump;

        public dev_grab_content()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_grab_content_Load(object sender, EventArgs e)

        {
            File.Delete(cd + "\\wiiu.zip");
            lg += "\r\ndev_grab: file_del--wiiu.zip";
            File.Delete(cd + "\\hosting.zip");
            lg += "\r\ndev_grab: file_del--wiiu.zip";
            //Directory.Delete(cd + "\\Common");
            lbl_content.Text = "Performing Magic...";
            Properties.Settings.Default.Save();
            fin.Start();
        }

        private void wait_Tick(object sender, EventArgs e)
        {
            Directory.CreateDirectory(cd + "\\Common");
            lg += "\r\ndev_grab: dir_cr--Common";
            Directory.CreateDirectory(cd + "\\Common\\Downloading");
            lg += "\r\ndev_grab: dir_cr--Common\\Downloading";
            Properties.Settings.Default.Save();
            //Decide whether to have Self-hosting Enabled, and Install
            //Recommended Homebrew.
            if (Properties.Settings.Default.sd_form == "1")
            {
                try
                {
                    wait.Stop();
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C" + "FORMAT " + dr + "/Y /FS:FAT32 /A:" + al + " /V:Wii /Q";
                    process.StartInfo = startInfo;
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                    prg_1.Value = 20;
                    fin.Start();
                    lg += "\r\ndev_grab: format_complete";
                    lgs = "1";
                    Properties.Settings.Default.Save();
                }
                catch
                {
                    wait.Stop();
                    lg += "\r\ndev_grab: format_failed";
                    lgs = "1";
                    Properties.Settings.Default.Save();
                    MessageBox.Show("An Error has ocurred during Format; Please try again! --FORMAT_FAT_ERROR ", "Format Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    dev_prepare dp = new dev_prepare();
                    dp.ShowDialog();
                }
            }
            else
            {
            }
        }

        private void dev_presto_Tick(object sender, EventArgs e)
        {
            dev_presto.Stop();
            if (Properties.Settings.Default.dev_cleanup == "1")
            {
                cleanup.Start();
            }
            else
            {
            }
            lg += "\r\ndev_grab: proc_complete";
            lgs = "1";
            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.dev_self_host == "1")
            {
                Hide();
                dev_hosting dh = new dev_hosting();
                dh.ShowDialog();
            }

            if (Properties.Settings.Default.dev_dev_mode == "1")
            {
                Hide();
                dev_error de = new dev_error();
                de.ShowDialog();
            }
            else
            {
                audio_tmr.Start();
                Properties.Settings.Default.dev_bck_music = "1";
                Properties.Settings.Default.Save();
                bck_music.URL = Application.StartupPath + "\\Common\\Music\\audio_complete.mp3";
                MessageBox.Show("Thanks for using this Program! \r\nThe version you're using is " + Application.ProductVersion + " x86 Nightly. \r\n \r\nCreated by Dr.Hacknik 2016 \r\n \r\nThanks to all the Creators for making their Homebrew for the Wii U & to you, my Fellow user, for your Support! \r\n \r\nMusic from From Sonic the Hedgehog (2006), Sonic Rush, and Rush Adventure - Remixed, and Tobu Higher (Electronica Genre).", "About:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void lbl_pls_wait_Click(object sender, EventArgs e)
        {
        }

        private void fin_Tick(object sender, EventArgs e)

        {
            try
            {
                if (Properties.Settings.Default.dev_install_rec == "1")
                {
                    using (var get_hb = new WebClient())
                    {
                        get_hb.DownloadFile("https://github.com/zoltx23/SimplyU/raw/master/Common/Homebrew/wiiu.zip", cd + "\\wiiu.zip");
                        get_hb.DownloadFile("https://github.com/zoltx23/SimplyU/raw/master/Common/Homebrew/hosting.zip", cd + "\\hosting.zip");

                        try
                        {
                            ZipFile zip = new ZipFile();

                            String TargetDirectory = sd;
                            using (ZipFile zp = ZipFile.Read(cd + "\\wiiu.zip"))
                            {
                                zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zp.ExtractAll(TargetDirectory);
                            }
                            lg += "\r\ndev_grab: hb_suc--wiiu";
                            lgs = "1";
                            Properties.Settings.Default.Save();
                        }
                        catch
                        {
                            lg += "\r\ndev_grab: hb_fail--wiiu";
                            lgs = "1";
                            Properties.Settings.Default.Save();
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
                            lg += "\r\ndev_grab: hb_suc--host";
                            lgs = "1";
                            Properties.Settings.Default.Save();
                        }
                        catch
                        {
                            lg += "\r\ndev_grab: hb_fail--hosting";
                            lgs = "1";
                            Properties.Settings.Default.Save();
                        }
                        if (Properties.Settings.Default.inst_ddd == "1")
                        {
                            prg_2.Value = 0;
                            get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/ddd.zip", cd + "\\Common\\Downloading\\ddd.zip");
                            prg_2.Value = 100;
                            try
                            {
                                ZipFile zip = new ZipFile();

                                String TargetDirectory = sd + "\\wiiu";
                                using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\ddd.zip"))
                                {
                                    zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                    zp.ExtractAll(TargetDirectory);
                                }
                                lg += "\r\ndev_grab: hb_suc--ddd";
                                lgs = "1";
                                Properties.Settings.Default.Save();
                            }
                            catch
                            {
                                lg += "\r\ndev_grab: hb_fail--ddd";
                                lgs = "1";
                                Properties.Settings.Default.Save();
                            }

                            if (Properties.Settings.Default.inst_sd_caffiine == "1")
                            {
                                get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/SDcafiine.zip", cd + "\\Common\\Downloading\\sd_caf.zip");
                                prg_2.Value = 0;

                                prg_2.Value = 100;
                                try
                                {
                                    ZipFile zip = new ZipFile();

                                    String TargetDirectory = sd + "\\wiiu";
                                    using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\sd_caf.zip"))
                                    {
                                        zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                        zp.ExtractAll(TargetDirectory);
                                    }
                                    lg += "\r\ndev_grab: hb_suc--sd_caf";
                                    lgs = "1";
                                    Properties.Settings.Default.Save();
                                }
                                catch
                                {
                                    lg += "\r\ndev_grab: hb_fail--sd_caf";
                                    lgs = "1";
                                    Properties.Settings.Default.Save();
                                }
                                if (Properties.Settings.Default.inst_sav == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/saviine.zip", cd + "\\Common\\Downloading\\saviine.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--saviine";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_pong == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/pong.zip", cd + "\\Common\\Downloading\\pong.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--pong";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_gac == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/gacubeboy.zip", cd + "\\Common\\Downloading\\gac.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--gac";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_tic == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/tictactoe.zip", cd + "\\Common\\Downloading\\tic.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--tic";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_pac == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/pacman.zip", cd + "\\Common\\Downloading\\pac.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--pac";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_u_paint == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/u-paint.zip", cd + "\\Common\\Downloading\\paint.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--paint";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_ftp == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/ftpiiu.zip", cd + "\\Common\\Downloading\\ftp.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--ftp";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_ast == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/asturoids.zip", cd + "\\Common\\Downloading\\ast.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--ast";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_nnu == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/nnupatcher.zip", cd + "\\Common\\Downloading\\nnu.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--nnu";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_geck == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/geckiine.zip", cd + "\\Common\\Downloading\\geck.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--geck";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_gbiine == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/gbiine.zip", cd + "\\Common\\Downloading\\gbiine.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--gbiine";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_tcp == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/geckiine.zip", cd + "\\Common\\Downloading\\tcp.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--tcp";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_hid == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/hidtovpad.zip", cd + "\\Common\\Downloading\\hid.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--hid";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_snake == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/snake.zip", cd + "\\Common\\Downloading\\snake.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--snake";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_cave == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/cave.zip", cd + "\\Common\\Downloading\\cave.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--cave";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_chip == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/CHIP8.zip", cd + "\\Common\\Downloading\\chip.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--chip";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_wiiu_key == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/keyboard_example.zip", cd + "\\Common\\Downloading\\key.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--key";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_wup == "1")
                                {
                                    prg_2.Value = 0;

                                    get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/wupinstaller.zip", cd + "\\Common\\Downloading\\wup.zip");
                                    prg_2.Value = 100;
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
                                        lg += "\r\ndev_grab: hb_fail--wup";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_live == "1")
                                {
                                    prg_2.Value = 0;
                                    get_hb.DownloadFile("http://wiiubru.com/appstore/zips/LiveSynthesisU.zip", cd + "\\Common\\Downloading\\live.zip");
                                    prg_2.Value = 100;
                                    try
                                    {
                                        ZipFile zip = new ZipFile();

                                        String TargetDirectory = sd + "\\wiiu";
                                        using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\live.zip"))
                                        {
                                            zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                            zp.ExtractAll(TargetDirectory);
                                        }
                                    }
                                    catch
                                    {
                                        lg += "\r\ndev_grab: hb_fail--live";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_hid_key == "1")
                                {
                                    prg_2.Value = 0;
                                    get_hb.DownloadFile("http://wiiubru.com/appstore/zips/hid_keyboard_monitor.zip", cd + "\\Common\\Downloading\\hid_key.zip");
                                    prg_2.Value = 100;
                                    try
                                    {
                                        ZipFile zip = new ZipFile();

                                        String TargetDirectory = sd + "\\wiiu";
                                        using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\hid_key.zip"))
                                        {
                                            zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                            zp.ExtractAll(TargetDirectory);
                                        }
                                    }
                                    catch
                                    {
                                        lg += "\r\ndev_grab: hb_fail--hid_key";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_poke == "1")
                                {
                                    prg_2.Value = 0;
                                    get_hb.DownloadFile("http://wiiubru.com/appstore/zips/PokeMiniU.zip", cd + "\\Common\\Downloading\\poke.zip");
                                    prg_2.Value = 100;
                                    try
                                    {
                                        ZipFile zip = new ZipFile();

                                        String TargetDirectory = sd + "\\wiiu";
                                        using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\poke.zip"))
                                        {
                                            zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                            zp.ExtractAll(TargetDirectory);
                                        }
                                    }
                                    catch
                                    {
                                        lg += "\r\ndev_grab: hb_fail--poke";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_app_dark == "1")
                                {
                                    prg_2.Value = 0;
                                    get_hb.DownloadFile("http://wiiubru.com/appstore/zips/Appstore-dark.zip", cd + "\\Common\\Downloading\\store_d.zip");
                                    prg_2.Value = 100;
                                    try
                                    {
                                        ZipFile zip = new ZipFile();

                                        String TargetDirectory = sd + "\\wiiu";
                                        using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\store_d.zip"))
                                        {
                                            zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                            zp.ExtractAll(TargetDirectory);
                                        }
                                    }
                                    catch
                                    {
                                        lg += "\r\ndev_grab: hb_fail--store_d";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_our == "1")
                                {
                                    prg_2.Value = 0;
                                    get_hb.DownloadFile("http://wiiubru.com/appstore/zips/ourloader.zip", cd + "\\Common\\Downloading\\our.zip");
                                    prg_2.Value = 100;
                                    try
                                    {
                                        ZipFile zip = new ZipFile();

                                        String TargetDirectory = sd + "\\wiiu";
                                        using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\our.zip"))
                                        {
                                            zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                            zp.ExtractAll(TargetDirectory);
                                        }
                                    }
                                    catch
                                    {
                                        lg += "\r\ndev_grab: hb_fail--our";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_space == "1")
                                {
                                    prg_2.Value = 0;
                                    get_hb.DownloadFile("http://wiiubru.com/appstore/zips/spacegame.zip", cd + "\\Common\\Downloading\\space.zip");
                                    prg_2.Value = 100;
                                    try
                                    {
                                        ZipFile zip = new ZipFile();

                                        String TargetDirectory = sd + "\\wiiu";
                                        using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\space.zip"))
                                        {
                                            zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                            zp.ExtractAll(TargetDirectory);
                                        }
                                    }
                                    catch
                                    {
                                        lg += "\r\ndev_grab: hb_fail--space";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_flappy == "1")
                                {
                                    prg_2.Value = 0;
                                    get_hb.DownloadFile("http://wiiubru.com/appstore/zips/flappy_bird.zip", cd + "\\Common\\Downloading\\flappy.zip");
                                    prg_2.Value = 100;
                                    try
                                    {
                                        ZipFile zip = new ZipFile();

                                        String TargetDirectory = sd + "\\wiiu";
                                        using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\flappy.zip"))
                                        {
                                            zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                            zp.ExtractAll(TargetDirectory);
                                        }
                                    }
                                    catch
                                    {
                                        lg += "\r\ndev_grab: hb_fail--flappy";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                                if (Properties.Settings.Default.inst_ios == "1")
                                {
                                    prg_2.Value = 0;
                                    get_hb.DownloadFile("http://wiiubru.com/appstore/zips/IOSreboot.zip", cd + "\\Common\\Downloading\\ios.zip");
                                    prg_2.Value = 100;
                                    try
                                    {
                                        ZipFile zip = new ZipFile();

                                        String TargetDirectory = sd + "\\wiiu";
                                        using (ZipFile zp = ZipFile.Read(cd + "\\Common\\Downloading\\ios.zip"))
                                        {
                                            zp.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                            zp.ExtractAll(TargetDirectory);
                                        }
                                    }
                                    catch
                                    {
                                        lg += "\r\ndev_grab: hb_fail--ios";
                                        lgs = "1";
                                        Properties.Settings.Default.Save();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                lg += "\r\ndev_grab: get_hb--fail_all";
                lgs = "1";
                prg_1.Value = 100;
                lbl_content.Text = "";
                lbl_ext_desc.Text = "";
                lbl_ext_desc.Text = "And Presto!";
                Properties.Settings.Default.Save();
                dev_presto.Start();
                wait.Stop();
                fin.Stop();
            }

            prg_1.Value = 100;
            lbl_content.Text = "";
            lbl_ext_desc.Text = "";
            lbl_ext_desc.Text = "And Presto!";
            Properties.Settings.Default.Save();
            dev_presto.Start();
            wait.Stop();
            fin.Stop();
        }

        private void lbl_ext_desc_Click(object sender, EventArgs e)
        {
        }

        private void audio_tmr_Tick(object sender, EventArgs e)
        {
            bck_music.URL = Application.StartupPath + "\\Common\\Music\\audio_credits.mp3";
            audio_tmr.Stop();
        }

        private void lbl_ext_desc_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_dev_mode == "1")
            {
                fin.Stop();
                dev_presto.Stop();
                cleanup.Start();
            }
            else
            {
            }
        }

        private void cleanup_Tick(object sender, EventArgs e)
        {
            cleanup.Stop();
            try
            {
                lbl_content.Text = "Cleaning Junk...";
                Directory.Delete(cd + "\\Common\\downloading", true);
                Directory.Delete(cd + "\\wiiu", true);
                File.Delete(cd + "\\wiiu.zip");
                File.Delete(cd + "\\hosting.zip");
                Properties.Settings.Default.dev_bck_music = "1";
                Properties.Settings.Default.Save();
                audio_tmr.Start();
                bck_music.URL = Application.StartupPath + "\\Common\\Music\\audio_complete.mp3";
                MessageBox.Show("Thanks for using this Program! \r\nThe version you're using is " + Application.ProductVersion + " x86 Nightly. \r\n \r\nCreated by Dr.Hacknik 2016 \r\n \r\nThanks to all the Creators for making their Homebrew for the Wii U & to you, my Fellow user, for your Support! \r\n \r\nMusic from From Sonic the Hedgehog (2006), Sonic Rush, and Rush Adventure - Remixed, and Tobu Higher (Electronica Genre).", "About:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Properties.Settings.Default.dev_self_host == "1")
                {
                    Hide();
                    dev_hosting dh = new dev_hosting();
                    dh.ShowDialog();
                }

                if (Properties.Settings.Default.dev_dev_mode == "1")
                {
                    Hide();
                    dev_error de = new dev_error();
                    de.ShowDialog();
                }
                else
                {
                    audio_tmr.Start();
                    Properties.Settings.Default.dev_bck_music = "1";
                    Properties.Settings.Default.Save();
                    bck_music.URL = Application.StartupPath + "\\Common\\Music\\audio_complete.mp3";
                    MessageBox.Show("Thanks for using this Program! \r\nThe version you're using is " + Application.ProductVersion + " x86 Nightly. \r\n \r\nCreated by Dr.Hacknik 2016 \r\n \r\nThanks to all the Creators for making their Homebrew for the Wii U & to you, my Fellow user, for your Support! \r\n \r\nMusic from From Sonic the Hedgehog (2006), Sonic Rush, and Rush Adventure - Remixed, and Tobu Higher (Electronica Genre).", "About:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
            catch
            {
                lg += "\r\ndev_grab: clean_fail";
                lgs = "1";
                lbl_content.Text = "Something went Wrong!";
                MessageBox.Show("Somthing Happened while removing Directories and Such, so you may need to remove them manually!", "Grabbing Content: --Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Properties.Settings.Default.dev_bck_music = "1";
                Properties.Settings.Default.Save();
                audio_tmr.Start();
                bck_music.URL = Application.StartupPath + "\\Common\\Music\\audio_complete.mp3";
                MessageBox.Show("Thanks for using this Program! \r\nThe version you're using is " + Application.ProductVersion + " x86 Nightly. \r\n \r\nCreated by Dr.Hacknik 2016 \r\n \r\nThanks to all the Creators for making their Homebrew for the Wii U & to you, my Fellow user, for your Support! \r\n \r\nMusic from From Sonic the Hedgehog (2006), Sonic Rush, and Rush Adventure - Remixed, and Tobu Higher (Electronica Genre).", "About:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Properties.Settings.Default.dev_self_host == "1")
                {
                    Hide();
                    dev_hosting dh = new dev_hosting();
                    dh.ShowDialog();
                }

                if (Properties.Settings.Default.dev_dev_mode == "1")
                {
                    Hide();
                    dev_error de = new dev_error();
                    de.ShowDialog();
                }
                else
                {
                    audio_tmr.Start();
                    Properties.Settings.Default.dev_bck_music = "1";
                    Properties.Settings.Default.Save();
                    bck_music.URL = Application.StartupPath + "\\Common\\Music\\audio_complete.mp3";
                    MessageBox.Show("Thanks for using this Program! \r\nThe version you're using is " + Application.ProductVersion + " x86 Nightly. \r\n \r\nCreated by Dr.Hacknik 2016 \r\n \r\nThanks to all the Creators for making their Homebrew for the Wii U & to you, my Fellow user, for your Support! \r\n \r\nMusic from From Sonic the Hedgehog (2006), Sonic Rush, and Rush Adventure - Remixed, and Tobu Higher (Electronica Genre).", "About:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }
    }
}