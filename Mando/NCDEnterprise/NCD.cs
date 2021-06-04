using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO.Ports;
using System.Security.Permissions;
using NCDEnterprise.ProXR;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections;

[assembly: FileIOPermission(SecurityAction.RequestMinimum)]

[assembly: CLSCompliant(true)]

namespace NCDEnterprise
{

    
    /// <summary>
    /// Provides methods to control relays of ProXR board.
    /// </summary>
    //[ToolboxBitmapAttribute( "NCDICON.BMP")]
    public partial class NCDController : Component
    {

        /// <summary>
        /// Event raised when there is a byte written to serial port
        /// </summary>
        public event EventHandler<WriteDataEventArgs > OnWriteData;
        /// <summary>
        /// Eevent raised when there is a byte read from serial port
        /// </summary>
        public event EventHandler<ReadDataEventArgs>  OnReadData;

        //flag for high speed writting/reading. Be Careful, it only work with direct usb access
        public bool HighSpeed = false;   

        /// <summary>
        /// Create ProXR Object.
        /// </summary>
        public NCDController()
        {
            InitializeComponent();
            CreateDevices();
        }

        /// <summary>
        /// Create ProXR Object.
        /// </summary>
        /// <param name="container">container object</param>
        public NCDController(IContainer container)
        {
            if (container != null)
            {
                container.Add(this);
            }
            InitializeComponent();
            CreateDevices();
        }

        #region device Declaration

        private IProXR mPROXR = null;
        private ITimers mTimers = null;
        private ProXR.CAdvanceConfiguration mAdvancedConfiguration = null;
        private IE3C mE3C = null;
        private IMesh mMesh = null;
        private ISeries1 mSeries1 = null;
        private IR2X mR2x = null;
        private IR2X mZR2x = null;
        
        
        /// <summary>
        /// R2x object
        /// </summary>
        public IR2X R2x
        {
            get 
            { 
                return mR2x; 
            }
        }

        /// <summary>
        /// R2x object
        /// </summary>
        public IR2X ZR2x
        {
            get
            {
                return mZR2x;
            }
        }


        private IR8XPro mR8x = null;


        /// <summary>
        /// R8X Pro object
        /// </summary>
        public IR8XPro R8xPro
        {
            get 
            { 
                return mR8x; 
            }
        }

        private IPWM mPWM = null;


        /// <summary>
        /// PWM object
        /// </summary>
        public IPWM PWM
        {
            get 
            { 
                return mPWM; 
            }
        }


      //  private IASELPro mASELPro = null;
      //
      //  /// <summary>
      //  /// ASEL Pro object
      //  /// </summary>
      //  public IASELPro ASELPro
      //  {
      //      get { return mASELPro; }
      //  }


        private bool mIsTwoWay = true;  // falg for if the board works in two way

        /// <summary>
        /// Property for communication in two way.
        /// </summary>
        public bool IsTwoWay
        {
            get
            {
                return mIsTwoWay;
            }
            set
            {
                mIsTwoWay = value;
                if (mIsTwoWay)
                {
                    TurnOnReportMode();
                }
                else
                {
                    TurnOffReportMode();
                }


            }
        }


        /// <summary>
        /// ProXR Object
        /// </summary>
        public IProXR ProXR
        {
            get
            {
                return mPROXR;
            }
        }

        /// <summary>
        /// Get Mesh Object
        /// </summary>
        public IMesh Mesh
        {
            get
            {
                return mMesh;
            }
        }

        /// <summary>
        /// Get Series1 type zigBee Object
        /// </summary>
        public ISeries1 Series1
        {
            get
            {
                return mSeries1;
            }
        }

        /// <summary>
        /// Get Timers object
        /// </summary>
        public ITimers Timers
        {
            get
            {
                return mTimers;
            }
        }

        /// <summary>
        /// Get AdvanceConfiguration object.
        /// </summary>
        internal ProXR.IAdvanceConfiguration AdvanceConfiguration
        {
            get
            {
                return mAdvancedConfiguration;
            }
        }

        /// <summary>
        /// Get E3C object.
        /// </summary>
        public IE3C E3C
        {
            get
            {
                return mE3C;
            }
        }

        private IFusion mFusion;

        public IFusion Fusion
        {
            get { return mFusion; }
            set { mFusion = value; }
        }


        private ITaraList mTaraList;

        /// <summary>
        /// Get TaraList Object
        /// </summary>
        public ITaraList TaraList
        {
            get
            {
                return mTaraList;
            }
        }

        private IReactor mReactor;
        /// <summary>
        /// Get Reactor object
        /// </summary>
        public IReactor Reactor
        {
            get
            {
                return mReactor;
            }
        }


#endregion


        #region Members
        private CommunicationLayer mCOM = new CommunicationLayer();

        #endregion

        #region Property

        private DeviceConfig mDeviceConfig = new DeviceConfig();


