using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*===============READMEFIRST==================
 * This is the Primary forum for selecting-
 * homebrew that you wish to install. The-
 * selected homebrew is saved to the propert-
 * -es. By doing so, we can tell the app what
 * and what not to install. You may modify or
 * add any homebrew you wish, although place
 * new code at the bottom, rather than the-
 * top.
 *============================================
 * */

namespace SimplyU
{
    public partial class dev_prepare : MaterialForm
    {
        public dev_prepare()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Radiobox's

            if (chck_self.Checked == true)
            {
                Properties.Settings.Default.dev_self_host = "1";
            }
            if (chck_frm_sd.Checked == true)
            {
                Properties.Settings.Default.sd_form = "1";
            }
            if (chck_guide.Checked == true)
            {
                Properties.Settings.Default.dev_guide = "1";
            }

            //Strings for 'to install' homebrew:
            if (chck_bt.Checked == true)
            {
                Properties.Settings.Default.inst_beetle = "1";
            }
            if (chck_tyrquake.Checked == true)
            {
                Properties.Settings.Default.inst_tyrquake = "1";
            }
            if (chck_fba_neo.Checked == true)
            {
                Properties.Settings.Default.inst_fb_neo = "1";
            }
            if (chck_btpce.Checked == true)
            {
                Properties.Settings.Default.inst_beetle_pcef = "1";
            }
            if (chck_fba.Checked == true)
            {
                Properties.Settings.Default.inst_fba = "1";
            }
            if (chck_gamebatte.Checked == true)
            {
                Properties.Settings.Default.inst_gamebatte = "1";
            }
            if (chck_fba_cps1.Checked == true)
            {
                Properties.Settings.Default.inst_beetle_neo = "1";
            }
            if (chck_prboom.Checked == true)
            {
                Properties.Settings.Default.inst_prboom = "1";
            }
            if (chck_lynx.Checked == true)
            {
                Properties.Settings.Default.inst_lynx = "1";
            }
            if (chck_snes9x_2010.Checked == true)
            {
                Properties.Settings.Default.inst_snes9x_2010 = "1";
            }
            if (chck_fba_cps3.Checked == true)
            {
                Properties.Settings.Default.inst_fb_cps3 = "1";
            }
            if (chck_nxe.Checked == true)
            {
                Properties.Settings.Default.inst_nxe = "1";
            }
            if (chck_btneo.Checked == true)
            {
                Properties.Settings.Default.inst_beetle_neo = "1";
            }
            if (chck_btsgx.Checked == true)
            {
                Properties.Settings.Default.inst_beetle_sgx = "1";
            }
            if (chck_fb_alpha_2012_cps2.Checked == true)
            {
                Properties.Settings.Default.inst_fb_cps2 = "1";
            }
            if (chck_snes9x.Checked == true)
            {
                Properties.Settings.Default.inst_snes9x = "1";
            }
            if (chck_nestopia.Checked == true)
            {
                Properties.Settings.Default.inst_nestopia = "1";
            }
            if (chck_mame_midway.Checked == true)
            {
                Properties.Settings.Default.inst_mame = "1";
            }
            if (chck_gen_pl_gx.Checked == true)
            {
                Properties.Settings.Default.inst_genisis = "1";
            }
            if (chck_btvb.Checked == true)
            {
                Properties.Settings.Default.inst_beetlevb = "1";
            }
            if (chck_psx.Checked == true)
            {
                Properties.Settings.Default.inst_psx = "1";
            }
            if (chck_quicknes.Checked == true)
            {
                Properties.Settings.Default.inst_quicknes = "1";
            }
            if (chck_mame_2003.Checked == true)
            {
                Properties.Settings.Default.inst_mame2003 = "1";
            }
            if (chck_fce.Checked == true)
            {
                Properties.Settings.Default.inst_fceumm = "1";
            }
            if (chck_fuse.Checked == true)
            {
                Properties.Settings.Default.inst_fuse = "1";
            }
            if (chck_sigpat_systmenu.Checked == true)
            {
                Properties.Settings.Default.inst_sigpat_sysmenu = "1";
            }
            if (chck_aoc.Checked == true)
            {
                Properties.Settings.Default.inst_aoc = "1";
            }
            if (chck_haxchi.Checked == true)
            {
                Properties.Settings.Default.inst_haxchi = "1";
            }
            if (chck_cbhc.Checked == true)
            {
                Properties.Settings.Default.inst_cbhc = "1";
            }
            if (chck_fsdumper.Checked == true)
            {
                Properties.Settings.Default.inst_fsdumper = "1";
            }
            if (chck_tik2sd.Checked == true)
            {
                Properties.Settings.Default.inst_tik2sd = "1";
            }
            if (chck_padcon.Checked == true)
            {
                Properties.Settings.Default.inst_padcon = "1";
            }
            if (chck_otp2sd.Checked == true)
            {
                Properties.Settings.Default.inst_otp2sd = "1";
            }
            if (chck_wuphax.Checked == true)
            {
                Properties.Settings.Default.inst_wuphax = "1";
            }
            if (chck_sigpat_hbl.Checked == true)
            {
                Properties.Settings.Default.inst_sigpat_hbl = "1";
            }
            if (chck_seeprom.Checked == true)
            {
                Properties.Settings.Default.inst_seeprom = "1";
            }
            if (chck_wudumper.Checked == true)
            {
                Properties.Settings.Default.inst_wudumper = "1";
            }
            if (chck_ftpiue.Checked == true)
            {
                Properties.Settings.Default.inst_ftpiu_every = "1";
            }
            if (chck_ft2sd.Checked == true)
            {
                Properties.Settings.Default.inst_ft2sd = "1";
            }
            if (chck_loadiine_ymod.Checked == true)
            {
                Properties.Settings.Default.inst_loadiine_y = "1";
            }
            if (chck_loadiine.Checked == true)
            {
                Properties.Settings.Default.inst_loadiine = "1";
            }
            if (chck_retro_launcher.Checked == true)
            {
                Properties.Settings.Default.inst_retro = "1";
            }
            if (chck_hbl_dark.Checked == true)
            {
                Properties.Settings.Default.inst_hbl_dark = "1";
            }
            if (chck_hbl.Checked == true)
            {
                Properties.Settings.Default.inst_hbl = "1";
            }
            if (rd_flappy.Checked == true)
            {
                Properties.Settings.Default.inst_flappy = "1";
            }
            if (rd_ios.Checked == true)
            {
                Properties.Settings.Default.inst_ios = "1";
            }
            if (rd_synth.Checked == true)
            {
                Properties.Settings.Default.inst_synth = "1";
            }
            if (rd_hid_key.Checked == true)
            {
                Properties.Settings.Default.inst_hid_key = "1";
            }
            if (rd_poke.Checked == true)
            {
                Properties.Settings.Default.inst_poke = "1";
            }
            if (rd_app_dark.Checked == true)
            {
                Properties.Settings.Default.inst_app_dark = "1";
            }
            if (chck_our.Checked == true)
            {
                Properties.Settings.Default.inst_our = "1";
            }
            if (rd_space.Checked == true)
            {
                Properties.Settings.Default.inst_space = "1";
            }
            if (chck_ddd.Checked == true)
            {
                Properties.Settings.Default.inst_ddd = "1";
            }
            if (rd_sd_caf.Checked == true)
            {
                Properties.Settings.Default.inst_sd_caffiine = "1";
            }
            if (rd_sav.Checked == true)
            {
                Properties.Settings.Default.inst_sav = "1";
            }
            if (rd_pong.Checked == true)
            {
                Properties.Settings.Default.inst_pong = "1";
            }
            if (rd_gacu.Checked == true)
            {
                Properties.Settings.Default.inst_gac = "1";
            }
            if (rd_tict.Checked == true)
            {
                Properties.Settings.Default.inst_tic = "1";
            }
            if (rd_pac.Checked == true)
            {
                Properties.Settings.Default.inst_pac = "1";
            }
            if (rd_u_paint.Checked == true)
            {
                Properties.Settings.Default.inst_u_paint = "1";
            }
            if (rd_ftp.Checked == true)
            {
                Properties.Settings.Default.inst_ftp = "1";
            }
            if (rd_ast.Checked == true)
            {
                Properties.Settings.Default.inst_ast = "1";
            }
            if (rd_nnu.Checked == true)
            {
                Properties.Settings.Default.inst_nnu = "1";
            }
            if (rd_geck.Checked == true)
            {
                Properties.Settings.Default.inst_geck = "1";
            }
            if (rd_gbiine.Checked == true)
            {
                Properties.Settings.Default.inst_gbiine = "1";
            }
            if (rd_tcp.Checked == true)
            {
                Properties.Settings.Default.inst_tcp = "1";
            }
            if (rd_hid.Checked == true)
            {
                Properties.Settings.Default.inst_snake = "1";
            }
            if (rd_cave.Checked == true)
            {
                Properties.Settings.Default.inst_cave = "1";
            }
            if (rd_chip.Checked == true)
            {
                Properties.Settings.Default.inst_chip = "1";
            }
            if (rd_wiiu_key.Checked == true)
            {
                Properties.Settings.Default.inst_wiiu_key = "1";
            }
            if (rd_wup.Checked == true)
            {
                Properties.Settings.Default.inst_wup = "1";
            }

