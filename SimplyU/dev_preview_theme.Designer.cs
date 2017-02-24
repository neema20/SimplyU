namespace SimplyU
{
    partial class dev_preview_theme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_preview_theme));
            this.lbl_panel = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pcx_logo = new System.Windows.Forms.PictureBox();
            this.pcx_panel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcx_color = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcx_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcx_color)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_panel
            // 
            this.lbl_panel.AutoSize = true;
            this.lbl_panel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_panel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_panel.Location = new System.Drawing.Point(12, 76);
            this.lbl_panel.Name = "lbl_panel";
            this.lbl_panel.Size = new System.Drawing.Size(161, 21);
            this.lbl_panel.TabIndex = 1;
            this.lbl_panel.Text = "Splash Screen Preview:";
            // 
            // lbl_logo
            // 
            this.lbl_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(12, 282);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(107, 21);
            this.lbl_logo.TabIndex = 1;
            this.lbl_logo.Text = "Logo Preview: ";
            // 
            // pcx_logo
            // 
            this.pcx_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcx_logo.BackColor = System.Drawing.Color.Transparent;
            this.pcx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcx_logo.Location = new System.Drawing.Point(12, 306);
            this.pcx_logo.Name = "pcx_logo";
            this.pcx_logo.Size = new System.Drawing.Size(590, 156);
            this.pcx_logo.TabIndex = 0;
            this.pcx_logo.TabStop = false;
            // 
            // pcx_panel
            // 
            this.pcx_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcx_panel.BackColor = System.Drawing.Color.Transparent;
            this.pcx_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcx_panel.Location = new System.Drawing.Point(12, 100);
            this.pcx_panel.Name = "pcx_panel";
            this.pcx_panel.Size = new System.Drawing.Size(590, 156);
            this.pcx_panel.TabIndex = 0;
            this.pcx_panel.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color Preview: ";
            // 
            // pcx_color
            // 
            this.pcx_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcx_color.BackColor = System.Drawing.Color.Transparent;
            this.pcx_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcx_color.Location = new System.Drawing.Point(12, 500);
            this.pcx_color.Name = "pcx_color";
            this.pcx_color.Size = new System.Drawing.Size(48, 23);
            this.pcx_color.TabIndex = 0;
            this.pcx_color.TabStop = false;
            // 
            // dev_preview_theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(614, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_logo);
            this.Controls.Add(this.lbl_panel);
            this.Controls.Add(this.pcx_color);
            this.Controls.Add(this.pcx_logo);
            this.Controls.Add(this.pcx_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_preview_theme";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dev_preview_theme";
            this.Load += new System.EventHandler(this.dev_preview_theme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcx_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcx_color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcx_panel;
        private System.Windows.Forms.PictureBox pcx_logo;
        private System.Windows.Forms.Label lbl_panel;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcx_color;
    }
}