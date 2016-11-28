namespace SimplyU
{
    partial class dev_properties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_properties));
            this.btn_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.chck_upd = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_grab = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_clean = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_dev = new MaterialSkin.Controls.MaterialCheckBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_dev_mode = new System.Windows.Forms.Label();
            this.chck_music = new MaterialSkin.Controls.MaterialCheckBox();
            this.lbl_build_status = new System.Windows.Forms.Label();
            this.btn_cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.chck_ctheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.lbl_music = new System.Windows.Forms.Label();
            this.txt_theme = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chck_tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Depth = 0;
            this.btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_save.Location = new System.Drawing.Point(361, 583);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = false;
            this.btn_save.Size = new System.Drawing.Size(46, 36);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chck_upd
            // 
            this.chck_upd.AutoSize = true;
            this.chck_upd.Checked = true;
            this.chck_upd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chck_upd.Depth = 0;
            this.chck_upd.Enabled = false;
            this.chck_upd.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_upd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_upd.Location = new System.Drawing.Point(9, 120);
            this.chck_upd.Margin = new System.Windows.Forms.Padding(0);
            this.chck_upd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_upd.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_upd.Name = "chck_upd";
            this.chck_upd.Ripple = true;
            this.chck_upd.Size = new System.Drawing.Size(306, 30);
            this.chck_upd.TabIndex = 13;
            this.chck_upd.Text = "Check for Application Updates upon Startup?";
            this.chck_upd.UseVisualStyleBackColor = true;
            // 
            // chck_grab
            // 
            this.chck_grab.AutoSize = true;
            this.chck_grab.Depth = 0;
            this.chck_grab.Enabled = false;
            this.chck_grab.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_grab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_grab.Location = new System.Drawing.Point(9, 177);
            this.chck_grab.Margin = new System.Windows.Forms.Padding(0);
            this.chck_grab.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_grab.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_grab.Name = "chck_grab";
            this.chck_grab.Ripple = true;
            this.chck_grab.Size = new System.Drawing.Size(241, 30);
            this.chck_grab.TabIndex = 13;
            this.chck_grab.Text = "Grab homebrew Nightlies/BETA\'s?";
            this.chck_grab.UseVisualStyleBackColor = true;
            // 
            // chck_clean
            // 
            this.chck_clean.AutoSize = true;
            this.chck_clean.Depth = 0;
            this.chck_clean.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_clean.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_clean.Location = new System.Drawing.Point(9, 235);
            this.chck_clean.Margin = new System.Windows.Forms.Padding(0);
            this.chck_clean.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_clean.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_clean.Name = "chck_clean";
            this.chck_clean.Ripple = true;
            this.chck_clean.Size = new System.Drawing.Size(320, 30);
            this.chck_clean.TabIndex = 14;
            this.chck_clean.Text = "Cleanup Junk files after everything is Finished?";
            this.chck_clean.UseVisualStyleBackColor = true;
            // 
            // chck_dev
            // 
            this.chck_dev.AutoSize = true;
            this.chck_dev.Depth = 0;
            this.chck_dev.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_dev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_dev.Location = new System.Drawing.Point(9, 290);
            this.chck_dev.Margin = new System.Windows.Forms.Padding(0);
            this.chck_dev.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_dev.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_dev.Name = "chck_dev";
            this.chck_dev.Ripple = true;
            this.chck_dev.Size = new System.Drawing.Size(201, 30);
            this.chck_dev.TabIndex = 15;
            this.chck_dev.Text = "Enable Development Mode?";
            this.chck_dev.UseVisualStyleBackColor = true;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(5, 66);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(284, 40);
            this.lbl_header.TabIndex = 16;
            this.lbl_header.Text = "Note: Some of these settings don\'t work, yet.\r\nSo, they have been disabled (for n" +
    "ow). ";
            // 
            // lbl_dev_mode
            // 
            this.lbl_dev_mode.AutoSize = true;
            this.lbl_dev_mode.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dev_mode.Location = new System.Drawing.Point(12, 320);
            this.lbl_dev_mode.Name = "lbl_dev_mode";
            this.lbl_dev_mode.Size = new System.Drawing.Size(248, 52);
            this.lbl_dev_mode.TabIndex = 17;
            this.lbl_dev_mode.Text = resources.GetString("lbl_dev_mode.Text");
            // 
            // chck_music
            // 
            this.chck_music.AutoSize = true;
            this.chck_music.Depth = 0;
            this.chck_music.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_music.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_music.Location = new System.Drawing.Point(9, 384);
            this.chck_music.Margin = new System.Windows.Forms.Padding(0);
            this.chck_music.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_music.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_music.Name = "chck_music";
            this.chck_music.Ripple = true;
            this.chck_music.Size = new System.Drawing.Size(219, 30);
            this.chck_music.TabIndex = 18;
            this.chck_music.Text = "Play Music in the Background? ";
            this.chck_music.UseVisualStyleBackColor = true;
            // 
            // lbl_build_status
            // 
            this.lbl_build_status.AutoSize = true;
            this.lbl_build_status.BackColor = System.Drawing.Color.Black;
            this.lbl_build_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_build_status.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_build_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_build_status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_build_status.Location = new System.Drawing.Point(0, 0);
            this.lbl_build_status.Name = "lbl_build_status";
            this.lbl_build_status.Size = new System.Drawing.Size(167, 15);
            this.lbl_build_status.TabIndex = 69;
            this.lbl_build_status.Text = "Development build_DEVPROP";
            this.lbl_build_status.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancel.Location = new System.Drawing.Point(298, 583);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = false;
            this.btn_cancel.Size = new System.Drawing.Size(64, 36);
            this.btn_cancel.TabIndex = 70;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // chck_ctheme
            // 
            this.chck_ctheme.AutoSize = true;
            this.chck_ctheme.Depth = 0;
            this.chck_ctheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_ctheme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_ctheme.Location = new System.Drawing.Point(9, 438);
            this.chck_ctheme.Margin = new System.Windows.Forms.Padding(0);
            this.chck_ctheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_ctheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_ctheme.Name = "chck_ctheme";
            this.chck_ctheme.Ripple = true;
            this.chck_ctheme.Size = new System.Drawing.Size(225, 30);
            this.chck_ctheme.TabIndex = 71;
            this.chck_ctheme.Text = "Use Custom Theme and Music? ";
            this.chck_ctheme.UseVisualStyleBackColor = true;
            // 
            // lbl_theme
            // 
            this.lbl_theme.AutoSize = true;
            this.lbl_theme.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_theme.Location = new System.Drawing.Point(12, 493);
            this.lbl_theme.Name = "lbl_theme";
            this.lbl_theme.Size = new System.Drawing.Size(258, 91);
            this.lbl_theme.TabIndex = 72;
            this.lbl_theme.Text = resources.GetString("lbl_theme.Text");
            // 
            // lbl_music
            // 
            this.lbl_music.AutoSize = true;
            this.lbl_music.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_music.Location = new System.Drawing.Point(12, 414);
            this.lbl_music.Name = "lbl_music";
            this.lbl_music.Size = new System.Drawing.Size(156, 13);
            this.lbl_music.TabIndex = 73;
            this.lbl_music.Text = "May differ depending on theme.";
            // 
            // txt_theme
            // 
            this.txt_theme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_theme.Depth = 0;
            this.txt_theme.Hint = "Enter the Name of the Theme IE: Kill_la_Kill";
            this.txt_theme.Location = new System.Drawing.Point(15, 467);
            this.txt_theme.MaxLength = 32767;
            this.txt_theme.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_theme.Name = "txt_theme";
            this.txt_theme.PasswordChar = '\0';
            this.txt_theme.SelectedText = "";
            this.txt_theme.SelectionLength = 0;
            this.txt_theme.SelectionStart = 0;
            this.txt_theme.Size = new System.Drawing.Size(300, 23);
            this.txt_theme.TabIndex = 75;
            this.txt_theme.TabStop = false;
            this.txt_theme.UseSystemPasswordChar = false;
            // 
            // chck_tmr
            // 
            this.chck_tmr.Enabled = true;
            this.chck_tmr.Tick += new System.EventHandler(this.chck_tmr_Tick);
            // 
            // dev_properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 621);
            this.ControlBox = false;
            this.Controls.Add(this.txt_theme);
            this.Controls.Add(this.lbl_music);
            this.Controls.Add(this.lbl_theme);
            this.Controls.Add(this.chck_ctheme);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_build_status);
            this.Controls.Add(this.chck_music);
            this.Controls.Add(this.lbl_dev_mode);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.chck_dev);
            this.Controls.Add(this.chck_clean);
            this.Controls.Add(this.chck_grab);
            this.Controls.Add(this.chck_upd);
            this.Controls.Add(this.btn_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dev_properties";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpliiU: Properties";
            this.Load += new System.EventHandler(this.dev_properties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btn_save;
        private MaterialSkin.Controls.MaterialCheckBox chck_upd;
        private MaterialSkin.Controls.MaterialCheckBox chck_grab;
        private MaterialSkin.Controls.MaterialCheckBox chck_clean;
        private MaterialSkin.Controls.MaterialCheckBox chck_dev;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_dev_mode;
        private MaterialSkin.Controls.MaterialCheckBox chck_music;
        private System.Windows.Forms.Label lbl_build_status;
        private MaterialSkin.Controls.MaterialFlatButton btn_cancel;
        private MaterialSkin.Controls.MaterialCheckBox chck_ctheme;
        private System.Windows.Forms.Label lbl_theme;
        private System.Windows.Forms.Label lbl_music;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_theme;
        private System.Windows.Forms.Timer chck_tmr;
    }
}