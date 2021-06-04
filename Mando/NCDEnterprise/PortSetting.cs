using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Schema;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO.Ports;

using NCDEnterprise;

namespace NCDEnterprise
{
    internal partial class PortSetting : Form
    {
        UDPNetwork ncdObj = null;

        ArrayList mDeviceList = new ArrayList();

        private Int32 mWirelessDestHigh;

        public Int32 WirelessDestHigh
        {
            get
            {
                UpdateAddressValue();
                return mWirelessDestHigh;
            }
            set
            {
                UpdateAddress();
                mWirelessDestHigh = value;
            }
        }


        private Int32 mWirelessDestLow;
        public Int32 WirelessDestLow
        {
            get
            {
                UpdateAddressValue();
                return mWirelessDestLow;
            }
            set
            {
                UpdateAddress();
                mWirelessDestLow = value;
            }
        }

        public string PortName
        {
            get
            {
                return cmbPortName.Text;
            }
            set
            {
                cmbPortName.Text = value;
            }
        }

        public bool ShowBaudrate
        {
            get
            {
                return cmbBaudrate.Visible;
            }
            set 
            {
                cmbBaudrate.Visible = value;
                lbBaudrate.Visible = value;
            }
        }

        public string IPAddress
        {
            get
            {
                return txtIP.Text;
            }
            set
            {
                txtIP.Text = value;
            }
        }

        public int Port
        {
            get
            {
                return System.Convert.ToInt32(txtNetworkPort.Text);
            }
            set
            {
                txtNetworkPort.Text = value.ToString();
            }
        }

        public int baudrate
        {
            get
            {
                return System.Convert.ToInt32(cmbBaudrate.Text);
            }
            set
            {
                cmbBaudrate.Text = value.ToString();
            }
        }

        /// <summary>
        /// Using Com Port
        /// </summary>
        public bool UsingComPort
        {
            get
            {
                return rdComPort.Checked;
            }
            set
            {
                rdComPort.Checked = value;
                rdNetwork.Checked = !value;
            }
        }

        public bool UseWireless
        {
            get
            {
                return chkUseWireless.Checked;
            }
            set
            {
                chkUseWireless.Checked = value;
            }
        }

        SerialDeviceInfo[] mSerialPortInfos = ListPorts.EnumPorts();

        public PortSetting()
        {
            InitializeComponent();
        }

        private void PortSetting_Load(object sender, EventArgs e)
        {
            FillComPortList();
            ncdObj = new UDPNetwork();
            ncdObj.OnGetIpAndMac = OnGetIpAndMac;
            ncdObj.Start();
        }

        private void FillComPortList()
        {
            cmbPortName.Items.Clear();
            for (int i = 0; i < mSerialPortInfos.Length; i++)
            {
                cmbPortName.Items.Add(mSerialPortInfos[i].PortName);
            }
        }


        private void cmbPortName_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the item.
            e.DrawBackground();
            e.Graphics.DrawString(mSerialPortInfos[e.Index].FriendName, e.Font, System.Drawing.Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Update Address value from GUI
        /// </summary>
        private void UpdateAddressValue()
        {
            mWirelessDestHigh = (int)(AD1.Value);
            mWirelessDestHigh = mWirelessDestHigh << 8 + (int)AD2.Value;
            mWirelessDestHigh = mWirelessDestHigh << 8 + (int)AD3.Value;
            mWirelessDestHigh = mWirelessDestHigh << 8 + (int)AD4.Value;

            mWirelessDestLow = (int)(AD5.Value);
            mWirelessDestLow = mWirelessDestLow << 8 + (int)AD6.Value;
            mWirelessDestLow = mWirelessDestLow << 8 + (int)AD7.Value;
            mWirelessDestLow = mWirelessDestLow << 8 + (int)AD8.Value;
        }


        /// <summary>
        /// Update Address from value to GUI
        /// </summary>
        private void UpdateAddress()
        {
            AD1.Value = (mWirelessDestHigh & 0xFF000000) >> 24;
            AD2.Value = (mWirelessDestHigh & 0xFF0000) >> 16;
            AD3.Value = (mWirelessDestHigh & 0xFF00) >> 8;
            AD4.Value = mWirelessDestHigh & 0xFF;

            AD5.Value = (mWirelessDestLow & 0xFF000000) >> 24;
            AD6.Value = (mWirelessDestLow & 0xFF0000) >> 16;
            AD7.Value = (mWirelessDestLow & 0xFF00) >> 8;
            AD8.Value = mWirelessDestLow & 0xFF;

        }

        private void cmbPortName_Enter(object sender, EventArgs e)
        {
            rdComPort.Checked = true;
        }

        private void cmbBaudrate_Enter(object sender, EventArgs e)
        {
            rdComPort.Checked = true;

        }

        private void txtIP_Enter(object sender, EventArgs e)
        {
            rdNetwork.Checked = true;
        }

        private void txtNetworkPort_Enter(object sender, EventArgs e)
        {
            rdNetwork.Checked = true;
        }

        private void listViewDevices_DoubleClick(object sender, EventArgs e)
        {
            if (listViewDevices.SelectedItems.Count > 0)
            {
                txtIP.Text = listViewDevices.SelectedItems[0].Text;
                //txtMacAddr.Text = listViewDevices.SelectedItems[0].SubItems[1].Text;
                rdNetwork.Checked = true;
            }
        }

        private void OnGetIpAndMac(ProXRDeviceInfo info)
        {
            if (!Created)
            {
                return;
            }
            if (this.InvokeRequired)
            {
                MyUpdateMessageHandler call = new MyUpdateMessageHandler(OnGetIpAndMac);
                BeginInvoke(call, info);
            }
            else
            {
                bool bFound = false;
                for (int i = 0; i < mDeviceList.Count; i++)
                {
                    ProXRDeviceInfo deviceInfo = (ProXRDeviceInfo)mDeviceList[i];
                    if (deviceInfo.IsSameDevice(info))
                    {
                        mDeviceList[i] = info;
                        UpdateListView(i, info);
                        bFound = true;
                        break;
                    }
                }
                if (!bFound)
                {
                    mDeviceList.Add(info);
                    AppendToListView(info);
                }

            }

        }

        /// <summary>
        /// Add new device to list
        /// </summary>
        /// <param name="info"></param>
        private void AppendToListView(ProXRDeviceInfo info)
        {
            ListViewItem item = new ListViewItem(info.GetDescripation());
            listViewDevices.Items.Add(item);
            listViewDevices.Enabled = true;
        }

        /// <summary>
        /// Update list view 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="info"></param>
        private void UpdateListView(int id, ProXRDeviceInfo info)
        {
            bool selected = listViewDevices.Items[id].Selected;
            listViewDevices.Items[id] = new ListViewItem(info.GetDescripation());
            listViewDevices.Items[id].Selected = selected;
        }
    }


