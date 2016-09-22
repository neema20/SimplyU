namespace SimplyU
{
    partial class dev_upd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_upd));
            this.lbl_status = new System.Windows.Forms.Label();
            this.prg_1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.lbl_upd_desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.White;
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_status.Location = new System.Drawing.Point(0, 132);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(327, 21);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "%STATUS%";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_status.UseMnemonic = false;
            // 
            // prg_1
            // 
            this.prg_1.Depth = 0;
            this.prg_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prg_1.Location = new System.Drawing.Point(0, 127);
            this.prg_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.prg_1.Name = "prg_1";
            this.prg_1.Size = new System.Drawing.Size(327, 5);
            this.prg_1.TabIndex = 10;
            // 
            // lbl_upd_desc
            // 
            this.lbl_upd_desc.BackColor = System.Drawing.Color.White;
            this.lbl_upd_desc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_upd_desc.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upd_desc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_upd_desc.Location = new System.Drawing.Point(0, 78);
            this.lbl_upd_desc.Name = "lbl_upd_desc";
            this.lbl_upd_desc.Size = new System.Drawing.Size(327, 49);
            this.lbl_upd_desc.TabIndex = 11;
            this.lbl_upd_desc.Text = "Please wait...";
            this.lbl_upd_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dev_upd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 153);
            this.Controls.Add(this.lbl_upd_desc);
            this.Controls.Add(this.prg_1);
            this.Controls.Add(this.lbl_status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_upd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checking for Updates....";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.dev_upd_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_status;
        private MaterialSkin.Controls.MaterialProgressBar prg_1;
        private System.Windows.Forms.Label lbl_upd_desc;
    }
}