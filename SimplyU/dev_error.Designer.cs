namespace SimplyU
{
    partial class dev_error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_error));
            this.dev_lbl_error = new System.Windows.Forms.Label();
            this.lbl_stat = new System.Windows.Forms.Label();
            this.dev_log = new System.Windows.Forms.TextBox();
            this.lbl_build_status = new System.Windows.Forms.Label();
            this.pic_logo_state = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_state)).BeginInit();
            this.SuspendLayout();
            // 
            // dev_lbl_error
            // 
            resources.ApplyResources(this.dev_lbl_error, "dev_lbl_error");
            this.dev_lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.dev_lbl_error.Name = "dev_lbl_error";
            // 
            // lbl_stat
            // 
            resources.ApplyResources(this.lbl_stat, "lbl_stat");
            this.lbl_stat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stat.Name = "lbl_stat";
            // 
            // dev_log
            // 
            resources.ApplyResources(this.dev_log, "dev_log");
            this.dev_log.Name = "dev_log";
            this.dev_log.ReadOnly = true;
            // 
            // lbl_build_status
            // 
            resources.ApplyResources(this.lbl_build_status, "lbl_build_status");
            this.lbl_build_status.BackColor = System.Drawing.Color.Black;
            this.lbl_build_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_build_status.Name = "lbl_build_status";
            // 
            // pic_logo_state
            // 
            this.pic_logo_state.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo_state.BackgroundImage = global::SimplyU.Properties.Resources.dev_error_logo;
            resources.ApplyResources(this.pic_logo_state, "pic_logo_state");
            this.pic_logo_state.Name = "pic_logo_state";
            this.pic_logo_state.TabStop = false;
            // 
            // dev_error
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lbl_build_status);
            this.Controls.Add(this.dev_log);
            this.Controls.Add(this.lbl_stat);
            this.Controls.Add(this.dev_lbl_error);
            this.Controls.Add(this.pic_logo_state);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_error";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dev_error_FormClosing);
            this.Load += new System.EventHandler(this.dev_error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_state)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo_state;
        private System.Windows.Forms.Label dev_lbl_error;
        private System.Windows.Forms.Label lbl_stat;
        private System.Windows.Forms.TextBox dev_log;
        private System.Windows.Forms.Label lbl_build_status;
    }
}