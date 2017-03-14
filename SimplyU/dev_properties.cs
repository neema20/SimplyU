using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

/*
 * ===================READMEFIRST=======================
 * This is the Properties form. This form allows said
 * user to modify all settings that are available.
 * Such as, chaning the theme, disabling and enabling
 * Automatic Updating, Enabling Development features,
 * etc, etc. Setting are stored within-
 * -Properties.Settings.Default(). Most settings start
 * with dev_ followed by the name.
 *
 * Theming:
 *
 * 1) Themes are stored within the /Common/Themes direc-
 * -tory. When you type a theme's folder name, it will
 * look for said theme. If it doesn't exist, it will
 * throw an error. Also, it is NOT case sensitive.
 * But, do not add any spaces to the end of the name.
 * This can result in some resources not being found, IE
 * Music.
 *
 * 2) Music, or background music. Is a big part of
 * SimpliiU. It adds a more, comfortable interface or
 * feeling to the Application; but can be disabled.
 * Music is stored within a themes directory-
 * -/Common/Themes/Defualt/audio/audio_file.mp3. Or just
 * /Default/audio/audio_file.mp3. The audio files that
 * are most likely available are "audio_bck.mp3, audio_credits.mp3,
 * and audio_complete.mp3." These files (if found) will be used.
 *
 * 3) Images are used a lot in SimpliiU. But, some are
 * used for a theme. For example, the splash screen changes
 * depending on the theme chosen. These files are stored
 * within the /Common/Themes/ThemeName/img directory.
 * The following files will be used "pnl_back.png, and SimplyU_Full_Logo.png."
 * These files are for the Logo, and Slash Screen.
 *
 * 4) Colors are quite simple; the color for a theme is stored
 * within the color.ini file inside of the root of said
 * themes folder. For example, the following colors can be used:
 *
 * Blue - blue
 * Red - red
 * Orange - orange
 * Brown - brown
 * Purple - purple
 * Pink - pink
 * Yellow - yellow
 * Grey - grey
 * Grey and Red - grey_red
 * Green - green
 * Blue and Red - blue_red
 * Blue and Grey - blue_grey
 *
 * You can also add other colors, by just copying and changing the code;
 * for example:
 *
 *   if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme + "\\color.ini") == "violet")
            {
                MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
                skinmgr.Theme = MaterialSkinManager.Themes.LIGHT;
                skinmgr.ColorScheme = new ColorScheme(Primary.Violet800, Primary.Violet900, Primary.Violet500, Accent.Purple200, TextShade.WHITE);
            }
 *
 * This code should be placed within the Program.cs file
 *
 * Thanks for reading this README. I hope that it helped in any way possible.
 *
 * Updated: 2/18/17
 *======================================================
 */

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
            if (chck_upd.Checked == true)
            {
                chck_grab_night.Enabled = true;
            }
            else
            {
                chck_grab_night.Enabled = false;
            }
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
                chck_grab_night.Checked = true;
            }
            else
            {
                chck_grab_night.Checked = false;
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
                    Properties.Settings.Default.dev_theme = "Default";
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
            if (chck_grab_night.Checked == true)
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
            if (chck_grab_night.Checked == false)
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
                btn_theme_choose.Enabled = true;
                txt_theme.Enabled = true;
            }
            else
            {
                btn_theme_choose.Enabled = false;
                txt_theme.Enabled = false;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This option will reset all Settings to their defaults! \r\n        Are you sure you want to continue?", "SimpliiU: Properties -- Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
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
                if (Properties.Settings.Default.dev_grab_night == "1")
                {
                    //Read latest update and convert to string
                    WebRequest request = WebRequest.Create("https://github.com/zoltx23/SimpliiU/blob/master/Common/Updates//Update_Info.ini?raw=true");
                    WebResponse response = request.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader upd_rd = new StreamReader(dataStream);
                    string upd_get = upd_rd.ReadToEnd();

                    //Get and read latest update info, then grab it
                    //But first delete old files, and continue.
                    WebClient get_info = new WebClient();
                    string cd = Application.StartupPath;
                    File.Delete(Path.Combine(cd, "Update_info.txt"));
                    File.Delete(Path.Combine(cd, "Update_URI.txt"));
                    File.Delete(Path.Combine(cd, "SimpliiU_old.exe"));
                    File.Delete(Path.Combine(cd, "SimpliiU_new.exe"));
                    File.Delete(Path.Combine(cd, "upd_fin.exe"));
                    get_info.DownloadFile(new Uri("https://github.com/zoltx23/SimpliiU/blob/master/Common/Updates/dev_latest/Update_Info.ini?raw=true"), cd + "\\Update_info.txt");
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
                                return;
                            }
                            else
                            {
                                DialogResult dr = MessageBox.Show("There's an Update available" + " (" + upd_get + ")" + "\r\nDo you wish to update?", "SimpliiU: Update", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                switch (dr)
                                {
                                    case System.Windows.Forms.DialogResult.Yes:
                                        upd_dwld.DownloadFile(new Uri("https://github.com/zoltx23/SimpliiU/blob/master/Common/Updates/dev_latest/SimpliiU.exe?raw=true"), cd + "\\SimpliiU_new.exe");
                                        WebClient get_fin = new WebClient();
                                        get_fin.DownloadFile(new Uri("https://github.com/zoltx23/SimplyU/blob/master/Common/Updates/upd_fin.exe?raw=true"), cd + "\\upd_fin.exe");
                                        Process.Start(cd + "\\upd_fin.exe");

                                        Application.Exit();
                                        break;

                                    case System.Windows.Forms.DialogResult.No:

                                        break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    //Read latest update and convert to string
                    WebRequest request = WebRequest.Create("https://github.com/zoltx23/SimpliiU/blob/master/Common/Updates//Update_Info.ini?raw=true");
                    WebResponse response = request.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader upd_rd = new StreamReader(dataStream);
                    string upd_get = upd_rd.ReadToEnd();

                    //Get and read latest update info, then grab it
                    //But first delete old files, and continue.
                    WebClient get_info = new WebClient();
                    string cd = Application.StartupPath;
                    File.Delete(Path.Combine(cd, "Update_info.txt"));
                    File.Delete(Path.Combine(cd, "Update_URI.txt"));
                    File.Delete(Path.Combine(cd, "SimpliiU_old.exe"));
                    File.Delete(Path.Combine(cd, "SimpliiU_new.exe"));
                    File.Delete(Path.Combine(cd, "upd_fin.exe"));
                    get_info.DownloadFile(new Uri("https://github.com/zoltx23/SimpliiU/blob/master/Common/Updates//Update_Info.ini?raw=true"), cd + "\\Update_info.txt");
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
                                return;
                            }
                            else
                            {
                                DialogResult dr = MessageBox.Show("There's an Update available" + " (" + upd_get + ")" + "\r\nDo you wish to update?", "SimpliiU: Update", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                switch (dr)
                                {
                                    case System.Windows.Forms.DialogResult.Yes:
                                        upd_dwld.DownloadFile(new Uri("https://github.com/zoltx23/SimpliiU/blob/master/Common/Updates/Latest/SimpliiU.exe?raw=true"), cd + "\\SimpliiU_new.exe");
                                        WebClient get_fin = new WebClient();
                                        get_fin.DownloadFile(new Uri("https://github.com/zoltx23/SimplyU/blob/master/Common/Updates/upd_fin.exe?raw=true"), cd + "\\upd_fin.exe");
                                        Process.Start(cd + "\\upd_fin.exe");

                                        Application.Exit();
                                        break;

                                    case System.Windows.Forms.DialogResult.No:

                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                lbl_upd.Text = "Unable to check for Updates!";
                Close();
                dev_error de = new dev_error();
                de.Show();
            }
        }

        private void chck_upd_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_upd.Checked == true)
            {
                chck_grab_night.Enabled = true;
            }
            else
            {
                chck_grab_night.Enabled = false;
            }
        }

        private void lbl_flbck_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_fallbck == "1")
            {
                Properties.Settings.Default.dev_fallbck = "0";
                Properties.Settings.Default.dev_theme = "Default";
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            else
            {
                Properties.Settings.Default.dev_theme = "Fallbck";
                Properties.Settings.Default.dev_fallbck = "1";
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

        private void btn_theme_choose_Click(object sender, EventArgs e)
        {
            dev_theme_chooser dr = new dev_theme_chooser();
            dr.Show();
        }

        private void btn_prev_theme_Click(object sender, EventArgs e)
        {
            if (chck_ctheme.Enabled == false)
            {
                Properties.Settings.Default.dev_theme_prev = "Default";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.dev_theme_prev = txt_theme.Text;
                Properties.Settings.Default.Save();
            }
            Form tp = new dev_preview_theme();
            tp.Show();
        }

        private void chck_grab_night_CheckStateChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_grab_night == "0")
            {
                if (chck_grab_night.Checked == true)
                {
                    DialogResult dr = MessageBox.Show("         This option will allow you to revieve development builds. \r\nThese builds are not ment for normal use. Please proceed with caution! \r\n \r\n                        Are you sure you want to continue?", "SimpliiU: Properties -- Update Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    switch (dr)
                    {
                        case System.Windows.Forms.DialogResult.Yes:

                            chck_grab_night.Checked = true;
                            break;

                        case System.Windows.Forms.DialogResult.No:
                            chck_grab_night.Checked = false;
                            break;
                    }
                }
                else
                {
                    chck_grab_night.Checked = false;
                }
            }
            else
            {
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            Form ab = new dev_about();
            ab.Show();
            Close();
        }
    }
}