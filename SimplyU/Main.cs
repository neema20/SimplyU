﻿using MaterialSkin;
using MaterialSkin.Controls;
using SimplyU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * ===================READMEFIRST=======================
 * This is the Main forum for getting the user
 * familiar with the program.
 *
 *
 * Credits:
 *
 * (C) Dr.Hacknik (zoltx23) 2014-2016
 * All Components are used under the Open-GPL GNU
 * Public license agreement (v3). Any modification of
 * said components or this application are acceptable.
 *
 * To see the full License, check LICENSE.txt on the
 * "Master" branch via GitHub.
 *
 * Thanks to all my patient users and fans, as well as
 * the people, whom have helped me with this project or
 * other projects! They include:
 *
 * MarcusD
 * VoxelStudios
 * HoloryTV
 * vmgoose
 * My fellow 'real-life' friends,
 * and many more...
 *
 * And of course, you! My fellow user, I'm so glad that
 * you are using this Application and/or my other-
 * creations. Thanks so much! :)
 *======================================================
 */

namespace SimplyU
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_upd == "1")
            {
                try
                {
                    string cd = Application.StartupPath;
                    File.Delete(Path.Combine(cd, "Update_info.txt"));
                    File.Delete(Path.Combine(cd, "Update_URI.txt"));
                    File.Delete(Path.Combine(cd, "SimpliiU_old.exe"));
                    File.Delete(Path.Combine(cd, "SimpliiU_new.exe"));
                    File.Delete(Path.Combine(cd, "upd_fin.exe"));
                    WebClient get_info = new WebClient();
                    get_info.DownloadFile(new Uri("https://github.com/zoltx23/SimpliiU/blob/master/Common/Updates/Update_Info.ini?raw=true"), cd + "\\Update_info.txt");
                    WebClient upd_dwld = new WebClient();
                    using (Stream upd = File.Open(cd + "\\Update_info.txt", FileMode.Open))
                    {
                        using (StreamReader reader = new StreamReader(upd))
                        {
                            string rd_upd = null;

                            rd_upd = reader.ReadToEnd();

                            if (rd_upd == Application.ProductVersion)
                            {
                                DialogResult dr = MessageBox.Show("There's an Update available" + File.Open(cd + "\\Update_info.txt", FileMode.Open) + "\r\n        Are you sure you want to continue?", "SimpliiU: Update", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                switch (dr)
                                {
                                    case System.Windows.Forms.DialogResult.Yes:
                                        upd_dwld.DownloadFile(new Uri("https://github.com/zoltx23/SimpliiU/blob/master/Common/Updates/Latest/SimpliiU.exe?raw=true"), cd + "\\SimpliiU_new.exe");
                                        WebClient get_fin = new WebClient();
                                        get_fin.DownloadFile(new Uri("https://github.com/zoltx23/SimplyU/blob/master/Common/Updates/upd_fin.exe?raw=true"), cd + "\\upd_fin.exe");
                                        Process.Start(cd + "\\upd_fin.exe");

                                        Application.Exit();
                                        break;

                                    case System.Windows.Forms.DialogResult.No:

                                        break;
                                }
                            }
                        }
                    }
                }
                catch
                {
                }
            }

            if (File.Exists(Application.StartupPath + "\\Common\\Themes\\dev_themes.ini"))
            {
                File.Delete(Application.StartupPath + "\\Common\\Themes\\dev_themes.ini");
            }
            else
            {
            }

            if (Directory.Exists(Application.StartupPath + "\\Common\\Music"))
            {
                Directory.Delete(Application.StartupPath + "\\Common\\Music", true);
            }
            else
            {
            }
            if (Properties.Settings.Default.dev_theme == "")
            {
                pic_splash.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\Default\\img\\SimplyU_Full_Logo.png");
            }
            if (Properties.Settings.Default.dev_theme == "0")
            {
                pic_splash.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\Default\\img\\SimplyU_Full_Logo.png");
            }
            else
            {
                pic_splash.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme + "\\img\\SimplyU_Full_Logo.png");
            }
            if (Properties.Settings.Default.dev_theme == "Ryko")
            {
                //Skin manager--RED
                MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
                skinmgr.Theme = MaterialSkinManager.Themes.LIGHT;
                skinmgr.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            }
            if (Properties.Settings.Default.dev_theme == "Satsuki")
            {
                //Skin manager--BLUE
                MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
                skinmgr.Theme = MaterialSkinManager.Themes.LIGHT;
                skinmgr.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
            }
            if (Properties.Settings.Default.dev_theme == "Default")
            {
                //Skin manager--BLUE
                MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
                skinmgr.Theme = MaterialSkinManager.Themes.LIGHT;
                skinmgr.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
            }
            if (Properties.Settings.Default.dev_bck_music_en == "")
            {
                Properties.Settings.Default.dev_bck_music_en = "1";
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            if (Properties.Settings.Default.dev_theme == "")
            {
                //Skin manager--BLUE
                MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
                skinmgr.Theme = MaterialSkinManager.Themes.LIGHT;
                skinmgr.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
                Properties.Settings.Default.dev_theme = "Default";
            }

            Properties.Settings.Default.inst_fba = "0";

            Properties.Settings.Default.inst_gamebatte = "0";

            Properties.Settings.Default.inst_beetle_neo = "0";

            Properties.Settings.Default.inst_prboom = "0";

            Properties.Settings.Default.inst_lynx = "0";

            Properties.Settings.Default.inst_snes9x_2010 = "0";

            Properties.Settings.Default.inst_fb_cps3 = "0";

            Properties.Settings.Default.inst_nxe = "0";

            Properties.Settings.Default.inst_beetle_neo = "0";

            Properties.Settings.Default.inst_beetle_sgx = "0";

            Properties.Settings.Default.inst_fb_cps2 = "0";

            Properties.Settings.Default.inst_snes9x = "0";

            Properties.Settings.Default.inst_tyrquake = "0";

            Properties.Settings.Default.inst_nestopia = "0";

            Properties.Settings.Default.inst_mame = "0";

            Properties.Settings.Default.inst_genisis = "0";

            Properties.Settings.Default.inst_beetlevb = "0";

            Properties.Settings.Default.inst_psx = "0";

            Properties.Settings.Default.inst_quicknes = "0";

            Properties.Settings.Default.inst_mame2003 = "0";

            Properties.Settings.Default.inst_fceumm = "0";

            Properties.Settings.Default.inst_fuse = "0";

            Properties.Settings.Default.inst_sigpat_sysmenu = "0";

            Properties.Settings.Default.inst_aoc = "0";

            Properties.Settings.Default.inst_haxchi = "0";

            Properties.Settings.Default.inst_cbhc = "0";

            Properties.Settings.Default.inst_fsdumper = "0";

            Properties.Settings.Default.inst_tik2sd = "0";

            Properties.Settings.Default.inst_padcon = "0";

            Properties.Settings.Default.inst_otp2sd = "0";

            Properties.Settings.Default.inst_wuphax = "0";

            Properties.Settings.Default.inst_sigpat_hbl = "0";

            Properties.Settings.Default.inst_seeprom = "0";

            Properties.Settings.Default.inst_wudumper = "0";

            Properties.Settings.Default.inst_ftpiu_every = "0";

            Properties.Settings.Default.inst_ft2sd = "0";

            Properties.Settings.Default.inst_loadiine_y = "0";

            Properties.Settings.Default.inst_loadiine = "0";

            Properties.Settings.Default.inst_retro = "0";

            Properties.Settings.Default.inst_hbl_dark = "0";

            Properties.Settings.Default.inst_hbl = "0";

            Properties.Settings.Default.dev_rednand = "";

            Properties.Settings.Default.dev_rednand_sd = "";

            Properties.Settings.Default.dev_rednand_sys = "";

            Properties.Settings.Default.dev_log_dump = "";

            Properties.Settings.Default.dev_log_state = "";

            Properties.Settings.Default.dev_bck_music = "0";

            Properties.Settings.Default.dev_self_host = "0";

            Properties.Settings.Default.inst_ios = "0";

            Properties.Settings.Default.inst_flappy = "0";

            Properties.Settings.Default.inst_our = "0";

            Properties.Settings.Default.inst_app_dark = "0";

            Properties.Settings.Default.inst_space = "0";

            Properties.Settings.Default.inst_poke = "0";

            Properties.Settings.Default.inst_hid_key = "0";

            Properties.Settings.Default.inst_live = "0";

            Properties.Settings.Default.inst_ddd = "0";

            Properties.Settings.Default.inst_sd_caffiine = "0";

            Properties.Settings.Default.inst_sav = "0";

            Properties.Settings.Default.inst_pong = "0";

            Properties.Settings.Default.inst_gac = "0";

            Properties.Settings.Default.inst_tic = "0";

            Properties.Settings.Default.inst_pac = "0";

            Properties.Settings.Default.inst_u_paint = "0";

            Properties.Settings.Default.inst_ftp = "0";

            Properties.Settings.Default.inst_ast = "0";

            Properties.Settings.Default.inst_nnu = "0";

            Properties.Settings.Default.inst_geck = "0";

            Properties.Settings.Default.inst_gbiine = "0";

            Properties.Settings.Default.inst_tcp = "0";

            Properties.Settings.Default.inst_snake = "0";

            Properties.Settings.Default.inst_cave = "0";

            Properties.Settings.Default.inst_chip = "0";

            Properties.Settings.Default.inst_wiiu_key = "0";

            Properties.Settings.Default.inst_wup = "0";

            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.dev_dev_mode == "1")
            {
                lbl_ver.Text = "Release: " + Application.ProductVersion + "  Final Beta--DEV_MODE";
            }
            else
            {
                lbl_ver.Text = "Release: " + Application.ProductVersion + "  Final Beta";
            }
        }

        private void lbl_term_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.terms_agreed = "0";
            Properties.Settings.Default.Save();
            MessageBox.Show("PROPERTIES_WRITE_VAL_SUCCESS", "ACCESS_WRITE_STATE:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            dev_notes dn = new dev_notes();
            dn.Show();
            this.Hide();
        }

        private void lbl_log_Click(object sender, EventArgs e)
        {
            dev_log dl = new dev_log();
            dl.Show();
        }

        private void lbl_ac_rdnand_Click(object sender, EventArgs e)
        {
            dev_rednand dr = new dev_rednand();
            dr.Show();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            dev_prepare dc = new dev_prepare();
            dc.ShowDialog();
        }

        private void btn_prop_Click_1(object sender, EventArgs e)
        {
            dev_properties dp = new dev_properties();
            dp.Show();
        }

        private void btn_self_host_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            dev_hosting dc = new dev_hosting();
            dc.ShowDialog();
        }

        private void btn_view_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://gbatemp.net/threads/release-simpliiu/");
        }
    }
}