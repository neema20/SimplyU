namespace SimplyU
{
    partial class dev_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_log));
            this.pnl_back = new System.Windows.Forms.Panel();
            this.rch_log = new System.Windows.Forms.RichTextBox();
            this.log_tmr = new System.Windows.Forms.Timer(this.components);
            this.event_log = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.event_log)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_back
            // 
            this.pnl_back.BackColor = System.Drawing.Color.Transparent;
            this.pnl_back.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_back.Location = new System.Drawing.Point(0, 338);
            this.pnl_back.Name = "pnl_back";
            this.pnl_back.Size = new System.Drawing.Size(430, 43);
            this.pnl_back.TabIndex = 0;
            // 
            // rch_log
            // 
            this.rch_log.BackColor = System.Drawing.Color.Black;
            this.rch_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rch_log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rch_log.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rch_log.ForeColor = System.Drawing.Color.White;
            this.rch_log.Location = new System.Drawing.Point(0, 64);
            this.rch_log.Name = "rch_log";
            this.rch_log.ReadOnly = true;
            this.rch_log.Size = new System.Drawing.Size(430, 274);
            this.rch_log.TabIndex = 1;
            this.rch_log.Text = "";
            // 
            // log_tmr
            // 
            this.log_tmr.Enabled = true;
            this.log_tmr.Tick += new System.EventHandler(this.log_tmr_Tick);
            // 
            // event_log
            // 
            this.event_log.Log = "Application";
            this.event_log.Source = "dev_log";
            this.event_log.SynchronizingObject = this;
            // 
            // dev_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 381);
            this.Controls.Add(this.rch_log);
            this.Controls.Add(this.pnl_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_log";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "dev_log";
            this.Load += new System.EventHandler(this.dev_log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.event_log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_back;
        private System.Windows.Forms.RichTextBox rch_log;
        private System.Windows.Forms.Timer log_tmr;
        private System.Diagnostics.EventLog event_log;
    }
}