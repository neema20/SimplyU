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

namespace SimplyU
{
    public partial class dev_log : MaterialForm
    {
        public dev_log()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_log_Load(object sender, EventArgs e)
        {
            event_log.BeginInit();
        }

        private void log_tmr_Tick(object sender, EventArgs e)
        {
            rch_log.Text += "\r\nUnable to access Log! \r\nSYSTEM.DIAGNOSTICS";
        }
    }
}