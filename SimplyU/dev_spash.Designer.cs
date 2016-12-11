namespace SimplyU
{
    partial class dev_spash
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.dev_tmr = new System.Windows.Forms.Timer(this.components);
            this.lbl_build_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(0, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(989, 341);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Starting SimpliiU...";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dev_tmr
            // 
            this.dev_tmr.Enabled = true;
            this.dev_tmr.Interval = 2500;
            this.dev_tmr.Tick += new System.EventHandler(this.dev_tmr_Tick);
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
            this.lbl_build_status.Size = new System.Drawing.Size(181, 15);
            this.lbl_build_status.TabIndex = 70;
            this.lbl_build_status.Text = "Development build_DEVSPLASH";
            // 
            // dev_spash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SimplyU.Properties.Resources.pnl_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(989, 341);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_build_status);
            this.Controls.Add(this.lbl_header);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dev_spash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dev_spash";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.dev_spash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Timer dev_tmr;
        private System.Windows.Forms.Label lbl_build_status;
    }
}