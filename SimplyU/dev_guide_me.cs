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

namespace SimplyU
{
    public partial class dev_guide_me : MaterialForm
    {
        private string cd = Application.StartupPath;

        public dev_guide_me()
        {
            InitializeComponent();
        }

        private void dev_guide_me_Load(object sender, EventArgs e)
        {
        }

        private void lbl_getting_Click(object sender, EventArgs e)
        {
            lbl_howto.Text = "Getting homebrew is quite simple. By reading this section, you should have already downloaded and installed the recommended homebrew onto your SDCard. \r\nYou should've already done this. Also, always make sure that your SDCard is formatted as FAT32. The Wii U cannot natively read SDCards formatted as NTFS, exFAT, etc. If you installed the recommended homebrew, please continue to the next section.";
        }

        private void btn_fin_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_close_now == "1")
            {
                Application.Exit();
            }
            else
            {
                Close();
            }
        }

        private void lbl_exploit_Click(object sender, EventArgs e)
        {
            lbl_howto.Text = "In order to run the exploit, you'll need to click the button below before doing anything. \r\nBefore you do that, I'll tell you how to do it. First off, run the Server exploit via this application, but there's other methods as well. I'd highly recommend you use other methods, such as going to loadiine.ovh on your Wii U. But, if you don't have Internet access on your Wii U. Then, this will be a good method. \r\nFirst, run the server via the button below. Then, go to your Wii U's internet browser. Now, edit two bookmarks; name on (kexploit10) and one (launcher). For the kexploit10 one, change it's URL to the IP v4 Address displayed in the server script, followed by (/hax?kexploit10). Do the same for the other Bookmark, but with (/hax?launcher). Then save them; now go to the kexploit10 bookmark, and you should see the exploit loading. Then, go back into the browser and tap the launcher bookmark; now the HBL should load. IF not, make sure everything is setup correctly. If you're having issues, use loadiine.ovh rather than this, it's far easier to use! ";
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient upd_src = new WebClient();
                File.Move(cd + "\\StartServer.bat", cd + "\\StartServer.bat.old");
                upd_src.DownloadFile(new Uri("https://github.com/zoltx23/SimplyU/blob/master/Common/Resources/Components/StartServer.bat?raw=true"), cd + "\\StartServer.bat");
            }
            catch
            {
                MessageBox.Show("It seems we weren't able to download the Latest Server script. But, we'll run the existing one anyways.", "dev_error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.Move(cd + "\\StartServer.bat.old", cd + "\\StartServer.bat");
            }

            Process.Start(cd + "\\StartServer.bat");
        }

        private void lbl_homebrew_Click(object sender, EventArgs e)
        {
            lbl_howto.Text = "Running homebrew is simple. Just load the exploit, and the homebrew launcher (Explained in Running the Exploit). There's already tons of Homebrew in the Wii U community, and it continues to grow. So, use SimpliiU to find what homebrew you want! \r\nWhen you run the homebrew launcher, you'll see you already have some homebrew ready for you! There's things like Loadiine (For loading Games from an SD Card), DDD (For dumping Games), Saviine (For Dumping savegames), and FTP client (For accessing your Wii U's SDCard over your Network), and you can get more Homebrew either with SimpliiU or the Wii U App-Store.";
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            lbl_howto.Text = "Dumping and Installing games is quite simple as well. Just load DDD for dumping games, insert your IP address (Of your PC; can be found by typing IPCONFIG in the CMD), and using DDD GUI (In the hosting folder). After that, just run the game or software you wish to dump, and tada! Installing games onto your System or USB drive is a bit more tedious though; all you need is a CFW (Custom Firmware). Although, if you don't want to use an 32GB or more SD card, and a EmuNAND. Just use Mocha CFW! It allows all, if not most, of the CFW Features, without an EMUNAND. So, you can remove signiture checks, allowing you to install custom software. To do so, use NUS Downloader U, or Wii U USB Tool, and place the Folder containing said install files on your SD Card in the (/install) folder. Then use WUP Installer (Use the Y-Mod version) and select said game/title and install it. Bam, isn't that so easy!";
        }
    }
}