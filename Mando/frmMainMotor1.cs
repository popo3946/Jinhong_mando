using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mando
{
    public partial class frmMainMotor1 : Form
    {
        public frmMainMotor1()
        {
            InitializeComponent();
        }

        private void frmMainMotor1_Load(object sender, EventArgs e)
        {
            String constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from Mando.Motor1_vib;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset1 = new DataTable();
                sda.Fill(dbdataset1);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset1;
                dataGridView_Vib1.DataSource = bSouce;
                sda.Update(dbdataset1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand("select * from Mando.Motor1_cur;", conDataBase1);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase1;
                DataTable dbdataset2 = new DataTable();
                sda.Fill(dbdataset2);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset2;
                dataGridView_Cur1.DataSource = bSouce;
                sda.Update(dbdataset2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\popo3\Desktop\Mando_final -  도전2\Mando-final\Mando\Mando\bin\Debug\Motor1_vib\Motor1_vib_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv");
            for (int i = 0; i < dataGridView_Vib1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView_Vib1.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView_Vib1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\popo3\Desktop\Mando_final -  도전2\Mando-final\Mando\Mando\bin\Debug\Motor1_cur\Motor1_cur" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv");
            for (int i = 0; i < dataGridView_Cur1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView_Cur1.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView_Cur1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            String constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            string query = "TRUNCATE TABLE Mando.motor1_vib";
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset1 = new DataTable();
                sda.Fill(dbdataset1);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset1;
                dataGridView_Vib1.DataSource = bSouce;
                sda.Update(dbdataset1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            String constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            string query = "TRUNCATE TABLE Mando.motor1_cur";
            MySqlCommand cmdDataBase1 = new MySqlCommand(query, conDataBase1);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase1;
                DataTable dbdataset2 = new DataTable();
                sda.Fill(dbdataset2);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset2;
                dataGridView_Cur1.DataSource = bSouce;
                sda.Update(dbdataset2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
