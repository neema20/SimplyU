using System;
using System.Drawing;
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
                this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\Kill_la_Kill\\img\\pnl_back.png");
                lbl_header.ForeColor = System.Drawing.Color.Black;
            }
            if (Properties.Settings.Default.dev_theme == "satsuki")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\Satsuki\\img\\pnl_back.png");
                lbl_header.ForeColor = System.Drawing.Color.Black;
            }
            if (Properties.Settings.Default.dev_theme == "default")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\Default\\img\\pnl_back.png");
                lbl_header.ForeColor = System.Drawing.Color.White;
            }
        }
    }
}