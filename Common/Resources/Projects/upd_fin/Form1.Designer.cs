namespace upd_fin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic_splash = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dev_upd = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_splash
            // 
            this.pic_splash.BackColor = System.Drawing.Color.White;
            this.pic_splash.BackgroundImage = global::upd_fin.Properties.Resources.SimplyU_Full_Logo;
            this.pic_splash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_splash.Location = new System.Drawing.Point(-2, 64);
            this.pic_splash.Name = "pic_splash";
            this.pic_splash.Size = new System.Drawing.Size(198, 173);
            this.pic_splash.TabIndex = 0;
            this.pic_splash.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "We\'re updating your SimpliiU Experience...";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Updating SimpliiU: ";
            // 
            // dev_upd
            // 
            this.dev_upd.Enabled = true;
            this.dev_upd.Interval = 3000;
            this.dev_upd.Tick += new System.EventHandler(this.dev_upd_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 236);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_splash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpliiU: Updating...";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_splash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer dev_upd;
    }
}

