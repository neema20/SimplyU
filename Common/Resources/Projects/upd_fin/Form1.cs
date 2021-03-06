﻿using MaterialSkin;
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
        private string upd = File.ReadAllText(Application.StartupPath + "\\Update_info.txt");

        public Form1()
        {
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_body.Text += "\r\nUpdating to: " + upd + "...";
        }

        private void dev_upd_Tick(object sender, EventArgs e)
        {
            dev_upd.Stop();
            try
            {
                File.Move(cd + "\\SimpliiU.exe", cd + "\\SimpliiU.exe.old");
                File.Move(cd + "\\SimpliiU_new.exe", cd + "\\SimpliiU.exe");
                Process.Start(cd + "\\SimpliiU.exe");
                Application.Exit();
            }
            catch
            {
                try
                {
                    MessageBox.Show("There were errors when Finishing the Update!", "upd_fin: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.Move(cd + "\\SimpliiU.exe.old", cd + "\\SimpliiU.exe");
                    File.Delete(cd + "\\SimpliiU_new.exe");
                    Application.Exit();
                }
                catch
                {
                    Application.Exit();
                }
            }
        }
    }
}