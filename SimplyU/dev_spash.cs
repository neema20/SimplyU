using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
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
            if (Properties.Settings.Default.dev_upd == "1")
            {
                lbl_header.Text = "Checking for updates....";
                this.Refresh();
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
                    lbl_header.Text = "Update failed.";
                }
            }

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