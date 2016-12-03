using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace SimplyU
{
    public partial class dev_upd : MaterialForm
    {
        private bool bb = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

        public dev_upd()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_upd_Load(object sender, EventArgs e)
        {
            lbl_status.Text = "Checking Internet Connection...";

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