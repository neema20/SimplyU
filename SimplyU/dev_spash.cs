using System;
using System.Windows.Forms;

namespace SimplyU
{
    public partial class dev_spash : Form
    {
        public dev_spash()
        {
            InitializeComponent();
        }

        private void dev_tmr_Tick(object sender, EventArgs e)
        {
            dev_tmr.Stop();
            this.Hide();
            dev_bck_music dm = new dev_bck_music();
            dm.ShowDialog();
        }

        private void lbl_header_Click(object sender, EventArgs e)
        {
        }

        private void dev_spash_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_theme == "klk")
            {
                this.BackgroundImage = Properties.Resources.pnl_back_klk;
                lbl_header.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}