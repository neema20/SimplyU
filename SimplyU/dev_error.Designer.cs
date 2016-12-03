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
            this.label1 = new System.Windows.Forms.Label();
            this.dev_log = new System.Windows.Forms.TextBox();
            this.lbl_build_status = new System.Windows.Forms.Label();
            this.pic_logo_state = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_state)).BeginInit();
            this.SuspendLayout();
            // 
            // dev_lbl_error
            // 
            this.dev_lbl_error.AutoSize = true;
            this.dev_lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.dev_lbl_error.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dev_lbl_error.Location = new System.Drawing.Point(110, 74);
            this.dev_lbl_error.Name = "dev_lbl_error";
            this.dev_lbl_error.Size = new System.Drawing.Size(166, 21);
            this.dev_lbl_error.TabIndex = 2;
            this.dev_lbl_error.Text = "An error has Occurred: ";
            this.dev_lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "During the \"%%\" section; a log dump\r\nhas been collected. Please review it, and fi" +
    "nd out what \r\nhas caused this Error, or you may submit it via GBATemp or \r\nGithu" +
    "b. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dev_log
            // 
            this.dev_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dev_log.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dev_log.Location = new System.Drawing.Point(12, 166);
            this.dev_log.Multiline = true;
            this.dev_log.Name = "dev_log";
            this.dev_log.ReadOnly = true;
            this.dev_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dev_log.Size = new System.Drawing.Size(434, 168);
            this.dev_log.TabIndex = 4;
            this.dev_log.Text = "%%";
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
            this.lbl_build_status.Size = new System.Drawing.Size(173, 15);
            this.lbl_build_status.TabIndex = 69;
            this.lbl_build_status.Text = "Development build_DEVERROR";
            this.lbl_build_status.Visible = false;
            // 
            // pic_logo_state
            // 
            this.pic_logo_state.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo_state.BackgroundImage = global::SimplyU.Properties.Resources.dev_error_logo;
            this.pic_logo_state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_logo_state.Location = new System.Drawing.Point(1, 65);
            this.pic_logo_state.Name = "pic_logo_state";
            this.pic_logo_state.Size = new System.Drawing.Size(103, 84);
            this.pic_logo_state.TabIndex = 0;
            this.pic_logo_state.TabStop = false;
            // 
            // dev_error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(458, 346);
            this.Controls.Add(this.lbl_build_status);
            this.Controls.Add(this.dev_log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dev_lbl_error);
            this.Controls.Add(this.pic_logo_state);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_error";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpliiU: Error";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dev_error_FormClosing);
            this.Load += new System.EventHandler(this.dev_error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_state)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo_state;
        private System.Windows.Forms.Label dev_lbl_error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dev_log;
        private System.Windows.Forms.Label lbl_build_status;
    }
}