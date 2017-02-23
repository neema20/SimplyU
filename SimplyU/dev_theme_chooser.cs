using MaterialSkin;
using MaterialSkin.Controls;
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

namespace SimplyU
{
    public partial class dev_theme_chooser : MaterialForm
    {
        private string cd = Application.StartupPath;
        private string sel = "0";
        private string sel2 = "0";
        private string sel3 = "0";
        private string sel4 = "0";
        private string sel5 = "0";
        private string sel6 = "0";
        private string sel7 = "0";
        private string sel8 = "0";
        private string sel9 = "0";
        private string sel10 = "0";
        private string sel11 = "0";
        private string sel12 = "0";
        private string sel13 = "0";
        private string sel14 = "0";
        private string sel15 = "0";
        private string sel16 = "0";
        private string sel17 = "0";
        private string sel18 = "0";
        private string sel19 = "0";
        private string sel20 = "0";
        private string sel21 = "0";
        private string sel22 = "0";
        private string sel23 = "0";
        private string sel24 = "0";
        private string sel25 = "0";

        public dev_theme_chooser()
        {
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        private void dev_theme_chooser_Load(object sender, EventArgs e)
        {
            MessageBox.Show("FOUND: " + Directory.GetDirectories(Application.StartupPath + "\\Common\\Themes"));
        }

        private void pcs_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pcs_MouseHover(object sender, EventArgs e)
        {
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pcs_Click(object sender, EventArgs e)
        {
            sel = "1";
            pcs.Image = Properties.Resources.theme_choose_sel;
        }

        private void pcs_MouseHover_1(object sender, EventArgs e)
        {
            pcs.Image = Properties.Resources.theme_choosexcf;
        }

        private void pcs_MouseLeave_1(object sender, EventArgs e)
        {
            if (sel == "1")
            {
                pcs.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs.Image = Properties.Resources.clear;
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pcs_2_MouseHover(object sender, EventArgs e)
        {
            if (sel2 == "1")
            {
                pcs_2.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_2.Image = Properties.Resources.clear;
            }
        }

        private void pcs_2_MouseLeave(object sender, EventArgs e)
        {
            pcs_2.Image = Properties.Resources.clear;
        }

        private void pcs_3_MouseHover(object sender, EventArgs e)
        {
            if (sel3 == "1")
            {
                pcs_3.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_3.Image = Properties.Resources.clear;
            }
        }

        private void pcs_3_MouseLeave(object sender, EventArgs e)
        {
            pcs_3.Image = Properties.Resources.clear;
        }

        private void pcs_4_MouseHover(object sender, EventArgs e)
        {
            if (sel4 == "1")
            {
                pcs_4.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_4.Image = Properties.Resources.clear;
            }
        }

        private void pcs_4_MouseLeave(object sender, EventArgs e)
        {
            pcs_4.Image = Properties.Resources.clear;
        }

        private void pcs_5_MouseHover(object sender, EventArgs e)
        {
            if (sel5 == "1")
            {
                pcs_5.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_5.Image = Properties.Resources.clear;
            }
        }

        private void pcs_5_MouseLeave(object sender, EventArgs e)
        {
            pcs_5.Image = Properties.Resources.clear;
        }

        private void pcs_6_MouseHover(object sender, EventArgs e)
        {
            if (sel6 == "1")
            {
                pcs_6.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_6.Image = Properties.Resources.clear;
            }
        }

        private void pcs_6_MouseLeave(object sender, EventArgs e)
        {
            pcs_6.Image = Properties.Resources.clear;
        }

        private void pcs_7_MouseHover(object sender, EventArgs e)
        {
            if (sel7 == "1")
            {
                pcs_7.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_7.Image = Properties.Resources.clear;
            }
        }

        private void pcs_7_MouseLeave(object sender, EventArgs e)
        {
            pcs_7.Image = Properties.Resources.clear;
        }

        private void pcs_8_MouseHover(object sender, EventArgs e)
        {
            if (sel8 == "1")
            {
                pcs_8.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_8.Image = Properties.Resources.clear;
            }
        }

        private void pcs_8_MouseLeave(object sender, EventArgs e)
        {
            pcs_8.Image = Properties.Resources.clear;
        }

        private void pcs_9_MouseHover(object sender, EventArgs e)
        {
            if (sel9 == "1")
            {
                pcs_9.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_9.Image = Properties.Resources.clear;
            }
        }

        private void pcs_9_MouseLeave(object sender, EventArgs e)
        {
            pcs_9.Image = Properties.Resources.clear;
        }

        private void pcs_10_MouseHover(object sender, EventArgs e)
        {
            if (sel10 == "1")
            {
                pcs_10.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_10.Image = Properties.Resources.clear;
            }
        }

        private void pcs_10_MouseLeave(object sender, EventArgs e)
        {
            pcs_10.Image = Properties.Resources.clear;
        }

        private void pcs_11_MouseHover(object sender, EventArgs e)
        {
            if (sel11 == "1")
            {
                pcs_11.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_11.Image = Properties.Resources.clear;
            }
        }

        private void pcs_11_MouseLeave(object sender, EventArgs e)
        {
            pcs_11.Image = Properties.Resources.clear;
        }

        private void pcs_12_MouseHover(object sender, EventArgs e)
        {
            if (sel12 == "1")
            {
                pcs_12.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_12.Image = Properties.Resources.clear;
            }
        }

        private void pcs_12_MouseLeave(object sender, EventArgs e)
        {
            pcs_12.Image = Properties.Resources.clear;
        }

        private void pcs_13_MouseHover(object sender, EventArgs e)
        {
            if (sel13 == "1")
            {
                pcs_13.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_13.Image = Properties.Resources.clear;
            }
        }

        private void pcs_13_MouseLeave(object sender, EventArgs e)
        {
            pcs_13.Image = Properties.Resources.clear;
        }

        private void pcs_14_MouseHover(object sender, EventArgs e)
        {
            if (sel14 == "1")
            {
                pcs_14.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_14.Image = Properties.Resources.clear;
            }
        }

        private void pcs_14_MouseLeave(object sender, EventArgs e)
        {
            pcs_14.Image = Properties.Resources.clear;
        }

        private void pcs_15_MouseHover(object sender, EventArgs e)
        {
            if (sel15 == "1")
            {
                pcs_15.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_15.Image = Properties.Resources.clear;
            }
        }

        private void pcs_15_MouseLeave(object sender, EventArgs e)
        {
            pcs_15.Image = Properties.Resources.clear;
        }

        private void pcs_16_MouseHover(object sender, EventArgs e)
        {
            if (sel16 == "1")
            {
                pcs_16.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_16.Image = Properties.Resources.clear;
            }
        }

        private void pcs_16_MouseLeave(object sender, EventArgs e)
        {
            pcs_16.Image = Properties.Resources.clear;
        }

        private void pcs_17_MouseHover(object sender, EventArgs e)
        {
            if (sel17 == "1")
            {
                pcs_17.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_17.Image = Properties.Resources.clear;
            }
        }

        private void pcs_17_MouseLeave(object sender, EventArgs e)
        {
            pcs_17.Image = Properties.Resources.clear;
        }

        private void pcs_18_MouseHover(object sender, EventArgs e)
        {
            if (sel18 == "1")
            {
                pcs_18.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_18.Image = Properties.Resources.clear;
            }
        }

        private void pcs_18_MouseLeave(object sender, EventArgs e)
        {
            pcs_18.Image = Properties.Resources.clear;
        }

        private void pcs_19_MouseHover(object sender, EventArgs e)
        {
            if (sel19 == "1")
            {
                pcs_19.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_19.Image = Properties.Resources.clear;
            }
        }

        private void pcs_19_MouseLeave(object sender, EventArgs e)
        {
            pcs_19.Image = Properties.Resources.clear;
        }

        private void pcs_20_MouseHover(object sender, EventArgs e)
        {
            if (sel20 == "1")
            {
                pcs_20.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_20.Image = Properties.Resources.clear;
            }
        }

        private void pcs_20_MouseLeave(object sender, EventArgs e)
        {
            pcs_20.Image = Properties.Resources.clear;
        }

        private void pcs_21_MouseHover(object sender, EventArgs e)
        {
            if (sel21 == "1")
            {
                pcs_21.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_21.Image = Properties.Resources.clear;
            }
        }

        private void pcs_21_MouseLeave(object sender, EventArgs e)
        {
            pcs_21.Image = Properties.Resources.clear;
        }

        private void pcs_22_MouseHover(object sender, EventArgs e)
        {
            if (sel22 == "1")
            {
                pcs_22.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_22.Image = Properties.Resources.clear;
            }
        }

        private void pcs_22_MouseLeave(object sender, EventArgs e)
        {
            pcs_22.Image = Properties.Resources.clear;
        }

        private void pcs_23_MouseHover(object sender, EventArgs e)
        {
            if (sel23 == "1")
            {
                pcs_23.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_23.Image = Properties.Resources.clear;
            }
        }

        private void pcs_23_MouseLeave(object sender, EventArgs e)
        {
            pcs_23.Image = Properties.Resources.clear;
        }

        private void pcs_24_MouseHover(object sender, EventArgs e)
        {
            if (sel24 == "1")
            {
                pcs_24.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_24.Image = Properties.Resources.clear;
            }
        }

        private void pcs_24_MouseLeave(object sender, EventArgs e)
        {
            pcs_24.Image = Properties.Resources.clear;
        }

        private void pcs_25_MouseHover(object sender, EventArgs e)
        {
            if (sel25 == "1")
            {
                pcs_25.Image = Properties.Resources.theme_choose_sel;
            }
            else
            {
                pcs_25.Image = Properties.Resources.clear;
            }
        }

        private void pcs_25_MouseLeave(object sender, EventArgs e)
        {
            pcs_25.Image = Properties.Resources.clear;
        }
    }
}