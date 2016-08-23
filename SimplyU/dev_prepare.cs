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
            Properties.Settings.Default.Save();
            dev_grab_content dg = new dev_grab_content();
            dg.ShowDialog();
        }

        private void dev_prepare_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}