        /// <summary>
        /// Gets a value indicating the open or closed status of the serial port.
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return mCOM.IsOpen;
            }
        }
        /// <summary>
        /// Represents the name of COM port. Example: COM1
        /// </summary>
        public string PortName
        {
            get
            {
                return mDeviceConfig.PortData.portName;
            }
            set
            {
                mDeviceConfig.PortData.portName = value;
            }
        }

        /// <summary>
        /// Represents the baudrate of the Com Port. Example: 38400
        /// </summary>
        public int BaudRate
        {
            get
            {
                return mDeviceConfig.PortData.baudRate;
            }
            set
            {
                mDeviceConfig.PortData.baudRate = value;
            }
        }

        /// <summary>
        /// Use Com Port
        /// </summary>
        public bool UsingComPort
        {
            get
            {
                return mDeviceConfig.UsingComPort;
            }
            set
            {
                mDeviceConfig.UsingComPort = value;
            }
        }

        /// <summary>
        /// Use Wireless
        /// </summary>
        public bool RemoteWirelessNode
        {
            get
            {
                return mDeviceConfig.RemoteWirelessNode;
            }
            set
            {
                mDeviceConfig.RemoteWirelessNode = value;
            }
        }

        /// <summary>
        /// Zigbee module Destination address high
        /// </summary>
        public Int32  WirelessDestHigh
        {
            get
            {
                return mDeviceConfig.WirelessDestHigh;
            }
            set
            {
                mDeviceConfig.WirelessDestHigh = value;
            }
        }

        /// <summary>
        /// Zigbee module Destination address low
        /// </summary>
        public Int32 WirelessDestLow
        {
            get
            {
                return mDeviceConfig.WirelessDestLow;
            }
            set
            {
                mDeviceConfig.WirelessDestLow = value;
            }
        }

        /// <summary>
        /// Represents the name of COM port. Example: COM1
        /// </summary>
        public string IPAddress
        {
            get
            {
                return mDeviceConfig.Network.IPAddress;
            }
            set
            {
                mDeviceConfig.Network.IPAddress = value;
            }
        }

        /// <summary>
        /// Represents the port number of the connection
        /// </summary>
        public int Port
        {
            get
            {
                return mDeviceConfig.Network.NetworkPort;
            }
            set
            {
                mDeviceConfig.Network.NetworkPort = value;
            }
        }


        #endregion

        #region Methodes
        /// <summary>
        /// Open the Com Port
        /// </summary>
        public void OpenPort()
        {
            mCOM.SetParameters(mDeviceConfig);
            mCOM.Open();
            mCOM.ReadTimeout = 100;  
        }

        public void OpenPort(int timeout)
        {
            mCOM.SetParameters(mDeviceConfig);
            mCOM.Open(timeout);
            mCOM.ReadTimeout = 100;  
        }

        /// <summary>
        /// Close the Com Port
        /// </summary>
        public void ClosePort()
        {
            if (mCOM.IsOpen)
            {
                mCOM.Close();
            }
        }


        /// <summary>
        /// Purge the COM Port
        /// </summary>
        public void Purge()
        {
            if (mCOM.IsOpen)
            {
                if (HighSpeed)
                {
                }
                else
                {
                    Sleep(30);
                }
                mCOM.Purge();
            }
        }

        /// <summary>
        /// calculate the checksum of the data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private byte GetCheckSum(byte[] data)
        {
            int checksum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                checksum = checksum + data[i];
            }
            checksum = checksum % 0x100;
            return (byte)checksum;
        }

        public string LastRecString = string.Empty;



        /// <summary>
        /// Read All Bytes from port directly
        /// return null if nothing come back
        /// </summary>
        /// <returns></returns>
        public byte[] ReadAllBytes()
        {
            LastRecString = "";
            ArrayList arr = new ArrayList();
            int n = ReadByte();
            while (n != -1)
            {
                arr.Add((byte)n);
                n = ReadByte();
            }
            byte[] rtn = (byte[])arr.ToArray(typeof(byte));
            return rtn;

        }

        /// <summary>
        /// Read data in api format, return null if read nothing
        /// </summary>
        /// <returns></returns>
        public byte[] ReadBytesApi()
        {
            LastRecString = "";
            byte[] apiData = null;
            if (RemoteWirelessNode)
            {
                int r = ReadByte();
                if(r != 126)
                {
                    Purge();
                    return apiData;
                }
                int msb, lsb;
                msb = ReadByte();
                lsb = ReadByte();
                if (msb == -1 || lsb == -1)
                {
                    return apiData;
                }
                int frameType = ReadByte();

                if (frameType != 0x90)
                {
                    return null;
                }
                int a1, a2, a3, a4;
                a1 = ReadByte();
                a2 = ReadByte();
                a3 = ReadByte();
                a4 = ReadByte();
                if(a1 == -1 || a2 == -1 || a3 == -1 || a4 == -1)
                {
                    return apiData;
                }
                Int32 addrHigh = (a1 << 24) + (a2 << 16) + (a3 << 8) + a4;

                a1 = ReadByte();
                a2 = ReadByte();
                a3 = ReadByte();
                a4 = ReadByte();
                if (a1 == -1 || a2 == -1 || a3 == -1 || a4 == -1)
                {
                    return apiData;
                }

                Int32 addrLow = (a1 << 24) + (a2 << 16) + (a3<< 8) + a4;
                if (addrHigh == WirelessDestHigh && addrLow == WirelessDestLow)
                {

                }
                else
                {
                    return apiData;    // wrong address
                }
                // data[12], data[13] // short address
                // data[14],  options
                ReadByte();
                ReadByte();
                ReadByte();

            }

            int ack = ReadByte();
            if(ack != 170)
            {
                Purge();
                return apiData;
            }

            bool correctData = true;
            int length = ReadByte();
            if (length != -1)
            {
                apiData = new byte[length];
                for (int i = 0; i < length; i++)
                {
                    int data = ReadByte();
                    if (data != -1)
                    {
                        apiData[i] = (byte)data;
                    }
                    else
                    {
                        correctData = false;
                        break;
                    }
                }
                if (correctData)
                {
                    int data = ReadByte();
                    if (data != -1)
                    {
                        int checksum = 170 + length + GetCheckSum(apiData);
                        checksum = checksum % 0x100;
                        if (data != checksum)
                        {
                            correctData = false;
                        }
                    }
                    else
                    {
                        correctData = false;
                    }

                }
            }
            else
            {
                correctData = false;
            }
            if (correctData)
            {
                Purge();    //read rest of data
                return apiData;
            }
            return null;
 
        }

        public string LastSendString = "";

        /// <summary>
        /// get a showing string
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private static string GetShowString(int v)
        {
            return string.Format("{0:X2} ", v);
        }

        private static string GetShowString(byte[] data)
        {
            string str = string.Empty;
            if (data != null)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    str += GetShowString(data[i]);
                }
            }
            return str;
        }
        /// <summary>
        /// Write data in api format
        /// </summary>
        /// <param name="data"></param>
        public void WriteBytesAPI(params byte[] data)
        {
            if (mCOM.IsOpen)
            {
                LastSendString = "";
                mCOM.SetTCPWritePace(0);
                ArrayList ApiPackage = new ArrayList();
                ApiPackage.Add((byte)170);
                ApiPackage.Add((byte)data.Length);
                ApiPackage.AddRange(data);
                int checksum = 0;
                checksum = checksum + 170;
                checksum = checksum + data.Length;
                for (int i = 0; i < data.Length; i++)
                {
                    checksum = checksum + data[i];
                }
                checksum = checksum % 0x100;
                ApiPackage.Add((byte)checksum);
                byte[] apiData = (byte[])ApiPackage.ToArray(typeof(byte));
                WriteBytes(apiData);
            }
        }

        /// <summary>
        /// Write a byte to Com port
        /// </summary>
        /// <param name="data"></param>
        public void WriteByte(byte data)
        {
            if (mCOM.IsOpen)
            {
                mCOM.WriteByte(data);
                if (OnWriteData != null)
                {
                    OnWriteData(this, new WriteDataEventArgs(data));
                }
            }
        }

        /// <summary>
        /// Write a byte to Com port
        /// </summary>
        /// <param name="data"></param>
        public void WriteBytes(params byte [] data)
        {
            if (mCOM.IsOpen)
            {
                if (RemoteWirelessNode)
                {
                    byte[] apiData = WrapWirelessData(data);
                    LastSendString = GetShowString(apiData);
                    mCOM.WriteBytes(apiData);
                }
                else
                {
                    LastSendString = GetShowString(data);
                    mCOM.WriteBytes(data);
                }
                if (OnWriteData != null)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        OnWriteData(this, new WriteDataEventArgs(data[i]));
                    }
                }
            }
        }

        public void TRIIWriteBytes(params byte[] data)
        {
            if (mCOM.IsOpen)
            {
                mCOM.TRIIWriteBytes(data);
                if (OnWriteData != null)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        OnWriteData(this, new WriteDataEventArgs(data[i]));
                    }
                }
            }
        }

        /// <summary>
        /// Flush the data in write buffer to port, it is added for network communiction only
        /// Serial port will write the to port immediately
        /// </summary>
        public void Flush()
        {
            if (mCOM.IsOpen)
            {
                mCOM.Flush();
            }
        }

        /// <summary>
        /// Write bytes array with pace between each byte
        /// </summary>
        /// <param name="sleepTime">in millseconds</param>
        /// <param name="data"></param>
        internal void WriteBytesWithSleep(int sleepTime, params byte[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                WriteByte(data[i]);
                Sleep(sleepTime);
            }
        }

        /// <summary>
        /// Write a string to Com port
        /// </summary>
        /// <param name="data"></param>
        public void WriteString(string data)
        {
            if (mCOM.IsOpen)
            {
                byte[] buf = Encoding.ASCII.GetBytes(data);
                for (int i = 0; i < buf.Length; i++)
                {
                    mCOM.WriteByte(buf[i]);
                }
            }
        }

        /// <summary>
        /// Read a byte from Com Port
        /// </summary>
        /// <param name="data">data been read</param>
        /// <returns>true for success</returns>
        internal bool _ReadByte(out byte data)
        {
            bool bRtn = false;
            data = 0;
            if (mCOM.IsOpen)
            {
                try
                {
                    data = (byte)mCOM.ReadByte();
                    if (OnReadData != null)
                    {
                        OnReadData(this, new ReadDataEventArgs(data, false));
                    }
                    bRtn = true;

                }
                catch (TimeoutException ex)
                {
                    Debug.Print(ex.ToString());
                    if (OnReadData != null)
                    {
                        OnReadData(this, new ReadDataEventArgs(0, true));
                    }

                }

            }
            return bRtn;
        }

        /// <summary>
        /// Ready a byte from Com port
        /// </summary>
        /// <returns>0 - 255, the data read, -1 for failure</returns>
        public int ReadByte()
        {
            int nRtn = -1;
            try
            {
                byte data = 0;
                if (_ReadByte(out data))
                {
                    nRtn = data;
                    LastRecString += GetShowString(nRtn);
                }

            }
            catch
            {

            }
            return nRtn;
        }
        /// <summary>
        /// Create all devices here
        /// </summary>
        private void CreateDevices()
        {
            mPROXR = new CPROXR(this);
            mAdvancedConfiguration = new NCDEnterprise.ProXR.CAdvanceConfiguration(this);
            mE3C = new NCDEnterprise.CE3C(this);
            mMesh = new NCDEnterprise.CMesh(this);
            mSeries1 = new NCDEnterprise.CSeries1(this);
            mR2x = new NCDEnterprise.R2X(this);
            mZR2x = new NCDEnterprise.ZR2X(this);
            mR8x = new NCDEnterprise.R8XPro(this);
            mPWM = new NCDEnterprise.PWM(this);
           // mASELPro = new NCDEnterprise.ASELPro(this);
            mTimers = new NCDEnterprise.CTimers(this);
            mReactor = new Reactor(this);
            mTaraList = new TaraList(this);
            mFusion = new Fusion(this);
        }

        private NCDEnterprise.IRelayBanks RelayBanks
        {
            get 
            {
                return mPROXR.RelayBanks;
            }
        }

        #endregion

        #region PROXR Boards Level Function


        /// <summary>
        /// Turns on report mode.
        /// </summary>
        /// <remarks>
        /// Reporting mode, by default, is ON, meaning every time a command is sent to the controller, 
        /// the controller will send an 85 back to the computer, indicating that the command has finished executing 
        /// your instructions. We recommend leaving it on, but doing so requires 2-Way communication with the controller. 
        /// You should turn it off if you intend to use 1-Way communication only. 
        /// A delay between some commands may be required when using 1-Way communications. 
        /// For optimum reliability, leave reporting mode on and use 2-Way communications with the IProXR Series controllers.
        /// </remarks>
        /// <returns>True for success</returns>
        
        
        public bool TurnOnReportMode()
        {
            mIsTwoWay = true;
            return mPROXR.TurnOnReportMode();
        }

        /// <summary>
        /// Turn off report mode.
        /// </summary>
        /// <remarks>
        /// Reporting mode, by default, is ON, meaning every time a command is sent to the controller, 
        /// the controller will send an 85 back to the computer, indicating that the command has finished executing 
        /// your instructions. We recommend leaving it on, but doing so requires 2-Way communication with the controller. 
        /// You should turn it off if you intend to use 1-Way communication only. 
        /// A delay between some commands may be required when using 1-Way communications. 
        /// For optimum reliability, leave reporting mode on and use 2-Way communications with the IProXR Series controllers.
        /// </remarks>
        /// <returns>True for success</returns>
        public bool TurnOffReportMode()
        {
            mIsTwoWay = false;
            return mPROXR.TurnOffReportMode();
        }
        #endregion

        #region Relaybanks functinos

        ///// <summary>
        ///// Directs commands to a selected relay bank.  
        ///// All subsequent commands will be sent to the selected relay bank.
        ///// </summary>
        ///// <param name="bankId">Bank number, 0 - 32</param>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        ///// <returns> true for success</returns>
        ///// <remarks>
        ///// A Bank Value of 0 applies this command to all relay banks.
        ///// </remarks>
        //public bool SelectBank(byte bankId)
        //{
        //    return RelayBanks.SelectBank(bankId);
        //}


        ///// <summary>
        ///// Turns off individual relays in the current selected bank.
        ///// </summary>
        ///// <param name="relayId">Relay number, 0 - 7</param>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        ///// <returns> true for success</returns>
        //public bool TurnOffRelay(byte relayId)
        //{
        //    return RelayBanks.TurnOffRelay(relayId);
        //}

        ///// <summary>
        ///// Turns on individual relays in the current selected bank.
        ///// </summary>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        ///// <param name="relayId">Relay number, 0 - 7</param>
        ///// <returns> true for success</returns>
        //public bool TurnOnRelay(byte relayId)
        //{
        //    return RelayBanks.TurnOnRelay(relayId);
        //}

        ///// <summary>
        ///// Turns off individual relays in the given bank.
        ///// </summary>
        ///// <param name="relayId">Relay number, 0 - 7</param>
        ///// <param name="bankId">Bank number, 0 - 32</param>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        ///// <remarks>
        ///// A Bank Value of 0 applies this command to all relay banks.
        ///// </remarks>
        ///// <returns> true for success</returns>
        //public bool TurnOffRelayInBank(byte relayId, byte bankId)
        //{
        //    return RelayBanks.TurnOffRelayInBank(relayId, bankId);
        //}

        ///// <summary>
        ///// Turns on individual relays in the given bank.
        ///// </summary>
        ///// <param name="relayId">Relay number, 0 - 7</param>
        ///// <param name="bankId">Bank number, 0 - 32</param>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        ///// <remarks>
        ///// A Bank Value of 0 applies this command to all relay banks.
        ///// </remarks>  
        ///// <returns> true for success</returns> 
        //public bool TurnOnRelayInBank(byte relayId, byte bankId)
        //{
        //    return RelayBanks.TurnOnRelayInBank(relayId, bankId);
        //}

        ///// <summary>
        ///// Gets the status of an individual relay in the current selected bank.
        ///// </summary>
        ///// <param name="relayId">Relay number, 0 - 7</param>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        ///// <exception cref="TimeoutException">Read Timeout</exception>
        ///// <returns>ON or OFF</returns>
        ///// <remarks>A BANK VALUE OF 0 IS INVALID FOR THIS COMMAND.RETURNED RESULTS MAY BE UNPREDICTABLE.</remarks>
        //public RelayStatus GetStatus(byte relayId)
        //{
        //    return RelayBanks.GetStatus(relayId);
        //}

        ///// <summary>
        ///// Gets the status of an individual relay in the given bank.
        ///// </summary>
        ///// <param name="relayId">Relay number, 0 - 7</param>
        ///// <param name="bankId">Bank number, 0 - 32</param>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        ///// <exception cref="TimeoutException">Read Timeout</exception>
        ///// <returns>ON or OFF</returns>
        ///// <remarks>
        ///// A BANK VALUE OF 0 IS INVALID FOR THIS COMMAND.RETURNED RESULTS MAY BE UNPREDICTABLE.
        ///// </remarks>
        //public RelayStatus GetStatusInBank(byte relayId, byte bankId)
        //{
        //    return RelayBanks.GetStatusInBank(relayId, bankId);
        //}

        ///// <summary>
        ///// Turns on auto relayId refresh .
        ///// </summary>
        ///// <remarks>
        ///// Meaning every time you send a relay control command, the relays will respond to your commands.
        ///// </remarks>
        ///// <returns> true for success</returns>
        //public bool TurnOnAutoRelayRefresh()
        //{
        //    return RelayBanks.TurnOnAutoRelayRefresh();
        //}

        ///// <summary>
        ///// Turns off auto relay refresh. 
        ///// </summary>
        ///// <remarks>
        ///// Turning off relay refreshing allows you to control when the relays actually switch. 
        ///// When refreshing is turned off, you can send relay control commands to the ProXR controller,
        ///// and the controller will work just like normal, but the relays will never change state.
        ///// </remarks>
        ///// <returns> true for success</returns>
        //public bool TurnOffAutoRelayRefresh()
        //{
        //    return RelayBanks.TurnOffAutoRelayRefresh();
        //}

        ///// <summary>
        ///// Stores relay refreshing mode
        ///// </summary>
        ///// <returns> true for success</returns>
        //public bool StoreRefreshSettings()
        //{
        //    return RelayBanks.StoreRefreshSettings();
        //}

        ///// <summary>
        ///// Reads the stored refresh settings.
        ///// </summary>
        ///// <exception cref="TimeoutException">Read Timeout</exception>
        ///// <returns>ON or OFF</returns>
        //public AutoRefreshSetting ReportStoredRefreshSettings()
        //{
        //    return RelayBanks.ReportStoredRefreshSettings();
        //}

        ///// <summary>
        ///// Sets the status of all relays at one time.
        ///// </summary>
        ///// <returns> true for success</returns>
        //public bool ManuallyRefresh()
        //{
        //    return RelayBanks.ManuallyRefresh();
        //}

        ///// <summary>
        ///// Turns all relays on.
        ///// </summary>
        ///// <returns> true for success</returns>
        //public bool TurnOnAllRelays()
        //{
        //    return RelayBanks.TurnOnAllRelays();
        //}

        ///// <summary>
        ///// Turns all relays on in the given bank.
        ///// </summary>
        ///// <param name="bankId">Bank number, 0 - 32</param>
        ///// <remarks>
        ///// A Bank Value of 0 applies this command to all relay banks.
        ///// </remarks>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        ///// <returns> true for success</returns>

        //public bool TurnOnAllRelaysInBank(byte bankId)
        //{
        //    return RelayBanks.TurnOnAllRelaysInBank(bankId);
        //}

        ///// <summary>
        ///// Turns off all relays in the current selected bank.
        ///// </summary>
        ///// <returns> true for success</returns>
        //public bool TurnOffAllRelays()
        //{
        //    return RelayBanks.TurnOffAllRelays();
        //}

        ///// <summary>
        ///// Turns all relays off in the given bank.
        ///// </summary>
        ///// <param name="bankId">Bank number, 0 - 32</param>
        ///// <remarks>
        ///// A Bank Value of 0 applies this command to all relay banks.
        ///// </remarks>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        ///// <returns> true for success</returns>
        //public bool TurnOffAllRelaysInBank(byte bankId)
        //{
        //    return RelayBanks.TurnOffAllRelaysInBank(bankId);
        //}

        ///// <summary>
        ///// Inverts the status of all relays.
        ///// </summary>
        ///// <returns> true for success</returns>
        //public bool InvertAllRelays()
        //{
        //    return RelayBanks.InvertAllRelays();
        //}

        ///// <summary>
        ///// Inverts the status of all relays in the given bank.
        ///// </summary>
        ///// <param name="bankId">bankId: Bank number, 0 - 32</param>
        ///// <remarks>
        ///// A Bank Value of 0 applies this command to all relay banks.
        ///// </remarks>
        ///// <returns> true for success</returns>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        //public bool InvertAllRelaysInBank(byte bankId)
        //{
        //    return RelayBanks.InvertAllRelaysInBank(bankId);
        //}


        ///// <summary>
        ///// Reverses the current pattern of relays in the current selected bank.
        ///// </summary>
        ///// <returns> true for success</returns>
        //public bool ReverseAllRelays()
        //{
        //    return RelayBanks.ReverseAllRelays();
        //}

        ///// <summary>
        ///// Reverses the current pattern of relays in a given relayId bank.
        ///// </summary>
        ///// <param name="bankId">Bank number, 0 - 32</param>
        ///// <remarks>
        ///// A Bank Value of 0 applies this command to all relay banks.
        ///// </remarks>
        ///// <returns> true for success</returns>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        //public bool ReverseAllRelaysInBank(byte bankId)
        //{
        //    return RelayBanks.ReverseAllRelaysInBank(bankId);
        //}


        ///// <summary>
        ///// Reports to user the selected relay bank.
        ///// </summary>
        ///// <exception cref="TimeoutException">Read Timeout</exception>
        ///// <returns>1 - 32: Bank number, 0: All banks</returns>
        //public byte GetSelectedBank()
        //{
        //    return RelayBanks.GetSelectedBank();
        //}

        ///// <summary>
        ///// Writes a byte of data directly to a relay bank. 
        ///// </summary>
        ///// <param name="status">8-bit status of the relays in a bankId, 0 - 255</param>
        ///// <remarks>
        ///// This allows you to easily set the status of 8 relays at one time. 
        ///// Status is a parameter value from 0-255. A value of 0 turns off all the relays. A value of 255 turns on all the relays. 
        ///// Other values set the status of the relays in the equivalent binary pattern of the relayData parameter value.
        ///// </remarks>
        ///// <returns> true for success</returns>
        //public bool SetRelayStatus(byte status)
        //{
        //    return RelayBanks.SetRelayStatus(status);
        //}

        ///// <summary>
        ///// Sets status of all relays at one time
        ///// </summary>
        ///// <param name="status">8-bit status of the relays in a bank, 0 - 255</param>
        ///// <param name="bankId">Bank number, 0 - 32</param>
        ///// <remarks>
        ///// This allows you to easily set the status of 8 relays at one time. Status is a parameter value from 0-255.
        ///// A value of 0 turns off all the relays. A value of 255 turns on all the relays. 
        ///// Other values set the status of the relays in the equivalent binary pattern of the status parameter value.
        ///// A Bank Value of 0 applies this command to all relay banks.
        ///// </remarks>
        ///// <returns> true for success</returns>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        //public bool SetRelayStatusInBank(byte status, byte bankId)
        //{
        //    return RelayBanks.SetRelayStatusInBank(status, bankId);
        //}

        ///// <summary>
        ///// Stores the current status of the relays in a given bank into memory. 
        ///// </summary>
        ///// <remarks>
        ///// The next time power is applied to the controller, relays will return to the stored on/off state. 
        ///// </remarks>
        ///// <returns> true for success</returns>
        //public bool StorePowerUpSatus()
        //{
        //    return RelayBanks.StorePowerUpSatus();
        //}

        ///// <summary>
        ///// Stores the current status of the relays in a given bank into memory. 
        ///// </summary>
        ///// <param name="bankId">Bank number, 0 - 32</param>
        ///// <remarks>
        ///// The next time power is applied to the controller, relays will return to the stored on/off state.
        ///// A bank value of 0 stores the pattern of all relays in all 32 banks.
        ///// </remarks>
        ///// <returns> true for success</returns>
        ///// <exception cref="ArgumentException">Wrong arguments</exception>
        //public bool StorePowerUpSatusInBank(byte bankId)
        //{
        //    return RelayBanks.StorePowerUpSatusInBank(bankId);
        //}


        ///// <summary>
        ///// Turns on one relay only, safe break before make.
        ///// </summary>
        ///// <param name="relayId">Relay number, 0 - 255</param>
        ///// <returns> true for success</returns>
        //public bool TurnOnOneRelayOnly(byte relayId)
        //{
        //    return RelayBanks.TurnOnOneRelayOnly(relayId); 
        //}

        ///// <summary>
        ///// Turns off a relay specified by its relay number.
        ///// </summary>
        ///// <param name="relayId">Relay number, 0 - 255 </param>
        ///// <returns> true for success</returns>
        //public bool TurnOffRelayAdvanced(byte relayId)
        //{
        //    return RelayBanks.TurnOffRelayAdvanced(relayId);
        //}

        ///// <summary>
        ///// Turns on a relay specified by its relay number.
        ///// </summary>
        ///// <param name="relayId">Relay number, 0 - 255</param>        
        ///// <returns> true for success</returns>
        //public bool TurnOnRelayAdvanced(byte relayId)
        //{
        //    return RelayBanks.TurnOnRelayAdvanced(relayId);
        //}

        ///// <summary>
        ///// Reads the stored power-up default status of the relays in current selected bank.
        ///// </summary>
        ///// <returns>Array that holds the status of current selected bank</returns>
        ///// <remarks>
        ///// Returns null if fail to read from COM port. The array contains one item if not all banks are selected.
        ///// </remarks>
        ///// <exception cref="TimeoutException">Read Timeout</exception>
        //public byte[] ReadPowerUpDefaultStatus()
        //{
        //    return RelayBanks.ReadPowerUpDefaultStatus();
        //}

        ///// <summary>
        ///// Reads the stored power-up default status of the relays in a given bankId.
        ///// </summary>
        ///// <param name="bankId">Bank number, 0 - 32</param>
        ///// <returns>Array that holds the status of current given bank</returns>
        ///// <remarks>
        ///// Returns null if fail to read from COM port. The array contains one item if not all banks are selected.
        ///// A bank value of 0 reports the status of all relays in all 32 banks.
        ///// </remarks>
        ///// <exception cref="TimeoutException">Read Timeout</exception>
        //public byte[] ReadPowerUpDefaultStatusInBank(byte bankId)
        //{
        //    return RelayBanks.ReadPowerUpDefaultStatusInBank(bankId);
        //}

        ///// <summary>
        ///// Gets the status of all relays in the current selected bankId.
        ///// </summary>
        ///// <returns>Array that holds the status of relays in all bank</returns>
        ///// <remarks>
        ///// Returns null if fail to read from COM port. The array contains one item if not all banks are selected.
        ///// </remarks>
        ///// <exception cref="TimeoutException">Read Timeout</exception>
        //public byte[] GetStatusInAllBanks()
        //{
        //    return RelayBanks.GetAllStatusInBank(0);
        //}


        ///// <summary>
        ///// Gets the status of all relays in the given bank.
        ///// </summary>
        ///// <param name="bankId">Bank number, 1 - 32</param>
        ///// <returns>Array that holds the status of current selected bank</returns>
        ///// <remarks>
        ///// Returns null if fail to read from COM port. The array contains one item if not all banks are selected.
        ///// </remarks>
        ///// <exception cref="TimeoutException">Read Timeout</exception>
        ///// <exception cref="ArgumentOutOfRangeException">Wrong argument</exception>
        //public byte GetAllRelaysStatusInBank(byte bankId)
        //{
        //    if (bankId == 0 || bankId > 32)
        //    {
        //        throw new ArgumentOutOfRangeException("Bank ID", bankId, "Invalid bank id");
        //    }
        //    return RelayBanks.GetAllStatusInBank(bankId)[0];
        //}


        #endregion



        /// <summary>
        /// Show setting port dialog and set the com port and baudrate
        /// </summary>
        public System.Windows.Forms.DialogResult SettingPort() 
        {
            PortSetting dlg = new PortSetting();
            dlg.PortName = PortName;
            dlg.baudrate = BaudRate;
            dlg.WirelessDestHigh = mDeviceConfig.WirelessDestHigh;
            dlg.WirelessDestLow = mDeviceConfig.WirelessDestLow;
            dlg.UseWireless = RemoteWirelessNode;
            dlg.IPAddress = IPAddress;
            dlg.Port = Port;
            dlg.UsingComPort = UsingComPort;
            System.Windows.Forms.DialogResult r = dlg.ShowDialog(); 
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                bool bOpen = false;
                if (mCOM.IsOpen)
                {
                    mCOM.Close();
                    bOpen = true;
                }
                PortName = dlg.PortName;
                BaudRate = dlg.baudrate;
                IPAddress = dlg.IPAddress;
                Port = dlg.Port;
                WirelessDestHigh = dlg.WirelessDestHigh;
                WirelessDestLow = dlg.WirelessDestLow;
                RemoteWirelessNode = dlg.UseWireless;
                UsingComPort = dlg.UsingComPort;
                if (bOpen)
                {
                    mCOM.Open();
                }
            }
            return r; 
        }

        /// <summary>
        /// Show setting port dialog and set the com port and baudrate
        /// </summary>
        public System.Windows.Forms.DialogResult SettingPort(bool showBaudrate)
        {
            PortSetting dlg = new PortSetting();
            dlg.PortName = PortName;
            dlg.baudrate = BaudRate;
            dlg.IPAddress = IPAddress;
            dlg.Port = Port;
            dlg.UsingComPort = UsingComPort;
            dlg.ShowBaudrate = showBaudrate;
            System.Windows.Forms.DialogResult r = dlg.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                bool bOpen = false;
                if (mCOM.IsOpen)
                {
                    mCOM.Close();
                    bOpen = true;
                }
                PortName = dlg.PortName;
                BaudRate = dlg.baudrate;
                IPAddress = dlg.IPAddress;
                Port = dlg.Port;
                UsingComPort = dlg.UsingComPort;
                if (bOpen)
                {
                    mCOM.Open();
                }
            }
            return r;
        }

        /// <summary>
        /// Tests 2-Way communications between the PC and the relay controller.
        /// </summary>
        /// <returns> true for success</returns>
        public bool Test2Ways()
        {
            return RelayBanks.Test2Ways();
        }

        /// <summary>
        /// Test 2 -way communciation between the PC and the relay controller, 
        /// will return -1 for failure,
        /// or 85 or 86 
        /// </summary>
        /// <returns></returns>
        public int Test2Ways2()
        {
            // 33 Test 2-Way Communications with Controller
            WriteBytes(254, 33);

            int n = ReadByte();

            return n;
        }

        /// <summary>
        /// sleep for specific time
        /// </summary>
        /// <param name="ms">millsecond</param>
        public void Sleep(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }

        /// <summary>
        /// Read timeout value
        /// </summary>
        public int ReadTimeOut
        {
            get
            {
                return mCOM.ReadTimeout;
            }
            set
            {
                mCOM.ReadTimeout = value;
            }
        }


        internal bool GetAck()
        {
            bool bRtn = false;
            if (mIsTwoWay)
            {
                int value = ReadByte();
                if (value == 85)
                {
                    bRtn = true;
                }
                else if(value == 86)
                {
                    // in configuration mode, an exception will be thrown in new versino
                }
                else if (value == 90)
                {
                    // in active timer calibration mode, it return 90
                    bRtn = true;
                }
            }
            else
            {
                bRtn = true;
            }
            return bRtn;
        }

        /// <summary>
        /// Load the last work seting
        /// </summary>
        public void LoadLastSetting()
        {
            string filename = "lastworkingsetting.xml";
            LoadSetting(filename);
        }

        /// <summary>
        /// Load the last work seting
        /// </summary>
        public void LoadSetting(string filename)
        {
            if (File.Exists(filename))
            {
                XmlReader reader = XmlReader.Create(filename);
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(DeviceConfig));
                    mDeviceConfig = (DeviceConfig)serializer.Deserialize(reader);
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    reader.Close();
                }
            }
        }

        /// <summary>
        /// save the last setting to default configuration file. 
        /// The file name is lastworkingsetting.xml
        /// </summary>
        public void SaveLastSetting()
        {
            SaveSetting("lastworkingsetting.xml");
        }

        /// <summary>
        /// save the setting to file
        /// </summary>
        /// <param name="filename"></param>
        public void SaveSetting(string filename)
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "  ";
                XmlWriter writer = XmlWriter.Create(filename, settings);
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add(String.Empty, String.Empty);
                XmlSerializer serializer = new XmlSerializer(typeof(DeviceConfig));
                serializer.Serialize(writer, mDeviceConfig, ns);
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
            }

        }


        /// <summary>
        /// set the write pace between bytes for tcp layer
        /// </summary>
        /// <param name="ms"></param>
        public void SetTcpWritePace(int ms)
        {
            mCOM.SetTCPWritePace(ms);
        }


        /// <summary>
        /// Help funtion to extract address to 4 bytes, 
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        private byte[] GetAddressBytes(Int32 addr)
        {
            byte[] addrBytes = new byte[4];
            addrBytes[0] = (byte)((addr & 0xff000000) >> 24);
            addrBytes[1] = (byte)((addr & 0xff0000) >> 16);
            addrBytes[2] = (byte)((addr & 0xff00) >> 8);
            addrBytes[3] = (byte)((addr & 0xff) );

            return addrBytes;
        }

        /// <summary>
        /// Wrap the data in wireless frame
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private byte[] WrapWirelessData(byte[] data)
        {
            ArrayList api = new ArrayList();
            api.Add((byte)0x7e); // ' Header 0x7e
            byte dataLength = (byte)(data.Length + 14);
            byte msb_length = (byte)(dataLength >> 8);
            byte lsb__length = (byte)(dataLength & 0xFF);
            api.Add((byte)msb_length);
            api.Add((byte)lsb__length);
            api.Add((byte)0x10); // frame type
            api.Add((byte)0);
            byte[] DestHigh = GetAddressBytes(WirelessDestHigh);
            byte[] DestLow = GetAddressBytes(WirelessDestLow);
            api.AddRange(DestHigh);
            api.AddRange(DestLow);
            api.Add((byte)0xff);  // short address, will be 0xfffe
            api.Add((byte)0xfe);  // short address, will be 0xfffe

            api.Add((byte)0xC0); //15 set hops, 0 
            api.Add((byte)0); // ' 16, options 0, for disable ack

            api.AddRange(data);
            int checksum = 0;
            byte[] temp = (byte[])api.ToArray(typeof(byte));
            for(int i = 3; i < api.Count; i++)
            {
                int t = (int) temp[i];
                checksum += (byte)t;
            }
            checksum = (byte)(255 - checksum & 0xFF);
            api.Add((byte)checksum);

            return (byte[])(api.ToArray(typeof(byte)));
        }
         

        private byte[] ExtractWirelessData(byte[] data)
        {
            if(data[0] != 126)
            {
                return null;
            }
            int msb, lsb;
            msb = data[1];
            lsb = data[2];
            if(msb == -1 || lsb == -1)
            {
                return null;
            }
            int len = msb * 256 + lsb;
            if(data.Length != len + 3)
            {
                return null;
            }
            int frameType = data[3];
            if(frameType != 0x90)
            {
                return null;
            }
            Int32 addrHigh = (data[4] << 24) + (data[5] << 16) + (data[6] << 8) + data[7];
            Int32 addrLow = (data[8] << 24) + (data[9] << 16) + (data[10] << 8) + data[11];
            if(addrHigh == WirelessDestHigh && addrLow == WirelessDestLow)
            {

            }
            else
            {
                return null;    // wrong address
            }

            // data[12], data[13] // short address
            // data[14],  options
            byte[] wrappedData = new byte[data.Length - 17];
            for(int i= 0; i < wrappedData.Length; i ++)
            {
                wrappedData[i] = data[15 + i];
            }
            return wrappedData;
        }


    }

    /// <summary>
    /// Define of write data event args
    /// </summary>
    public class WriteDataEventArgs: EventArgs 
    {
        /// <summary>
        /// Data been written
        /// </summary>
        public Byte Data;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data">data been written</param>
        public WriteDataEventArgs(byte data)
        {
            Data = data;
        }

   
    }

    /// <summary>
    /// Define of read data event args
    /// </summary>
    public class ReadDataEventArgs : EventArgs
    {
        /// <summary>
        /// date been read
        /// </summary>
        public Byte Data;
        /// <summary>
        /// flag for timeout
        /// </summary>
        public bool IsTimeOut;

        /// <summary>
        /// Construct
        /// </summary>
        /// <param name="data"></param>
        /// <param name="isTimeout"></param>
        public ReadDataEventArgs(byte data, bool isTimeout)
        {
            Data = data;
            IsTimeOut = isTimeout;
        }
    }

}
