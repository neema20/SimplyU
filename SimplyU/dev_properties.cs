using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This option will reset all Settings to their defaults! \r\n        Are you sure you want to continue?", "SimpliiU: Properties -- Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch (dr)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    Properties.Settings.Default.Reset();
                    Application.Restart();
                    break;

                case System.Windows.Forms.DialogResult.No:

                    break;
            }
        }

        private void lbl_dwn_themes_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/zoltx23/SimplyU/tree/master/Common/Themes/README.md#downloads");
        }

        private void lbl_upd_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Application.StartupPath;
                lbl_upd.Text = "Checking for Updates...";
                File.Delete(Path.Combine(cd, "Update_info.txt"));
                File.Delete(Path.Combine(cd, "Update_URI.txt"));
                File.Delete(Path.Combine(cd, "SimpliiU_old.exe"));
                File.Delete(Path.Combine(cd, "SimpliiU_new.exe"));
                File.Delete(Path.Combine(cd, "upd_fin.exe"));
                WebClient get_info = new WebClient();
                get_info.DownloadFile(new Uri("https://github.com/zoltx23/SimpliiU/blob/master/Common/Updates/Update_Info.ini?raw=true"), cd + "\\Update_info.txt");
                WebClient upd_dwld = new WebClient();
                using (Stream upd = File.Open(cd + "\\Update_info.txt", FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(upd))
                    {
                        string rd_upd = null;

                        rd_upd = reader.ReadToEnd();

                        if (rd_upd == Application.ProductVersion)
                        {
                            lbl_upd.Text = "No new Updates";
                        }
                        else
                        {
                            lbl_upd.Text = "Downloading New update...";
                            upd_dwld.DownloadFile(new Uri("https://github.com/zoltx23/SimpliiU/blob/master/Common/Updates/Latest/SimpliiU.exe?raw=true"), cd + "\\SimpliiU_new.exe");
                            WebClient get_fin = new WebClient();
                            get_fin.DownloadFile(new Uri("https://github.com/zoltx23/SimpliiU/blob/master/Common/Updates/Latest/upd_fin.exe?raw=true"), cd + "\\upd_fin.exe");
                            Process.Start(cd + "\\upd_fin.exe");
                            lbl_upd.Text = "Preparing...";
                            Application.Exit();
                        }
                    }
                }
            }
            catch
            {
                lbl_upd.Text = "Unable to check for Updates!";
            }
        }
    }
}