
namespace Mando
{
    partial class frmMainMotor1
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDel2 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_Cur1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnDel1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_Vib1 = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cur1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vib1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDel2);
            this.groupBox4.Controls.Add(this.btnEx2);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.groupBox4.Location = new System.Drawing.Point(11, 284);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(1028, 274);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current";
            // 
            // btnDel2
            // 
            this.btnDel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDel2.ForeColor = System.Drawing.Color.Black;
            this.btnDel2.Location = new System.Drawing.Point(736, 245);
            this.btnDel2.Name = "btnDel2";
            this.btnDel2.Size = new System.Drawing.Size(133, 23);
            this.btnDel2.TabIndex = 65;
            this.btnDel2.Text = "Delete";
            this.btnDel2.UseVisualStyleBackColor = true;
            this.btnDel2.Click += new System.EventHandler(this.btnDel2_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEx2.ForeColor = System.Drawing.Color.Black;
            this.btnEx2.Location = new System.Drawing.Point(875, 245);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(133, 23);
            this.btnEx2.TabIndex = 63;
            this.btnEx2.Text = "Export(.CSV)";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView_Cur1);
            this.panel4.Location = new System.Drawing.Point(15, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(993, 217);
            this.panel4.TabIndex = 4;
            // 
            // dataGridView_Cur1
            // 
            this.dataGridView_Cur1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Cur1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Cur1.Name = "dataGridView_Cur1";
            this.dataGridView_Cur1.RowTemplate.Height = 23;
            this.dataGridView_Cur1.Size = new System.Drawing.Size(993, 217);
            this.dataGridView_Cur1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEx1);
            this.groupBox3.Controls.Add(this.btnDel1);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.groupBox3.Location = new System.Drawing.Point(11, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1026, 272);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vibration and Temperature";
            // 
            // btnEx1
            // 
            this.btnEx1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEx1.ForeColor = System.Drawing.Color.Black;
            this.btnEx1.Location = new System.Drawing.Point(875, 244);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(133, 23);
            this.btnEx1.TabIndex = 62;
            this.btnEx1.Text = "Export(.CSV)";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnDel1
            // 
            this.btnDel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDel1.ForeColor = System.Drawing.Color.Black;
            this.btnDel1.Location = new System.Drawing.Point(736, 244);
            this.btnDel1.Name = "btnDel1";
            this.btnDel1.Size = new System.Drawing.Size(133, 23);
            this.btnDel1.TabIndex = 64;
            this.btnDel1.Text = "Delete";
            this.btnDel1.UseVisualStyleBackColor = true;
            this.btnDel1.Click += new System.EventHandler(this.btnDel1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_Vib1);
            this.panel3.Location = new System.Drawing.Point(15, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 217);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView_Vib1
            // 
            this.dataGridView_Vib1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vib1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Vib1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Vib1.Name = "dataGridView_Vib1";
            this.dataGridView_Vib1.RowTemplate.Height = 23;
            this.dataGridView_Vib1.Size = new System.Drawing.Size(993, 217);
            this.dataGridView_Vib1.TabIndex = 0;
            // 
            // frmMainMotor1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1052, 569);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainMotor1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.frmMainMotor1_Load);
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cur1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vib1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_Cur1;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_Vib1;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnDel1;
        private System.Windows.Forms.Button btnDel2;
    }
}