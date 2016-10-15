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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_properties));
            this.btn_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.chck_upd = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_grab = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_clean = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_dev = new MaterialSkin.Controls.MaterialCheckBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Depth = 0;
            this.btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_save.Location = new System.Drawing.Point(350, 341);
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
            this.chck_grab.Size = new System.Drawing.Size(237, 30);
            this.chck_grab.TabIndex = 13;
            this.chck_grab.Text = "Grab homebrew Nighlies/BETA\'s?";
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
            // dev_properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 379);
            this.ControlBox = false;
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
    }
}