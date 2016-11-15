using MaterialSkin;
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

/*
 * ===================READMEFIRST=======================
 * This is the Main forum for playing background Music.
 * There is a settings in the Properties that indicates
 * whether or not to play said music.
 *
 * The Music is contained (should be) in the directory
 * "\\Common\\Music"; if not, the application will ignore
 * them. The files are as follows: "audio_bck.mp3,
 * audio_complete.mp3, and audio_credits.mp3." You may
 * replace any of these files, with your own music files.
 * But, they must be in the .mp3/.wav/.mp2 format.
 *
 * Credits:
 *
 * Music from Sonic the Hedgehog (2006), Sonic Rush/Rush Adventure,
 * and Tobu Higher (Electronica Genre).
 *======================================================
 */

namespace SimplyU
{
    public partial class dev_bck_music : MaterialForm
    {
        public dev_bck_music()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_bck_music_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_bck_music_en == "1")
            {
                if (Properties.Settings.Default.dev_theme == "klk")
                {
                    audio_tmr.Interval = 246800;
                    audio_tmr.Start();
                    bck_music.URL = Application.StartupPath + "\\Common\\Music\\audio_bck_klk.mp3";
                    this.Hide();
                    dev_notes mn = new dev_notes();
                    mn.ShowDialog();
                }
                else
                {
                    audio_tmr.Start();
                    bck_music.URL = Application.StartupPath + "\\Common\\Music\\audio_bck.mp3";
                    this.Hide();
                    dev_notes mn = new dev_notes();
                    mn.ShowDialog();
                }
            }
            else
            {
                this.Hide();
                Main mn = new Main();
                mn.ShowDialog();
            }
        }

        private void audio_tmr_Tick(object sender, EventArgs e)
        {
            /*This will replay the audio file after a given interval, convert the Time of the song from Minutes or Seconds
             *to Miliseconds, then apply that to the timer. It may give you an Invalid error, just type the number manually rather
             * than pasting said number. Example: "132000" which is 2:20.
             *
             * You can change the audio file, by replacing the present one. It's recommended to name the old one "audio_bck.mp3.old".
             *
             * As of 0.7, the Kill la Kill theme and Music has been implemented, only because I love kill la kill. So, the file for that background music is as follows:
             * audio_bck_klk.mp3, audio_complete_klk.mp3, and audio_credits_klk.mp3. You may replace the files, if you wish.
            */

            {
                if (Properties.Settings.Default.dev_theme == "klk")
                {
                    audio_tmr.Interval = 246800;
                    audio_tmr.Start();
                    bck_music.URL = Application.StartupPath + "\\Common\\Music\\audio_bck_klk.mp3";
                }
                else
                {
                    audio_tmr.Interval = 199800;
                    audio_tmr.Start();
                    bck_music.URL = Application.StartupPath + "\\Common\\Music\\audio_bck.mp3";
                }
            }
        }

        private void check_sett_Tick(object sender, EventArgs e)
        {
        }

        private void check_sett_Tick_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_bck_music == "1")
            {
                bck_music.Ctlcontrols.stop();
            }
        }
    }
}