using Ionic.Zip;
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
                }
                catch
                {
                    wait.Stop();
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
            MessageBox.Show("Thanks for using this Program! \r\nThe version you're using is " + Application.ProductVersion + " x86 BETA. \r\n \r\nCreated by Dr.Hacknik 2016 \r\n \r\nThanks to all the Creators for making their Homebrew for the Wii U & to you, my Fellow user, for your Support!", "About:", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lbl_pls_wait_Click(object sender, EventArgs e)
        {
        }

        private void fin_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_install_rec == "1")
            {
                using (var get_hb = new WebClient())
                {
                    get_hb.DownloadFile("https://raw.githubusercontent.com/zoltx23/SimplyU/master/Common/Homebrew/wiiu.zip", cd + "\\wiiu.zip");
                    get_hb.DownloadFile("https://raw.githubusercontent.com/zoltx23/SimplyU/master/Common/Homebrew/hosting.zip", cd + "\\hosting.zip");

                    if (Properties.Settings.Default.inst_ddd == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/ddd.zip", cd + "\\Common\\Downloading\\ddd.zip");
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_sd_caffiine == "1")
                    {
                        get_hb.DownloadFile("http://www.wiiubru.com/appstore/zips/SDcafiine.zip", cd + "\\Common\\Downloading\\sd_caf.zip");
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                        catch
                        {
                        }
                    }
                    if (Properties.Settings.Default.inst_sav == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_pong == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_gac == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_tic == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_pac == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_u_paint == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_ftp == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_ast == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_nnu == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_geck == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_gbiine == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_tcp == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_hid == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_snake == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_cave == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                        }
                    }
                    if (Properties.Settings.Default.inst_chip == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

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
                        }
                    }
                    if (Properties.Settings.Default.inst_wup == "1")
                    {
                        prg_2.Value = 0;
                        get_hb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        get_hb.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
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
                    lbl_ext_desc.Text = "And Presto!";
                    dev_presto.Start();
                }
                if (Properties.Settings.Default.dev_self_host == "1")
                {
                }
                wait.Stop();
                fin.Stop();
            }
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            prg_2.Maximum = (int)e.TotalBytesToReceive / 100;
            prg_2.Value = (int)e.BytesReceived / 100;
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lbl_content.Text = "Grabbed Package";
        }
    }
}