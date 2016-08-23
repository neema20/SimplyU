namespace SimplyU
{
    partial class dev_grab_content
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
            this.lbl_pls_wait = new System.Windows.Forms.Label();
            this.lbl_ext_desc = new System.Windows.Forms.Label();
            this.lbl_content = new System.Windows.Forms.Label();
            this.prg_1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.wait = new System.Windows.Forms.Timer(this.components);
            this.dev_presto = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_pls_wait
            // 
            this.lbl_pls_wait.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_pls_wait.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pls_wait.Location = new System.Drawing.Point(0, 0);
            this.lbl_pls_wait.Name = "lbl_pls_wait";
            this.lbl_pls_wait.Size = new System.Drawing.Size(333, 45);
            this.lbl_pls_wait.TabIndex = 3;
            this.lbl_pls_wait.Text = "Please wait....";
            this.lbl_pls_wait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ext_desc
            // 
            this.lbl_ext_desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ext_desc.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ext_desc.Location = new System.Drawing.Point(0, 45);
            this.lbl_ext_desc.Name = "lbl_ext_desc";
            this.lbl_ext_desc.Size = new System.Drawing.Size(333, 21);
            this.lbl_ext_desc.TabIndex = 4;
            this.lbl_ext_desc.Text = "We\'re grabbing some Files for Setup";
            this.lbl_ext_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ext_desc.UseMnemonic = false;
            // 
            // lbl_content
            // 
            this.lbl_content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_content.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_content.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_content.Location = new System.Drawing.Point(0, 85);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(333, 21);
            this.lbl_content.TabIndex = 5;
            this.lbl_content.Text = "%CONTENT%";
            this.lbl_content.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_content.UseMnemonic = false;
            // 
            // prg_1
            // 
            this.prg_1.Depth = 0;
            this.prg_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prg_1.Location = new System.Drawing.Point(0, 80);
            this.prg_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.prg_1.Name = "prg_1";
            this.prg_1.Size = new System.Drawing.Size(333, 5);
            this.prg_1.TabIndex = 6;
            // 
            // wait
            // 
            this.wait.Enabled = true;
            this.wait.Tick += new System.EventHandler(this.wait_Tick);
            // 
            // dev_presto
            // 
            this.dev_presto.Interval = 5000;
            this.dev_presto.Tick += new System.EventHandler(this.dev_presto_Tick);
            // 
            // dev_grab_content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(333, 106);
            this.ControlBox = false;
            this.Controls.Add(this.prg_1);
            this.Controls.Add(this.lbl_content);
            this.Controls.Add(this.lbl_ext_desc);
            this.Controls.Add(this.lbl_pls_wait);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_grab_content";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dev_grab_content";
            this.Load += new System.EventHandler(this.dev_grab_content_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_pls_wait;
        private System.Windows.Forms.Label lbl_ext_desc;
        private System.Windows.Forms.Label lbl_content;
        private MaterialSkin.Controls.MaterialProgressBar prg_1;
        private System.Windows.Forms.Timer wait;
        private System.Windows.Forms.Timer dev_presto;
    }
}