using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace SimplyU
{
    public partial class dev_properties : MaterialForm
    {
        public dev_properties()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_properties_Load(object sender, EventArgs e)
        {
            txt_theme.Text = Properties.Settings.Default.dev_theme;
            txt_theme.Enabled = true;
            chck_ctheme.Checked = true;
            if (Properties.Settings.Default.dev_theme == "")
            {
                txt_theme.Enabled = false;
                chck_ctheme.Checked = false;
            }
            if (Properties.Settings.Default.dev_theme == "Default")
            {
                txt_theme.Enabled = false;
                chck_ctheme.Checked = false;
            }
            if (Properties.Settings.Default.dev_bck_music_en == "1")
            {
                chck_music.Checked = true;
            }
            else
            {
                chck_music.Checked = false;
            }
            if (Properties.Settings.Default.dev_grab_night == "1")
            {
                chck_grab.Checked = true;
            }
            else
            {
                chck_grab.Checked = false;
            }
            if (Properties.Settings.Default.dev_dev_mode == "1")
            {
                chck_dev.Checked = true;
            }
            else
            {
                chck_dev.Checked = false;
            }
            if (Properties.Settings.Default.dev_cleanup == "1")
            {
                chck_clean.Checked = true;
            }
            else
            {
                chck_clean.Checked = false;
            }
            if (Properties.Settings.Default.dev_upd == "1")
            {
                chck_upd.Checked = true;
            }
            else
            {
                chck_upd.Checked = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (chck_ctheme.Checked == true)
            {
                Properties.Settings.Default.dev_theme = txt_theme.Text;
                if (Directory.Exists(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme))
                {
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("The theme that you have entered was NOT found! Please try again, and confirm that it's there.", "SimpliiU: Properties --Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                Properties.Settings.Default.dev_theme = "Default";
            }
            if (chck_music.Checked == true)
            {
                Properties.Settings.Default.dev_bck_music_en = "1";
            }
            if (chck_upd.Checked == true)
            {
                Properties.Settings.Default.dev_upd = "1";
            }
            if (chck_grab.Checked == true)
            {
                Properties.Settings.Default.dev_grab_night = "1";
            }
            if (chck_clean.Checked == true)
            {
                Properties.Settings.Default.dev_cleanup = "1";
            }
            if (chck_dev.Checked == true)
            {
                Properties.Settings.Default.dev_dev_mode = "1";
            }
            if (chck_music.Checked == false)
            {
                Properties.Settings.Default.dev_bck_music_en = "0";
            }
            if (chck_upd.Checked == false)
            {
                Properties.Settings.Default.dev_upd = "0";
            }
            if (chck_grab.Checked == false)
            {
                Properties.Settings.Default.dev_grab_night = "0";
            }
            if (chck_clean.Checked == false)
            {
                Properties.Settings.Default.dev_cleanup = "0";
            }
            if (chck_dev.Checked == false)
            {
                Properties.Settings.Default.dev_dev_mode = "0";
            }
            Properties.Settings.Default.Save();
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chck_tmr_Tick(object sender, EventArgs e)
        {
            if (chck_ctheme.Checked == true)
            {
                txt_theme.Enabled = true;
            }
            else
            {
                txt_theme.Enabled = false;
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Application.Restart();
        }
    }
}