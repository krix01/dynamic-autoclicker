namespace dynamicAC
{
    partial class autoclicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autoclicker));
            this.title = new System.Windows.Forms.Label();
            this.CPS_trackbar = new Guna.UI.WinForms.GunaMetroTrackBar();
            this.autoclicker_start_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.autoclicker_stop_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CPS_LEFT = new System.Windows.Forms.Label();
            this.top_drag = new System.Windows.Forms.Panel();
            this.minimize_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.exit_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.clicker = new System.Windows.Forms.Timer(this.components);
            this.random = new System.Windows.Forms.Timer(this.components);
            this.randomTB = new Guna.UI.WinForms.GunaMetroTrackBar();
            this.DELAY_label = new System.Windows.Forms.Label();
            this.millis_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DELAY_rand1_trackbar = new Guna.UI.WinForms.GunaMetroTrackBar();
            this.DELAY_rand2_trackbar = new Guna.UI.WinForms.GunaMetroTrackBar();
            this.system = new System.Windows.Forms.Timer(this.components);
            this.startKey_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BINDKEY_label = new System.Windows.Forms.Label();
            this.alwaysOnTop = new Guna.UI.WinForms.GunaCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            this.rightClick_checkbox = new Guna.UI.WinForms.GunaCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.top_drag.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Kumbh Sans SemiBold", 20.75F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.title.Location = new System.Drawing.Point(6, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(282, 35);
            this.title.TabIndex = 0;
            this.title.Text = "dynamic autoclicker";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_MouseUp);
            // 
            // CPS_trackbar
            // 
            this.CPS_trackbar.Location = new System.Drawing.Point(12, 100);
            this.CPS_trackbar.Maximum = 50;
            this.CPS_trackbar.Minimum = 5;
            this.CPS_trackbar.Name = "CPS_trackbar";
            this.CPS_trackbar.Size = new System.Drawing.Size(226, 26);
            this.CPS_trackbar.TabIndex = 2;
            this.CPS_trackbar.TrackColor = System.Drawing.Color.DimGray;
            this.CPS_trackbar.TrackHoverColor = System.Drawing.Color.Gray;
            this.CPS_trackbar.TrackIdleColor = System.Drawing.Color.Silver;
            this.CPS_trackbar.TrackPressedColor = System.Drawing.Color.Black;
            this.CPS_trackbar.Value = 10;
            this.CPS_trackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CPS_trackbar_Scroll);
            // 
            // autoclicker_start_btn
            // 
            this.autoclicker_start_btn.Animated = true;
            this.autoclicker_start_btn.AnimationHoverSpeed = 0.07F;
            this.autoclicker_start_btn.AnimationSpeed = 0.03F;
            this.autoclicker_start_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.autoclicker_start_btn.BorderColor = System.Drawing.Color.Black;
            this.autoclicker_start_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.autoclicker_start_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.autoclicker_start_btn.CheckedForeColor = System.Drawing.Color.White;
            this.autoclicker_start_btn.CheckedImage = null;
            this.autoclicker_start_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.autoclicker_start_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.autoclicker_start_btn.FocusedColor = System.Drawing.Color.Empty;
            this.autoclicker_start_btn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoclicker_start_btn.ForeColor = System.Drawing.Color.White;
            this.autoclicker_start_btn.Image = null;
            this.autoclicker_start_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.autoclicker_start_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.autoclicker_start_btn.Location = new System.Drawing.Point(12, 387);
            this.autoclicker_start_btn.Name = "autoclicker_start_btn";
            this.autoclicker_start_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.autoclicker_start_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.autoclicker_start_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.autoclicker_start_btn.OnHoverImage = null;
            this.autoclicker_start_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.autoclicker_start_btn.OnPressedColor = System.Drawing.Color.Black;
            this.autoclicker_start_btn.Size = new System.Drawing.Size(160, 42);
            this.autoclicker_start_btn.TabIndex = 3;
            this.autoclicker_start_btn.Text = "start";
            this.autoclicker_start_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.autoclicker_start_btn.Click += new System.EventHandler(this.autoclicker_start_btn_Click);
            // 
            // autoclicker_stop_btn
            // 
            this.autoclicker_stop_btn.Animated = true;
            this.autoclicker_stop_btn.AnimationHoverSpeed = 0.07F;
            this.autoclicker_stop_btn.AnimationSpeed = 0.03F;
            this.autoclicker_stop_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.autoclicker_stop_btn.BorderColor = System.Drawing.Color.Black;
            this.autoclicker_stop_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.autoclicker_stop_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.autoclicker_stop_btn.CheckedForeColor = System.Drawing.Color.White;
            this.autoclicker_stop_btn.CheckedImage = null;
            this.autoclicker_stop_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.autoclicker_stop_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.autoclicker_stop_btn.FocusedColor = System.Drawing.Color.Empty;
            this.autoclicker_stop_btn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoclicker_stop_btn.ForeColor = System.Drawing.Color.White;
            this.autoclicker_stop_btn.Image = null;
            this.autoclicker_stop_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.autoclicker_stop_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.autoclicker_stop_btn.Location = new System.Drawing.Point(201, 387);
            this.autoclicker_stop_btn.Name = "autoclicker_stop_btn";
            this.autoclicker_stop_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.autoclicker_stop_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.autoclicker_stop_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.autoclicker_stop_btn.OnHoverImage = null;
            this.autoclicker_stop_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.autoclicker_stop_btn.OnPressedColor = System.Drawing.Color.Black;
            this.autoclicker_stop_btn.Size = new System.Drawing.Size(160, 42);
            this.autoclicker_stop_btn.TabIndex = 4;
            this.autoclicker_stop_btn.Text = "stop";
            this.autoclicker_stop_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.autoclicker_stop_btn.Click += new System.EventHandler(this.autoclicker_stop_btn_Click);
            // 
            // CPS_LEFT
            // 
            this.CPS_LEFT.AutoSize = true;
            this.CPS_LEFT.Font = new System.Drawing.Font("Kumbh Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.CPS_LEFT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.CPS_LEFT.Location = new System.Drawing.Point(8, 77);
            this.CPS_LEFT.Name = "CPS_LEFT";
            this.CPS_LEFT.Size = new System.Drawing.Size(73, 20);
            this.CPS_LEFT.TabIndex = 5;
            this.CPS_LEFT.Text = "CPS - 10";
            // 
            // top_drag
            // 
            this.top_drag.Controls.Add(this.author_label);
            this.top_drag.Controls.Add(this.minimize_btn);
            this.top_drag.Controls.Add(this.exit_btn);
            this.top_drag.Location = new System.Drawing.Point(0, 1);
            this.top_drag.Name = "top_drag";
            this.top_drag.Size = new System.Drawing.Size(373, 61);
            this.top_drag.TabIndex = 6;
            this.top_drag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_drag_MouseDown);
            this.top_drag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_drag_MouseMove);
            this.top_drag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_drag_MouseUp);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Animated = true;
            this.minimize_btn.AnimationHoverSpeed = 0.07F;
            this.minimize_btn.AnimationSpeed = 0.03F;
            this.minimize_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimize_btn.BorderColor = System.Drawing.Color.Black;
            this.minimize_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.minimize_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.minimize_btn.CheckedForeColor = System.Drawing.Color.White;
            this.minimize_btn.CheckedImage = null;
            this.minimize_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.minimize_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minimize_btn.FocusedColor = System.Drawing.Color.Empty;
            this.minimize_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Image = null;
            this.minimize_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.minimize_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.minimize_btn.Location = new System.Drawing.Point(304, 8);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimize_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.minimize_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.minimize_btn.OnHoverImage = null;
            this.minimize_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimize_btn.OnPressedColor = System.Drawing.Color.Black;
            this.minimize_btn.Size = new System.Drawing.Size(30, 29);
            this.minimize_btn.TabIndex = 7;
            this.minimize_btn.Text = "-";
            this.minimize_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.AnimationHoverSpeed = 0.07F;
            this.exit_btn.AnimationSpeed = 0.03F;
            this.exit_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.exit_btn.BorderColor = System.Drawing.Color.Black;
            this.exit_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.exit_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.exit_btn.CheckedForeColor = System.Drawing.Color.White;
            this.exit_btn.CheckedImage = null;
            this.exit_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.exit_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exit_btn.FocusedColor = System.Drawing.Color.Empty;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Image = null;
            this.exit_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.exit_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.exit_btn.Location = new System.Drawing.Point(340, 8);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.exit_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.exit_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.exit_btn.OnHoverImage = null;
            this.exit_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.exit_btn.OnPressedColor = System.Drawing.Color.Black;
            this.exit_btn.Size = new System.Drawing.Size(30, 29);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "x";
            this.exit_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // clicker
            // 
            this.clicker.Tick += new System.EventHandler(this.clicker_Tick);
            // 
            // random
            // 
            this.random.Enabled = true;
            this.random.Interval = 150;
            this.random.Tick += new System.EventHandler(this.random_Tick);
            // 
            // randomTB
            // 
            this.randomTB.Location = new System.Drawing.Point(333, 355);
            this.randomTB.Maximum = 60;
            this.randomTB.Minimum = 6;
            this.randomTB.Name = "randomTB";
            this.randomTB.Size = new System.Drawing.Size(28, 26);
            this.randomTB.TabIndex = 7;
            this.randomTB.TrackColor = System.Drawing.Color.DimGray;
            this.randomTB.TrackHoverColor = System.Drawing.Color.Gray;
            this.randomTB.TrackIdleColor = System.Drawing.Color.Silver;
            this.randomTB.TrackPressedColor = System.Drawing.Color.Black;
            this.randomTB.Value = 10;
            this.randomTB.Visible = false;
            // 
            // DELAY_label
            // 
            this.DELAY_label.AutoSize = true;
            this.DELAY_label.Font = new System.Drawing.Font("Kumbh Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.DELAY_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.DELAY_label.Location = new System.Drawing.Point(8, 139);
            this.DELAY_label.Name = "DELAY_label";
            this.DELAY_label.Size = new System.Drawing.Size(53, 20);
            this.DELAY_label.TabIndex = 5;
            this.DELAY_label.Text = "Delay";
            // 
            // millis_label
            // 
            this.millis_label.AutoSize = true;
            this.millis_label.Font = new System.Drawing.Font("Kumbh Sans SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.millis_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.millis_label.Location = new System.Drawing.Point(57, 145);
            this.millis_label.Name = "millis_label";
            this.millis_label.Size = new System.Drawing.Size(71, 14);
            this.millis_label.TabIndex = 5;
            this.millis_label.Text = "milliseconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kumbh Sans SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(144, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "-";
            // 
            // DELAY_rand1_trackbar
            // 
            this.DELAY_rand1_trackbar.Location = new System.Drawing.Point(13, 164);
            this.DELAY_rand1_trackbar.Maximum = 1000;
            this.DELAY_rand1_trackbar.Name = "DELAY_rand1_trackbar";
            this.DELAY_rand1_trackbar.Size = new System.Drawing.Size(125, 26);
            this.DELAY_rand1_trackbar.TabIndex = 9;
            this.DELAY_rand1_trackbar.TrackColor = System.Drawing.Color.DimGray;
            this.DELAY_rand1_trackbar.TrackHoverColor = System.Drawing.Color.Gray;
            this.DELAY_rand1_trackbar.TrackIdleColor = System.Drawing.Color.Silver;
            this.DELAY_rand1_trackbar.TrackPressedColor = System.Drawing.Color.Black;
            this.DELAY_rand1_trackbar.Value = 10;
            this.DELAY_rand1_trackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DELAY_rand1_trackbar_Scroll);
            // 
            // DELAY_rand2_trackbar
            // 
            this.DELAY_rand2_trackbar.Location = new System.Drawing.Point(163, 164);
            this.DELAY_rand2_trackbar.Maximum = 1000;
            this.DELAY_rand2_trackbar.Name = "DELAY_rand2_trackbar";
            this.DELAY_rand2_trackbar.Size = new System.Drawing.Size(125, 26);
            this.DELAY_rand2_trackbar.TabIndex = 9;
            this.DELAY_rand2_trackbar.TrackColor = System.Drawing.Color.DimGray;
            this.DELAY_rand2_trackbar.TrackHoverColor = System.Drawing.Color.Gray;
            this.DELAY_rand2_trackbar.TrackIdleColor = System.Drawing.Color.Silver;
            this.DELAY_rand2_trackbar.TrackPressedColor = System.Drawing.Color.Black;
            this.DELAY_rand2_trackbar.Value = 10;
            this.DELAY_rand2_trackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DELAY_rand2_trackbar_Scroll);
            // 
            // system
            // 
            this.system.Enabled = true;
            this.system.Tick += new System.EventHandler(this.system_Tick);
            // 
            // startKey_btn
            // 
            this.startKey_btn.Animated = true;
            this.startKey_btn.AnimationHoverSpeed = 0.07F;
            this.startKey_btn.AnimationSpeed = 0.03F;
            this.startKey_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.startKey_btn.BorderColor = System.Drawing.Color.Black;
            this.startKey_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.startKey_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.startKey_btn.CheckedForeColor = System.Drawing.Color.White;
            this.startKey_btn.CheckedImage = null;
            this.startKey_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.startKey_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startKey_btn.FocusedColor = System.Drawing.Color.Empty;
            this.startKey_btn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startKey_btn.ForeColor = System.Drawing.Color.White;
            this.startKey_btn.Image = null;
            this.startKey_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.startKey_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.startKey_btn.Location = new System.Drawing.Point(12, 241);
            this.startKey_btn.Name = "startKey_btn";
            this.startKey_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.startKey_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startKey_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.startKey_btn.OnHoverImage = null;
            this.startKey_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.startKey_btn.OnPressedColor = System.Drawing.Color.Black;
            this.startKey_btn.Size = new System.Drawing.Size(69, 33);
            this.startKey_btn.TabIndex = 3;
            this.startKey_btn.Text = "none";
            this.startKey_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startKey_btn.Click += new System.EventHandler(this.startKey_btn_Click);
            this.startKey_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startKey_btn_KeyDown);
            // 
            // BINDKEY_label
            // 
            this.BINDKEY_label.AutoSize = true;
            this.BINDKEY_label.Font = new System.Drawing.Font("Kumbh Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.BINDKEY_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BINDKEY_label.Location = new System.Drawing.Point(9, 209);
            this.BINDKEY_label.Name = "BINDKEY_label";
            this.BINDKEY_label.Size = new System.Drawing.Size(164, 20);
            this.BINDKEY_label.TabIndex = 5;
            this.BINDKEY_label.Text = "Autoclicker Keybind";
            // 
            // alwaysOnTop
            // 
            this.alwaysOnTop.BaseColor = System.Drawing.Color.White;
            this.alwaysOnTop.CheckedOffColor = System.Drawing.Color.Gray;
            this.alwaysOnTop.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.alwaysOnTop.FillColor = System.Drawing.Color.White;
            this.alwaysOnTop.Font = new System.Drawing.Font("Kumbh Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.alwaysOnTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.alwaysOnTop.Location = new System.Drawing.Point(108, 354);
            this.alwaysOnTop.Name = "alwaysOnTop";
            this.alwaysOnTop.Size = new System.Drawing.Size(20, 20);
            this.alwaysOnTop.TabIndex = 10;
            this.alwaysOnTop.CheckedChanged += new System.EventHandler(this.alwaysOnTop_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kumbh Sans SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(10, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Always on top -";
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Font = new System.Drawing.Font("Kumbh Sans SemiBold", 8.75F, System.Drawing.FontStyle.Bold);
            this.author_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.author_label.Location = new System.Drawing.Point(10, 45);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(81, 15);
            this.author_label.TabIndex = 0;
            this.author_label.Text = "made by krix";
            this.author_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.author_label_MouseDown);
            this.author_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.author_label_MouseMove);
            this.author_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.author_label_MouseUp);
            // 
            // rightClick_checkbox
            // 
            this.rightClick_checkbox.BaseColor = System.Drawing.Color.White;
            this.rightClick_checkbox.CheckedOffColor = System.Drawing.Color.Gray;
            this.rightClick_checkbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.rightClick_checkbox.FillColor = System.Drawing.Color.White;
            this.rightClick_checkbox.Font = new System.Drawing.Font("Kumbh Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.rightClick_checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.rightClick_checkbox.Location = new System.Drawing.Point(90, 329);
            this.rightClick_checkbox.Name = "rightClick_checkbox";
            this.rightClick_checkbox.Size = new System.Drawing.Size(20, 20);
            this.rightClick_checkbox.TabIndex = 10;
            this.rightClick_checkbox.CheckedChanged += new System.EventHandler(this.rightClick_checkbox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kumbh Sans SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(10, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Right Click -";
            // 
            // autoclicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(373, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rightClick_checkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alwaysOnTop);
            this.Controls.Add(this.DELAY_rand2_trackbar);
            this.Controls.Add(this.DELAY_rand1_trackbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomTB);
            this.Controls.Add(this.title);
            this.Controls.Add(this.millis_label);
            this.Controls.Add(this.BINDKEY_label);
            this.Controls.Add(this.DELAY_label);
            this.Controls.Add(this.CPS_LEFT);
            this.Controls.Add(this.autoclicker_stop_btn);
            this.Controls.Add(this.startKey_btn);
            this.Controls.Add(this.autoclicker_start_btn);
            this.Controls.Add(this.CPS_trackbar);
            this.Controls.Add(this.top_drag);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "autoclicker";
            this.Text = "dynamic autoclicker";
            this.top_drag.ResumeLayout(false);
            this.top_drag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private Guna.UI.WinForms.GunaMetroTrackBar CPS_trackbar;
        private Guna.UI.WinForms.GunaAdvenceButton autoclicker_start_btn;
        private Guna.UI.WinForms.GunaAdvenceButton autoclicker_stop_btn;
        private System.Windows.Forms.Label CPS_LEFT;
        private System.Windows.Forms.Panel top_drag;
        private Guna.UI.WinForms.GunaAdvenceButton minimize_btn;
        private Guna.UI.WinForms.GunaAdvenceButton exit_btn;
        private System.Windows.Forms.Timer clicker;
        private System.Windows.Forms.Timer random;
        private Guna.UI.WinForms.GunaMetroTrackBar randomTB;
        private System.Windows.Forms.Label DELAY_label;
        private System.Windows.Forms.Label millis_label;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaMetroTrackBar DELAY_rand1_trackbar;
        private Guna.UI.WinForms.GunaMetroTrackBar DELAY_rand2_trackbar;
        private System.Windows.Forms.Timer system;
        private Guna.UI.WinForms.GunaAdvenceButton startKey_btn;
        private System.Windows.Forms.Label BINDKEY_label;
        private Guna.UI.WinForms.GunaCheckBox alwaysOnTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label author_label;
        private Guna.UI.WinForms.GunaCheckBox rightClick_checkbox;
        private System.Windows.Forms.Label label3;
    }
}

