namespace GPXLogInterface
{
    partial class GPXLogInterface
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
            this.setA = new System.Windows.Forms.Button();
            this.setB = new System.Windows.Forms.Button();
            this.fileAdisplay = new System.Windows.Forms.TextBox();
            this.fileBdisplay = new System.Windows.Forms.TextBox();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.GO = new System.Windows.Forms.Button();
            this.LoadFile = new System.Windows.Forms.Button();
            this.currFileDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.security_stats_frame = new System.Windows.Forms.Panel();
            this.secOtherPer = new System.Windows.Forms.TextBox();
            this.secOpenPer = new System.Windows.Forms.TextBox();
            this.secWPA2Per = new System.Windows.Forms.TextBox();
            this.secWPAPer = new System.Windows.Forms.TextBox();
            this.secWEPPer = new System.Windows.Forms.TextBox();
            this.secTotalNum = new System.Windows.Forms.TextBox();
            this.secOtherLabel = new System.Windows.Forms.Label();
            this.secOpenLabel = new System.Windows.Forms.Label();
            this.secWPA2Label = new System.Windows.Forms.Label();
            this.secWPALabel = new System.Windows.Forms.Label();
            this.secWEPLabel = new System.Windows.Forms.Label();
            this.secTotalLabel = new System.Windows.Forms.Label();
            this.secOtherNum = new System.Windows.Forms.TextBox();
            this.secOpenNum = new System.Windows.Forms.TextBox();
            this.secWPANum = new System.Windows.Forms.TextBox();
            this.secWPA2Num = new System.Windows.Forms.TextBox();
            this.secWEPNum = new System.Windows.Forms.TextBox();
            this.secStatLabel = new System.Windows.Forms.Label();
            this.lower_panel = new System.Windows.Forms.Panel();
            this.curr_record_frame = new System.Windows.Forms.Panel();
            this.time_info = new System.Windows.Forms.TextBox();
            this.security_info = new System.Windows.Forms.TextBox();
            this.mac_info = new System.Windows.Forms.TextBox();
            this.ssid_info = new System.Windows.Forms.TextBox();
            this.long_info = new System.Windows.Forms.TextBox();
            this.lat_info = new System.Windows.Forms.TextBox();
            this.jumpToNum = new System.Windows.Forms.NumericUpDown();
            this.currRecordPosition = new System.Windows.Forms.Label();
            this.jumpToRecord = new System.Windows.Forms.Button();
            this.nextRecord = new System.Windows.Forms.Button();
            this.prevRecord = new System.Windows.Forms.Button();
            this.currRecordLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.security_filter = new System.Windows.Forms.ComboBox();
            this.channel_filter = new System.Windows.Forms.ComboBox();
            this.ssid_filter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.apply_filter = new System.Windows.Forms.Button();
            this.upper_panel.SuspendLayout();
            this.security_stats_frame.SuspendLayout();
            this.lower_panel.SuspendLayout();
            this.curr_record_frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jumpToNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // setA
            // 
            this.setA.Location = new System.Drawing.Point(3, 27);
            this.setA.Name = "setA";
            this.setA.Size = new System.Drawing.Size(92, 23);
            this.setA.TabIndex = 0;
            this.setA.Text = "Set File A:";
            this.setA.UseVisualStyleBackColor = true;
            this.setA.Click += new System.EventHandler(this.setA_Click);
            // 
            // setB
            // 
            this.setB.Location = new System.Drawing.Point(3, 67);
            this.setB.Name = "setB";
            this.setB.Size = new System.Drawing.Size(92, 23);
            this.setB.TabIndex = 1;
            this.setB.Text = "Set File B:";
            this.setB.UseVisualStyleBackColor = true;
            this.setB.Click += new System.EventHandler(this.setB_Click);
            // 
            // fileAdisplay
            // 
            this.fileAdisplay.Location = new System.Drawing.Point(101, 29);
            this.fileAdisplay.Name = "fileAdisplay";
            this.fileAdisplay.ReadOnly = true;
            this.fileAdisplay.Size = new System.Drawing.Size(555, 20);
            this.fileAdisplay.TabIndex = 2;
            // 
            // fileBdisplay
            // 
            this.fileBdisplay.Location = new System.Drawing.Point(101, 69);
            this.fileBdisplay.Name = "fileBdisplay";
            this.fileBdisplay.ReadOnly = true;
            this.fileBdisplay.Size = new System.Drawing.Size(555, 20);
            this.fileBdisplay.TabIndex = 3;
            // 
            // upper_panel
            // 
            this.upper_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.upper_panel.Controls.Add(this.label3);
            this.upper_panel.Controls.Add(this.GO);
            this.upper_panel.Controls.Add(this.fileBdisplay);
            this.upper_panel.Controls.Add(this.fileAdisplay);
            this.upper_panel.Controls.Add(this.setB);
            this.upper_panel.Controls.Add(this.setA);
            this.upper_panel.Location = new System.Drawing.Point(10, 7);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(676, 138);
            this.upper_panel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Combine Logs";
            // 
            // GO
            // 
            this.GO.Location = new System.Drawing.Point(521, 95);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(124, 23);
            this.GO.TabIndex = 1;
            this.GO.Text = "Combine and Load";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(270, 151);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(163, 23);
            this.LoadFile.TabIndex = 0;
            this.LoadFile.Text = "Load File";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // currFileDisplay
            // 
            this.currFileDisplay.Location = new System.Drawing.Point(90, 20);
            this.currFileDisplay.Multiline = true;
            this.currFileDisplay.Name = "currFileDisplay";
            this.currFileDisplay.ReadOnly = true;
            this.currFileDisplay.Size = new System.Drawing.Size(555, 35);
            this.currFileDisplay.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current File:";
            // 
            // security_stats_frame
            // 
            this.security_stats_frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.security_stats_frame.Controls.Add(this.secOtherPer);
            this.security_stats_frame.Controls.Add(this.secOpenPer);
            this.security_stats_frame.Controls.Add(this.secWPA2Per);
            this.security_stats_frame.Controls.Add(this.secWPAPer);
            this.security_stats_frame.Controls.Add(this.secWEPPer);
            this.security_stats_frame.Controls.Add(this.secTotalNum);
            this.security_stats_frame.Controls.Add(this.secOtherLabel);
            this.security_stats_frame.Controls.Add(this.secOpenLabel);
            this.security_stats_frame.Controls.Add(this.secWPA2Label);
            this.security_stats_frame.Controls.Add(this.secWPALabel);
            this.security_stats_frame.Controls.Add(this.secWEPLabel);
            this.security_stats_frame.Controls.Add(this.secTotalLabel);
            this.security_stats_frame.Controls.Add(this.secOtherNum);
            this.security_stats_frame.Controls.Add(this.secOpenNum);
            this.security_stats_frame.Controls.Add(this.secWPANum);
            this.security_stats_frame.Controls.Add(this.secWPA2Num);
            this.security_stats_frame.Controls.Add(this.secWEPNum);
            this.security_stats_frame.Controls.Add(this.secStatLabel);
            this.security_stats_frame.Location = new System.Drawing.Point(27, 73);
            this.security_stats_frame.Name = "security_stats_frame";
            this.security_stats_frame.Size = new System.Drawing.Size(152, 199);
            this.security_stats_frame.TabIndex = 12;
            // 
            // secOtherPer
            // 
            this.secOtherPer.Enabled = false;
            this.secOtherPer.Location = new System.Drawing.Point(102, 169);
            this.secOtherPer.Name = "secOtherPer";
            this.secOtherPer.ReadOnly = true;
            this.secOtherPer.Size = new System.Drawing.Size(37, 20);
            this.secOtherPer.TabIndex = 19;
            this.secOtherPer.Text = "--%";
            this.secOtherPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secOpenPer
            // 
            this.secOpenPer.Enabled = false;
            this.secOpenPer.Location = new System.Drawing.Point(102, 143);
            this.secOpenPer.Name = "secOpenPer";
            this.secOpenPer.ReadOnly = true;
            this.secOpenPer.Size = new System.Drawing.Size(37, 20);
            this.secOpenPer.TabIndex = 18;
            this.secOpenPer.Text = "--%";
            this.secOpenPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secWPA2Per
            // 
            this.secWPA2Per.Enabled = false;
            this.secWPA2Per.Location = new System.Drawing.Point(102, 117);
            this.secWPA2Per.Name = "secWPA2Per";
            this.secWPA2Per.ReadOnly = true;
            this.secWPA2Per.Size = new System.Drawing.Size(37, 20);
            this.secWPA2Per.TabIndex = 17;
            this.secWPA2Per.Text = "--%";
            this.secWPA2Per.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secWPAPer
            // 
            this.secWPAPer.Enabled = false;
            this.secWPAPer.Location = new System.Drawing.Point(102, 91);
            this.secWPAPer.Name = "secWPAPer";
            this.secWPAPer.ReadOnly = true;
            this.secWPAPer.Size = new System.Drawing.Size(37, 20);
            this.secWPAPer.TabIndex = 16;
            this.secWPAPer.Text = "--%";
            this.secWPAPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secWEPPer
            // 
            this.secWEPPer.Enabled = false;
            this.secWEPPer.Location = new System.Drawing.Point(102, 65);
            this.secWEPPer.Name = "secWEPPer";
            this.secWEPPer.ReadOnly = true;
            this.secWEPPer.Size = new System.Drawing.Size(37, 20);
            this.secWEPPer.TabIndex = 15;
            this.secWEPPer.Text = "--%";
            this.secWEPPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secTotalNum
            // 
            this.secTotalNum.Enabled = false;
            this.secTotalNum.Location = new System.Drawing.Point(62, 35);
            this.secTotalNum.Name = "secTotalNum";
            this.secTotalNum.ReadOnly = true;
            this.secTotalNum.Size = new System.Drawing.Size(37, 20);
            this.secTotalNum.TabIndex = 14;
            this.secTotalNum.Text = "---";
            this.secTotalNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secOtherLabel
            // 
            this.secOtherLabel.AutoSize = true;
            this.secOtherLabel.Location = new System.Drawing.Point(13, 172);
            this.secOtherLabel.Name = "secOtherLabel";
            this.secOtherLabel.Size = new System.Drawing.Size(48, 13);
            this.secOtherLabel.TabIndex = 13;
            this.secOtherLabel.Text = "OTHER:";
            // 
            // secOpenLabel
            // 
            this.secOpenLabel.AutoSize = true;
            this.secOpenLabel.Location = new System.Drawing.Point(21, 146);
            this.secOpenLabel.Name = "secOpenLabel";
            this.secOpenLabel.Size = new System.Drawing.Size(40, 13);
            this.secOpenLabel.TabIndex = 12;
            this.secOpenLabel.Text = "OPEN:";
            // 
            // secWPA2Label
            // 
            this.secWPA2Label.AutoSize = true;
            this.secWPA2Label.Location = new System.Drawing.Point(21, 120);
            this.secWPA2Label.Name = "secWPA2Label";
            this.secWPA2Label.Size = new System.Drawing.Size(41, 13);
            this.secWPA2Label.TabIndex = 11;
            this.secWPA2Label.Text = "WPA2:";
            // 
            // secWPALabel
            // 
            this.secWPALabel.AutoSize = true;
            this.secWPALabel.Location = new System.Drawing.Point(26, 94);
            this.secWPALabel.Name = "secWPALabel";
            this.secWPALabel.Size = new System.Drawing.Size(35, 13);
            this.secWPALabel.TabIndex = 10;
            this.secWPALabel.Text = "WPA:";
            // 
            // secWEPLabel
            // 
            this.secWEPLabel.AutoSize = true;
            this.secWEPLabel.Location = new System.Drawing.Point(26, 68);
            this.secWEPLabel.Name = "secWEPLabel";
            this.secWEPLabel.Size = new System.Drawing.Size(35, 13);
            this.secWEPLabel.TabIndex = 9;
            this.secWEPLabel.Text = "WEP:";
            // 
            // secTotalLabel
            // 
            this.secTotalLabel.AutoSize = true;
            this.secTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secTotalLabel.Location = new System.Drawing.Point(20, 39);
            this.secTotalLabel.Name = "secTotalLabel";
            this.secTotalLabel.Size = new System.Drawing.Size(42, 16);
            this.secTotalLabel.TabIndex = 8;
            this.secTotalLabel.Text = "Total:";
            // 
            // secOtherNum
            // 
            this.secOtherNum.Enabled = false;
            this.secOtherNum.Location = new System.Drawing.Point(62, 169);
            this.secOtherNum.Name = "secOtherNum";
            this.secOtherNum.ReadOnly = true;
            this.secOtherNum.Size = new System.Drawing.Size(37, 20);
            this.secOtherNum.TabIndex = 7;
            this.secOtherNum.Text = "---";
            this.secOtherNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secOpenNum
            // 
            this.secOpenNum.Enabled = false;
            this.secOpenNum.Location = new System.Drawing.Point(62, 143);
            this.secOpenNum.Name = "secOpenNum";
            this.secOpenNum.ReadOnly = true;
            this.secOpenNum.Size = new System.Drawing.Size(37, 20);
            this.secOpenNum.TabIndex = 5;
            this.secOpenNum.Text = "---";
            this.secOpenNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secWPANum
            // 
            this.secWPANum.Enabled = false;
            this.secWPANum.Location = new System.Drawing.Point(62, 91);
            this.secWPANum.Name = "secWPANum";
            this.secWPANum.ReadOnly = true;
            this.secWPANum.Size = new System.Drawing.Size(37, 20);
            this.secWPANum.TabIndex = 4;
            this.secWPANum.Text = "---";
            this.secWPANum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secWPA2Num
            // 
            this.secWPA2Num.Enabled = false;
            this.secWPA2Num.Location = new System.Drawing.Point(62, 117);
            this.secWPA2Num.Name = "secWPA2Num";
            this.secWPA2Num.ReadOnly = true;
            this.secWPA2Num.Size = new System.Drawing.Size(37, 20);
            this.secWPA2Num.TabIndex = 2;
            this.secWPA2Num.Text = "---";
            this.secWPA2Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secWEPNum
            // 
            this.secWEPNum.Enabled = false;
            this.secWEPNum.Location = new System.Drawing.Point(62, 65);
            this.secWEPNum.Name = "secWEPNum";
            this.secWEPNum.ReadOnly = true;
            this.secWEPNum.Size = new System.Drawing.Size(37, 20);
            this.secWEPNum.TabIndex = 1;
            this.secWEPNum.Text = "---";
            this.secWEPNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secStatLabel
            // 
            this.secStatLabel.AutoSize = true;
            this.secStatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secStatLabel.Location = new System.Drawing.Point(16, 9);
            this.secStatLabel.Name = "secStatLabel";
            this.secStatLabel.Size = new System.Drawing.Size(112, 16);
            this.secStatLabel.TabIndex = 0;
            this.secStatLabel.Text = "Security Statistics";
            // 
            // lower_panel
            // 
            this.lower_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lower_panel.Controls.Add(this.curr_record_frame);
            this.lower_panel.Controls.Add(this.jumpToNum);
            this.lower_panel.Controls.Add(this.currRecordPosition);
            this.lower_panel.Controls.Add(this.jumpToRecord);
            this.lower_panel.Controls.Add(this.nextRecord);
            this.lower_panel.Controls.Add(this.prevRecord);
            this.lower_panel.Controls.Add(this.currRecordLabel);
            this.lower_panel.Controls.Add(this.security_stats_frame);
            this.lower_panel.Controls.Add(this.label1);
            this.lower_panel.Controls.Add(this.currFileDisplay);
            this.lower_panel.Location = new System.Drawing.Point(10, 180);
            this.lower_panel.Name = "lower_panel";
            this.lower_panel.Size = new System.Drawing.Size(675, 279);
            this.lower_panel.TabIndex = 5;
            // 
            // curr_record_frame
            // 
            this.curr_record_frame.Controls.Add(this.time_info);
            this.curr_record_frame.Controls.Add(this.security_info);
            this.curr_record_frame.Controls.Add(this.mac_info);
            this.curr_record_frame.Controls.Add(this.ssid_info);
            this.curr_record_frame.Controls.Add(this.long_info);
            this.curr_record_frame.Controls.Add(this.lat_info);
            this.curr_record_frame.Location = new System.Drawing.Point(207, 94);
            this.curr_record_frame.Name = "curr_record_frame";
            this.curr_record_frame.Size = new System.Drawing.Size(438, 138);
            this.curr_record_frame.TabIndex = 23;
            // 
            // time_info
            // 
            this.time_info.Location = new System.Drawing.Point(119, 104);
            this.time_info.Name = "time_info";
            this.time_info.ReadOnly = true;
            this.time_info.Size = new System.Drawing.Size(191, 20);
            this.time_info.TabIndex = 5;
            // 
            // security_info
            // 
            this.security_info.Location = new System.Drawing.Point(119, 78);
            this.security_info.Name = "security_info";
            this.security_info.ReadOnly = true;
            this.security_info.Size = new System.Drawing.Size(191, 20);
            this.security_info.TabIndex = 4;
            // 
            // mac_info
            // 
            this.mac_info.Location = new System.Drawing.Point(119, 52);
            this.mac_info.Name = "mac_info";
            this.mac_info.ReadOnly = true;
            this.mac_info.Size = new System.Drawing.Size(191, 20);
            this.mac_info.TabIndex = 3;
            // 
            // ssid_info
            // 
            this.ssid_info.Location = new System.Drawing.Point(119, 26);
            this.ssid_info.Name = "ssid_info";
            this.ssid_info.ReadOnly = true;
            this.ssid_info.Size = new System.Drawing.Size(191, 20);
            this.ssid_info.TabIndex = 2;
            // 
            // long_info
            // 
            this.long_info.Location = new System.Drawing.Point(220, 0);
            this.long_info.Name = "long_info";
            this.long_info.ReadOnly = true;
            this.long_info.Size = new System.Drawing.Size(134, 20);
            this.long_info.TabIndex = 1;
            // 
            // lat_info
            // 
            this.lat_info.Location = new System.Drawing.Point(73, 0);
            this.lat_info.Name = "lat_info";
            this.lat_info.ReadOnly = true;
            this.lat_info.Size = new System.Drawing.Size(141, 20);
            this.lat_info.TabIndex = 0;
            // 
            // jumpToNum
            // 
            this.jumpToNum.Location = new System.Drawing.Point(427, 243);
            this.jumpToNum.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.jumpToNum.Name = "jumpToNum";
            this.jumpToNum.Size = new System.Drawing.Size(65, 20);
            this.jumpToNum.TabIndex = 22;
            // 
            // currRecordPosition
            // 
            this.currRecordPosition.AutoSize = true;
            this.currRecordPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currRecordPosition.Location = new System.Drawing.Point(439, 66);
            this.currRecordPosition.Name = "currRecordPosition";
            this.currRecordPosition.Size = new System.Drawing.Size(68, 16);
            this.currRecordPosition.TabIndex = 21;
            this.currRecordPosition.Text = "(_ out of _)";
            // 
            // jumpToRecord
            // 
            this.jumpToRecord.Enabled = false;
            this.jumpToRecord.Location = new System.Drawing.Point(360, 240);
            this.jumpToRecord.Name = "jumpToRecord";
            this.jumpToRecord.Size = new System.Drawing.Size(61, 23);
            this.jumpToRecord.TabIndex = 20;
            this.jumpToRecord.Text = "Jump To:";
            this.jumpToRecord.UseVisualStyleBackColor = true;
            this.jumpToRecord.Click += new System.EventHandler(this.jumpToRecord_Click);
            // 
            // nextRecord
            // 
            this.nextRecord.Enabled = false;
            this.nextRecord.Location = new System.Drawing.Point(521, 241);
            this.nextRecord.Name = "nextRecord";
            this.nextRecord.Size = new System.Drawing.Size(75, 23);
            this.nextRecord.TabIndex = 17;
            this.nextRecord.Text = "Next";
            this.nextRecord.UseVisualStyleBackColor = true;
            this.nextRecord.Click += new System.EventHandler(this.nextRecord_Click);
            // 
            // prevRecord
            // 
            this.prevRecord.Enabled = false;
            this.prevRecord.Location = new System.Drawing.Point(256, 241);
            this.prevRecord.Name = "prevRecord";
            this.prevRecord.Size = new System.Drawing.Size(75, 23);
            this.prevRecord.TabIndex = 16;
            this.prevRecord.Text = "Prev";
            this.prevRecord.UseVisualStyleBackColor = true;
            this.prevRecord.Click += new System.EventHandler(this.prevRecord_Click);
            // 
            // currRecordLabel
            // 
            this.currRecordLabel.AutoSize = true;
            this.currRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currRecordLabel.Location = new System.Drawing.Point(335, 66);
            this.currRecordLabel.Name = "currRecordLabel";
            this.currRecordLabel.Size = new System.Drawing.Size(98, 16);
            this.currRecordLabel.TabIndex = 15;
            this.currRecordLabel.Text = "Current Record";
            // 
            // logo
            // 
            this.logo.Image = global::GPXLogInterface.Properties.Resources.cloud_100x75;
            this.logo.Location = new System.Drawing.Point(696, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(213, 133);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // security_filter
            // 
            this.security_filter.FormattingEnabled = true;
            this.security_filter.Items.AddRange(new object[] {
            "security"});
            this.security_filter.Location = new System.Drawing.Point(749, 256);
            this.security_filter.Name = "security_filter";
            this.security_filter.Size = new System.Drawing.Size(121, 21);
            this.security_filter.TabIndex = 7;
            this.security_filter.Text = "Security";
            this.security_filter.SelectedIndexChanged += new System.EventHandler(this.security_filter_SelectedIndexChanged);
            // 
            // channel_filter
            // 
            this.channel_filter.FormattingEnabled = true;
            this.channel_filter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.channel_filter.Location = new System.Drawing.Point(749, 290);
            this.channel_filter.Name = "channel_filter";
            this.channel_filter.Size = new System.Drawing.Size(121, 21);
            this.channel_filter.TabIndex = 10;
            this.channel_filter.Text = "Channel";
            this.channel_filter.SelectedIndexChanged += new System.EventHandler(this.channel_filter_SelectedIndexChanged);
            // 
            // ssid_filter
            // 
            this.ssid_filter.Location = new System.Drawing.Point(758, 222);
            this.ssid_filter.Name = "ssid_filter";
            this.ssid_filter.Size = new System.Drawing.Size(100, 20);
            this.ssid_filter.TabIndex = 11;
            this.ssid_filter.Text = "SSID";
            this.ssid_filter.TextChanged += new System.EventHandler(this.ssid_filter_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(771, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Filters:";
            // 
            // apply_filter
            // 
            this.apply_filter.Location = new System.Drawing.Point(769, 354);
            this.apply_filter.Name = "apply_filter";
            this.apply_filter.Size = new System.Drawing.Size(75, 23);
            this.apply_filter.TabIndex = 12;
            this.apply_filter.Text = "Apply";
            this.apply_filter.UseVisualStyleBackColor = true;
            this.apply_filter.Click += new System.EventHandler(this.apply_filter_Click);
            // 
            // GPXLogInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 471);
            this.Controls.Add(this.apply_filter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ssid_filter);
            this.Controls.Add(this.channel_filter);
            this.Controls.Add(this.security_filter);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.lower_panel);
            this.Controls.Add(this.upper_panel);
            this.Name = "GPXLogInterface";
            this.Text = "GPX Log Interface";
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            this.security_stats_frame.ResumeLayout(false);
            this.security_stats_frame.PerformLayout();
            this.lower_panel.ResumeLayout(false);
            this.lower_panel.PerformLayout();
            this.curr_record_frame.ResumeLayout(false);
            this.curr_record_frame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jumpToNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setA;
        private System.Windows.Forms.Button setB;
        private System.Windows.Forms.TextBox fileAdisplay;
        private System.Windows.Forms.TextBox fileBdisplay;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.TextBox currFileDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel security_stats_frame;
        private System.Windows.Forms.Label secStatLabel;
        private System.Windows.Forms.Panel lower_panel;
        private System.Windows.Forms.TextBox secOpenNum;
        private System.Windows.Forms.TextBox secWPANum;
        private System.Windows.Forms.TextBox secWPA2Num;
        private System.Windows.Forms.TextBox secWEPNum;
        private System.Windows.Forms.TextBox secOtherNum;
        private System.Windows.Forms.Label secTotalLabel;
        private System.Windows.Forms.TextBox secTotalNum;
        private System.Windows.Forms.Label secOtherLabel;
        private System.Windows.Forms.Label secOpenLabel;
        private System.Windows.Forms.Label secWPA2Label;
        private System.Windows.Forms.Label secWPALabel;
        private System.Windows.Forms.Label secWEPLabel;
        private System.Windows.Forms.Button nextRecord;
        private System.Windows.Forms.Button prevRecord;
        private System.Windows.Forms.Label currRecordLabel;
        private System.Windows.Forms.Button jumpToRecord;
        private System.Windows.Forms.Label currRecordPosition;
        private System.Windows.Forms.TextBox secWPA2Per;
        private System.Windows.Forms.TextBox secWPAPer;
        private System.Windows.Forms.TextBox secWEPPer;
        private System.Windows.Forms.TextBox secOtherPer;
        private System.Windows.Forms.TextBox secOpenPer;
        private System.Windows.Forms.NumericUpDown jumpToNum;
        private System.Windows.Forms.Panel curr_record_frame;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ComboBox security_filter;
        private System.Windows.Forms.ComboBox channel_filter;
        private System.Windows.Forms.TextBox ssid_filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox time_info;
        private System.Windows.Forms.TextBox security_info;
        private System.Windows.Forms.TextBox mac_info;
        private System.Windows.Forms.TextBox ssid_info;
        private System.Windows.Forms.TextBox long_info;
        private System.Windows.Forms.TextBox lat_info;
        private System.Windows.Forms.Button apply_filter;
    }
}

