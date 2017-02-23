using System;
using System.Drawing;
using System.IO;
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

        private void dev_spash_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme + "\\img\\pnl_back.png");
                lbl_header.ForeColor = System.Drawing.Color.Black;
            }
            catch
            {
                if (Properties.Settings.Default.dev_theme == "")
                {
                    Properties.Settings.Default.dev_theme = "Default";
                    Properties.Settings.Default.Save();
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("The theme that you have entered was NOT found! Please try again, and confirm that it's there. SimpliiU will now enter Fallback mode!", "SimpliiU: Properties --Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Properties.Settings.Default.dev_theme = "Fallbck";
                    Properties.Settings.Default.dev_fallbck = "1";
                    Properties.Settings.Default.Save();
                    dev_tmr.Stop();
                }
            }

            if (Properties.Settings.Default.dev_theme == "")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\Default\\img\\pnl_back.png");
                Properties.Settings.Default.dev_theme = "Default";
                Properties.Settings.Default.Save();
                Application.Restart();
            }

            if (Properties.Settings.Default.dev_theme == "0")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\Default\\img\\pnl_back.png");
                Properties.Settings.Default.dev_theme = "Default";
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            if (Directory.Exists(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme))
            {
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("The theme that you have entered was NOT found! Please try again, and confirm that it's there.", "SimpliiU: Properties --Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Properties.Settings.Default.dev_theme = "Default";
                Properties.Settings.Default.Save();
            }
        }

        private void lbl_header_Click(object sender, EventArgs e)
        {
        }
    }
}