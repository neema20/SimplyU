namespace SimpliiU_Theme_Compiler
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btn_comp = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.txt_theme_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.txt_theme_author = new System.Windows.Forms.TextBox();
            this.lbl_bck_name = new System.Windows.Forms.Label();
            this.txt_bck_audio = new System.Windows.Forms.TextBox();
            this.lbl_audio_task_compl = new System.Windows.Forms.Label();
            this.txt_audio_task_compl = new System.Windows.Forms.TextBox();
            this.lbl_splash = new System.Windows.Forms.Label();
            this.txt_splash = new System.Windows.Forms.TextBox();
            this.lbl_icon_logo = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lbl_author_notes = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.chck_sign = new System.Windows.Forms.CheckBox();
            this.lbl_audio_credits = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_dest = new System.Windows.Forms.Label();
            this.txt_dest = new System.Windows.Forms.TextBox();
            this.btn_dest = new System.Windows.Forms.Button();
            this.sv_dest = new System.Windows.Forms.SaveFileDialog();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_comp
            // 
            this.btn_comp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_comp.Location = new System.Drawing.Point(491, 506);
            this.btn_comp.Name = "btn_comp";
            this.btn_comp.Size = new System.Drawing.Size(62, 28);
            this.btn_comp.TabIndex = 0;
            this.btn_comp.Text = "Compile";
            this.btn_comp.UseVisualStyleBackColor = true;
            this.btn_comp.Click += new System.EventHandler(this.btn_comp_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImage = global::SimpliiU_Theme_Compiler.Properties.Resources.SimplyU_Full_Logo_theme;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_logo.Location = new System.Drawing.Point(3, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(236, 138);
            this.pic_logo.TabIndex = 1;
            this.pic_logo.TabStop = false;
            // 
            // txt_theme_name
            // 
            this.txt_theme_name.Location = new System.Drawing.Point(3, 188);
            this.txt_theme_name.Name = "txt_theme_name";
            this.txt_theme_name.Size = new System.Drawing.Size(236, 20);
            this.txt_theme_name.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(0, 172);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(80, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Themes name: ";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(0, 225);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(81, 13);
            this.lbl_author.TabIndex = 5;
            this.lbl_author.Text = "Themes author:";
            // 
            // txt_theme_author
            // 
            this.txt_theme_author.Location = new System.Drawing.Point(3, 241);
            this.txt_theme_author.Name = "txt_theme_author";
            this.txt_theme_author.Size = new System.Drawing.Size(236, 20);
            this.txt_theme_author.TabIndex = 4;
            // 
            // lbl_bck_name
            // 
            this.lbl_bck_name.AutoSize = true;
            this.lbl_bck_name.Location = new System.Drawing.Point(0, 281);
            this.lbl_bck_name.Name = "lbl_bck_name";
            this.lbl_bck_name.Size = new System.Drawing.Size(143, 13);
            this.lbl_bck_name.TabIndex = 7;
            this.lbl_bck_name.Text = "Background Audio file name:";
            // 
            // txt_bck_audio
            // 
            this.txt_bck_audio.Location = new System.Drawing.Point(3, 297);
            this.txt_bck_audio.Name = "txt_bck_audio";
            this.txt_bck_audio.Size = new System.Drawing.Size(236, 20);
            this.txt_bck_audio.TabIndex = 6;
            // 
            // lbl_audio_task_compl
            // 
            this.lbl_audio_task_compl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_audio_task_compl.AutoSize = true;
            this.lbl_audio_task_compl.Location = new System.Drawing.Point(0, 333);
            this.lbl_audio_task_compl.Name = "lbl_audio_task_compl";
            this.lbl_audio_task_compl.Size = new System.Drawing.Size(165, 13);
            this.lbl_audio_task_compl.TabIndex = 9;
            this.lbl_audio_task_compl.Text = "Audio Task Completed file name: ";
            // 
            // txt_audio_task_compl
            // 
            this.txt_audio_task_compl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_audio_task_compl.Location = new System.Drawing.Point(3, 349);
            this.txt_audio_task_compl.Name = "txt_audio_task_compl";
            this.txt_audio_task_compl.Size = new System.Drawing.Size(236, 20);
            this.txt_audio_task_compl.TabIndex = 8;
            // 
            // lbl_splash
            // 
            this.lbl_splash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_splash.AutoSize = true;
            this.lbl_splash.Location = new System.Drawing.Point(0, 439);
            this.lbl_splash.Name = "lbl_splash";
            this.lbl_splash.Size = new System.Drawing.Size(90, 13);
            this.lbl_splash.TabIndex = 11;
            this.lbl_splash.Text = "Splash file name: ";
            // 
            // txt_splash
            // 
            this.txt_splash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_splash.Location = new System.Drawing.Point(3, 455);
            this.txt_splash.Name = "txt_splash";
            this.txt_splash.Size = new System.Drawing.Size(236, 20);
            this.txt_splash.TabIndex = 10;
            // 
            // lbl_icon_logo
            // 
            this.lbl_icon_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_icon_logo.AutoSize = true;
            this.lbl_icon_logo.Location = new System.Drawing.Point(260, 172);
            this.lbl_icon_logo.Name = "lbl_icon_logo";
            this.lbl_icon_logo.Size = new System.Drawing.Size(108, 13);
            this.lbl_icon_logo.TabIndex = 13;
            this.lbl_icon_logo.Text = "Icon (logo) file name: ";
            this.lbl_icon_logo.Click += new System.EventHandler(this.lbl_icon_logo_Click);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(263, 188);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(236, 20);
            this.textBox6.TabIndex = 12;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lbl_author_notes
            // 
            this.lbl_author_notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_author_notes.AutoSize = true;
            this.lbl_author_notes.Location = new System.Drawing.Point(260, 225);
            this.lbl_author_notes.Name = "lbl_author_notes";
            this.lbl_author_notes.Size = new System.Drawing.Size(73, 13);
            this.lbl_author_notes.TabIndex = 15;
            this.lbl_author_notes.Text = "Author notes: ";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(263, 241);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(236, 128);
            this.textBox7.TabIndex = 14;
            // 
            // chck_sign
            // 
            this.chck_sign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chck_sign.AutoSize = true;
            this.chck_sign.Checked = true;
            this.chck_sign.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chck_sign.Location = new System.Drawing.Point(3, 513);
            this.chck_sign.Name = "chck_sign";
            this.chck_sign.Size = new System.Drawing.Size(199, 17);
            this.chck_sign.TabIndex = 17;
            this.chck_sign.Text = "Sign the Theme (Security Checking) ";
            this.chck_sign.UseVisualStyleBackColor = true;
            // 
            // lbl_audio_credits
            // 
            this.lbl_audio_credits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_audio_credits.AutoSize = true;
            this.lbl_audio_credits.Location = new System.Drawing.Point(0, 384);
            this.lbl_audio_credits.Name = "lbl_audio_credits";
            this.lbl_audio_credits.Size = new System.Drawing.Size(120, 13);
            this.lbl_audio_credits.TabIndex = 19;
            this.lbl_audio_credits.Text = "Audio Credits file name: ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(3, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 18;
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.Location = new System.Drawing.Point(423, 506);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(62, 28);
            this.btn_reset.TabIndex = 20;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(356, 514);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(66, 13);
            this.lbl_status.TabIndex = 21;
            this.lbl_status.Text = "%STATUS%";
            this.lbl_status.Visible = false;
            // 
            // lbl_dest
            // 
            this.lbl_dest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dest.AutoSize = true;
            this.lbl_dest.Location = new System.Drawing.Point(260, 439);
            this.lbl_dest.Name = "lbl_dest";
            this.lbl_dest.Size = new System.Drawing.Size(82, 13);
            this.lbl_dest.TabIndex = 23;
            this.lbl_dest.Text = "Destination File:";
            // 
            // txt_dest
            // 
            this.txt_dest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dest.Location = new System.Drawing.Point(263, 455);
            this.txt_dest.Name = "txt_dest";
            this.txt_dest.Size = new System.Drawing.Size(236, 20);
            this.txt_dest.TabIndex = 22;
            // 
            // btn_dest
            // 
            this.btn_dest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dest.Location = new System.Drawing.Point(505, 455);
            this.btn_dest.Name = "btn_dest";
            this.btn_dest.Size = new System.Drawing.Size(48, 20);
            this.btn_dest.TabIndex = 24;
            this.btn_dest.Text = "...";
            this.btn_dest.UseVisualStyleBackColor = true;
            this.btn_dest.Click += new System.EventHandler(this.btn_dest_Click);
            // 
            // sv_dest
            // 
            this.sv_dest.DefaultExt = "ph";
            this.sv_dest.Filter = "Packed Theme File|*.ph|Zip File|*.zip|Any File|*";
            this.sv_dest.Title = "Save Theme as: ";
            this.sv_dest.FileOk += new System.ComponentModel.CancelEventHandler(this.sv_dest_FileOk);
            // 
            // lbl_ver
            // 
            this.lbl_ver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Location = new System.Drawing.Point(487, 9);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(48, 13);
            this.lbl_ver.TabIndex = 25;
            this.lbl_ver.Text = "Version: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 65);
            this.label1.TabIndex = 26;
            this.label1.Text = "Place the audio file and image files within\r\nthe \\Common\\Temp folder. The applica" +
    "tion \r\nwill handle the files from there. \r\nMake sure that the file names match t" +
    "he ones \r\nthat you enter here. ";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.btn_dest);
            this.Controls.Add(this.lbl_dest);
            this.Controls.Add(this.txt_dest);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_audio_credits);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chck_sign);
            this.Controls.Add(this.lbl_author_notes);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.lbl_icon_logo);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lbl_splash);
            this.Controls.Add(this.txt_splash);
            this.Controls.Add(this.lbl_audio_task_compl);
            this.Controls.Add(this.txt_audio_task_compl);
            this.Controls.Add(this.lbl_bck_name);
            this.Controls.Add(this.txt_bck_audio);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.txt_theme_author);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_theme_name);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_comp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpliiU: Theme Compiler";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_comp;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.TextBox txt_theme_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.TextBox txt_theme_author;
        private System.Windows.Forms.Label lbl_bck_name;
        private System.Windows.Forms.TextBox txt_bck_audio;
        private System.Windows.Forms.Label lbl_audio_task_compl;
        private System.Windows.Forms.TextBox txt_audio_task_compl;
        private System.Windows.Forms.Label lbl_splash;
        private System.Windows.Forms.TextBox txt_splash;
        private System.Windows.Forms.Label lbl_icon_logo;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lbl_author_notes;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckBox chck_sign;
        private System.Windows.Forms.Label lbl_audio_credits;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_dest;
        private System.Windows.Forms.TextBox txt_dest;
        private System.Windows.Forms.Button btn_dest;
        private System.Windows.Forms.SaveFileDialog sv_dest;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.Label label1;
    }
}

