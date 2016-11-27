namespace SimplyU
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbl_build_status = new System.Windows.Forms.Label();
            this.lbl_term = new System.Windows.Forms.Label();
            this.lbl_log = new System.Windows.Forms.Label();
            this.lbl_ac_rdnand = new System.Windows.Forms.Label();
            this.btn_view = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_prop = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.btn_self_host = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_next = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.pic_splash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).BeginInit();
            this.SuspendLayout();
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
            this.lbl_build_status.Size = new System.Drawing.Size(202, 15);
            this.lbl_build_status.TabIndex = 68;
            this.lbl_build_status.Text = "Development build_DEVMAIN_REV3";
            this.lbl_build_status.Visible = false;
            this.lbl_build_status.Click += new System.EventHandler(this.lbl_build_status_Click);
            // 
            // lbl_term
            // 
            this.lbl_term.AutoSize = true;
            this.lbl_term.BackColor = System.Drawing.Color.Black;
            this.lbl_term.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_term.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_term.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_term.ForeColor = System.Drawing.Color.Red;
            this.lbl_term.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_term.Location = new System.Drawing.Point(0, 15);
            this.lbl_term.Name = "lbl_term";
            this.lbl_term.Size = new System.Drawing.Size(85, 15);
            this.lbl_term.TabIndex = 69;
            this.lbl_term.Text = "ACCESS_TERM";
            this.lbl_term.Visible = false;
            this.lbl_term.Click += new System.EventHandler(this.lbl_term_Click);
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.BackColor = System.Drawing.Color.Black;
            this.lbl_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_log.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_log.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_log.ForeColor = System.Drawing.Color.Red;
            this.lbl_log.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_log.Location = new System.Drawing.Point(0, 30);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(77, 15);
            this.lbl_log.TabIndex = 70;
            this.lbl_log.Text = "ACCESS_LOG";
            this.lbl_log.Visible = false;
            this.lbl_log.Click += new System.EventHandler(this.lbl_log_Click);
            // 
            // lbl_ac_rdnand
            // 
            this.lbl_ac_rdnand.AutoSize = true;
            this.lbl_ac_rdnand.BackColor = System.Drawing.Color.Black;
            this.lbl_ac_rdnand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ac_rdnand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ac_rdnand.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_ac_rdnand.ForeColor = System.Drawing.Color.Red;
            this.lbl_ac_rdnand.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ac_rdnand.Location = new System.Drawing.Point(0, 45);
            this.lbl_ac_rdnand.Name = "lbl_ac_rdnand";
            this.lbl_ac_rdnand.Size = new System.Drawing.Size(97, 15);
            this.lbl_ac_rdnand.TabIndex = 71;
            this.lbl_ac_rdnand.Text = "ACCESS_RDDND";
            this.lbl_ac_rdnand.Visible = false;
            this.lbl_ac_rdnand.Click += new System.EventHandler(this.lbl_ac_rdnand_Click);
            // 
            // btn_view
            // 
            this.btn_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_view.AutoSize = true;
            this.btn_view.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_view.Depth = 0;
            this.btn_view.Location = new System.Drawing.Point(107, 430);
            this.btn_view.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_view.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_view.Name = "btn_view";
            this.btn_view.Primary = false;
            this.btn_view.Size = new System.Drawing.Size(101, 36);
            this.btn_view.TabIndex = 79;
            this.btn_view.Text = "view thread";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click_1);
            // 
            // btn_prop
            // 
            this.btn_prop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_prop.AutoSize = true;
            this.btn_prop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prop.BackColor = System.Drawing.Color.Transparent;
            this.btn_prop.Depth = 0;
            this.btn_prop.Location = new System.Drawing.Point(13, 430);
            this.btn_prop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_prop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_prop.Name = "btn_prop";
            this.btn_prop.Primary = false;
            this.btn_prop.Size = new System.Drawing.Size(92, 36);
            this.btn_prop.TabIndex = 78;
            this.btn_prop.Text = "properties";
            this.btn_prop.UseVisualStyleBackColor = false;
            this.btn_prop.Click += new System.EventHandler(this.btn_prop_Click_1);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.Black;
            this.lbl_welcome.Location = new System.Drawing.Point(0, 297);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(736, 51);
            this.lbl_welcome.TabIndex = 76;
            this.lbl_welcome.Text = "Welcome to SimpliiU\r\n";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ver
            // 
            this.lbl_ver.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ver.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ver.ForeColor = System.Drawing.Color.Black;
            this.lbl_ver.Location = new System.Drawing.Point(0, 348);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(736, 22);
            this.lbl_ver.TabIndex = 75;
            this.lbl_ver.Text = "Release: ";
            this.lbl_ver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ver.Click += new System.EventHandler(this.lbl_ver_Click);
            // 
            // btn_self_host
            // 
            this.btn_self_host.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_self_host.AutoSize = true;
            this.btn_self_host.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_self_host.BackColor = System.Drawing.Color.Transparent;
            this.btn_self_host.Depth = 0;
            this.btn_self_host.Location = new System.Drawing.Point(517, 430);
            this.btn_self_host.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_self_host.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_self_host.Name = "btn_self_host";
            this.btn_self_host.Primary = false;
            this.btn_self_host.Size = new System.Drawing.Size(152, 36);
            this.btn_self_host.TabIndex = 73;
            this.btn_self_host.Text = "start self-hosting";
            this.btn_self_host.UseVisualStyleBackColor = false;
            this.btn_self_host.Click += new System.EventHandler(this.btn_self_host_Click_1);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.AutoSize = true;
            this.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.Depth = 0;
            this.btn_next.Location = new System.Drawing.Point(677, 430);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_next.Name = "btn_next";
            this.btn_next.Primary = false;
            this.btn_next.Size = new System.Drawing.Size(46, 36);
            this.btn_next.TabIndex = 72;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_desc
            // 
            this.lbl_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_desc.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.ForeColor = System.Drawing.Color.Black;
            this.lbl_desc.Location = new System.Drawing.Point(0, 370);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(736, 105);
            this.lbl_desc.TabIndex = 74;
            this.lbl_desc.Text = resources.GetString("lbl_desc.Text");
            this.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_splash
            // 
            this.pic_splash.BackColor = System.Drawing.Color.Transparent;
            this.pic_splash.BackgroundImage = global::SimplyU.Properties.Resources.SimplyU_Full_Logo;
            this.pic_splash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_splash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pic_splash.Location = new System.Drawing.Point(0, 63);
            this.pic_splash.Name = "pic_splash";
            this.pic_splash.Size = new System.Drawing.Size(736, 234);
            this.pic_splash.TabIndex = 77;
            this.pic_splash.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 475);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_prop);
            this.Controls.Add(this.pic_splash);
            this.Controls.Add(this.btn_self_host);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_ac_rdnand);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.lbl_term);
            this.Controls.Add(this.lbl_build_status);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.lbl_desc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpliiU: Getting Started";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_build_status;
        private System.Windows.Forms.Label lbl_term;
        private System.Windows.Forms.Label lbl_log;
        private System.Windows.Forms.Label lbl_ac_rdnand;
        private MaterialSkin.Controls.MaterialFlatButton btn_view;
        private MaterialSkin.Controls.MaterialFlatButton btn_prop;
        private System.Windows.Forms.PictureBox pic_splash;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_ver;
        private MaterialSkin.Controls.MaterialFlatButton btn_self_host;
        private MaterialSkin.Controls.MaterialFlatButton btn_next;
        private System.Windows.Forms.Label lbl_desc;
    }
}

