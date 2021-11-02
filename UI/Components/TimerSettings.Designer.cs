namespace LiveSplit.UI.Components
{
    partial class TimerSettings
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
            this.cbMinsFmt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHoursFMT = new System.Windows.Forms.Label();
            this.cmbGradientType = new System.Windows.Forms.ComboBox();
            this.trkDecimalsSize = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCenterTimer = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimerColor = new System.Windows.Forms.Button();
            this.chkOverrideTimerColors = new System.Windows.Forms.CheckBox();
            this.chkGradient = new System.Windows.Forms.CheckBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.trkSize = new System.Windows.Forms.TrackBar();
            this.cmbTimingMethod = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbSeparatorFmt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDecFmt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSecsFmt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHoursFmt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkDecimalsSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSize)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMinsFmt
            // 
            this.cbMinsFmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbMinsFmt, 4);
            this.cbMinsFmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinsFmt.FormattingEnabled = true;
            this.cbMinsFmt.Items.AddRange(new object[] {
            "",
            "0",
            "00"});
            this.cbMinsFmt.Location = new System.Drawing.Point(160, 261);
            this.cbMinsFmt.Name = "cbMinsFmt";
            this.cbMinsFmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbMinsFmt.Size = new System.Drawing.Size(299, 21);
            this.cbMinsFmt.TabIndex = 47;
            this.cbMinsFmt.SelectedIndexChanged += new System.EventHandler(this.cbMinsFmt_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Decimals Font Size:";
            // 
            // lbHoursFMT
            // 
            this.lbHoursFMT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHoursFMT.Location = new System.Drawing.Point(3, 236);
            this.lbHoursFMT.Name = "lbHoursFMT";
            this.lbHoursFMT.Size = new System.Drawing.Size(151, 13);
            this.lbHoursFMT.TabIndex = 46;
            this.lbHoursFMT.Text = "Hours Format:";
            // 
            // cmbGradientType
            // 
            this.cmbGradientType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbGradientType, 2);
            this.cmbGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradientType.FormattingEnabled = true;
            this.cmbGradientType.Items.AddRange(new object[] {
            "Plain",
            "Vertical",
            "Horizontal",
            "Plain With Delta Color",
            "Vertical With Delta Color",
            "Horizontal With Delta Color"});
            this.cmbGradientType.Location = new System.Drawing.Point(218, 4);
            this.cmbGradientType.Name = "cmbGradientType";
            this.cmbGradientType.Size = new System.Drawing.Size(241, 21);
            this.cmbGradientType.TabIndex = 2;
            this.cmbGradientType.SelectedIndexChanged += new System.EventHandler(this.cmbGradientType_SelectedIndexChanged);
            // 
            // trkDecimalsSize
            // 
            this.trkDecimalsSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.trkDecimalsSize, 4);
            this.trkDecimalsSize.Location = new System.Drawing.Point(160, 376);
            this.trkDecimalsSize.Maximum = 50;
            this.trkDecimalsSize.Minimum = 10;
            this.trkDecimalsSize.Name = "trkDecimalsSize";
            this.trkDecimalsSize.Size = new System.Drawing.Size(299, 23);
            this.trkDecimalsSize.TabIndex = 9;
            this.trkDecimalsSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkDecimalsSize.Value = 10;
            this.trkDecimalsSize.Scroll += new System.EventHandler(this.trkDecimalsSize_Scroll);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Timing Method:";
            // 
            // chkCenterTimer
            // 
            this.chkCenterTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCenterTimer.AutoSize = true;
            this.chkCenterTimer.Location = new System.Drawing.Point(7, 205);
            this.chkCenterTimer.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.chkCenterTimer.Name = "chkCenterTimer";
            this.chkCenterTimer.Size = new System.Drawing.Size(147, 17);
            this.chkCenterTimer.TabIndex = 7;
            this.chkCenterTimer.Text = "Align to Center";
            this.chkCenterTimer.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Background Color:";
            // 
            // btnColor2
            // 
            this.btnColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor2.Location = new System.Drawing.Point(189, 3);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(23, 23);
            this.btnColor2.TabIndex = 1;
            this.btnColor2.UseVisualStyleBackColor = false;
            this.btnColor2.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btnColor1
            // 
            this.btnColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor1.Location = new System.Drawing.Point(160, 3);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(23, 23);
            this.btnColor1.TabIndex = 0;
            this.btnColor1.UseVisualStyleBackColor = false;
            this.btnColor1.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 5);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 77);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer Color";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.55556F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.44444F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnTimerColor, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.chkOverrideTimerColors, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(450, 58);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Color:";
            // 
            // btnTimerColor
            // 
            this.btnTimerColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimerColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimerColor.Location = new System.Drawing.Point(154, 32);
            this.btnTimerColor.Name = "btnTimerColor";
            this.btnTimerColor.Size = new System.Drawing.Size(23, 23);
            this.btnTimerColor.TabIndex = 1;
            this.btnTimerColor.UseVisualStyleBackColor = false;
            this.btnTimerColor.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // chkOverrideTimerColors
            // 
            this.chkOverrideTimerColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOverrideTimerColors.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.chkOverrideTimerColors, 2);
            this.chkOverrideTimerColors.Location = new System.Drawing.Point(7, 6);
            this.chkOverrideTimerColors.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.chkOverrideTimerColors.Name = "chkOverrideTimerColors";
            this.chkOverrideTimerColors.Size = new System.Drawing.Size(440, 17);
            this.chkOverrideTimerColors.TabIndex = 0;
            this.chkOverrideTimerColors.Text = "Override Layout Settings";
            this.chkOverrideTimerColors.UseVisualStyleBackColor = true;
            this.chkOverrideTimerColors.CheckedChanged += new System.EventHandler(this.chkOverrideTimerColors_CheckedChanged);
            // 
            // chkGradient
            // 
            this.chkGradient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGradient.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkGradient, 2);
            this.chkGradient.Location = new System.Drawing.Point(7, 176);
            this.chkGradient.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.chkGradient.Name = "chkGradient";
            this.chkGradient.Size = new System.Drawing.Size(176, 17);
            this.chkGradient.TabIndex = 6;
            this.chkGradient.Text = "Show Gradient";
            this.chkGradient.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(3, 66);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(151, 13);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Height:";
            // 
            // trkSize
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.trkSize, 4);
            this.trkSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkSize.Location = new System.Drawing.Point(160, 61);
            this.trkSize.Name = "trkSize";
            this.trkSize.Size = new System.Drawing.Size(299, 23);
            this.trkSize.TabIndex = 4;
            this.trkSize.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // cmbTimingMethod
            // 
            this.cmbTimingMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbTimingMethod, 4);
            this.cmbTimingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimingMethod.FormattingEnabled = true;
            this.cmbTimingMethod.Items.AddRange(new object[] {
            "Current Timing Method",
            "Real Time",
            "Game Time"});
            this.cmbTimingMethod.Location = new System.Drawing.Point(160, 33);
            this.cmbTimingMethod.Name = "cmbTimingMethod";
            this.cmbTimingMethod.Size = new System.Drawing.Size(299, 21);
            this.cmbTimingMethod.TabIndex = 3;
            this.cmbTimingMethod.SelectedIndexChanged += new System.EventHandler(this.cmbTimingMethod_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Controls.Add(this.cbSeparatorFmt, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.cbDecFmt, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbSecsFmt, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbHoursFmt, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbTimingMethod, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.trkSize, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSize, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkGradient, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnColor1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnColor2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkCenterTimer, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbGradientType, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbHoursFMT, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbMinsFmt, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.trkDecimalsSize, 1, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 402);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbSeparatorFmt
            // 
            this.cbSeparatorFmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbSeparatorFmt, 4);
            this.cbSeparatorFmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeparatorFmt.FormattingEnabled = true;
            this.cbSeparatorFmt.Items.AddRange(new object[] {
            "\' \" (0\'00\"000)",
            ": . (0:00.000)"});
            this.cbSeparatorFmt.Location = new System.Drawing.Point(160, 348);
            this.cbSeparatorFmt.Name = "cbSeparatorFmt";
            this.cbSeparatorFmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSeparatorFmt.Size = new System.Drawing.Size(299, 21);
            this.cbSeparatorFmt.TabIndex = 56;
            this.cbSeparatorFmt.SelectedIndexChanged += new System.EventHandler(this.cbSeparatorFmt_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(3, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Separator Format:";
            // 
            // cbDecFmt
            // 
            this.cbDecFmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbDecFmt, 4);
            this.cbDecFmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDecFmt.FormattingEnabled = true;
            this.cbDecFmt.Items.AddRange(new object[] {
            "",
            "0",
            "00",
            "000"});
            this.cbDecFmt.Location = new System.Drawing.Point(160, 319);
            this.cbDecFmt.Name = "cbDecFmt";
            this.cbDecFmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbDecFmt.Size = new System.Drawing.Size(299, 21);
            this.cbDecFmt.TabIndex = 53;
            this.cbDecFmt.SelectedIndexChanged += new System.EventHandler(this.cbDecFmt_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(3, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Decimals Format:";
            // 
            // cbSecsFmt
            // 
            this.cbSecsFmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbSecsFmt, 4);
            this.cbSecsFmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecsFmt.FormattingEnabled = true;
            this.cbSecsFmt.Items.AddRange(new object[] {
            "0",
            "00"});
            this.cbSecsFmt.Location = new System.Drawing.Point(160, 290);
            this.cbSecsFmt.Name = "cbSecsFmt";
            this.cbSecsFmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSecsFmt.Size = new System.Drawing.Size(299, 21);
            this.cbSecsFmt.TabIndex = 51;
            this.cbSecsFmt.SelectedIndexChanged += new System.EventHandler(this.cbSecsFmt_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(3, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Seconds Format:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Minutes Format:";
            // 
            // cbHoursFmt
            // 
            this.cbHoursFmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbHoursFmt, 4);
            this.cbHoursFmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoursFmt.FormattingEnabled = true;
            this.cbHoursFmt.Items.AddRange(new object[] {
            "",
            "0",
            "00",
            "000"});
            this.cbHoursFmt.Location = new System.Drawing.Point(160, 232);
            this.cbHoursFmt.Name = "cbHoursFmt";
            this.cbHoursFmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbHoursFmt.Size = new System.Drawing.Size(299, 21);
            this.cbHoursFmt.TabIndex = 48;
            this.cbHoursFmt.SelectedIndexChanged += new System.EventHandler(this.cbHoursFmt_SelectedIndexChanged);
            // 
            // TimerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TimerSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(476, 416);
            this.Load += new System.EventHandler(this.TimerSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkDecimalsSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSize)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cbMinsFmt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ComboBox cbHoursFmt;
        private System.Windows.Forms.ComboBox cmbTimingMethod;
        private System.Windows.Forms.TrackBar trkSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.CheckBox chkGradient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimerColor;
        private System.Windows.Forms.CheckBox chkOverrideTimerColors;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkCenterTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trkDecimalsSize;
        private System.Windows.Forms.ComboBox cmbGradientType;
        private System.Windows.Forms.Label lbHoursFMT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbDecFmt;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbSecsFmt;
        public System.Windows.Forms.ComboBox cbSeparatorFmt;
        private System.Windows.Forms.Label label7;
    }
}