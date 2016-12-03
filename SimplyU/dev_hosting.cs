using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimplyU
{
    public partial class dev_hosting : MaterialForm
    {
        public dev_hosting()
        {
            InitializeComponent();
        }

        private void dev_hosting_Load(object sender, EventArgs e)
        {
            try
            {
                Process.Start("StartServer.bat");
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Unable to locate the 'StartServer.bat' file; make sure it's there, and the Other Folders.", "SimpliiU: Start Hosting --Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                Main mn = new Main();
                mn.ShowDialog();
            }
        }

        private void ipv4_Tick(object sender, EventArgs e)
        {
            lbl_ip.Text = "Check ipconfig";
            lbl_stats.Text = "Hosting Online!";
        }

        private void dev_hosting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}