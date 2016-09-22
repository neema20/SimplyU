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
            Properties.Settings.Default.Reset();
            lbl_ver.Text = "Release: " + Application.ProductVersion + " Nightly";
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
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

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://gbatemp.net/threads/release-simpliiu.438899/");
        }
    }
}