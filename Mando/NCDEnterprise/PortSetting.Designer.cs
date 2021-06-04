namespace NCDEnterprise
{
    partial class PortSetting
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBaudrate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupNetwork = new System.Windows.Forms.GroupBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.txtNetworkPort = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.rdComPort = new System.Windows.Forms.RadioButton();
            this.rdNetwork = new System.Windows.Forms.RadioButton();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.DestinationGroup = new System.Windows.Forms.GroupBox();
            this.DefaultSettings = new System.Windows.Forms.Button();
            this.AD8 = new System.Windows.Forms.NumericUpDown();
            this.AD7 = new System.Windows.Forms.NumericUpDown();
            this.AD6 = new System.Windows.Forms.NumericUpDown();
            this.AD5 = new System.Windows.Forms.NumericUpDown();
            this.AD4 = new System.Windows.Forms.NumericUpDown();
            this.AD3 = new System.Windows.Forms.NumericUpDown();
            this.AD2 = new System.Windows.Forms.NumericUpDown();
            this.AD1 = new System.Windows.Forms.NumericUpDown();
            this.chkUseWireless = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewDevices = new System.Windows.Forms.ListView();
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DevInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirmwareVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupNetwork.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.DestinationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AD8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(216, 443);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(314, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbPortName
            // 
            this.cmbPortName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPortName.DropDownWidth = 300;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(105, 19);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(183, 21);
            this.cmbPortName.TabIndex = 2;
            this.cmbPortName.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbPortName_DrawItem);
            this.cmbPortName.Enter += new System.EventHandler(this.cmbPortName_Enter);
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "250000",
            "266660",
            "285710",
            "307700",
            "333330",
            "363620",
            "400000",
            "444440",
            "500000",
            "571410",
            "666660",
            "800000",
            "1000000",
            "1333300",
            "2000000"});
            this.cmbBaudrate.Location = new System.Drawing.Point(105, 49);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(183, 21);
            this.cmbBaudrate.TabIndex = 3;
            this.cmbBaudrate.Enter += new System.EventHandler(this.cmbBaudrate_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port";
            // 
            // lbBaudrate
            // 
            this.lbBaudrate.AutoSize = true;
            this.lbBaudrate.Location = new System.Drawing.Point(18, 52);
            this.lbBaudrate.Name = "lbBaudrate";
            this.lbBaudrate.Size = new System.Drawing.Size(50, 13);
            this.lbBaudrate.TabIndex = 4;
            this.lbBaudrate.Text = "Baudrate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPortName);
            this.groupBox1.Controls.Add(this.lbBaudrate);
            this.groupBox1.Controls.Add(this.cmbBaudrate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupNetwork
            // 
            this.groupNetwork.Controls.Add(this.txtIP);
            this.groupNetwork.Controls.Add(this.lbPort);
            this.groupNetwork.Controls.Add(this.txtNetworkPort);
            this.groupNetwork.Controls.Add(this.lbIP);
            this.groupNetwork.Location = new System.Drawing.Point(12, 131);
            this.groupNetwork.Name = "groupNetwork";
            this.groupNetwork.Size = new System.Drawing.Size(314, 82);
            this.groupNetwork.TabIndex = 13;
            this.groupNetwork.TabStop = false;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(105, 20);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(182, 20);
            this.txtIP.TabIndex = 12;
            this.txtIP.Text = "192.168.0.104";
            this.txtIP.Enter += new System.EventHandler(this.txtIP_Enter);
            // 
            // lbPort
            // 
            this.lbPort.Location = new System.Drawing.Point(13, 51);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(86, 17);
            this.lbPort.TabIndex = 9;
            this.lbPort.Text = "Listen Port";
            // 
            // txtNetworkPort
            // 
            this.txtNetworkPort.Location = new System.Drawing.Point(105, 49);
            this.txtNetworkPort.Name = "txtNetworkPort";
            this.txtNetworkPort.Size = new System.Drawing.Size(182, 20);
            this.txtNetworkPort.TabIndex = 11;
            this.txtNetworkPort.Text = "2101";
            this.txtNetworkPort.Enter += new System.EventHandler(this.txtNetworkPort_Enter);
            // 
            // lbIP
            // 
            this.lbIP.Location = new System.Drawing.Point(13, 22);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(86, 17);
            this.lbIP.TabIndex = 10;
            this.lbIP.Text = "IP Adress";
            // 
            // rdComPort
            // 
            this.rdComPort.AutoSize = true;
            this.rdComPort.Checked = true;
            this.rdComPort.Location = new System.Drawing.Point(12, 3);
            this.rdComPort.Name = "rdComPort";
            this.rdComPort.Size = new System.Drawing.Size(68, 17);
            this.rdComPort.TabIndex = 14;
            this.rdComPort.TabStop = true;
            this.rdComPort.Text = "Com Port";
            this.rdComPort.UseVisualStyleBackColor = true;
            // 
            // rdNetwork
            // 
            this.rdNetwork.AutoSize = true;
            this.rdNetwork.Location = new System.Drawing.Point(12, 111);
            this.rdNetwork.Name = "rdNetwork";
            this.rdNetwork.Size = new System.Drawing.Size(65, 17);
            this.rdNetwork.TabIndex = 14;
            this.rdNetwork.Text = "Network";
            this.rdNetwork.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.DestinationGroup);
            this.GroupBox4.Controls.Add(this.chkUseWireless);
            this.GroupBox4.Location = new System.Drawing.Point(343, 12);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(274, 201);
            this.GroupBox4.TabIndex = 476;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Wireless Destination";
            // 
            // DestinationGroup
            // 
            this.DestinationGroup.Controls.Add(this.DefaultSettings);
            this.DestinationGroup.Controls.Add(this.AD8);
            this.DestinationGroup.Controls.Add(this.AD7);
            this.DestinationGroup.Controls.Add(this.AD6);
            this.DestinationGroup.Controls.Add(this.AD5);
            this.DestinationGroup.Controls.Add(this.AD4);
            this.DestinationGroup.Controls.Add(this.AD3);
            this.DestinationGroup.Controls.Add(this.AD2);
            this.DestinationGroup.Controls.Add(this.AD1);
            this.DestinationGroup.Location = new System.Drawing.Point(12, 66);
            this.DestinationGroup.Name = "DestinationGroup";
            this.DestinationGroup.Size = new System.Drawing.Size(252, 118);
            this.DestinationGroup.TabIndex = 476;
            this.DestinationGroup.TabStop = false;
            this.DestinationGroup.Text = "Destination Address of Remote Node";
            // 
            // DefaultSettings
            // 
            this.DefaultSettings.Location = new System.Drawing.Point(15, 89);
            this.DefaultSettings.Name = "DefaultSettings";
            this.DefaultSettings.Size = new System.Drawing.Size(208, 23);
            this.DefaultSettings.TabIndex = 8;
            this.DefaultSettings.Text = "Default Address Settings";
            this.DefaultSettings.UseVisualStyleBackColor = true;
            // 
            // AD8
            // 
            this.AD8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD8.Hexadecimal = true;
            this.AD8.Location = new System.Drawing.Point(174, 54);
            this.AD8.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AD8.Name = "AD8";
            this.AD8.Size = new System.Drawing.Size(49, 26);
            this.AD8.TabIndex = 7;
            this.AD8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AD8.Value = new decimal(new int[] {
            49,
            0,
            0,
            0});
            // 
            // AD7
            // 
            this.AD7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD7.Hexadecimal = true;
            this.AD7.Location = new System.Drawing.Point(121, 54);
            this.AD7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AD7.Name = "AD7";
            this.AD7.Size = new System.Drawing.Size(49, 26);
            this.AD7.TabIndex = 6;
            this.AD7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AD7.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // AD6
            // 
            this.AD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD6.Hexadecimal = true;
            this.AD6.Location = new System.Drawing.Point(68, 54);
            this.AD6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AD6.Name = "AD6";
            this.AD6.Size = new System.Drawing.Size(49, 26);
            this.AD6.TabIndex = 5;
            this.AD6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AD6.Value = new decimal(new int[] {
            206,
            0,
            0,
            0});
            // 
            // AD5
            // 
            this.AD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD5.Hexadecimal = true;
            this.AD5.Location = new System.Drawing.Point(15, 54);
            this.AD5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AD5.Name = "AD5";
            this.AD5.Size = new System.Drawing.Size(49, 26);
            this.AD5.TabIndex = 4;
            this.AD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AD5.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // AD4
            // 
            this.AD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD4.Hexadecimal = true;
            this.AD4.Location = new System.Drawing.Point(174, 20);
            this.AD4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AD4.Name = "AD4";
            this.AD4.Size = new System.Drawing.Size(49, 26);
            this.AD4.TabIndex = 3;
            this.AD4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AD3
            // 
            this.AD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD3.Hexadecimal = true;
            this.AD3.Location = new System.Drawing.Point(121, 20);
            this.AD3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AD3.Name = "AD3";
            this.AD3.Size = new System.Drawing.Size(49, 26);
            this.AD3.TabIndex = 2;
            this.AD3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AD3.Value = new decimal(new int[] {
            162,
            0,
            0,
            0});
            // 
            // AD2
            // 
            this.AD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD2.Hexadecimal = true;
            this.AD2.Location = new System.Drawing.Point(68, 20);
            this.AD2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AD2.Name = "AD2";
            this.AD2.Size = new System.Drawing.Size(49, 26);
            this.AD2.TabIndex = 1;
            this.AD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AD2.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // AD1
            // 
            this.AD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD1.Hexadecimal = true;
            this.AD1.Location = new System.Drawing.Point(15, 20);
            this.AD1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AD1.Name = "AD1";
            this.AD1.Size = new System.Drawing.Size(49, 26);
            this.AD1.TabIndex = 0;
            this.AD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkUseWireless
            // 
            this.chkUseWireless.AutoSize = true;
            this.chkUseWireless.Location = new System.Drawing.Point(27, 34);
            this.chkUseWireless.Name = "chkUseWireless";
            this.chkUseWireless.Size = new System.Drawing.Size(223, 17);
            this.chkUseWireless.TabIndex = 476;
            this.chkUseWireless.Text = "Communicate to a Remote Wireless Node";
            this.chkUseWireless.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewDevices);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 205);
            this.groupBox2.TabIndex = 477;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discovered Network Devices";
            // 
            // listViewDevices
            // 
            this.listViewDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IP,
            this.Mac,
            this.DevInfo,
            this.FirmwareVersion});
            this.listViewDevices.Enabled = false;
            this.listViewDevices.FullRowSelect = true;
            this.listViewDevices.HideSelection = false;
            this.listViewDevices.Location = new System.Drawing.Point(11, 18);
            this.listViewDevices.Name = "listViewDevices";
            this.listViewDevices.Size = new System.Drawing.Size(582, 175);
            this.listViewDevices.TabIndex = 2;
            this.listViewDevices.UseCompatibleStateImageBehavior = false;
            this.listViewDevices.View = System.Windows.Forms.View.Details;
            this.listViewDevices.DoubleClick += new System.EventHandler(this.listViewDevices_DoubleClick);
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 113;
            // 
            // Mac
            // 
            this.Mac.Text = "Mac/ZigBee Address";
            this.Mac.Width = 147;
            // 
            // DevInfo
            // 
            this.DevInfo.Text = "Device Infomation";
            this.DevInfo.Width = 159;
            // 
            // FirmwareVersion
            // 
            this.FirmwareVersion.Text = "FirmwareVersion";
            this.FirmwareVersion.Width = 228;
            // 
            // PortSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.groupNetwork);
            this.Controls.Add(this.rdComPort);
            this.Controls.Add(this.rdNetwork);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection Setting";
            this.Load += new System.EventHandler(this.PortSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupNetwork.ResumeLayout(false);
            this.groupNetwork.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.DestinationGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AD8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBaudrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupNetwork;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtNetworkPort;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.RadioButton rdComPort;
        private System.Windows.Forms.RadioButton rdNetwork;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.GroupBox DestinationGroup;
        internal System.Windows.Forms.Button DefaultSettings;
        internal System.Windows.Forms.NumericUpDown AD8;
        internal System.Windows.Forms.NumericUpDown AD7;
        internal System.Windows.Forms.NumericUpDown AD6;
        internal System.Windows.Forms.NumericUpDown AD5;
        internal System.Windows.Forms.NumericUpDown AD4;
        internal System.Windows.Forms.NumericUpDown AD3;
        internal System.Windows.Forms.NumericUpDown AD2;
        internal System.Windows.Forms.NumericUpDown AD1;
        internal System.Windows.Forms.CheckBox chkUseWireless;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewDevices;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Mac;
        internal System.Windows.Forms.ColumnHeader DevInfo;
        private System.Windows.Forms.ColumnHeader FirmwareVersion;
    }
}