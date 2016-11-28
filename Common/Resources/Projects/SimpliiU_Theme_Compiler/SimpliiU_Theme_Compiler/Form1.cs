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

namespace SimpliiU_Theme_Compiler
{
    public partial class main : Form
    {
        private string cd = Application.StartupPath;

        public main()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_icon_logo_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_comp_Click(object sender, EventArgs e)
        {
            lbl_status.Visible = true;
            lbl_status.Text = "Compiling...";
        }

        private void btn_dest_Click(object sender, EventArgs e)
        {
            sv_dest.ShowDialog();
        }

        private void sv_dest_FileOk(object sender, CancelEventArgs e)
        {
            txt_dest.Text = sv_dest.FileName;
        }

        private void main_Load(object sender, EventArgs e)
        {
            lbl_ver.Text += "" + Application.ProductVersion;
            try
            {
                if (Directory.Exists(cd + "\\Common\\Temp"))
                {
                    Directory.Delete(cd + "\\Common\\Temp", true);
                }
                else
                {
                    Directory.CreateDirectory(cd + "\\Common\\Temp");
                }
            }
            catch
            {
                MessageBox.Show("There was an problem when attempting to remove the Temp Directories, and creating a new one.", "SimpliiU: Theme Compiler --ERROR_DIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}