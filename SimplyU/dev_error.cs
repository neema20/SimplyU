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
            dev_log.Text = lg;
        }

        private void dev_error_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}