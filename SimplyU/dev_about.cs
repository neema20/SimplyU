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

namespace SimplyU
{
    public partial class dev_about : MaterialForm
    {
        public dev_about()
        {
            InitializeComponent();
        }

        private void dev_about_Load(object sender, EventArgs e)
        {
            lbl_header.Text = "About SimpliiU " + Application.ProductVersion + ":";
            if (Properties.Settings.Default.dev_guide == "1")
            {
                btn_close.Visible = false;
                btn_cont.Visible = true;
            }
            try
            {
                pcx_logo.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme + "\\img\\SimplyU_Full_Logo.png");
            }
            catch
            {
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_close_now == "1")
            {
                Application.Exit();
            }
            else
            {
                Close();
            }
        }

        private void btn_cont_Click(object sender, EventArgs e)
        {
            Hide();
            Form gm = new dev_guide_me();
            gm.ShowDialog();
        }
    }
}