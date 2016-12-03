using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace SimplyU
{
    public partial class dev_notes : MaterialForm
    {
        public dev_notes()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_notes_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.terms_agreed == "1")
            {
                this.Hide();
                Main mn = new Main();
                mn.ShowDialog();
            }
            else
            {
                Properties.Settings.Default.terms_agreed = "0";
                Properties.Settings.Default.Save();
            }
        }

        private void btn_agree_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.terms_agreed = "1";
            Properties.Settings.Default.Save();
            this.Hide();
            Main mn = new Main();
            mn.ShowDialog();
        }

        private void btn_no_agree_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.terms_agreed = "0";
            Properties.Settings.Default.Save();
            Application.Exit();
        }
    }
}