using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Mando
{
    public partial class frmOtherMotors : Form
    {

        public frmOtherMotors()
        {
            InitializeComponent();
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\popo3\Desktop\Mando_final -  도전2\Mando-final\Mando\Mando\bin\Debug\Motor3_vib\Motor3_vib" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv");
            for (int i = 0; i < dataGridView_Vib3.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView_Vib3.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView_Vib3.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\popo3\Desktop\Mando_final -  도전2\Mando-final\Mando\Mando\bin\Debug\Motor3_cur\Motor3_cur" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv");
            for (int i = 0; i < dataGridView_Cur3.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView_Cur3.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView_Cur3.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void frmOtherMotors_Load(object sender, EventArgs e)
        {
            String constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from Mando.Motor3_Vib;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset5 = new DataTable();
                sda.Fill(dbdataset5);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset5;
                dataGridView_Vib3.DataSource = bSouce;
                sda.Update(dbdataset5);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand("select * from Mando.Motor3_cur;", conDataBase1);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase1;
                DataTable dbdataset6 = new DataTable();
                sda.Fill(dbdataset6);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset6;
                dataGridView_Cur3.DataSource = bSouce;
                sda.Update(dbdataset6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel5_Click(object sender, EventArgs e)
        {
            String constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            string query = "TRUNCATE TABLE Mando.motor3_vib";
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase1);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset5 = new DataTable();
                sda.Fill(dbdataset5);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset5;
                dataGridView_Vib3.DataSource = bSouce;
                sda.Update(dbdataset5);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel6_Click(object sender, EventArgs e)
        {
            String constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            string query = "TRUNCATE TABLE Mando.motor3_cur";
            MySqlCommand cmdDataBase1 = new MySqlCommand(query, conDataBase1);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase1;
                DataTable dbdataset6 = new DataTable();
                sda.Fill(dbdataset6);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset6;
                dataGridView_Cur3.DataSource = bSouce;
                sda.Update(dbdataset6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}