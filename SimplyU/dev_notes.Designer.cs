namespace SimplyU
{
    partial class dev_notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_notes));
            this.dev_terms = new System.Windows.Forms.TextBox();
            this.lbl_small_hd = new System.Windows.Forms.Label();
            this.dev_lbl_error = new System.Windows.Forms.Label();
            this.pic_logo_state = new System.Windows.Forms.PictureBox();
            this.btn_agree = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_no_agree = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_build_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_state)).BeginInit();
            this.SuspendLayout();
            // 
            // dev_terms
            // 
            this.dev_terms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dev_terms.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dev_terms.Location = new System.Drawing.Point(12, 154);
            this.dev_terms.Multiline = true;
            this.dev_terms.Name = "dev_terms";
            this.dev_terms.ReadOnly = true;
            this.dev_terms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dev_terms.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dev_terms.Size = new System.Drawing.Size(432, 235);
            this.dev_terms.TabIndex = 8;
            this.dev_terms.Text = resources.GetString("dev_terms.Text");
            // 
            // lbl_small_hd
            // 
            this.lbl_small_hd.AutoSize = true;
            this.lbl_small_hd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_small_hd.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_small_hd.Location = new System.Drawing.Point(110, 93);
            this.lbl_small_hd.Name = "lbl_small_hd";
            this.lbl_small_hd.Size = new System.Drawing.Size(207, 26);
            this.lbl_small_hd.TabIndex = 7;
            this.lbl_small_hd.Text = "Do you agree to the following terms below: \r\nIf not, the Application will close. " +
    "";
            this.lbl_small_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dev_lbl_error
            // 
            this.dev_lbl_error.AutoSize = true;
            this.dev_lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.dev_lbl_error.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dev_lbl_error.Location = new System.Drawing.Point(110, 72);
            this.dev_lbl_error.Name = "dev_lbl_error";
            this.dev_lbl_error.Size = new System.Drawing.Size(180, 21);
            this.dev_lbl_error.TabIndex = 6;
            this.dev_lbl_error.Text = "Please read the following:\r\n";
            this.dev_lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_logo_state
            // 
            this.pic_logo_state.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo_state.BackgroundImage = global::SimplyU.Properties.Resources.SimplyU_Logo;
            this.pic_logo_state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_logo_state.Location = new System.Drawing.Point(1, 72);
            this.pic_logo_state.Name = "pic_logo_state";
            this.pic_logo_state.Size = new System.Drawing.Size(103, 76);
            this.pic_logo_state.TabIndex = 5;
            this.pic_logo_state.TabStop = false;
            // 
            // btn_agree
            // 
            this.btn_agree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agree.AutoSize = true;
            this.btn_agree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_agree.Depth = 0;
            this.btn_agree.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_agree.Location = new System.Drawing.Point(382, 398);
            this.btn_agree.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_agree.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_agree.Name = "btn_agree";
            this.btn_agree.Primary = false;
            this.btn_agree.Size = new System.Drawing.Size(62, 36);
            this.btn_agree.TabIndex = 12;
            this.btn_agree.Text = "I agree";
            this.btn_agree.UseVisualStyleBackColor = true;
            this.btn_agree.Click += new System.EventHandler(this.btn_agree_Click);
            // 
            // btn_no_agree
            // 
            this.btn_no_agree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_no_agree.AutoSize = true;
            this.btn_no_agree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_no_agree.Depth = 0;
            this.btn_no_agree.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_no_agree.Location = new System.Drawing.Point(12, 398);
            this.btn_no_agree.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_no_agree.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_no_agree.Name = "btn_no_agree";
            this.btn_no_agree.Primary = false;
            this.btn_no_agree.Size = new System.Drawing.Size(104, 36);
            this.btn_no_agree.TabIndex = 13;
            this.btn_no_agree.Text = "I don\'t agree";
            this.btn_no_agree.UseVisualStyleBackColor = true;
            this.btn_no_agree.Click += new System.EventHandler(this.btn_no_agree_Click);
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
            this.lbl_build_status.Size = new System.Drawing.Size(167, 15);
            this.lbl_build_status.TabIndex = 70;
            this.lbl_build_status.Text = "Development build_DEVNOTE";
            // 
            // dev_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 435);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_build_status);
            this.Controls.Add(this.btn_no_agree);
            this.Controls.Add(this.btn_agree);
            this.Controls.Add(this.dev_terms);
            this.Controls.Add(this.lbl_small_hd);
            this.Controls.Add(this.dev_lbl_error);
            this.Controls.Add(this.pic_logo_state);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dev_notes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes: ";
            this.Load += new System.EventHandler(this.dev_notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_state)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dev_terms;
        private System.Windows.Forms.Label lbl_small_hd;
        private System.Windows.Forms.Label dev_lbl_error;
        private System.Windows.Forms.PictureBox pic_logo_state;
        private MaterialSkin.Controls.MaterialFlatButton btn_agree;
        private MaterialSkin.Controls.MaterialFlatButton btn_no_agree;
        private System.Windows.Forms.Label lbl_build_status;
    }
}