using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Threading;
using System.IO;
using MySql.Data.MySqlClient;


namespace Mando
{

    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse

      );
       

        public Form1()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            IbItitle.Text = "Dashboard";
            this.PnIFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnIFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            DialogResult Result = frmlogin.ShowDialog();

            if (Result != DialogResult.OK)
            {
                MessageBox.Show("Exit Program.");
                textBox1.Text += DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]") + "Exit Program." + Environment.NewLine;
                this.Close();
            }

            Timer.Start();
            Timer.Interval = 1000; //1s
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=123456789";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("select * database;", myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                DataSet ds = new DataSet();
                textBox1.Text += DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]") + "MySQL is successfully connected." + Environment.NewLine;
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            IbItitle.Text = "Dashboard";
            this.PnIFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnIFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();

        }

        private void btnMainMotor1_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnMainMotor1.Height;
            PnlNav.Top = btnMainMotor1.Top;
            btnMainMotor1.BackColor = Color.FromArgb(46, 51, 73);

            IbItitle.Text = "MainMotor1";
            this.PnIFormLoader.Controls.Clear();
            frmMainMotor1 frmDashboard_Vrb = new frmMainMotor1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnIFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnMainMotor2_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnMainMotor2.Height;
            PnlNav.Top = btnMainMotor2.Top;
            btnMainMotor2.BackColor = Color.FromArgb(46, 51, 73);

            IbItitle.Text = "MainMotor2";
            this.PnIFormLoader.Controls.Clear();
            frmMainMotor2 frmDashboard_Vrb = new frmMainMotor2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnIFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMainMotor1_Leave(object sender, EventArgs e)
        {
            btnMainMotor1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMainMotor2_Leave(object sender, EventArgs e)
        {
            btnMainMotor2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOtherMotors_Leave(object sender, EventArgs e)
        {
            btnOtherMotors.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOtherMotors_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnOtherMotors.Height;
            PnlNav.Top = btnOtherMotors.Top;
            btnOtherMotors.BackColor = Color.FromArgb(46, 51, 73);

            IbItitle.Text = "OtherMotors";
            this.PnIFormLoader.Controls.Clear();
            frmOtherMotors frmDashboard_Vrb = new frmOtherMotors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnIFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnSettings.Height;
            PnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);

            IbItitle.Text = "Settings";
            this.PnIFormLoader.Controls.Clear();
            frmSettings frmDashboard_Vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnIFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnTime.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void Btnconnect_Click(object sender, EventArgs e)
        {
            
        }

        private void Btndisconnect_Click(object sender, EventArgs e)
        {
        }

        private void PnIFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}