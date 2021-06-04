using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

/*https://www.youtube.com/watch?v=jO4g8Hw1BkM&t=311s*/

namespace Mando
{
    public partial class frmDashboard : Form
    {

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer2.Tick += timer2_Tick;
            timer3.Tick += timer3_Tick;
            timer1.Interval = 5000;
            timer2.Interval = 5000;
            timer3.Interval = 5000;
            btnStop1.Text = "Auto";
            btnStop2.Text = "Auto";
            btnStop3.Text = "Auto";

            chart1.Series["rms_x"].BorderWidth = 2;
            chart1.Series["rms_y"].BorderWidth = 2;
            chart1.Series["rms_z"].BorderWidth = 2;
            chart2.Series["I_a"].BorderWidth = 2;
            chart2.Series["I_b"].BorderWidth = 2;
            chart2.Series["I_c"].BorderWidth = 2;
            chart3.Series["rms_x"].BorderWidth = 2;
            chart3.Series["rms_y"].BorderWidth = 2;
            chart3.Series["rms_z"].BorderWidth = 2;
            chart4.Series["I_a"].BorderWidth = 2;
            chart4.Series["I_b"].BorderWidth = 2;
            chart4.Series["I_c"].BorderWidth = 2;
            chart5.Series["rms_x"].BorderWidth = 2;
            chart5.Series["rms_y"].BorderWidth = 2;
            chart5.Series["rms_z"].BorderWidth = 2;
            chart6.Series["I_a"].BorderWidth = 2;
            chart6.Series["I_b"].BorderWidth = 2;
            chart6.Series["I_c"].BorderWidth = 2;
            chart7.Series["temperature"].BorderWidth = 2;
            chart8.Series["temperature"].BorderWidth = 2;
            chart9.Series["temperature"].BorderWidth = 2;


