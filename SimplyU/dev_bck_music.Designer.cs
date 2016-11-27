namespace SimplyU
{
    partial class dev_bck_music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_bck_music));
            this.bck_music = new AxWMPLib.AxWindowsMediaPlayer();
            this.audio_tmr = new System.Windows.Forms.Timer(this.components);
            this.check_sett = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bck_music)).BeginInit();
            this.SuspendLayout();
            // 
            // bck_music
            // 
            this.bck_music.Enabled = true;
            this.bck_music.Location = new System.Drawing.Point(-5, 82);
            this.bck_music.Name = "bck_music";
            this.bck_music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bck_music.OcxState")));
            this.bck_music.Size = new System.Drawing.Size(75, 23);
            this.bck_music.TabIndex = 15;
            this.bck_music.Visible = false;
            // 
            // audio_tmr
            // 
            this.audio_tmr.Interval = 199800;
            this.audio_tmr.Tick += new System.EventHandler(this.audio_tmr_Tick_1);
            // 
            // check_sett
            // 
            this.check_sett.Enabled = true;
            this.check_sett.Interval = 1;
            this.check_sett.Tick += new System.EventHandler(this.check_sett_Tick_1);
            // 
            // dev_bck_music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 117);
            this.ControlBox = false;
            this.Controls.Add(this.bck_music);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dev_bck_music";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "dev_bck_music";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.dev_bck_music_Load);
            this.DoubleClick += new System.EventHandler(this.dev_bck_music_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.bck_music)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer bck_music;
        private System.Windows.Forms.Timer audio_tmr;
        private System.Windows.Forms.Timer check_sett;
    }
}