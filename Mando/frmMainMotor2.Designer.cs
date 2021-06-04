
namespace Mando
{
    partial class frmMainMotor2
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_Vib2 = new System.Windows.Forms.DataGridView();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnDel3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_Cur2 = new System.Windows.Forms.DataGridView();
            this.btnDel4 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vib2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cur2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.btnEx3);
            this.groupBox3.Controls.Add(this.btnDel3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.groupBox3.Location = new System.Drawing.Point(11, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1026, 270);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vibration and Temperature";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_Vib2);
            this.panel3.Location = new System.Drawing.Point(15, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 217);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView_Vib2
            // 
            this.dataGridView_Vib2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vib2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Vib2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Vib2.Name = "dataGridView_Vib2";
            this.dataGridView_Vib2.RowTemplate.Height = 23;
            this.dataGridView_Vib2.Size = new System.Drawing.Size(993, 217);
            this.dataGridView_Vib2.TabIndex = 0;
            // 
            // btnEx3
            // 
            this.btnEx3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEx3.ForeColor = System.Drawing.Color.Black;
            this.btnEx3.Location = new System.Drawing.Point(875, 243);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(133, 23);
            this.btnEx3.TabIndex = 60;
            this.btnEx3.Text = "Export(.CSV)";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // btnDel3
            // 
            this.btnDel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDel3.ForeColor = System.Drawing.Color.Black;
            this.btnDel3.Location = new System.Drawing.Point(736, 243);
            this.btnDel3.Name = "btnDel3";
            this.btnDel3.Size = new System.Drawing.Size(133, 23);
            this.btnDel3.TabIndex = 68;
            this.btnDel3.Text = "Delete";
            this.btnDel3.UseVisualStyleBackColor = true;
            this.btnDel3.Click += new System.EventHandler(this.btnDel3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEx4);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Controls.Add(this.btnDel4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.groupBox4.Location = new System.Drawing.Point(11, 281);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(1026, 276);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current";
            // 
            // btnEx4
            // 
            this.btnEx4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEx4.ForeColor = System.Drawing.Color.Black;
            this.btnEx4.Location = new System.Drawing.Point(875, 244);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(133, 23);
            this.btnEx4.TabIndex = 61;
            this.btnEx4.Text = "Export(.CSV)";
            this.btnEx4.UseVisualStyleBackColor = true;
            this.btnEx4.Click += new System.EventHandler(this.btnEx4_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView_Cur2);
            this.panel4.Location = new System.Drawing.Point(15, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(993, 217);
            this.panel4.TabIndex = 4;
            // 
            // dataGridView_Cur2
            // 
            this.dataGridView_Cur2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cur2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Cur2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Cur2.Name = "dataGridView_Cur2";
            this.dataGridView_Cur2.RowTemplate.Height = 23;
            this.dataGridView_Cur2.Size = new System.Drawing.Size(993, 217);
            this.dataGridView_Cur2.TabIndex = 0;
            // 
            // btnDel4
            // 
            this.btnDel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDel4.ForeColor = System.Drawing.Color.Black;
            this.btnDel4.Location = new System.Drawing.Point(736, 244);
            this.btnDel4.Name = "btnDel4";
            this.btnDel4.Size = new System.Drawing.Size(133, 23);
            this.btnDel4.TabIndex = 69;
            this.btnDel4.Text = "Delete";
            this.btnDel4.UseVisualStyleBackColor = true;
            this.btnDel4.Click += new System.EventHandler(this.btnDel4_Click);
            // 
            // frmMainMotor2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1052, 569);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainMotor2";
            this.Text = "frmMainMotor2";
            this.Load += new System.EventHandler(this.frmMainMotor2_Load);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vib2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cur2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_Vib2;
        internal System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_Cur2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx4;
        private System.Windows.Forms.Button btnDel4;
        private System.Windows.Forms.Button btnDel3;
    }
}