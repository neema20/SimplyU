namespace SimplyU
{
    partial class dev_about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_about));
            this.btn_close = new MaterialSkin.Controls.MaterialFlatButton();
            this.pcx_logo = new System.Windows.Forms.PictureBox();
            this.pcx_avatar = new System.Windows.Forms.PictureBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.dev_license = new System.Windows.Forms.TextBox();
            this.btn_cont = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_me = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcx_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AutoSize = true;
            this.btn_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_close.Depth = 0;
            this.btn_close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_close.Location = new System.Drawing.Point(410, 443);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_close.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_close.Name = "btn_close";
            this.btn_close.Primary = false;
            this.btn_close.Size = new System.Drawing.Size(54, 36);
            this.btn_close.TabIndex = 12;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pcx_logo
            // 
            this.pcx_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcx_logo.Location = new System.Drawing.Point(192, 84);
            this.pcx_logo.Name = "pcx_logo";
            this.pcx_logo.Size = new System.Drawing.Size(272, 123);
            this.pcx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcx_logo.TabIndex = 0;
            this.pcx_logo.TabStop = false;
            // 
            // pcx_avatar
            // 
            this.pcx_avatar.BackgroundImage = global::SimplyU.Properties.Resources.avatar;
            this.pcx_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcx_avatar.Image = global::SimplyU.Properties.Resources.theme_choose_sel;
            this.pcx_avatar.Location = new System.Drawing.Point(12, 84);
            this.pcx_avatar.Name = "pcx_avatar";
            this.pcx_avatar.Size = new System.Drawing.Size(137, 123);
            this.pcx_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcx_avatar.TabIndex = 0;
            this.pcx_avatar.TabStop = false;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(12, 224);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(202, 25);
            this.lbl_header.TabIndex = 13;
            this.lbl_header.Text = "About SimpliiU %VER%:\r\n";
            // 
            // dev_license
            // 
            this.dev_license.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dev_license.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dev_license.Location = new System.Drawing.Point(12, 266);
            this.dev_license.Multiline = true;
            this.dev_license.Name = "dev_license";
            this.dev_license.ReadOnly = true;
            this.dev_license.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dev_license.Size = new System.Drawing.Size(452, 168);
            this.dev_license.TabIndex = 14;
            this.dev_license.Text = resources.GetString("dev_license.Text");
            this.dev_license.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cont
            // 
            this.btn_cont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cont.AutoSize = true;
            this.btn_cont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cont.Depth = 0;
            this.btn_cont.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cont.Location = new System.Drawing.Point(384, 443);
            this.btn_cont.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cont.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cont.Name = "btn_cont";
            this.btn_cont.Primary = false;
            this.btn_cont.Size = new System.Drawing.Size(79, 36);
            this.btn_cont.TabIndex = 15;
            this.btn_cont.Text = "continue";
            this.btn_cont.UseVisualStyleBackColor = true;
            this.btn_cont.Visible = false;
            this.btn_cont.Click += new System.EventHandler(this.btn_cont_Click);
            // 
            // lbl_me
            // 
            this.lbl_me.AutoSize = true;
            this.lbl_me.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_me.Location = new System.Drawing.Point(10, 70);
            this.lbl_me.Name = "lbl_me";
            this.lbl_me.Size = new System.Drawing.Size(77, 12);
            this.lbl_me.TabIndex = 16;
            this.lbl_me.Text = "Me (Dr.Hacknik):";
            // 
            // dev_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 481);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_me);
            this.Controls.Add(this.dev_license);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pcx_logo);
            this.Controls.Add(this.pcx_avatar);
            this.Controls.Add(this.btn_cont);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dev_about";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpliiU: About ";
            this.Load += new System.EventHandler(this.dev_about_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcx_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcx_avatar;
        private System.Windows.Forms.PictureBox pcx_logo;
        private MaterialSkin.Controls.MaterialFlatButton btn_close;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TextBox dev_license;
        private MaterialSkin.Controls.MaterialFlatButton btn_cont;
        private System.Windows.Forms.Label lbl_me;
    }
}