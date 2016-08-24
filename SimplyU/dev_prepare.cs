using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyU
{
    public partial class dev_prepare : Form
    {
        public dev_prepare()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Radiobox's
            if (rd_55b.Checked == true)
            {
                Properties.Settings.Default.dev_sel_firmware = "55";
            }
            if (rd_54b.Checked == true)
            {
                Properties.Settings.Default.dev_sel_firmware = "54";
            }
            if (rd_53b.Checked == true)
            {
                Properties.Settings.Default.dev_sel_firmware = "53";
            }
            if (rd_52b.Checked == true)
            {
                Properties.Settings.Default.dev_sel_firmware = "52";
            }
            if (chck_self.Checked == true)
            {
                Properties.Settings.Default.dev_self_host = "1";
            }

            //Strings for 'to install' homebrew:

            if (rd_ddd.Checked == true)
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
            Properties.Settings.Default.dev_target = txt_target.Text;
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
        }
    }
}