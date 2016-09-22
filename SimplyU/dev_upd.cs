using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyU
{
    public partial class dev_upd : MaterialForm
    {
        public dev_upd()
        {
            InitializeComponent();
        }

        private void dev_upd_Load(object sender, EventArgs e)
        {
            lbl_status.Text = "Checking Internet Connection...";
            bool bb = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

            if (bb == true)
                lbl_status.Text = "Internet Connection Available!";
            else
                lbl_status.Text = "Internet Connection NOT Available!";
            Hide();
            Main mn = new Main();
            mn.Show();

            /*As of now, the Update code isn't completed yet.
             * So, the Application will just Continue!
             */
        }
    }
}