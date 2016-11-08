namespace SimplyU
{
    partial class dev_rednand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_rednand));
            this.btn_next = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_build_status = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.chck_c_fw = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_fw_cfw = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_syst = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_ = new MaterialSkin.Controls.MaterialCheckBox();
            this.btn_cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_target = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_target = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dev_drive = new System.Windows.Forms.FolderBrowserDialog();
            this.dev_target_timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_body = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.AutoSize = true;
            this.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_next.Depth = 0;
            this.btn_next.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_next.Location = new System.Drawing.Point(575, 464);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_next.Name = "btn_next";
            this.btn_next.Primary = false;
            this.btn_next.Size = new System.Drawing.Size(46, 36);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = "next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
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
            this.lbl_build_status.Size = new System.Drawing.Size(188, 15);
            this.lbl_build_status.TabIndex = 70;
            this.lbl_build_status.Text = "Development build_DEVRDNAND";
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(0, 64);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(624, 39);
            this.lbl_header.TabIndex = 71;
            this.lbl_header.Text = "Welcome to the RedNAND Setup.";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chck_c_fw
            // 
            this.chck_c_fw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chck_c_fw.AutoSize = true;
            this.chck_c_fw.Checked = true;
            this.chck_c_fw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chck_c_fw.Depth = 0;
            this.chck_c_fw.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_c_fw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_c_fw.Location = new System.Drawing.Point(3, 222);
            this.chck_c_fw.Margin = new System.Windows.Forms.Padding(0);
            this.chck_c_fw.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_c_fw.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_c_fw.Name = "chck_c_fw";
            this.chck_c_fw.Ripple = true;
            this.chck_c_fw.Size = new System.Drawing.Size(126, 30);
            this.chck_c_fw.TabIndex = 73;
            this.chck_c_fw.Text = "Create FW.img? \r\n";
            this.chck_c_fw.UseVisualStyleBackColor = true;
            // 
            // chck_fw_cfw
            // 
            this.chck_fw_cfw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chck_fw_cfw.AutoSize = true;
            this.chck_fw_cfw.Depth = 0;
            this.chck_fw_cfw.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_fw_cfw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_fw_cfw.Location = new System.Drawing.Point(3, 261);
            this.chck_fw_cfw.Margin = new System.Windows.Forms.Padding(0);
            this.chck_fw_cfw.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_fw_cfw.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_fw_cfw.Name = "chck_fw_cfw";
            this.chck_fw_cfw.Ripple = true;
            this.chck_fw_cfw.Size = new System.Drawing.Size(187, 30);
            this.chck_fw_cfw.TabIndex = 74;
            this.chck_fw_cfw.Text = "Bundle CFW into FW.img? \r\n";
            this.chck_fw_cfw.UseVisualStyleBackColor = true;
            // 
            // chck_syst
            // 
            this.chck_syst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chck_syst.AutoSize = true;
            this.chck_syst.Depth = 0;
            this.chck_syst.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_syst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_syst.Location = new System.Drawing.Point(3, 303);
            this.chck_syst.Margin = new System.Windows.Forms.Padding(0);
            this.chck_syst.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_syst.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_syst.Name = "chck_syst";
            this.chck_syst.Ripple = true;
            this.chck_syst.Size = new System.Drawing.Size(160, 30);
            this.chck_syst.TabIndex = 75;
            this.chck_syst.Text = "Install System Tools? \r\n";
            this.chck_syst.UseVisualStyleBackColor = true;
            // 
            // chck_
            // 
            this.chck_.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chck_.AutoSize = true;
            this.chck_.Depth = 0;
            this.chck_.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_.Location = new System.Drawing.Point(3, 342);
            this.chck_.Margin = new System.Windows.Forms.Padding(0);
            this.chck_.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_.Name = "chck_";
            this.chck_.Ripple = true;
            this.chck_.Size = new System.Drawing.Size(281, 30);
            this.chck_.TabIndex = 76;
            this.chck_.Text = "Patch eShop and block System Updates? \r\n";
            this.chck_.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancel.Location = new System.Drawing.Point(503, 464);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = false;
            this.btn_cancel.Size = new System.Drawing.Size(64, 36);
            this.btn_cancel.TabIndex = 77;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_target
            // 
            this.btn_target.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_target.AutoSize = true;
            this.btn_target.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_target.Depth = 0;
            this.btn_target.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_target.Location = new System.Drawing.Point(355, 464);
            this.btn_target.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_target.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_target.Name = "btn_target";
            this.btn_target.Primary = false;
            this.btn_target.Size = new System.Drawing.Size(23, 36);
            this.btn_target.TabIndex = 79;
            this.btn_target.Text = "...";
            this.btn_target.UseVisualStyleBackColor = true;
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // txt_target
            // 
            this.txt_target.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_target.Depth = 0;
            this.txt_target.Hint = "Target Drive";
            this.txt_target.Location = new System.Drawing.Point(3, 477);
            this.txt_target.MaxLength = 32767;
            this.txt_target.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_target.Name = "txt_target";
            this.txt_target.PasswordChar = '\0';
            this.txt_target.SelectedText = "";
            this.txt_target.SelectionLength = 0;
            this.txt_target.SelectionStart = 0;
            this.txt_target.Size = new System.Drawing.Size(340, 23);
            this.txt_target.TabIndex = 78;
            this.txt_target.TabStop = false;
            this.txt_target.UseSystemPasswordChar = false;
            // 
            // dev_drive
            // 
            this.dev_drive.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // dev_target_timer
            // 
            this.dev_target_timer.Enabled = true;
            this.dev_target_timer.Tick += new System.EventHandler(this.dev_target_timer_Tick);
            // 
            // lbl_body
            // 
            this.lbl_body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_body.BackColor = System.Drawing.Color.Transparent;
            this.lbl_body.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_body.Location = new System.Drawing.Point(0, 103);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(624, 116);
            this.lbl_body.TabIndex = 72;
            this.lbl_body.Text = "We\'ll help and guide you through the process of \r\ngetting RedNAND ready to go! We" +
    "\'ll also prepare everything\r\nas well.\r\n\r\nTo continue, select the following Optio" +
    "ns below: ";
            // 
            // dev_rednand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 500);
            this.ControlBox = false;
            this.Controls.Add(this.btn_target);
            this.Controls.Add(this.txt_target);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.chck_);
            this.Controls.Add(this.chck_syst);
            this.Controls.Add(this.chck_fw_cfw);
            this.Controls.Add(this.chck_c_fw);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.lbl_build_status);
            this.Controls.Add(this.btn_next);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_rednand";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpliiU: RedNAND Setup -- Rev0.1";
            this.Load += new System.EventHandler(this.dev_rednand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btn_next;
        private System.Windows.Forms.Label lbl_build_status;
        private System.Windows.Forms.Label lbl_header;
        private MaterialSkin.Controls.MaterialCheckBox chck_c_fw;
        private MaterialSkin.Controls.MaterialCheckBox chck_fw_cfw;
        private MaterialSkin.Controls.MaterialCheckBox chck_syst;
        private MaterialSkin.Controls.MaterialCheckBox chck_;
        private MaterialSkin.Controls.MaterialFlatButton btn_cancel;
        private MaterialSkin.Controls.MaterialFlatButton btn_target;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_target;
        private System.Windows.Forms.FolderBrowserDialog dev_drive;
        private System.Windows.Forms.Timer dev_target_timer;
        private System.Windows.Forms.Label lbl_body;
    }
}