            // button1
            string constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand("select * from Mando.Motor1_vib;", conDataBase1);
            MySqlDataReader myReader1;

            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {
                    this.chart1.Series["rms_x"].Points.AddXY(myReader1.GetString("Time"), myReader1.GetString("rms_x"));
                    this.chart1.Series["rms_y"].Points.AddXY(myReader1.GetString("Time"), myReader1.GetString("rms_y"));
                    this.chart1.Series["rms_z"].Points.AddXY(myReader1.GetString("Time"), myReader1.GetString("rms_z"));
                    this.chart7.Series["temperature"].Points.AddXY(myReader1.GetString("Time"), myReader1.GetString("temperature"));
                    Label_V1.Text = myReader1["Battery"].ToString();
                    Label_rms_x1.Text = myReader1["rms_x"].ToString();
                    Label_rms_y1.Text = myReader1["rms_y"].ToString();
                    Label_rms_z1.Text = myReader1["rms_z"].ToString();
                    Label_Temp1.Text = myReader1["temperature"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conDataBase1.Close();
            }

            MySqlConnection conDataBase2 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase2 = new MySqlCommand("select * from Mando.Motor1_cur;", conDataBase2);
            MySqlDataReader myReader2;
            try
            {
                conDataBase2.Open();
                myReader2 = cmdDataBase2.ExecuteReader();
                while (myReader2.Read())
                {
                    this.chart2.Series["I_a"].Points.AddXY(myReader2.GetString("Time"), myReader2.GetString("I_a"));
                    this.chart2.Series["I_b"].Points.AddXY(myReader2.GetString("Time"), myReader2.GetString("I_b"));
                    this.chart2.Series["I_c"].Points.AddXY(myReader2.GetString("Time"), myReader2.GetString("I_c"));
                    Label_C1.Text = myReader2["Battery"].ToString();
                    Label_Ia1.Text = myReader2["I_a"].ToString();
                    Label_Ib1.Text = myReader2["I_b"].ToString();
                    Label_Ic1.Text = myReader2["I_c"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conDataBase2.Close();
            }

            // button2
            MySqlConnection conDataBase3 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase3 = new MySqlCommand("select * from Mando.Motor2_vib;", conDataBase3);
            MySqlDataReader myReader3;


            try
            {
                conDataBase3.Open();
                myReader3 = cmdDataBase3.ExecuteReader();
                while (myReader3.Read())
                {
                    this.chart3.Series["rms_x"].Points.AddXY(myReader3.GetString("Time"), myReader3.GetString("rms_x"));
                    this.chart3.Series["rms_y"].Points.AddXY(myReader3.GetString("Time"), myReader3.GetString("rms_y"));
                    this.chart3.Series["rms_z"].Points.AddXY(myReader3.GetString("Time"), myReader3.GetString("rms_z"));
                    this.chart8.Series["temperature"].Points.AddXY(myReader3.GetString("Time"), myReader3.GetString("temperature"));
                    Label_V2.Text = myReader3["Battery"].ToString();
                    Label_rms_x2.Text = myReader3["rms_x"].ToString();
                    Label_rms_y2.Text = myReader3["rms_y"].ToString();
                    Label_rms_z2.Text = myReader3["rms_z"].ToString();
                    Label_Temp2.Text = myReader3["temperature"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conDataBase3.Close();
            }

            MySqlConnection conDataBase4 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase4 = new MySqlCommand("select * from Mando.Motor2_cur;", conDataBase4);
            MySqlDataReader myReader4;
            try
            {
                conDataBase4.Open();
                myReader4 = cmdDataBase4.ExecuteReader();
                while (myReader4.Read())
                {
                    this.chart4.Series["I_a"].Points.AddXY(myReader4.GetString("Time"), myReader4.GetString("I_a"));
                    this.chart4.Series["I_b"].Points.AddXY(myReader4.GetString("Time"), myReader4.GetString("I_b"));
                    this.chart4.Series["I_c"].Points.AddXY(myReader4.GetString("Time"), myReader4.GetString("I_c"));
                    Label_C2.Text = myReader4["Battery"].ToString();
                    Label_Ia2.Text = myReader4["I_a"].ToString();
                    Label_Ib2.Text = myReader4["I_b"].ToString();
                    Label_Ic2.Text = myReader4["I_c"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conDataBase4.Close();
            }

            //button3
            MySqlConnection conDataBase5 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase5 = new MySqlCommand("select * from Mando.Motor3_vib;", conDataBase5);
            MySqlDataReader myReader5;
            try
            {
                conDataBase5.Open();
                myReader5 = cmdDataBase5.ExecuteReader();
                while (myReader5.Read())
                {
                    this.chart5.Series["rms_x"].Points.AddXY(myReader5.GetString("Time"), myReader5.GetString("rms_x"));
                    this.chart5.Series["rms_y"].Points.AddXY(myReader5.GetString("Time"), myReader5.GetString("rms_y"));
                    this.chart5.Series["rms_z"].Points.AddXY(myReader5.GetString("Time"), myReader5.GetString("rms_z"));
                    this.chart9.Series["temperature"].Points.AddXY(myReader5.GetString("Time"), myReader5.GetString("temperature"));
                    Label_V3.Text = myReader5["Battery"].ToString();
                    Label_rms_x3.Text = myReader5["rms_x"].ToString();
                    Label_rms_y3.Text = myReader5["rms_y"].ToString();
                    Label_rms_z3.Text = myReader5["rms_z"].ToString();
                    Label_Temp3.Text = myReader5["temperature"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conDataBase5.Close();
            }

            MySqlConnection conDataBase6 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase6 = new MySqlCommand("select * from Mando.Motor3_cur;", conDataBase6);
            MySqlDataReader myReader6;
            try
            {
                conDataBase6.Open();
                myReader6 = cmdDataBase6.ExecuteReader();
                while (myReader6.Read())
                {
                    this.chart6.Series["I_a"].Points.AddXY(myReader6.GetString("Time"), myReader6.GetString("I_a"));
                    this.chart6.Series["I_b"].Points.AddXY(myReader6.GetString("Time"), myReader6.GetString("I_b"));
                    this.chart6.Series["I_c"].Points.AddXY(myReader6.GetString("Time"), myReader6.GetString("I_c"));
                    Label_C3.Text = myReader6["Battery"].ToString();
                    Label_Ia3.Text = myReader6["I_a"].ToString();
                    Label_Ib3.Text = myReader6["I_b"].ToString();
                    Label_Ic3.Text = myReader6["I_c"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conDataBase6.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand("select * from Mando.Motor1_vib;", conDataBase1);
            MySqlDataReader myReader1;

            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {
                    Console.WriteLine(myReader1.GetString("Time"));
                    Console.WriteLine(myReader1.GetString("rms_x"));
                    Console.WriteLine(myReader1.GetString("temperature"));
                    

                    this.chart1.Series["rms_x"].Points.AddXY(myReader1.GetString("Time"), myReader1.GetString("rms_x"));
                    this.chart1.Series["rms_y"].Points.AddXY(myReader1.GetString("Time"), myReader1.GetString("rms_y"));
                    this.chart1.Series["rms_z"].Points.AddXY(myReader1.GetString("Time"), myReader1.GetString("rms_z"));
                    this.chart7.Series["temperature"].Points.AddXY(myReader1.GetString("Time"), myReader1.GetString("temperature"));
                    Label_V1.Text = myReader1["battery"].ToString();
                    Label_rms_x1.Text = myReader1["rms_x"].ToString();
                    Label_rms_y1.Text = myReader1["rms_y"].ToString();
                    Label_rms_z1.Text = myReader1["rms_z"].ToString();
                    Label_Temp1.Text = myReader1["temperature"].ToString();

                    if (chart1.Series["rms_x"].Points.Count > 5)
                        chart1.Series["rms_x"].Points.RemoveAt(0);
                    if (chart1.Series["rms_y"].Points.Count > 5)
                        chart1.Series["rms_y"].Points.RemoveAt(0);
                    if (chart1.Series["rms_z"].Points.Count > 5)
                        chart1.Series["rms_z"].Points.RemoveAt(0);
                    if (chart7.Series["temperature"].Points.Count > 5)
                        chart7.Series["temperature"].Points.RemoveAt(0);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conDataBase1.Close();
            }

            MySqlConnection conDataBase2 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase2 = new MySqlCommand("select * from Mando.Motor1_cur;", conDataBase2);
            MySqlDataReader myReader2;
            try
            {
                conDataBase2.Open();
                myReader2 = cmdDataBase2.ExecuteReader();
                while (myReader2.Read())
                {
                    this.chart2.Series["I_a"].Points.AddXY(myReader2.GetString("Time"), myReader2.GetString("I_a"));
                    this.chart2.Series["I_b"].Points.AddXY(myReader2.GetString("Time"), myReader2.GetString("I_b"));
                    this.chart2.Series["I_c"].Points.AddXY(myReader2.GetString("Time"), myReader2.GetString("I_c"));
                    Label_C1.Text = myReader2["Battery"].ToString();
                    Label_Ia1.Text = myReader2["I_a"].ToString();
                    Label_Ib1.Text = myReader2["I_b"].ToString();
                    Label_Ic1.Text = myReader2["I_c"].ToString();

                    if (chart2.Series["I_a"].Points.Count > 1)
                        chart2.Series["I_a"].Points.RemoveAt(0);
                    if (chart2.Series["I_b"].Points.Count > 1)
                        chart2.Series["I_b"].Points.RemoveAt(0);
                    if (chart2.Series["I_c"].Points.Count > 1)
                        chart2.Series["I_c"].Points.RemoveAt(0);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conDataBase2.Close();
            }

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase3 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase3 = new MySqlCommand("select * from Mando.Motor2_vib;", conDataBase3);
            MySqlDataReader myReader3;


            try
            {
                conDataBase3.Open();
                myReader3 = cmdDataBase3.ExecuteReader();
                while (myReader3.Read())
                {
                    this.chart3.Series["rms_x"].Points.AddXY(myReader3.GetString("Time"), myReader3.GetString("rms_x"));
                    this.chart3.Series["rms_y"].Points.AddXY(myReader3.GetString("Time"), myReader3.GetString("rms_y"));
                    this.chart3.Series["rms_z"].Points.AddXY(myReader3.GetString("Time"), myReader3.GetString("rms_z"));
                    this.chart8.Series["temperature"].Points.AddXY(myReader3.GetString("Time"), myReader3.GetString("temperature"));
                    Label_V2.Text = myReader3["Battery"].ToString();
                    Label_rms_x2.Text = myReader3["rms_x"].ToString();
                    Label_rms_y2.Text = myReader3["rms_y"].ToString();
                    Label_rms_z2.Text = myReader3["rms_z"].ToString();
                    Label_Temp2.Text = myReader3["temperature"].ToString();

                    if (chart3.Series["rms_x"].Points.Count > 1)
                        chart3.Series["rms_x"].Points.RemoveAt(0);
                    if (chart3.Series["rms_y"].Points.Count > 1)
                        chart3.Series["rms_y"].Points.RemoveAt(0);
                    if (chart3.Series["rms_z"].Points.Count > 1)
                        chart3.Series["rms_z"].Points.RemoveAt(0);
                    if (chart8.Series["temperature"].Points.Count > 1)
                        chart8.Series["temperature"].Points.RemoveAt(0);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conDataBase3.Close();
            }

            MySqlConnection conDataBase4 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase4 = new MySqlCommand("select * from Mando.Motor2_cur;", conDataBase4);
            MySqlDataReader myReader4;
            try
            {
                conDataBase4.Open();
                myReader4 = cmdDataBase4.ExecuteReader();
                while (myReader4.Read())
                {
                    this.chart4.Series["I_a"].Points.AddXY(myReader4.GetString("Time"), myReader4.GetString("I_a"));
                    this.chart4.Series["I_b"].Points.AddXY(myReader4.GetString("Time"), myReader4.GetString("I_b"));
                    this.chart4.Series["I_c"].Points.AddXY(myReader4.GetString("Time"), myReader4.GetString("I_c"));
                    Label_C2.Text = myReader4["Battery"].ToString();
                    Label_Ia2.Text = myReader4["I_a"].ToString();
                    Label_Ib2.Text = myReader4["I_b"].ToString();
                    Label_Ic2.Text = myReader4["I_c"].ToString();

                    if (chart4.Series["I_a"].Points.Count > 1)
                        chart4.Series["I_a"].Points.RemoveAt(0);
                    if (chart4.Series["I_b"].Points.Count > 1)
                        chart4.Series["I_b"].Points.RemoveAt(0);
                    if (chart4.Series["I_c"].Points.Count > 1)
                        chart4.Series["I_c"].Points.RemoveAt(0);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conDataBase4.Close();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=123456789";
            MySqlConnection conDataBase5 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase5 = new MySqlCommand("select * from Mando.Motor3_vib;", conDataBase5);
            MySqlDataReader myReader5;
            try
            {
                conDataBase5.Open();
                myReader5 = cmdDataBase5.ExecuteReader();
                while (myReader5.Read())
                {
                    this.chart5.Series["rms_x"].Points.AddXY(myReader5.GetString("Time"), myReader5.GetString("rms_x"));
                    this.chart5.Series["rms_y"].Points.AddXY(myReader5.GetString("Time"), myReader5.GetString("rms_y"));
                    this.chart5.Series["rms_z"].Points.AddXY(myReader5.GetString("Time"), myReader5.GetString("rms_z"));
                    this.chart9.Series["temperature"].Points.AddXY(myReader5.GetString("Time"), myReader5.GetString("temperature"));
                    Label_V3.Text = myReader5["Battery"].ToString();
                    Label_rms_x3.Text = myReader5["rms_x"].ToString();
                    Label_rms_y3.Text = myReader5["rms_y"].ToString();
                    Label_rms_z3.Text = myReader5["rms_z"].ToString();
                    Label_Temp3.Text = myReader5["temperature"].ToString();

                    if (chart5.Series["rms_x"].Points.Count > 1)
                        chart5.Series["rms_x"].Points.RemoveAt(0);
                    if (chart5.Series["rms_y"].Points.Count > 1)
                        chart5.Series["rms_y"].Points.RemoveAt(0);
                    if (chart5.Series["rms_z"].Points.Count > 1)
                        chart5.Series["rms_z"].Points.RemoveAt(0);
                    if (chart9.Series["temperature"].Points.Count > 1)
                        chart9.Series["temperature"].Points.RemoveAt(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conDataBase5.Close();
            }

            MySqlConnection conDataBase6 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase6 = new MySqlCommand("select * from Mando.Motor3_cur;", conDataBase6);
            MySqlDataReader myReader6;
            try
            {
                conDataBase6.Open();
                myReader6 = cmdDataBase6.ExecuteReader();
                while (myReader6.Read())
                {
                    this.chart6.Series["I_a"].Points.AddXY(myReader6.GetString("Time"), myReader6.GetString("I_a"));
                    this.chart6.Series["I_b"].Points.AddXY(myReader6.GetString("Time"), myReader6.GetString("I_b"));
                    this.chart6.Series["I_c"].Points.AddXY(myReader6.GetString("Time"), myReader6.GetString("I_c"));
                    Label_C3.Text = myReader6["Battery"].ToString();
                    Label_Ia3.Text = myReader6["I_a"].ToString();
                    Label_Ib3.Text = myReader6["I_b"].ToString();
                    Label_Ic3.Text = myReader6["I_c"].ToString();

                    if (chart6.Series["I_a"].Points.Count > 1)
                        chart6.Series["I_a"].Points.RemoveAt(0);
                    if (chart6.Series["I_b"].Points.Count > 1)
                        chart6.Series["I_b"].Points.RemoveAt(0);
                    if (chart6.Series["I_c"].Points.Count > 1)
                        chart6.Series["I_c"].Points.RemoveAt(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conDataBase6.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnStop1.Text = "Start";
            }

            else
            {
                timer1.Start();
                btnStop1.Text = "Stop";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled)
            {
                timer2.Stop();
                btnStop2.Text = "Start";
            }
            else
            {
                timer2.Start();
                btnStop2.Text = "Stop";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (timer3.Enabled)
            {
                timer3.Stop();
                btnStop3.Text = "Start";
            }
            else
            {
                timer3.Start();
                btnStop3.Text = "Stop";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
