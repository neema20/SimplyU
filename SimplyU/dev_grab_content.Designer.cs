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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_grab_content));
            this.lbl_content = new System.Windows.Forms.Label();
            this.prg_1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.wait = new System.Windows.Forms.Timer(this.components);
            this.dev_presto = new System.Windows.Forms.Timer(this.components);
            this.fin = new System.Windows.Forms.Timer(this.components);
            this.prg_2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.lbl_ext_desc = new System.Windows.Forms.Label();
            this.dev_download = new System.Windows.Forms.Timer(this.components);
            this.audio_tmr = new System.Windows.Forms.Timer(this.components);
            this.bck_music = new AxWMPLib.AxWindowsMediaPlayer();
            this.cleanup = new System.Windows.Forms.Timer(this.components);
            this.lbl_build_status = new System.Windows.Forms.Label();
            this.dev_error = new System.Windows.Forms.Timer(this.components);
            this.dev_comp_chck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bck_music)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_content
            // 
            this.lbl_content.BackColor = System.Drawing.Color.White;
            this.lbl_content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_content.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_content.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_content.Location = new System.Drawing.Point(0, 136);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(353, 21);
            this.lbl_content.TabIndex = 5;
            this.lbl_content.Text = "%CONTENT%";
            this.lbl_content.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_content.UseMnemonic = false;
            // 
            // prg_1
            // 
            this.prg_1.Depth = 0;
            this.prg_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prg_1.Location = new System.Drawing.Point(0, 131);
            this.prg_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.prg_1.Name = "prg_1";
            this.prg_1.Size = new System.Drawing.Size(353, 5);
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
            // fin
            // 
            this.fin.Tick += new System.EventHandler(this.fin_Tick);
            // 
            // prg_2
            // 
            this.prg_2.Depth = 0;
            this.prg_2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prg_2.Location = new System.Drawing.Point(0, 126);
            this.prg_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.prg_2.Name = "prg_2";
            this.prg_2.Size = new System.Drawing.Size(353, 5);
            this.prg_2.TabIndex = 8;
            // 
            // lbl_ext_desc
            // 
            this.lbl_ext_desc.BackColor = System.Drawing.Color.White;
            this.lbl_ext_desc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ext_desc.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ext_desc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ext_desc.Location = new System.Drawing.Point(0, 77);
            this.lbl_ext_desc.Name = "lbl_ext_desc";
            this.lbl_ext_desc.Size = new System.Drawing.Size(353, 49);
            this.lbl_ext_desc.TabIndex = 9;
            this.lbl_ext_desc.Text = "Please wait...";
            this.lbl_ext_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ext_desc.Click += new System.EventHandler(this.lbl_ext_desc_Click_1);
            // 
            // dev_download
            // 
            this.dev_download.Enabled = true;
            this.dev_download.Interval = 10;
            // 
            // audio_tmr
            // 
            this.audio_tmr.Interval = 7000;
            this.audio_tmr.Tick += new System.EventHandler(this.audio_tmr_Tick);
            // 
            // bck_music
            // 
            this.bck_music.Enabled = true;
            this.bck_music.Location = new System.Drawing.Point(278, 22);
            this.bck_music.Name = "bck_music";
            this.bck_music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bck_music.OcxState")));
            this.bck_music.Size = new System.Drawing.Size(75, 23);
            this.bck_music.TabIndex = 16;
            this.bck_music.Visible = false;
            // 
            // cleanup
            // 
            this.cleanup.Interval = 10;
            this.cleanup.Tick += new System.EventHandler(this.cleanup_Tick);
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
            this.lbl_build_status.TabIndex = 69;
            this.lbl_build_status.Text = "Development build_DEVGRAB";
            this.lbl_build_status.Visible = false;
            // 
            // dev_error
            // 
            this.dev_error.Interval = 5000;
            this.dev_error.Tick += new System.EventHandler(this.dev_error_Tick);
            // 
            // dev_comp_chck
            // 
            this.dev_comp_chck.Interval = 10;
            this.dev_comp_chck.Tick += new System.EventHandler(this.dev_comp_chck_Tick);
            // 
            // dev_grab_content
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(353, 157);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_build_status);
            this.Controls.Add(this.bck_music);
            this.Controls.Add(this.lbl_ext_desc);
            this.Controls.Add(this.prg_2);
            this.Controls.Add(this.prg_1);
            this.Controls.Add(this.lbl_content);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_grab_content";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grabbing Content...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dev_grab_content_FormClosing);
            this.Load += new System.EventHandler(this.dev_grab_content_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bck_music)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_content;
        private MaterialSkin.Controls.MaterialProgressBar prg_1;
        private System.Windows.Forms.Timer wait;
        private System.Windows.Forms.Timer dev_presto;
        private System.Windows.Forms.Timer fin;
        private MaterialSkin.Controls.MaterialProgressBar prg_2;
        private System.Windows.Forms.Label lbl_ext_desc;
        private System.Windows.Forms.Timer dev_download;
        private System.Windows.Forms.Timer cleanup;
        private System.Windows.Forms.Timer audio_tmr;
        private AxWMPLib.AxWindowsMediaPlayer bck_music;
        private System.Windows.Forms.Label lbl_build_status;
        private System.Windows.Forms.Timer dev_error;
        private System.Windows.Forms.Timer dev_comp_chck;
    }
}