namespace SimplyU
{
    partial class dev_hosting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_hosting));
            this.ipv4 = new System.Windows.Forms.Timer(this.components);
            this.lbl_stats = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipv4
            // 
            this.ipv4.Enabled = true;
            this.ipv4.Tick += new System.EventHandler(this.ipv4_Tick);
            // 
            // lbl_stats
            // 
            this.lbl_stats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_stats.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats.Location = new System.Drawing.Point(0, 25);
            this.lbl_stats.Name = "lbl_stats";
            this.lbl_stats.Size = new System.Drawing.Size(279, 28);
            this.lbl_stats.TabIndex = 5;
            this.lbl_stats.Text = "%STATS%";
            this.lbl_stats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    
            // 
            // lbl_ip
            // 
            this.lbl_ip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ip.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip.Location = new System.Drawing.Point(0, 53);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(279, 45);
            this.lbl_ip.TabIndex = 4;
            this.lbl_ip.Text = "%IP%";
            this.lbl_ip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dev_hosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(279, 98);
            this.Controls.Add(this.lbl_stats);
            this.Controls.Add(this.lbl_ip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dev_hosting";
            this.ShowInTaskbar = false;
            this.Text = "dev_hosting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dev_hosting_FormClosing);
            this.Load += new System.EventHandler(this.dev_hosting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ipv4;
        private System.Windows.Forms.Label lbl_stats;
        private System.Windows.Forms.Label lbl_ip;
    }
}