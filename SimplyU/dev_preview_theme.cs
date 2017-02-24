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
    public partial class dev_preview_theme : MaterialForm
    {
        public dev_preview_theme()
        {
            InitializeComponent();
        }

        private void dev_preview_theme_Load(object sender, EventArgs e)
        {
            try
            {
                pcx_panel.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\img\\pnl_back.png");
                pcx_logo.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\img\\SimplyU_Full_Logo.png");

                if (Properties.Settings.Default.dev_theme == "")
                {
                    pcx_color.BackColor = Color.LightSkyBlue;
                }

                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "blue")
                {
                    pcx_color.BackColor = Color.LightSkyBlue;
                }

                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "red")
                {
                    pcx_color.BackColor = Color.Red;
                }

                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "orange")
                {
                    pcx_color.BackColor = Color.Orange;
                }

                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "brown")
                {
                    pcx_color.BackColor = Color.Brown;
                }

                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "purple")
                {
                    pcx_color.BackColor = Color.Purple;
                }

                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "pink")
                {
                    pcx_color.BackColor = Color.Pink;
                }

                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "yellow")
                {
                    pcx_color.BackColor = Color.Yellow;
                }

                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "grey")
                {
                    pcx_color.BackColor = Color.Gray;
                }

                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "grey_red")
                {
                    pcx_color.BackColor = Color.Gray;
                }

                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "green")
                {
                    pcx_color.BackColor = Color.Green;
                }

                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "blue_red")
                {
                    pcx_color.BackColor = Color.LightSkyBlue;
                }
                if (File.ReadAllText(Application.StartupPath + "\\Common\\Themes\\" + Properties.Settings.Default.dev_theme_prev + "\\color.ini") == "blue_grey")
                {
                    pcx_color.BackColor = Color.Gray;
                }
            }
            catch
            {
                if (Properties.Settings.Default.dev_theme == "")
                {
                    Properties.Settings.Default.dev_theme = "Default";
                    Properties.Settings.Default.Save();
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("The theme that you have entered was NOT found! Please try again, and confirm that it's there. SimpliiU will now enter Fallback mode!", "SimpliiU: Properties --Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }
    }
}