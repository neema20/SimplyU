namespace SimplyU
{
    partial class dev_prepare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_prepare));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.chck_rec = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_self = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_55b = new MaterialSkin.Controls.MaterialRadioButton();
            this.rd_54b = new MaterialSkin.Controls.MaterialRadioButton();
            this.rd_53b = new MaterialSkin.Controls.MaterialRadioButton();
            this.rd_52b = new MaterialSkin.Controls.MaterialRadioButton();
            this.lbl_fw = new MaterialSkin.Controls.MaterialLabel();
            this.btn_next = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.pic_splash = new System.Windows.Forms.PictureBox();
            this.dev_folder = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_target = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_target = new MaterialSkin.Controls.MaterialFlatButton();
            this.dev_target_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(3, 110);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(206, 45);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "Let\'s Prepare: ";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chck_rec
            // 
            this.chck_rec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chck_rec.AutoSize = true;
            this.chck_rec.Checked = true;
            this.chck_rec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chck_rec.Depth = 0;
            this.chck_rec.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_rec.Location = new System.Drawing.Point(11, 179);
            this.chck_rec.Margin = new System.Windows.Forms.Padding(0);
            this.chck_rec.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_rec.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_rec.Name = "chck_rec";
            this.chck_rec.Ripple = true;
            this.chck_rec.Size = new System.Drawing.Size(241, 30);
            this.chck_rec.TabIndex = 4;
            this.chck_rec.Text = "Install Recommended Homebrew? ";
            this.chck_rec.UseVisualStyleBackColor = true;
            // 
            // chck_self
            // 
            this.chck_self.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chck_self.AutoSize = true;
            this.chck_self.Depth = 0;
            this.chck_self.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_self.Location = new System.Drawing.Point(11, 238);
            this.chck_self.Margin = new System.Windows.Forms.Padding(0);
            this.chck_self.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_self.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_self.Name = "chck_self";
            this.chck_self.Ripple = true;
            this.chck_self.Size = new System.Drawing.Size(158, 30);
            this.chck_self.TabIndex = 5;
            this.chck_self.Text = "Enable Self-Hosting? ";
            this.chck_self.UseVisualStyleBackColor = true;
            // 
            // rd_55b
            // 
            this.rd_55b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rd_55b.AutoSize = true;
            this.rd_55b.Checked = true;
            this.rd_55b.Depth = 0;
            this.rd_55b.Font = new System.Drawing.Font("Roboto", 10F);
            this.rd_55b.Location = new System.Drawing.Point(11, 326);
            this.rd_55b.Margin = new System.Windows.Forms.Padding(0);
            this.rd_55b.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_55b.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_55b.Name = "rd_55b";
            this.rd_55b.Ripple = true;
            this.rd_55b.Size = new System.Drawing.Size(59, 30);
            this.rd_55b.TabIndex = 6;
            this.rd_55b.TabStop = true;
            this.rd_55b.Text = "5.5.x";
            this.rd_55b.UseVisualStyleBackColor = true;
            // 
            // rd_54b
            // 
            this.rd_54b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rd_54b.AutoSize = true;
            this.rd_54b.Depth = 0;
            this.rd_54b.Font = new System.Drawing.Font("Roboto", 10F);
            this.rd_54b.Location = new System.Drawing.Point(11, 356);
            this.rd_54b.Margin = new System.Windows.Forms.Padding(0);
            this.rd_54b.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_54b.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_54b.Name = "rd_54b";
            this.rd_54b.Ripple = true;
            this.rd_54b.Size = new System.Drawing.Size(59, 30);
            this.rd_54b.TabIndex = 7;
            this.rd_54b.Text = "5.4.x ";
            this.rd_54b.UseVisualStyleBackColor = true;
            // 
            // rd_53b
            // 
            this.rd_53b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rd_53b.AutoSize = true;
            this.rd_53b.Depth = 0;
            this.rd_53b.Font = new System.Drawing.Font("Roboto", 10F);
            this.rd_53b.Location = new System.Drawing.Point(11, 386);
            this.rd_53b.Margin = new System.Windows.Forms.Padding(0);
            this.rd_53b.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_53b.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_53b.Name = "rd_53b";
            this.rd_53b.Ripple = true;
            this.rd_53b.Size = new System.Drawing.Size(59, 30);
            this.rd_53b.TabIndex = 8;
            this.rd_53b.Text = "5.3.x ";
            this.rd_53b.UseVisualStyleBackColor = true;
            // 
            // rd_52b
            // 
            this.rd_52b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rd_52b.AutoSize = true;
            this.rd_52b.Depth = 0;
            this.rd_52b.Font = new System.Drawing.Font("Roboto", 10F);
            this.rd_52b.Location = new System.Drawing.Point(11, 416);
            this.rd_52b.Margin = new System.Windows.Forms.Padding(0);
            this.rd_52b.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_52b.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_52b.Name = "rd_52b";
            this.rd_52b.Ripple = true;
            this.rd_52b.Size = new System.Drawing.Size(59, 30);
            this.rd_52b.TabIndex = 9;
            this.rd_52b.Text = "5.2.x ";
            this.rd_52b.UseVisualStyleBackColor = true;
            // 
            // lbl_fw
            // 
            this.lbl_fw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_fw.AutoSize = true;
            this.lbl_fw.Depth = 0;
            this.lbl_fw.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_fw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_fw.Location = new System.Drawing.Point(12, 297);
            this.lbl_fw.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_fw.Name = "lbl_fw";
            this.lbl_fw.Size = new System.Drawing.Size(321, 19);
            this.lbl_fw.TabIndex = 10;
            this.lbl_fw.Text = "What Firmware Version is your Wii U Running? ";
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.AutoSize = true;
            this.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_next.Depth = 0;
            this.btn_next.Location = new System.Drawing.Point(677, 434);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_next.Name = "btn_next";
            this.btn_next.Primary = false;
            this.btn_next.Size = new System.Drawing.Size(46, 36);
            this.btn_next.TabIndex = 11;
            this.btn_next.Text = "next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(13, 209);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(338, 15);
            this.lbl_1.TabIndex = 12;
            this.lbl_1.Text = "This includes the HBL, Loadiine GX2, and other Related Homebrew.";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(13, 268);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(373, 15);
            this.lbl_2.TabIndex = 12;
            this.lbl_2.Text = "Self-Host via Java, your IP and Other Information will be Displayed for you!";
            // 
            // pic_splash
            // 
            this.pic_splash.BackColor = System.Drawing.Color.Transparent;
            this.pic_splash.BackgroundImage = global::SimplyU.Properties.Resources.SimpyU_Full_Logo;
            this.pic_splash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_splash.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_splash.Location = new System.Drawing.Point(0, 0);
            this.pic_splash.Name = "pic_splash";
            this.pic_splash.Size = new System.Drawing.Size(736, 107);
            this.pic_splash.TabIndex = 1;
            this.pic_splash.TabStop = false;
            // 
            // dev_folder
            // 
            this.dev_folder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.dev_folder.HelpRequest += new System.EventHandler(this.dev_folder_HelpRequest);
            // 
            // txt_target
            // 
            this.txt_target.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_target.Depth = 0;
            this.txt_target.Hint = "Target Folder";
            this.txt_target.Location = new System.Drawing.Point(11, 449);
            this.txt_target.MaxLength = 32767;
            this.txt_target.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_target.Name = "txt_target";
            this.txt_target.PasswordChar = '\0';
            this.txt_target.SelectedText = "";
            this.txt_target.SelectionLength = 0;
            this.txt_target.SelectionStart = 0;
            this.txt_target.Size = new System.Drawing.Size(340, 23);
            this.txt_target.TabIndex = 13;
            this.txt_target.TabStop = false;
            this.txt_target.UseSystemPasswordChar = false;
            // 
            // btn_target
            // 
            this.btn_target.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_target.AutoSize = true;
            this.btn_target.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_target.Depth = 0;
            this.btn_target.Location = new System.Drawing.Point(358, 436);
            this.btn_target.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_target.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_target.Name = "btn_target";
            this.btn_target.Primary = false;
            this.btn_target.Size = new System.Drawing.Size(23, 36);
            this.btn_target.TabIndex = 14;
            this.btn_target.Text = "...";
            this.btn_target.UseVisualStyleBackColor = true;
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // dev_target_timer
            // 
            this.dev_target_timer.Enabled = true;
            this.dev_target_timer.Tick += new System.EventHandler(this.dev_target_timer_Tick);
            // 
            // dev_prepare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(736, 475);
            this.Controls.Add(this.btn_target);
            this.Controls.Add(this.txt_target);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_fw);
            this.Controls.Add(this.rd_52b);
            this.Controls.Add(this.rd_53b);
            this.Controls.Add(this.rd_54b);
            this.Controls.Add(this.rd_55b);
            this.Controls.Add(this.chck_self);
            this.Controls.Add(this.chck_rec);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.pic_splash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_prepare";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimplyU: Let\'s Prepare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dev_prepare_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_splash;
        private System.Windows.Forms.Label lbl_welcome;
        private MaterialSkin.Controls.MaterialCheckBox chck_rec;
        private MaterialSkin.Controls.MaterialCheckBox chck_self;
        private MaterialSkin.Controls.MaterialRadioButton rd_55b;
        private MaterialSkin.Controls.MaterialRadioButton rd_54b;
        private MaterialSkin.Controls.MaterialRadioButton rd_53b;
        private MaterialSkin.Controls.MaterialRadioButton rd_52b;
        private MaterialSkin.Controls.MaterialLabel lbl_fw;
        private MaterialSkin.Controls.MaterialFlatButton btn_next;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.FolderBrowserDialog dev_folder;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_target;
        private MaterialSkin.Controls.MaterialFlatButton btn_target;
        private System.Windows.Forms.Timer dev_target_timer;
    }
}