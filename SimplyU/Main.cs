using MaterialSkin.Controls;
using SimplyU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyU
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            dev_prepare dc = new dev_prepare();
            dc.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.dev_self_host = "0";

            Properties.Settings.Default.sd_form = "0";

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

            if (Properties.Settings.Default.dev_dev_mode == "1")
            {
                lbl_ver.Text = "Release: " + Application.ProductVersion + " Nightly--DEV_MODE";
            }
            else
            {
                lbl_ver.Text = "Release: " + Application.ProductVersion + " Nightly";
            }
        }

        private void btn_self_host_Click(object sender, EventArgs e)
        {
            this.Hide();
            dev_hosting dc = new dev_hosting();
            dc.ShowDialog();
        }

        private void btn_prop_Click(object sender, EventArgs e)
        {
            dev_properties dp = new dev_properties();
            dp.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Process.Start("https://gbatemp.net/threads/release-simpliiu.438899/");
        }
    }
}