    public class ProXRDeviceInfo
    {
        public string Mac;
        public string IP;
        public string DeviceInfo;
        public string FirmwareVersion = "1.0";
        public int Port = 2101;

        public static bool ValidMacAddress(string mac)
        {
            return true;
        }

        public string[] GetDescripation()
        {
            return new string[] { IP, Mac, DeviceInfo, FirmwareVersion };
        }

        public bool IsSameDevice(ProXRDeviceInfo info)
        {
            return (Mac == info.Mac);

        }


        /// <summary>
        /// Init the device information object with data come from network
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Parse(byte[] data)
        {
            bool bRtn = false;
            //data are seperated by ","
            // Data format
            // IP,LocalMac,RemoteMac,Server1, Server2, Server3, Server4, Port1, Port2, Port3, Port4, FirmwareVersion, ---
            string str = Encoding.UTF8.GetString(data, 0, data.Length);
            string[] strs = str.Split(new char[] { ',' });
            if (strs.Length == 5)       // xport module
            {
                try
                {
                    IP = strs[0];
                    Mac = strs[1];
                    Port = int.Parse(strs[2]);
                    DeviceInfo = strs[3];
                    FirmwareVersion = strs[4];
                    bRtn = true;
                }
                catch
                {
                    bRtn = false;
                }
            }
            else if (strs.Length == 6)  // beagle bone
            {
                try
                {
                    IP = strs[0];
                    Mac = strs[1];
                    Port = int.Parse(strs[2]);
                    DeviceInfo = strs[3];
                    FirmwareVersion = strs[4];
                    bRtn = true;
                }
                catch
                {
                    bRtn = false;
                }
            }
            else
            {
                // webi or old module
                try
                {
                    IP = strs[0];
                    if (strs[0].Contains(":"))
                    {
                        string[] ss = strs[0].Split(new char[] { ':' });
                        Port = int.Parse(ss[1]);
                    }
                    Mac = strs[1];
                    DeviceInfo = strs[2];
                    FirmwareVersion = strs[3];
                    bRtn = true;
                }
                catch
                {
                    bRtn = false;
                }

            }
            return bRtn;
        }


        /// <summary>
        /// Parse the data for udp port 55555 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Parse5(byte[] data)
        {
            bool bRtn = false;
            //data are seperated by ","
            // Data format
            // IP,LocalMac,RemoteMac,Server1, Server2, Server3, Server4, Port1, Port2, Port3, Port4, FirmwareVersion, ---
            try
            {
                Mac = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}{5:X2}",
                    data[110], data[111], data[112], data[113], data[114], data[115]);
                byte[] verBuffer = new byte[26];
                Array.Copy(data, 32, verBuffer, 0, 26);
                FirmwareVersion = Encoding.UTF7.GetString(verBuffer);
                byte[] devInfoBuffer = new byte[32];
                Array.Copy(data, 60, devInfoBuffer, 0, 32);
                DeviceInfo = Encoding.UTF7.GetString(devInfoBuffer);
                bRtn = true;
            }
            catch
            {
                bRtn = false;
            }
            return bRtn;
        }