            //Install Recommended

            if (chck_rec.Checked == true)
            {
                Properties.Settings.Default.dev_install_rec = "1";
            }

            //Enable Self-Hosting?

            if (chck_self.Checked == true)
            {
                Properties.Settings.Default.dev_self_host = "1";
            }

            //Save formatting settings to Properties, then Show the next forum.

            Properties.Settings.Default.dev_target = txt_target.Text;
            Properties.Settings.Default.sd_form_drive = drive.Text;
            Properties.Settings.Default.sd_form_cluster = allocation.Text;
            Properties.Settings.Default.Save();
            dev_grab_content dg = new dev_grab_content();
            dg.ShowDialog();
        }

        private void dev_prepare_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_target_Click(object sender, EventArgs e)
        {
            dev_folder.ShowDialog();
        }

        private void dev_folder_HelpRequest(object sender, EventArgs e)
        {
        }

        private void dev_target_timer_Tick(object sender, EventArgs e)
        {
            txt_target.Text = dev_folder.SelectedPath.ToString();
            if (chck_frm_sd.Checked == true)
            {
                lbl_format_warn.ForeColor = Color.Red;
                drive.Enabled = true;
                allocation.Enabled = true;
            }
            else
            {
                lbl_format_warn.ForeColor = Color.DarkGray;
                drive.Enabled = false;
                allocation.Enabled = false;
            }
        }

