namespace SimplyU
{
    partial class dev_guide_me
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_guide_me));
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_body = new System.Windows.Forms.Label();
            this.btn_fin = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_exploit = new System.Windows.Forms.Label();
            this.lbl_homebrew = new System.Windows.Forms.Label();
            this.lbl_dump = new System.Windows.Forms.Label();
            this.lbl_getting = new System.Windows.Forms.Label();
            this.lbl_howto = new System.Windows.Forms.RichTextBox();
            this.btn_run = new MaterialSkin.Controls.MaterialFlatButton();
            this.pcx_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(168, 77);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(595, 45);
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Text = "Welcome. Let\'s get you all setup shall we?";
            // 
            // lbl_body
            // 
            this.lbl_body.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_body.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_body.Location = new System.Drawing.Point(176, 122);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(568, 146);
            this.lbl_body.TabIndex = 1;
            this.lbl_body.Text = "First, we need to make sure your SD card is already setup.\r\nThen we\'ll setup your" +
    " Wii U with the exploit, and proceed to\r\nuse homebrew.";
            // 
            // btn_fin
            // 
            this.btn_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fin.AutoSize = true;
            this.btn_fin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_fin.Depth = 0;
            this.btn_fin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_fin.Location = new System.Drawing.Point(771, 610);
            this.btn_fin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_fin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_fin.Name = "btn_fin";
            this.btn_fin.Primary = false;
            this.btn_fin.Size = new System.Drawing.Size(55, 36);
            this.btn_fin.TabIndex = 13;
            this.btn_fin.Text = "finish";
            this.btn_fin.UseVisualStyleBackColor = true;
            this.btn_fin.Click += new System.EventHandler(this.btn_fin_Click);
            // 
            // lbl_exploit
            // 
            this.lbl_exploit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_exploit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_exploit.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exploit.Location = new System.Drawing.Point(7, 328);
            this.lbl_exploit.Name = "lbl_exploit";
            this.lbl_exploit.Size = new System.Drawing.Size(172, 37);
            this.lbl_exploit.TabIndex = 14;
            this.lbl_exploit.Text = "Running the Exploit";
            this.lbl_exploit.Click += new System.EventHandler(this.lbl_exploit_Click);
            // 
            // lbl_homebrew
            // 
            this.lbl_homebrew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_homebrew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_homebrew.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_homebrew.Location = new System.Drawing.Point(7, 365);
            this.lbl_homebrew.Name = "lbl_homebrew";
            this.lbl_homebrew.Size = new System.Drawing.Size(172, 37);
            this.lbl_homebrew.TabIndex = 14;
            this.lbl_homebrew.Text = "Running Homebrew";
            this.lbl_homebrew.Click += new System.EventHandler(this.lbl_homebrew_Click);
            // 
            // lbl_dump
            // 
            this.lbl_dump.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_dump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_dump.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dump.Location = new System.Drawing.Point(7, 402);
            this.lbl_dump.Name = "lbl_dump";
            this.lbl_dump.Size = new System.Drawing.Size(251, 37);
            this.lbl_dump.TabIndex = 14;
            this.lbl_dump.Text = "Dumping and Installing games";
            this.lbl_dump.Click += new System.EventHandler(this.lbl__Click);
            // 
            // lbl_getting
            // 
            this.lbl_getting.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_getting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_getting.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getting.Location = new System.Drawing.Point(7, 291);
            this.lbl_getting.Name = "lbl_getting";
            this.lbl_getting.Size = new System.Drawing.Size(159, 37);
            this.lbl_getting.TabIndex = 15;
            this.lbl_getting.Text = "Getting Homebrew";
            this.lbl_getting.Click += new System.EventHandler(this.lbl_getting_Click);
            // 
            // lbl_howto
            // 
            this.lbl_howto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_howto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_howto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_howto.Enabled = false;
            this.lbl_howto.Font = new System.Drawing.Font("Segoe UI Light", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_howto.Location = new System.Drawing.Point(264, 291);
            this.lbl_howto.Name = "lbl_howto";
            this.lbl_howto.ReadOnly = true;
            this.lbl_howto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lbl_howto.Size = new System.Drawing.Size(563, 310);
            this.lbl_howto.TabIndex = 16;
            this.lbl_howto.Text = "Click on a Topic to read it. ";
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.AutoSize = true;
            this.btn_run.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_run.Depth = 0;
            this.btn_run.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_run.Location = new System.Drawing.Point(641, 610);
            this.btn_run.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_run.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_run.Name = "btn_run";
            this.btn_run.Primary = false;
            this.btn_run.Size = new System.Drawing.Size(122, 36);
            this.btn_run.TabIndex = 17;
            this.btn_run.Text = "run the server";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // pcx_logo
            // 
            this.pcx_logo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcx_logo.BackgroundImage = global::SimplyU.Properties.Resources.New_Logo1;
            this.pcx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcx_logo.Location = new System.Drawing.Point(12, 77);
            this.pcx_logo.Name = "pcx_logo";
            this.pcx_logo.Size = new System.Drawing.Size(142, 124);
            this.pcx_logo.TabIndex = 0;
            this.pcx_logo.TabStop = false;
            // 
            // dev_guide_me
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(839, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.lbl_howto);
            this.Controls.Add(this.lbl_getting);
            this.Controls.Add(this.lbl_dump);
            this.Controls.Add(this.lbl_homebrew);
            this.Controls.Add(this.lbl_exploit);
            this.Controls.Add(this.btn_fin);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.pcx_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dev_guide_me";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpliiU: Guide me | Revision 0.2";
            this.Load += new System.EventHandler(this.dev_guide_me_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcx_logo;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_body;
        private MaterialSkin.Controls.MaterialFlatButton btn_fin;
        private System.Windows.Forms.Label lbl_exploit;
        private System.Windows.Forms.Label lbl_homebrew;
        private System.Windows.Forms.Label lbl_dump;
        private System.Windows.Forms.Label lbl_getting;
        private System.Windows.Forms.RichTextBox lbl_howto;
        private MaterialSkin.Controls.MaterialFlatButton btn_run;
    }
}