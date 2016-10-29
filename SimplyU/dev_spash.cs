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
    }
}