        private void dev_prepare_Load(object sender, EventArgs e)
        {
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
        }

        private void chck_rec_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_rec.Checked == true)
            {
                chck_hbl.Checked = true;
                chck_hbl.Enabled = false;

                chck_our.Checked = true;
                chck_our.Enabled = false;

                chck_ddd.Checked = true;
                chck_ddd.Enabled = false;

                rd_sav.Checked = true;
                rd_sav.Enabled = false;

                rd_sd_caf.Checked = true;
                rd_sd_caf.Enabled = false;

                rd_ftp.Checked = true;
                rd_ftp.Enabled = false;

                rd_nnu.Checked = true;
                rd_nnu.Enabled = false;

                chck_loadiine.Checked = true;
                chck_loadiine.Enabled = false;

                chck_loadiine_ymod.Checked = true;
                chck_loadiine_ymod.Enabled = false;
            }
            if (chck_rec.Checked == false)
            {
                chck_hbl.Checked = false;
                chck_hbl.Enabled = true;

                chck_our.Checked = false;
                chck_our.Enabled = true;

                chck_ddd.Checked = false;
                chck_ddd.Enabled = true;

                rd_sav.Checked = false;
                rd_sav.Enabled = true;

                rd_sd_caf.Checked = false;
                rd_sd_caf.Enabled = true;

                rd_ftp.Checked = false;
                rd_ftp.Enabled = true;

                rd_nnu.Checked = false;
                rd_nnu.Enabled = true;

                chck_loadiine.Checked = false;
                chck_loadiine.Enabled = true;

                chck_loadiine_ymod.Checked = false;
                chck_loadiine_ymod.Enabled = true;
            }
        }
    }
}