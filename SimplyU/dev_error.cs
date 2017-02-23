using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

/*
 * ===================READMEFIRST=======================
 * This is the Error forum for displaying error and Log
 * information, this is only available in Dev Mode, and
 * is not functioning properly, as of now.
 *======================================================
 */

namespace SimplyU

{
    public partial class dev_error : MaterialForm

    {
        public string lg = Properties.Settings.Default.dev_log_state;

        public dev_error()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_error_Load(object sender, EventArgs e)
        {
            lbl_stat.Text = "During the " + "Updater" + " section; a log dump has been collected. \r\nPlease review it, and find out what \r\nhas caused this Error, or you may submit it via GBATemp or Github. ";
            dev_log.Text = "System Debugging: " + SystemInformation.DebugOS + "\r\nUser Info: " + SystemInformation.UserName + "\r\nApplication Version: " + Application.ProductVersion + "\r\nWindows Version: " + "%%" + "\r\nScreen Size: " + SystemInformation.VirtualScreen + "\r\nNetwork: " + SystemInformation.Network + "\r\nBoot Mode: " + SystemInformation.BootMode + "\r\nDebug LOG: UPDATE_VER_CHECK_0 .. UNABLE_TO_PING_URL .. CODE 0C202";
        }

        private void dev_error_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}