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
    public partial class frmMainMotor2 : Form
    {
        
        public frmMainMotor2()
        {
            InitializeComponent();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\popo3\Desktop\Mando_final -  도전2\Mando-final\Mando\Mando\bin\Debug\Motor2_vib\Motor2_vib" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv");
            for (int i = 0; i < dataGridView_Vib2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView_Vib2.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView_Vib2.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\popo3\Desktop\Mando_final -  도전2\Mando-final\Mando\Mando\bin\Debug\Motor2_cur\Motor2_cur" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv");
            for (int i = 0; i < dataGridView_Cur2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView_Cur2.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView_Cur2.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void frmMainMotor2_Load(object sender, EventArgs e)
        {
            String constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from Mando.Motor2_Vib;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset3 = new DataTable();
                sda.Fill(dbdataset3);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset3;
                dataGridView_Vib2.DataSource = bSouce;
                sda.Update(dbdataset3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlConnection conDataBase1= new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand("select * from Mando.Motor2_cur;", conDataBase1);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase1;
                DataTable dbdataset4 = new DataTable();
                sda.Fill(dbdataset4);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset4;
                dataGridView_Cur2.DataSource = bSouce;
                sda.Update(dbdataset4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnDel3_Click(object sender, EventArgs e)
        {
            String constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            string query = "TRUNCATE TABLE Mando.motor2_vib";
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset3 = new DataTable();
                sda.Fill(dbdataset3);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset3;
                dataGridView_Vib2.DataSource = bSouce;
                sda.Update(dbdataset3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel4_Click(object sender, EventArgs e)
        {
            String constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            string query = "TRUNCATE TABLE Mando.motor2_cur";
            MySqlCommand cmdDataBase1 = new MySqlCommand(query, conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase1;
                DataTable dbdataset4 = new DataTable();
                sda.Fill(dbdataset4);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset4;
                dataGridView_Cur2.DataSource = bSouce;
                sda.Update(dbdataset4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
