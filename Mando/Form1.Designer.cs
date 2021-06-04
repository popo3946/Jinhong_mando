
namespace Mando
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOtherMotors = new System.Windows.Forms.Button();
            this.btnMainMotor2 = new System.Windows.Forms.Button();
            this.btnMainMotor1 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.IbItitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PnIFormLoader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTime = new System.Windows.Forms.Label();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.PortName = new System.Windows.Forms.TextBox();
            this.BaudRate = new System.Windows.Forms.TextBox();
            this.txtstopbits = new System.Windows.Forms.TextBox();
            this.txtparity = new System.Windows.Forms.TextBox();
            this.txtdatabits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStopBit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.btnDel5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnOtherMotors);
            this.panel1.Controls.Add(this.btnMainMotor2);
            this.panel1.Controls.Add(this.btnMainMotor1);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 728);
            this.panel1.TabIndex = 0;
            // 
            // btnOtherMotors
            // 
            this.btnOtherMotors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOtherMotors.FlatAppearance.BorderSize = 0;
            this.btnOtherMotors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherMotors.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherMotors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOtherMotors.Image = global::Mando.Properties.Resources.diagram;
            this.btnOtherMotors.Location = new System.Drawing.Point(0, 351);
            this.btnOtherMotors.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtherMotors.Name = "btnOtherMotors";
            this.btnOtherMotors.Size = new System.Drawing.Size(118, 64);
            this.btnOtherMotors.TabIndex = 5;
            this.btnOtherMotors.Text = "Other Motors";
            this.btnOtherMotors.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOtherMotors.UseVisualStyleBackColor = true;
            this.btnOtherMotors.Click += new System.EventHandler(this.btnOtherMotors_Click);
            this.btnOtherMotors.Leave += new System.EventHandler(this.btnOtherMotors_Leave);
            // 
            // btnMainMotor2
            // 
            this.btnMainMotor2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainMotor2.FlatAppearance.BorderSize = 0;
            this.btnMainMotor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMotor2.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMotor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMainMotor2.Image = global::Mando.Properties.Resources.diagram;
            this.btnMainMotor2.Location = new System.Drawing.Point(0, 287);
            this.btnMainMotor2.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMotor2.Name = "btnMainMotor2";
            this.btnMainMotor2.Size = new System.Drawing.Size(118, 64);
            this.btnMainMotor2.TabIndex = 4;
            this.btnMainMotor2.Text = "Main Motor2";
            this.btnMainMotor2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMainMotor2.UseVisualStyleBackColor = true;
            this.btnMainMotor2.Click += new System.EventHandler(this.btnMainMotor2_Click);
            this.btnMainMotor2.Leave += new System.EventHandler(this.btnMainMotor2_Leave);
            // 
            // btnMainMotor1
            // 
            this.btnMainMotor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainMotor1.FlatAppearance.BorderSize = 0;
            this.btnMainMotor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMotor1.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMotor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMainMotor1.Image = global::Mando.Properties.Resources.diagram;
            this.btnMainMotor1.Location = new System.Drawing.Point(0, 223);
            this.btnMainMotor1.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMotor1.Name = "btnMainMotor1";
            this.btnMainMotor1.Size = new System.Drawing.Size(118, 64);
            this.btnMainMotor1.TabIndex = 3;
            this.btnMainMotor1.Text = "Main Motor1";
            this.btnMainMotor1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMainMotor1.UseVisualStyleBackColor = true;
            this.btnMainMotor1.Click += new System.EventHandler(this.btnMainMotor1_Click);
            this.btnMainMotor1.Leave += new System.EventHandler(this.btnMainMotor1_Leave);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::Mando.Properties.Resources.settings;
            this.btnSettings.Location = new System.Drawing.Point(0, 664);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(118, 64);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Image = global::Mando.Properties.Resources.home1;
            this.btnDashboard.Location = new System.Drawing.Point(0, 159);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(118, 64);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard ";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 159);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::Mando.Properties.Resources.Auburn_logo;
            this.pictureBox3.Location = new System.Drawing.Point(0, 50);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Mando.Properties.Resources.Mando_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 183);
            this.PnlNav.Margin = new System.Windows.Forms.Padding(2);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(6, 73);
            this.PnlNav.TabIndex = 1;
            // 
            // IbItitle
            // 
            this.IbItitle.AutoSize = true;
            this.IbItitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbItitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.IbItitle.Location = new System.Drawing.Point(133, 7);
            this.IbItitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IbItitle.Name = "IbItitle";
            this.IbItitle.Size = new System.Drawing.Size(166, 32);
            this.IbItitle.TabIndex = 6;
            this.IbItitle.Text = "DashBoard";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // PnIFormLoader
            // 
            this.PnIFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnIFormLoader.Location = new System.Drawing.Point(118, 159);
            this.PnIFormLoader.Margin = new System.Windows.Forms.Padding(2);
            this.PnIFormLoader.Name = "PnIFormLoader";
            this.PnIFormLoader.Size = new System.Drawing.Size(1052, 569);
            this.PnIFormLoader.TabIndex = 8;
            this.PnIFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnIFormLoader_Paint);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.button2.Location = new System.Drawing.Point(1138, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.btnTime);
            this.panel3.Controls.Add(this.GroupBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(118, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1052, 111);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(787, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 50);
            this.label1.TabIndex = 72;
            this.label1.Text = "Abnormal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 97);
            this.textBox1.TabIndex = 91;
            // 
            // btnTime
            // 
            this.btnTime.AutoSize = true;
            this.btnTime.BackColor = System.Drawing.Color.Transparent;
            this.btnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTime.Location = new System.Drawing.Point(779, 11);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(270, 46);
            this.btnTime.TabIndex = 90;
            this.btnTime.Text = "HH:MM:SS N";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.btnDel5);
            this.GroupBox5.Controls.Add(this.PortName);
            this.GroupBox5.Controls.Add(this.BaudRate);
            this.GroupBox5.Controls.Add(this.txtstopbits);
            this.GroupBox5.Controls.Add(this.txtparity);
            this.GroupBox5.Controls.Add(this.txtdatabits);
            this.GroupBox5.Controls.Add(this.label2);
            this.GroupBox5.Controls.Add(this.cmbStopBit);
            this.GroupBox5.Controls.Add(this.label3);
            this.GroupBox5.Controls.Add(this.label5);
            this.GroupBox5.Controls.Add(this.label4);
            this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.GroupBox5.Location = new System.Drawing.Point(11, 3);
            this.GroupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBox5.Size = new System.Drawing.Size(363, 105);
            this.GroupBox5.TabIndex = 57;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Serial Port Settings";
            // 
            // PortName
            // 
            this.PortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortName.Location = new System.Drawing.Point(97, 24);
            this.PortName.Margin = new System.Windows.Forms.Padding(2);
            this.PortName.Multiline = true;
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(80, 23);
            this.PortName.TabIndex = 64;
            this.PortName.Text = "COM3";
            // 
            // BaudRate
            // 
            this.BaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRate.Location = new System.Drawing.Point(97, 49);
            this.BaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.BaudRate.Multiline = true;
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(80, 23);
            this.BaudRate.TabIndex = 63;
            this.BaudRate.Text = "115200";
            // 
            // txtstopbits
            // 
            this.txtstopbits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstopbits.Location = new System.Drawing.Point(275, 50);
            this.txtstopbits.Margin = new System.Windows.Forms.Padding(2);
            this.txtstopbits.Multiline = true;
            this.txtstopbits.Name = "txtstopbits";
            this.txtstopbits.Size = new System.Drawing.Size(74, 23);
            this.txtstopbits.TabIndex = 62;
            this.txtstopbits.Text = "1";
            // 
            // txtparity
            // 
            this.txtparity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtparity.Location = new System.Drawing.Point(275, 24);
            this.txtparity.Margin = new System.Windows.Forms.Padding(2);
            this.txtparity.Multiline = true;
            this.txtparity.Name = "txtparity";
            this.txtparity.Size = new System.Drawing.Size(74, 23);
            this.txtparity.TabIndex = 61;
            this.txtparity.Text = "None";
            // 
            // txtdatabits
            // 
            this.txtdatabits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatabits.Location = new System.Drawing.Point(97, 74);
            this.txtdatabits.Margin = new System.Windows.Forms.Padding(2);
            this.txtdatabits.Multiline = true;
            this.txtdatabits.Name = "txtdatabits";
            this.txtdatabits.Size = new System.Drawing.Size(80, 23);
            this.txtdatabits.TabIndex = 60;
            this.txtdatabits.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port Name :";
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.AutoSize = true;
            this.cmbStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStopBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cmbStopBit.Location = new System.Drawing.Point(200, 51);
            this.cmbStopBit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(78, 16);
            this.cmbStopBit.TabIndex = 20;
            this.cmbStopBit.Text = "Stop Bits :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Baud Rate :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(200, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Parity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(11, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data Bits :";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDel5
            // 
            this.btnDel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDel5.ForeColor = System.Drawing.Color.Black;
            this.btnDel5.Location = new System.Drawing.Point(203, 75);
            this.btnDel5.Name = "btnDel5";
            this.btnDel5.Size = new System.Drawing.Size(146, 24);
            this.btnDel5.TabIndex = 69;
            this.btnDel5.Text = "Data Logging";
            this.btnDel5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1170, 728);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PnIFormLoader);
            this.Controls.Add(this.IbItitle);
            this.Controls.Add(this.PnlNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "l;";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnOtherMotors;
        private System.Windows.Forms.Button btnMainMotor2;
        private System.Windows.Forms.Button btnMainMotor1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Label IbItitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnIFormLoader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.GroupBox GroupBox5;
        private System.Windows.Forms.TextBox txtstopbits;
        private System.Windows.Forms.TextBox txtparity;
        private System.Windows.Forms.TextBox txtdatabits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cmbStopBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PortName;
        private System.Windows.Forms.TextBox BaudRate;
        private System.Windows.Forms.Label btnTime;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel5;
    }
}

