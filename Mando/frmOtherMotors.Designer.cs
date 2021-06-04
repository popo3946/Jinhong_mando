
namespace Mando
{
    partial class frmOtherMotors
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
            this.btnDel6 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_Cur3 = new System.Windows.Forms.DataGridView();
            this.btnEx6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_Vib3 = new System.Windows.Forms.DataGridView();
            this.btnDel5 = new System.Windows.Forms.Button();
            this.btnEx5 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cur3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vib3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDel6);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Controls.Add(this.btnEx6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.groupBox4.Location = new System.Drawing.Point(11, 282);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(1026, 275);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current";
            // 
            // btnDel6
            // 
            this.btnDel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDel6.ForeColor = System.Drawing.Color.Black;
            this.btnDel6.Location = new System.Drawing.Point(736, 246);
            this.btnDel6.Name = "btnDel6";
            this.btnDel6.Size = new System.Drawing.Size(133, 23);
            this.btnDel6.TabIndex = 69;
            this.btnDel6.Text = "Delete";
            this.btnDel6.UseVisualStyleBackColor = true;
            this.btnDel6.Click += new System.EventHandler(this.btnDel6_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView_Cur3);
            this.panel4.Location = new System.Drawing.Point(15, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(993, 217);
            this.panel4.TabIndex = 4;
            // 
            // dataGridView_Cur3
            // 
            this.dataGridView_Cur3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cur3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Cur3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Cur3.Name = "dataGridView_Cur3";
            this.dataGridView_Cur3.RowTemplate.Height = 23;
            this.dataGridView_Cur3.Size = new System.Drawing.Size(993, 217);
            this.dataGridView_Cur3.TabIndex = 0;
            // 
            // btnEx6
            // 
            this.btnEx6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEx6.ForeColor = System.Drawing.Color.Black;
            this.btnEx6.Location = new System.Drawing.Point(875, 246);
            this.btnEx6.Name = "btnEx6";
            this.btnEx6.Size = new System.Drawing.Size(133, 23);
            this.btnEx6.TabIndex = 65;
            this.btnEx6.Text = "Export(.CSV)";
            this.btnEx6.UseVisualStyleBackColor = true;
            this.btnEx6.Click += new System.EventHandler(this.btnEx6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.btnDel5);
            this.groupBox3.Controls.Add(this.btnEx5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.groupBox3.Location = new System.Drawing.Point(11, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1026, 272);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vibration and Temperature";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_Vib3);
            this.panel3.Location = new System.Drawing.Point(15, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 217);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView_Vib3
            // 
            this.dataGridView_Vib3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vib3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Vib3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Vib3.Name = "dataGridView_Vib3";
            this.dataGridView_Vib3.RowTemplate.Height = 23;
            this.dataGridView_Vib3.Size = new System.Drawing.Size(993, 217);
            this.dataGridView_Vib3.TabIndex = 0;
            // 
            // btnDel5
            // 
            this.btnDel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDel5.ForeColor = System.Drawing.Color.Black;
            this.btnDel5.Location = new System.Drawing.Point(736, 244);
            this.btnDel5.Name = "btnDel5";
            this.btnDel5.Size = new System.Drawing.Size(133, 23);
            this.btnDel5.TabIndex = 68;
            this.btnDel5.Text = "Delete";
            this.btnDel5.UseVisualStyleBackColor = true;
            this.btnDel5.Click += new System.EventHandler(this.btnDel5_Click);
            // 
            // btnEx5
            // 
            this.btnEx5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEx5.ForeColor = System.Drawing.Color.Black;
            this.btnEx5.Location = new System.Drawing.Point(875, 244);
            this.btnEx5.Name = "btnEx5";
            this.btnEx5.Size = new System.Drawing.Size(133, 23);
            this.btnEx5.TabIndex = 64;
            this.btnEx5.Text = "Export(.CSV)";
            this.btnEx5.UseVisualStyleBackColor = true;
            this.btnEx5.Click += new System.EventHandler(this.btnEx5_Click);
            // 
            // frmOtherMotors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1052, 569);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOtherMotors";
            this.Text = "frmOtherMotors";
            this.Load += new System.EventHandler(this.frmOtherMotors_Load);
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cur3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vib3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_Cur3;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_Vib3;
        private System.Windows.Forms.Button btnEx5;
        private System.Windows.Forms.Button btnEx6;
        private System.Windows.Forms.Button btnDel6;
        private System.Windows.Forms.Button btnDel5;
    }
}