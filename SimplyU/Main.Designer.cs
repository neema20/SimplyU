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
            this.btn_next = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.btn_prop = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pic_splash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.AutoSize = true;
            this.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_next.BackColor = System.Drawing.Color.White;
            this.btn_next.Depth = 0;
            this.btn_next.Location = new System.Drawing.Point(677, 434);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_next.Name = "btn_next";
            this.btn_next.Primary = false;
            this.btn_next.Size = new System.Drawing.Size(46, 36);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.White;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(517, 434);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(152, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "start self-hosting";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.BackColor = System.Drawing.Color.White;
            this.lbl_welcome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(0, 297);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(736, 51);
            this.lbl_welcome.TabIndex = 9;
            this.lbl_welcome.Text = "Welcome to SimpliiU\r\n";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ver
            // 
            this.lbl_ver.BackColor = System.Drawing.Color.White;
            this.lbl_ver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ver.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ver.Location = new System.Drawing.Point(0, 348);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(736, 22);
            this.lbl_ver.TabIndex = 8;
            this.lbl_ver.Text = "Release: ";
            this.lbl_ver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_desc
            // 
            this.lbl_desc.BackColor = System.Drawing.Color.White;
            this.lbl_desc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_desc.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(0, 370);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(736, 105);
            this.lbl_desc.TabIndex = 7;
            this.lbl_desc.Text = "This application will allow you to Setup an SD Card with Homebrew for the \r\nNinte" +
    "ndo Wii U, with little User Interaction. \r\n\r\nWe\'re not responsable for any \r\nDam" +
    "age done to your Wii U! ";
            this.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_prop
            // 
            this.btn_prop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_prop.AutoSize = true;
            this.btn_prop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prop.BackColor = System.Drawing.Color.White;
            this.btn_prop.Depth = 0;
            this.btn_prop.Location = new System.Drawing.Point(7, 434);
            this.btn_prop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_prop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_prop.Name = "btn_prop";
            this.btn_prop.Primary = false;
            this.btn_prop.Size = new System.Drawing.Size(92, 36);
            this.btn_prop.TabIndex = 11;
            this.btn_prop.Text = "properties";
            this.btn_prop.UseVisualStyleBackColor = false;
            this.btn_prop.Click += new System.EventHandler(this.btn_prop_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.Color.White;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(98, 434);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(101, 36);
            this.materialFlatButton2.TabIndex = 12;
            this.materialFlatButton2.Text = "view thread";
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // pic_splash
            // 
            this.pic_splash.BackColor = System.Drawing.Color.Transparent;
            this.pic_splash.BackgroundImage = global::SimplyU.Properties.Resources.SimplyU_Full_Logo;
            this.pic_splash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_splash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pic_splash.Location = new System.Drawing.Point(0, 69);
            this.pic_splash.Name = "pic_splash";
            this.pic_splash.Size = new System.Drawing.Size(736, 228);
            this.pic_splash.TabIndex = 10;
            this.pic_splash.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 475);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.btn_prop);
            this.Controls.Add(this.pic_splash);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.btn_next);
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
        private MaterialSkin.Controls.MaterialFlatButton btn_next;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.PictureBox pic_splash;
        private MaterialSkin.Controls.MaterialFlatButton btn_prop;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    }
}

