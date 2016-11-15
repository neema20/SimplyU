using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyU
{
    public partial class dev_rednand : MaterialForm
    {
        public dev_rednand()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dev_rednand_Load(object sender, EventArgs e)
        {
        }

        private void dev_target_timer_Tick(object sender, EventArgs e)
        {
            txt_target.Text = dev_drive.SelectedPath.ToString();
        }

        private void btn_target_Click(object sender, EventArgs e)
        {
            dev_drive.ShowDialog();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            dev_rednand_prepare dp = new dev_rednand_prepare();
            dp.Show();
            Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.python.org/downloads/");
            Process.Start("http://cygwin.com/install.html");
        }
    }
}