        public string ToString()
        {
            string str = IP + ","
                + Mac + ","
                + FirmwareVersion;
            return str;
        }
    }



    public delegate void MyUpdateMessageHandler(ProXRDeviceInfo mac);

    /// <summary>
    /// Support NCD Network Component
    /// 
    /// </summary>
    class UDPNetwork
    {
        public MyUpdateMessageHandler OnGetIpAndMac;

        Thread mThread = null;      // thread for port 13000 udp device discovery
        Thread mThread55555 = null; // thread for port 55555 udp device discovery
        /// <summary>
        /// Socket Listening for connections
        /// </summary>
        private Socket ListenSocket = null;
        private Socket ListenSocket5 = null;    // socket for port 55555
        public UDPNetwork()
        {

        }

        public bool IsStart()
        {
            return (mThread != null);
        }

        /// <summary>
        /// Start NCD Network Component
        /// </summary>
        public bool Start()
        {
            mThread = new Thread(new ThreadStart(NCDNetworkThread));
            mThread.Start();
            mThread55555 = new Thread(new ThreadStart(NCDNetworkThread5));
            mThread55555.Start();
            return true;
        }

        /// <summary>
        /// Stop NCD Network
        /// </summary>
        public bool Stop()
        {
            try
            {
                if (mThread != null)
                {
                    mThread.Abort();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                mThread = null;
            }
            ListenSocket.Close();

            try
            {
                if (mThread55555 != null)
                {
                    mThread55555.Abort();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                mThread55555 = null;
            }
            ListenSocket5.Close();

            return true;

        }

        private void NCDNetworkThread()
        {
            try
            {
                ListenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                int port = 13000;
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);
                ListenSocket.Bind(localEndPoint);
                StartCommunication(ref ListenSocket);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                ListenSocket.Close();
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }


        private void StartCommunication(ref Socket AcceptSocket)
        {
            try
            {
                byte[] buffer = new byte[1024];
                while (true)
                {


                    Thread.Sleep(2000);

                    int available = AcceptSocket.Available;

                    DateTime timeoutAt = DateTime.Now.AddSeconds(15);
                    Int32 _Available = AcceptSocket.Available;
                    while (_Available == 0 && DateTime.Now < timeoutAt)
                    {
                        try
                        {
                            _Available = AcceptSocket.Available;
                        }
                        catch
                        {
                            break;
                        }

                        System.Threading.Thread.Sleep(100);
                    }
                    if (_Available > 0)
                    {
                        int n = 0;
                        while (AcceptSocket.Poll(500000, SelectMode.SelectRead))
                        {
                            EndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 13000);

                            n = AcceptSocket.ReceiveFrom(buffer, ref localEndPoint);
                            byte[] data = new byte[n];
                            Array.Copy(buffer, data, n);
                            if (OnGetIpAndMac != null)
                            {
                                ProXRDeviceInfo info = new ProXRDeviceInfo();
                                info.Parse(data);
                                OnGetIpAndMac(info);
                            }
                        }
                    }
                }

            }
            catch
            {

            }
        }

        /// <summary>
        ///  thread function for port 55555
        /// </summary>
        private void NCDNetworkThread5()
        {
            try
            {
                ListenSocket5 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                int port = 55555;
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);
                ListenSocket5.Bind(localEndPoint);
                StartCommunication5(ref ListenSocket5);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                ListenSocket.Close();
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        /// <summary>
        ///  function for port 55555
        /// </summary>
        /// <param name="AcceptSocket"></param>
        private void StartCommunication5(ref Socket AcceptSocket)
        {
            try
            {
                byte[] buffer = new byte[1024];
                while (true)
                {


                    Thread.Sleep(2000);

                    int available = AcceptSocket.Available;

                    DateTime timeoutAt = DateTime.Now.AddSeconds(15);
                    Int32 _Available = AcceptSocket.Available;
                    while (_Available == 0 && DateTime.Now < timeoutAt)
                    {
                        try
                        {
                            _Available = AcceptSocket.Available;
                        }
                        catch
                        {
                            break;
                        }

                        System.Threading.Thread.Sleep(100);
                    }
                    if (_Available > 0)
                    {
                        int n = 0;
                        while (AcceptSocket.Poll(500000, SelectMode.SelectRead) && n < 120)
                        {
                            EndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 55555);
                            n = AcceptSocket.ReceiveFrom(buffer, ref localEndPoint);
                            if (n == 120)
                            {
                                byte[] data = new byte[n];
                                Array.Copy(buffer, data, n);
                                if (OnGetIpAndMac != null)
                                {
                                    ProXRDeviceInfo info = new ProXRDeviceInfo();
                                    info.IP = ((IPEndPoint)localEndPoint).Address.ToString();
                                    int nPort = buffer[8] * 256 + buffer[9];

                                    info.Parse5(data);
                                    OnGetIpAndMac(info);
                                }
                            }
                        }
                    }
                }

            }
            catch
            {

            }
        }
    }

}