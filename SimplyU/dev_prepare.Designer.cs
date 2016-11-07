namespace SimplyU
{
    partial class dev_prepare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_prepare));
            this.chck_rec = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_self = new MaterialSkin.Controls.MaterialCheckBox();
            this.btn_next = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.dev_folder = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_target = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_target = new MaterialSkin.Controls.MaterialFlatButton();
            this.dev_target_timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_your_hb = new MaterialSkin.Controls.MaterialLabel();
            this.rd_ddd = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_sd_caf = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_sav = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_ftp = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_ast = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_nnu = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_pong = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_gacu = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_tict = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_geck = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_gbiine = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_tcp = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_pac = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_u_paint = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_hid = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_snake = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_cave = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_chip = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_wiiu_key = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_wup = new MaterialSkin.Controls.MaterialCheckBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.chck_frm_sd = new MaterialSkin.Controls.MaterialCheckBox();
            this.drive = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.allocation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rd_ios = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_flappy = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_space = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_our_loader = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_app_dark = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_poke = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_hid_key = new MaterialSkin.Controls.MaterialCheckBox();
            this.rd_synth = new MaterialSkin.Controls.MaterialCheckBox();
            this.lbl_build_status = new System.Windows.Forms.Label();
            this.chck_guide = new MaterialSkin.Controls.MaterialCheckBox();
            this.lbl_guide = new System.Windows.Forms.Label();
            this.lbl_rednand = new System.Windows.Forms.Label();
            this.chck_rednand = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // chck_rec
            // 
            resources.ApplyResources(this.chck_rec, "chck_rec");
            this.chck_rec.Checked = true;
            this.chck_rec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chck_rec.Depth = 0;
            this.chck_rec.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_rec.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_rec.Name = "chck_rec";
            this.chck_rec.Ripple = true;
            this.chck_rec.UseVisualStyleBackColor = true;
            // 
            // chck_self
            // 
            resources.ApplyResources(this.chck_self, "chck_self");
            this.chck_self.Depth = 0;
            this.chck_self.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_self.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_self.Name = "chck_self";
            this.chck_self.Ripple = true;
            this.chck_self.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            resources.ApplyResources(this.btn_next, "btn_next");
            this.btn_next.Depth = 0;
            this.btn_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_next.Name = "btn_next";
            this.btn_next.Primary = false;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_1
            // 
            resources.ApplyResources(this.lbl_1, "lbl_1");
            this.lbl_1.Name = "lbl_1";
            // 
            // lbl_2
            // 
            resources.ApplyResources(this.lbl_2, "lbl_2");
            this.lbl_2.Name = "lbl_2";
            // 
            // dev_folder
            // 
            this.dev_folder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.dev_folder.HelpRequest += new System.EventHandler(this.dev_folder_HelpRequest);
            // 
            // txt_target
            // 
            resources.ApplyResources(this.txt_target, "txt_target");
            this.txt_target.Depth = 0;
            this.txt_target.Hint = "Target Folder";
            this.txt_target.MaxLength = 32767;
            this.txt_target.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_target.Name = "txt_target";
            this.txt_target.PasswordChar = '\0';
            this.txt_target.SelectedText = "";
            this.txt_target.SelectionLength = 0;
            this.txt_target.SelectionStart = 0;
            this.txt_target.TabStop = false;
            this.txt_target.UseSystemPasswordChar = false;
            // 
            // btn_target
            // 
            resources.ApplyResources(this.btn_target, "btn_target");
            this.btn_target.Depth = 0;
            this.btn_target.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_target.Name = "btn_target";
            this.btn_target.Primary = false;
            this.btn_target.UseVisualStyleBackColor = true;
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // dev_target_timer
            // 
            this.dev_target_timer.Enabled = true;
            this.dev_target_timer.Tick += new System.EventHandler(this.dev_target_timer_Tick);
            // 
            // lbl_your_hb
            // 
            resources.ApplyResources(this.lbl_your_hb, "lbl_your_hb");
            this.lbl_your_hb.Depth = 0;
            this.lbl_your_hb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_your_hb.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_your_hb.Name = "lbl_your_hb";
            this.lbl_your_hb.UseMnemonic = false;
            // 
            // rd_ddd
            // 
            resources.ApplyResources(this.rd_ddd, "rd_ddd");
            this.rd_ddd.Depth = 0;
            this.rd_ddd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_ddd.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_ddd.Name = "rd_ddd";
            this.rd_ddd.Ripple = true;
            this.rd_ddd.UseMnemonic = false;
            this.rd_ddd.UseVisualStyleBackColor = true;
            // 
            // rd_sd_caf
            // 
            resources.ApplyResources(this.rd_sd_caf, "rd_sd_caf");
            this.rd_sd_caf.Depth = 0;
            this.rd_sd_caf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_sd_caf.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_sd_caf.Name = "rd_sd_caf";
            this.rd_sd_caf.Ripple = true;
            this.rd_sd_caf.UseMnemonic = false;
            this.rd_sd_caf.UseVisualStyleBackColor = true;
            // 
            // rd_sav
            // 
            resources.ApplyResources(this.rd_sav, "rd_sav");
            this.rd_sav.Depth = 0;
            this.rd_sav.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_sav.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_sav.Name = "rd_sav";
            this.rd_sav.Ripple = true;
            this.rd_sav.UseMnemonic = false;
            this.rd_sav.UseVisualStyleBackColor = true;
            // 
            // rd_ftp
            // 
            resources.ApplyResources(this.rd_ftp, "rd_ftp");
            this.rd_ftp.Depth = 0;
            this.rd_ftp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_ftp.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_ftp.Name = "rd_ftp";
            this.rd_ftp.Ripple = true;
            this.rd_ftp.UseMnemonic = false;
            this.rd_ftp.UseVisualStyleBackColor = true;
            // 
            // rd_ast
            // 
            resources.ApplyResources(this.rd_ast, "rd_ast");
            this.rd_ast.Depth = 0;
            this.rd_ast.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_ast.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_ast.Name = "rd_ast";
            this.rd_ast.Ripple = true;
            this.rd_ast.UseMnemonic = false;
            this.rd_ast.UseVisualStyleBackColor = true;
            // 
            // rd_nnu
            // 
            resources.ApplyResources(this.rd_nnu, "rd_nnu");
            this.rd_nnu.Depth = 0;
            this.rd_nnu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_nnu.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_nnu.Name = "rd_nnu";
            this.rd_nnu.Ripple = true;
            this.rd_nnu.UseMnemonic = false;
            this.rd_nnu.UseVisualStyleBackColor = true;
            // 
            // rd_pong
            // 
            resources.ApplyResources(this.rd_pong, "rd_pong");
            this.rd_pong.Depth = 0;
            this.rd_pong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_pong.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_pong.Name = "rd_pong";
            this.rd_pong.Ripple = true;
            this.rd_pong.UseMnemonic = false;
            this.rd_pong.UseVisualStyleBackColor = true;
            // 
            // rd_gacu
            // 
            resources.ApplyResources(this.rd_gacu, "rd_gacu");
            this.rd_gacu.Depth = 0;
            this.rd_gacu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_gacu.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_gacu.Name = "rd_gacu";
            this.rd_gacu.Ripple = true;
            this.rd_gacu.UseMnemonic = false;
            this.rd_gacu.UseVisualStyleBackColor = true;
            // 
            // rd_tict
            // 
            resources.ApplyResources(this.rd_tict, "rd_tict");
            this.rd_tict.Depth = 0;
            this.rd_tict.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_tict.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_tict.Name = "rd_tict";
            this.rd_tict.Ripple = true;
            this.rd_tict.UseMnemonic = false;
            this.rd_tict.UseVisualStyleBackColor = true;
            // 
            // rd_geck
            // 
            resources.ApplyResources(this.rd_geck, "rd_geck");
            this.rd_geck.Depth = 0;
            this.rd_geck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_geck.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_geck.Name = "rd_geck";
            this.rd_geck.Ripple = true;
            this.rd_geck.UseMnemonic = false;
            this.rd_geck.UseVisualStyleBackColor = true;
            // 
            // rd_gbiine
            // 
            resources.ApplyResources(this.rd_gbiine, "rd_gbiine");
            this.rd_gbiine.Depth = 0;
            this.rd_gbiine.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_gbiine.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_gbiine.Name = "rd_gbiine";
            this.rd_gbiine.Ripple = true;
            this.rd_gbiine.UseMnemonic = false;
            this.rd_gbiine.UseVisualStyleBackColor = true;
            // 
            // rd_tcp
            // 
            resources.ApplyResources(this.rd_tcp, "rd_tcp");
            this.rd_tcp.Depth = 0;
            this.rd_tcp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_tcp.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_tcp.Name = "rd_tcp";
            this.rd_tcp.Ripple = true;
            this.rd_tcp.UseMnemonic = false;
            this.rd_tcp.UseVisualStyleBackColor = true;
            // 
            // rd_pac
            // 
            resources.ApplyResources(this.rd_pac, "rd_pac");
            this.rd_pac.Depth = 0;
            this.rd_pac.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_pac.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_pac.Name = "rd_pac";
            this.rd_pac.Ripple = true;
            this.rd_pac.UseMnemonic = false;
            this.rd_pac.UseVisualStyleBackColor = true;
            // 
            // rd_u_paint
            // 
            resources.ApplyResources(this.rd_u_paint, "rd_u_paint");
            this.rd_u_paint.Depth = 0;
            this.rd_u_paint.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_u_paint.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_u_paint.Name = "rd_u_paint";
            this.rd_u_paint.Ripple = true;
            this.rd_u_paint.UseMnemonic = false;
            this.rd_u_paint.UseVisualStyleBackColor = true;
            // 
            // rd_hid
            // 
            resources.ApplyResources(this.rd_hid, "rd_hid");
            this.rd_hid.Depth = 0;
            this.rd_hid.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_hid.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_hid.Name = "rd_hid";
            this.rd_hid.Ripple = true;
            this.rd_hid.UseMnemonic = false;
            this.rd_hid.UseVisualStyleBackColor = true;
            // 
            // rd_snake
            // 
            resources.ApplyResources(this.rd_snake, "rd_snake");
            this.rd_snake.Depth = 0;
            this.rd_snake.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_snake.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_snake.Name = "rd_snake";
            this.rd_snake.Ripple = true;
            this.rd_snake.UseMnemonic = false;
            this.rd_snake.UseVisualStyleBackColor = true;
            // 
            // rd_cave
            // 
            resources.ApplyResources(this.rd_cave, "rd_cave");
            this.rd_cave.Depth = 0;
            this.rd_cave.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_cave.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_cave.Name = "rd_cave";
            this.rd_cave.Ripple = true;
            this.rd_cave.UseMnemonic = false;
            this.rd_cave.UseVisualStyleBackColor = true;
            // 
            // rd_chip
            // 
            resources.ApplyResources(this.rd_chip, "rd_chip");
            this.rd_chip.Depth = 0;
            this.rd_chip.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_chip.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_chip.Name = "rd_chip";
            this.rd_chip.Ripple = true;
            this.rd_chip.UseMnemonic = false;
            this.rd_chip.UseVisualStyleBackColor = true;
            // 
            // rd_wiiu_key
            // 
            resources.ApplyResources(this.rd_wiiu_key, "rd_wiiu_key");
            this.rd_wiiu_key.Depth = 0;
            this.rd_wiiu_key.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_wiiu_key.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_wiiu_key.Name = "rd_wiiu_key";
            this.rd_wiiu_key.Ripple = true;
            this.rd_wiiu_key.UseMnemonic = false;
            this.rd_wiiu_key.UseVisualStyleBackColor = true;
            // 
            // rd_wup
            // 
            resources.ApplyResources(this.rd_wup, "rd_wup");
            this.rd_wup.Depth = 0;
            this.rd_wup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_wup.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_wup.Name = "rd_wup";
            this.rd_wup.Ripple = true;
            this.rd_wup.UseMnemonic = false;
            this.rd_wup.UseVisualStyleBackColor = true;
            // 
            // lbl_3
            // 
            resources.ApplyResources(this.lbl_3, "lbl_3");
            this.lbl_3.Name = "lbl_3";
            // 
            // chck_frm_sd
            // 
            resources.ApplyResources(this.chck_frm_sd, "chck_frm_sd");
            this.chck_frm_sd.Depth = 0;
            this.chck_frm_sd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_frm_sd.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_frm_sd.Name = "chck_frm_sd";
            this.chck_frm_sd.Ripple = true;
            this.chck_frm_sd.UseVisualStyleBackColor = true;
            // 
            // drive
            // 
            resources.ApplyResources(this.drive, "drive");
            this.drive.Depth = 0;
            this.drive.Hint = "Drive Letter ( EX: C: )  ";
            this.drive.MaxLength = 32767;
            this.drive.MouseState = MaterialSkin.MouseState.HOVER;
            this.drive.Name = "drive";
            this.drive.PasswordChar = '\0';
            this.drive.SelectedText = "";
            this.drive.SelectionLength = 0;
            this.drive.SelectionStart = 0;
            this.drive.TabStop = false;
            this.drive.UseSystemPasswordChar = false;
            // 
            // allocation
            // 
            resources.ApplyResources(this.allocation, "allocation");
            this.allocation.Depth = 0;
            this.allocation.Hint = "Cluster Size ( EX: 32k) ";
            this.allocation.MaxLength = 32767;
            this.allocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.allocation.Name = "allocation";
            this.allocation.PasswordChar = '\0';
            this.allocation.SelectedText = "";
            this.allocation.SelectionLength = 0;
            this.allocation.SelectionStart = 0;
            this.allocation.TabStop = false;
            this.allocation.UseSystemPasswordChar = false;
            // 
            // rd_ios
            // 
            resources.ApplyResources(this.rd_ios, "rd_ios");
            this.rd_ios.Depth = 0;
            this.rd_ios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_ios.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_ios.Name = "rd_ios";
            this.rd_ios.Ripple = true;
            this.rd_ios.UseMnemonic = false;
            this.rd_ios.UseVisualStyleBackColor = true;
            // 
            // rd_flappy
            // 
            resources.ApplyResources(this.rd_flappy, "rd_flappy");
            this.rd_flappy.Depth = 0;
            this.rd_flappy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_flappy.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_flappy.Name = "rd_flappy";
            this.rd_flappy.Ripple = true;
            this.rd_flappy.UseMnemonic = false;
            this.rd_flappy.UseVisualStyleBackColor = true;
            // 
            // rd_space
            // 
            resources.ApplyResources(this.rd_space, "rd_space");
            this.rd_space.Depth = 0;
            this.rd_space.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_space.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_space.Name = "rd_space";
            this.rd_space.Ripple = true;
            this.rd_space.UseMnemonic = false;
            this.rd_space.UseVisualStyleBackColor = true;
            // 
            // rd_our_loader
            // 
            resources.ApplyResources(this.rd_our_loader, "rd_our_loader");
            this.rd_our_loader.Depth = 0;
            this.rd_our_loader.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_our_loader.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_our_loader.Name = "rd_our_loader";
            this.rd_our_loader.Ripple = true;
            this.rd_our_loader.UseMnemonic = false;
            this.rd_our_loader.UseVisualStyleBackColor = true;
            // 
            // rd_app_dark
            // 
            resources.ApplyResources(this.rd_app_dark, "rd_app_dark");
            this.rd_app_dark.Depth = 0;
            this.rd_app_dark.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_app_dark.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_app_dark.Name = "rd_app_dark";
            this.rd_app_dark.Ripple = true;
            this.rd_app_dark.UseMnemonic = false;
            this.rd_app_dark.UseVisualStyleBackColor = true;
            // 
            // rd_poke
            // 
            resources.ApplyResources(this.rd_poke, "rd_poke");
            this.rd_poke.Depth = 0;
            this.rd_poke.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_poke.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_poke.Name = "rd_poke";
            this.rd_poke.Ripple = true;
            this.rd_poke.UseMnemonic = false;
            this.rd_poke.UseVisualStyleBackColor = true;
            // 
            // rd_hid_key
            // 
            resources.ApplyResources(this.rd_hid_key, "rd_hid_key");
            this.rd_hid_key.Depth = 0;
            this.rd_hid_key.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_hid_key.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_hid_key.Name = "rd_hid_key";
            this.rd_hid_key.Ripple = true;
            this.rd_hid_key.UseMnemonic = false;
            this.rd_hid_key.UseVisualStyleBackColor = true;
            // 
            // rd_synth
            // 
            resources.ApplyResources(this.rd_synth, "rd_synth");
            this.rd_synth.Depth = 0;
            this.rd_synth.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_synth.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_synth.Name = "rd_synth";
            this.rd_synth.Ripple = true;
            this.rd_synth.UseMnemonic = false;
            this.rd_synth.UseVisualStyleBackColor = true;
            // 
            // lbl_build_status
            // 
            resources.ApplyResources(this.lbl_build_status, "lbl_build_status");
            this.lbl_build_status.BackColor = System.Drawing.Color.Black;
            this.lbl_build_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_build_status.Name = "lbl_build_status";
            // 
            // chck_guide
            // 
            resources.ApplyResources(this.chck_guide, "chck_guide");
            this.chck_guide.Depth = 0;
            this.chck_guide.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_guide.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_guide.Name = "chck_guide";
            this.chck_guide.Ripple = true;
            this.chck_guide.UseMnemonic = false;
            this.chck_guide.UseVisualStyleBackColor = true;
            // 
            // lbl_guide
            // 
            resources.ApplyResources(this.lbl_guide, "lbl_guide");
            this.lbl_guide.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_guide.Name = "lbl_guide";
            // 
            // lbl_rednand
            // 
            resources.ApplyResources(this.lbl_rednand, "lbl_rednand");
            this.lbl_rednand.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_rednand.Name = "lbl_rednand";
            // 
            // chck_rednand
            // 
            resources.ApplyResources(this.chck_rednand, "chck_rednand");
            this.chck_rednand.Depth = 0;
            this.chck_rednand.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_rednand.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_rednand.Name = "chck_rednand";
            this.chck_rednand.Ripple = true;
            this.chck_rednand.UseMnemonic = false;
            this.chck_rednand.UseVisualStyleBackColor = true;
            // 
            // dev_prepare
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_rednand);
            this.Controls.Add(this.chck_rednand);
            this.Controls.Add(this.lbl_guide);
            this.Controls.Add(this.chck_guide);
            this.Controls.Add(this.lbl_build_status);
            this.Controls.Add(this.rd_synth);
            this.Controls.Add(this.rd_hid_key);
            this.Controls.Add(this.rd_poke);
            this.Controls.Add(this.rd_app_dark);
            this.Controls.Add(this.rd_our_loader);
            this.Controls.Add(this.rd_space);
            this.Controls.Add(this.allocation);
            this.Controls.Add(this.drive);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.chck_frm_sd);
            this.Controls.Add(this.rd_wup);
            this.Controls.Add(this.rd_wiiu_key);
            this.Controls.Add(this.rd_chip);
            this.Controls.Add(this.rd_cave);
            this.Controls.Add(this.rd_ios);
            this.Controls.Add(this.rd_flappy);
            this.Controls.Add(this.rd_snake);
            this.Controls.Add(this.rd_hid);
            this.Controls.Add(this.rd_u_paint);
            this.Controls.Add(this.rd_pac);
            this.Controls.Add(this.rd_tcp);
            this.Controls.Add(this.rd_gbiine);
            this.Controls.Add(this.rd_geck);
            this.Controls.Add(this.rd_tict);
            this.Controls.Add(this.rd_gacu);
            this.Controls.Add(this.rd_pong);
            this.Controls.Add(this.rd_nnu);
            this.Controls.Add(this.rd_ast);
            this.Controls.Add(this.rd_ftp);
            this.Controls.Add(this.rd_sav);
            this.Controls.Add(this.rd_sd_caf);
            this.Controls.Add(this.rd_ddd);
            this.Controls.Add(this.lbl_your_hb);
            this.Controls.Add(this.btn_target);
            this.Controls.Add(this.txt_target);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.chck_self);
            this.Controls.Add(this.chck_rec);
            this.MaximizeBox = false;
            this.Name = "dev_prepare";
            this.Sizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dev_prepare_FormClosing);
            this.Load += new System.EventHandler(this.dev_prepare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox chck_rec;
        private MaterialSkin.Controls.MaterialCheckBox chck_self;
        private MaterialSkin.Controls.MaterialFlatButton btn_next;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.FolderBrowserDialog dev_folder;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_target;
        private MaterialSkin.Controls.MaterialFlatButton btn_target;
        private System.Windows.Forms.Timer dev_target_timer;
        private MaterialSkin.Controls.MaterialLabel lbl_your_hb;
        private MaterialSkin.Controls.MaterialCheckBox rd_ddd;
        private MaterialSkin.Controls.MaterialCheckBox rd_sd_caf;
        private MaterialSkin.Controls.MaterialCheckBox rd_sav;
        private MaterialSkin.Controls.MaterialCheckBox rd_ftp;
        private MaterialSkin.Controls.MaterialCheckBox rd_ast;
        private MaterialSkin.Controls.MaterialCheckBox rd_nnu;
        private MaterialSkin.Controls.MaterialCheckBox rd_pong;
        private MaterialSkin.Controls.MaterialCheckBox rd_gacu;
        private MaterialSkin.Controls.MaterialCheckBox rd_tict;
        private MaterialSkin.Controls.MaterialCheckBox rd_geck;
        private MaterialSkin.Controls.MaterialCheckBox rd_gbiine;
        private MaterialSkin.Controls.MaterialCheckBox rd_tcp;
        private MaterialSkin.Controls.MaterialCheckBox rd_pac;
        private MaterialSkin.Controls.MaterialCheckBox rd_u_paint;
        private MaterialSkin.Controls.MaterialCheckBox rd_hid;
        private MaterialSkin.Controls.MaterialCheckBox rd_snake;
        private MaterialSkin.Controls.MaterialCheckBox rd_cave;
        private MaterialSkin.Controls.MaterialCheckBox rd_chip;
        private MaterialSkin.Controls.MaterialCheckBox rd_wiiu_key;
        private MaterialSkin.Controls.MaterialCheckBox rd_wup;
        private System.Windows.Forms.Label lbl_3;
        private MaterialSkin.Controls.MaterialCheckBox chck_frm_sd;
        private MaterialSkin.Controls.MaterialSingleLineTextField drive;
        private MaterialSkin.Controls.MaterialSingleLineTextField allocation;
        private MaterialSkin.Controls.MaterialCheckBox rd_ios;
        private MaterialSkin.Controls.MaterialCheckBox rd_flappy;
        private MaterialSkin.Controls.MaterialCheckBox rd_space;
        private MaterialSkin.Controls.MaterialCheckBox rd_our_loader;
        private MaterialSkin.Controls.MaterialCheckBox rd_app_dark;
        private MaterialSkin.Controls.MaterialCheckBox rd_poke;
        private MaterialSkin.Controls.MaterialCheckBox rd_hid_key;
        private MaterialSkin.Controls.MaterialCheckBox rd_synth;
        private System.Windows.Forms.Label lbl_build_status;
        private MaterialSkin.Controls.MaterialCheckBox chck_guide;
        private System.Windows.Forms.Label lbl_guide;
        private System.Windows.Forms.Label lbl_rednand;
        private MaterialSkin.Controls.MaterialCheckBox chck_rednand;
    }
}