namespace SimplyU
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_next = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pic_splash = new System.Windows.Forms.PictureBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 105);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.AutoSize = true;
            this.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_next.Depth = 0;
            this.btn_next.Location = new System.Drawing.Point(677, 434);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_next.Name = "btn_next";
            this.btn_next.Primary = false;
            this.btn_next.Size = new System.Drawing.Size(46, 36);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(517, 434);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(152, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "start self-hosting";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // pic_splash
            // 
            this.pic_splash.BackColor = System.Drawing.Color.Transparent;
            this.pic_splash.BackgroundImage = global::SimplyU.Properties.Resources.SimplyU_Full_Logo;
            this.pic_splash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_splash.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_splash.Location = new System.Drawing.Point(0, 0);
            this.pic_splash.Name = "pic_splash";
            this.pic_splash.Size = new System.Drawing.Size(736, 294);
            this.pic_splash.TabIndex = 0;
            this.pic_splash.TabStop = false;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(0, 325);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(736, 45);
            this.lbl_welcome.TabIndex = 5;
            this.lbl_welcome.Text = "Welcome to SimplyU: ";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(736, 475);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_splash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimplyU: Getting Started";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_splash;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton btn_next;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Label lbl_welcome;
    }
}

