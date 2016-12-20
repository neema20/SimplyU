using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upd_fin
{
    public partial class Form1 : MaterialForm
    {
        public readonly String cd = Path.GetDirectoryName(Application.ExecutablePath);
        private WebClient upd_dwld = new WebClient();

        public Form1()
        {
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dev_upd_Tick(object sender, EventArgs e)
        {
            dev_upd.Stop();
            try
            {
                File.Delete(cd + "\\SimpliiU.exe");
                File.Move(cd + "\\SimpliiU_new.exe", cd + "\\SimpliiU.exe");
                Directory.CreateDirectory(cd + "\\snd");
                Process.Start(cd + "\\SimpliiU.exe");
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("There were errors when Finishing the Update!", "upd_fin: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}