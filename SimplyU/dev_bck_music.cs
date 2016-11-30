using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
 * "\\Common\\Themes\\ThatTheme\\audio"; if not, the application will ignore
 * them. The files are as follows: "audio_bck.mp3,
 * audio_complete.mp3, and audio_credits.mp3." You may
 * replace any of these files, with your own music files.
 * But, they must be in the .mp3/.wav/.mp2 format.
 *
 * Note: The Application now has a new INI Parser, for parsing
 * the "dev_themes.ini"; which is used for making the app know,
 * the themes that are currently available. But, must be edited
 * by yourself. I will add the function of installing themes, then
 * It'll automatically add the entry for that theme.
 *
 * Credits:
 *
 * Music from Sonic the Hedgehog (2006), Sonic Rush/Rush Adventure,
 * and Tobu Higher (Electronica Genre). As well as 'Dont lose yourself'
 * from Kill la Kill, and a Snippet from SE1 EPS1.
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
            try
            {
                if (Directory.Exists(Application.StartupPath + "\\Common\\Themes\\Kill_la_Kill"))
                {
                    Directory.Move(Application.StartupPath + "\\Common\\Themes\\Kill_la_Kill", Application.StartupPath + "\\Common\\Themes\\Ryuko");
                }
            }
            catch
            {
            }

            if (Properties.Settings.Default.dev_bck_music_en == "1")
            {
                bck_music.URL = Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme + "\\audio\\audio_bck.mp3";
                this.Hide();
                dev_notes mn = new dev_notes();
                mn.ShowDialog();
            }
            else
            {
                this.Hide();
                Main mn = new Main();
                mn.ShowDialog();
            }
        }

        private void check_sett_Tick_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_bck_music == "1")
            {
                bck_music.Ctlcontrols.stop();
            }
        }

        private void dev_bck_music_DoubleClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void audio_tmr_Tick_1(object sender, EventArgs e)
        {
            //Check to see if the media has ended or stopped, then repeat.
            if (bck_music.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                bck_music.URL = Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme + "\\audio\\audio_bck.mp3";
            }
            if (bck_music.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                bck_music.URL = Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme + "\\audio\\audio_bck.mp3";
            }
        }
    }
}