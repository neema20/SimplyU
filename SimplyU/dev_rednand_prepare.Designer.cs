namespace SimplyU
{
    partial class dev_rednand_prepare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_rednand_prepare));
            this.pnl = new System.Windows.Forms.Panel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_build_status = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackgroundImage = global::SimplyU.Properties.Resources.panel;
            this.pnl.Controls.Add(this.icon);
            this.pnl.Controls.Add(this.lbl_header);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl.Location = new System.Drawing.Point(0, 64);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(557, 352);
            this.pnl.TabIndex = 1;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImage = global::SimplyU.Properties.Resources.icon;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(557, 98);
            this.icon.TabIndex = 73;
            this.icon.TabStop = false;
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(0, 313);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(557, 39);
            this.lbl_header.TabIndex = 72;
            this.lbl_header.Text = "Please wait, we\'re getting things ready....";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.lbl_build_status.Size = new System.Drawing.Size(220, 15);
            this.lbl_build_status.TabIndex = 75;
            this.lbl_build_status.Text = "Development build_DEVRDNAND_PREP";
            // 
            // dev_rednand_prepare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimplyU.Properties.Resources.panel;
            this.ClientSize = new System.Drawing.Size(557, 416);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_build_status);
            this.Controls.Add(this.pnl);
            this.DoubleBuffered = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_rednand_prepare";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpliiU: RedNAND - Preparing";
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label lbl_build_status;
    }
}