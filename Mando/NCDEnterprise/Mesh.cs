using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace NCDEnterprise
{

    /// <summary>
    /// ZigBee Info struct
    /// </summary>
    public struct ZigBeeInfo
    {
        /// <summary>
        /// MY
        /// </summary>
        public string MY;
        /// <summary>
        /// SH
        /// </summary>
        public string SH;
        /// <summary>
        /// SL
        /// </summary>
        public string SL;
        /// <summary>
        /// NI
        /// </summary>
        public string NI;
        /// <summary>
        /// Parent Network Address
        /// </summary>
        public string ParentNetworkAddress;
        /// <summary>
        /// Device Type
        /// </summary>
        public string DeviceType;
        /// <summary>
        /// Status
        /// </summary>
        public string Status;
        /// <summary>
        /// Profile ID
        /// </summary>
        public string ProfileID;
        /// <summary>
        /// Manufacturer ID
        /// </summary>
        public string ManufacturerID;
    }

    struct LineDataInfo
    {
        public string content;
        public bool timeout;
    }

    /// <summary>
    /// ZigBee Mesh Object interface
    /// </summary>
    public interface IMesh
    {
        /// <summary>
        /// Return array of zigbeeinfo.
        /// </summary>
        /// <returns><para>Array of ZigBeeInfo</para></returns>
        ZigBeeInfo[] GetDeviceList();

        /// <summary>
        /// Talk to specific address.
        /// </summary>
        /// <param name="dh"></param>
        /// <param name="dl"></param>
        /// <returns><para>True for success</para></returns>
        bool TalkToDevice(string dh, string dl);

        /// <summary>
        /// Talk to all devices.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool BroadcasatToAllDevices();
        
        /// <summary>
        /// Return high address of destination in string.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        string GetDestinationHigh();

        /// <summary>
        /// Get low address of destinatin in string.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        string GetDestinationLow();

        /// <summary>
        /// Get high address of source in string.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        string GetSourceHigh();
        
        /// <summary>
        /// get low address of source in string.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        string GetSourceLow();

        /// <summary>
        /// Get Pan id of in string.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        string GetPanID();

        /// <summary>
        /// Set Pan ID.
        /// </summary>
        /// <param name="id">ID of the Pan, in string format</param>
        /// <returns><para>True for success</para></returns>
        bool SetPanID(string id);
    }
    
    internal class CMesh : NCDBase, IMesh
    {
        public CMesh(NCDController objNCD)
            : base(objNCD)
        {
            
        }

        ZigBeeInfo[] IMesh.GetDeviceList()
        {
            List<ZigBeeInfo> DeviceList = new List<ZigBeeInfo>();
            Thread.Sleep(2000);
            EnterCommandMode();
            LineDataInfo ln = ReadLine(1000);
            if (ln.timeout)
            {
                return null;
            }

            if (ln.content != "OK")
            {
                return null;
            }

            mNCD.Purge();
            SendString("ATND", true);
            Thread.Sleep(1000);
            ZigBeeInfo info = GetZigBeeInfo();
            if (IsValidZigBeeInfo(info))
            {
                DeviceList.Add(info);
                info = GetZigBeeInfo();
            }
            while (IsValidZigBeeInfo(info))
            {
                DeviceList.Add(info);
                info = GetZigBeeInfo();
            }
            return DeviceList.ToArray();

        }

        bool IMesh.TalkToDevice(string dh, string dl)
        {
            return _TalkToDevice(dh, dl);

        }

        private bool _TalkToDevice(string dh, string dl)
        {
            bool bRtn = false;
            Thread.Sleep(1000);
            EnterCommandMode();
            LineDataInfo ln;
            ln = ReadLine(1000);
            if (ln.timeout)
            {
                return bRtn;
            }

            if (ln.content != "OK")
            {
                return bRtn;
            }

            SendString("ATDH" + dh + "WR", true);
            Thread.Sleep(1000);
            ln = ReadLine(1000);
            if (ln.content != "OK")
            {
                return bRtn;
            }
            SendString("ATDL" + dl + "WR", true);
            Thread.Sleep(1000);
            ln = ReadLine(1000);
            if (ln.content != "OK")
            {
                return bRtn;
            }
            ExitCommandMode();
            bRtn = true;

            return bRtn;


        }

        bool IMesh.BroadcasatToAllDevices()
        {
            return _TalkToDevice("0", "FFFF");
        }

        string IMesh.GetDestinationHigh()
        {
            return GetValue("DH");

        }

        string IMesh.GetDestinationLow()
        {
            return GetValue("DL");

        }

        string IMesh.GetSourceHigh()
        {
            return GetValue("SH");

        }


        string IMesh.GetSourceLow()
        {
            return GetValue("SL");

        }

        /// <summary>
        /// Get Pan id of in string
        /// </summary>
        /// <returns></returns>
        string IMesh.GetPanID()
        {
            return GetValue("ID");
        }

        /// <summary>
        /// set pan id
        /// </summary>
        /// <returns></returns>
        bool IMesh.SetPanID(string id)
        {
            return SetValue("ID", id);
        }

        private string GetValue(string name)
        {
            string value = string.Empty;
            Thread.Sleep(2000);
            EnterCommandMode();
            LineDataInfo ln;
            Thread.Sleep(1000);
            ln = ReadLine(1000);
            if (ln.timeout)
            {
                return value;
            }

            if (ln.content != "OK")
            {
                return value;
            }

            SendString("AT" + name, true);
            Thread.Sleep(1000);
            ln = ReadLine(1000);
            if (ln.timeout)
            {
                return value;
            }
            value = ln.content;
            ExitCommandMode();
            return value;

        }

        private bool SetValue(string name, string value)
        {
            bool bRtn = false;
            Thread.Sleep(2000);
            EnterCommandMode();
            Thread.Sleep(1000);
            LineDataInfo ln;
            ln = ReadLine(1000);
            if (ln.timeout)
            {
                return bRtn;
            }

            if (ln.content != "OK")
            {
                return bRtn;
            }

            SendString("AT" + name + value + "WR", true);
            Thread.Sleep(1000);
            ln = ReadLine(1000);
            if (ln.content != "OK")
            {
                return bRtn;
            }

            ExitCommandMode();
            return bRtn;
        }

        private void EnterCommandMode()
        {
            mNCD.Purge();
            WriteString("+++");

        }

        private void ExitCommandMode()
        {
            mNCD.Purge();
            SendString("ATCN", true);

        }

        private LineDataInfo ReadLine(int timeout)
        {
            LineDataInfo info;
            info.timeout = false;
            StringBuilder sb = new StringBuilder();
            int i = GetData();
            int timenow = 0;
            while (i == -1 && timenow < timeout)
            {
                System.Threading.Thread.Sleep(100);
                i = GetData();
                timenow = timenow + 100;
            }
            if (i == -1)
            {
                info.timeout = true;
            }
            else
            {
                do
                {
                    sb.Append(System.Convert.ToChar(i));
                    i = GetData();

                } while (i != -1 && i != 13);
            }

            info.content = sb.ToString();
            return info;
        }

        private void SendString(string str, bool sendCarriage)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(str);
            for (int i = 0; i < data.Length; i++)
            {
                PutData(data[i]);
            }
            if (sendCarriage)
            {
                PutData(13);
            }

        }


        private void PutData(byte bt)
        {
            if (!mNCD.IsOpen)
            {
                mNCD.OpenPort();
            }
            mNCD.WriteByte(bt);
        }

        private int GetData()
        {
            if (!mNCD.IsOpen)
            {
                mNCD.OpenPort();
            }
            return mNCD.ReadByte();
        }

        private ZigBeeInfo InitZigBeeInfo()
        {
            ZigBeeInfo info;
            info.MY = string.Empty;
            info.SH = string.Empty;
            info.SL = string.Empty;
            info.NI = string.Empty;
            info.ParentNetworkAddress = string.Empty;
            info.DeviceType = string.Empty;
            info.Status = string.Empty;
            info.ProfileID = string.Empty;
            info.ManufacturerID = string.Empty;
            return info;
        }

        private bool IsValidZigBeeInfo(ZigBeeInfo info)
        {
            bool valid = true;
            if (info.SH == string.Empty)
            {
                valid = false;
            }
            if (info.SL == string.Empty)
            {
                valid = false;
            }
            return valid;
        }

        private ZigBeeInfo GetZigBeeInfo()
        {
            ZigBeeInfo info = InitZigBeeInfo();
            LineDataInfo ln;
            ln = ReadLine(3000);
            info.MY = ln.content;
            if(info.MY == string.Empty)
            {
                return info;
            }

            if(!ln.timeout )
            {
                ln = ReadLine(1000);
                info.SH = ln.content;
                if(ln.content.Length  == 16)
                {
                    info.SH = ln.content.Substring(0,8);
                    info.SL = ln.content.Substring(8,8);
                }
                else
                {
                    ln = ReadLine(1000);
                    info.SL = ln.content;
                }
            }
            
            if (!ln.timeout)
            {
                ln = ReadLine(1000);
                info.NI = ln.content;
            }

            if(!ln.timeout)
            {
                ln = ReadLine(1000);
                info.ParentNetworkAddress = ln.content;
            }
            
            if(!ln.timeout)
            {
                ln = ReadLine(1000);
                info.DeviceType = ln.content;
            }

            if(!ln.timeout)
            {
                ln = ReadLine(1000);
                info.Status = ln.content;
            }

            if(!ln.timeout)
            {
                ln = ReadLine(1000);
                info.ProfileID = ln.content;
            }

            if(!ln.timeout)
            {
                ln = ReadLine(1000);
                info.ManufacturerID = ln.content;
            }
            if (!ln.timeout)
            {
                ln = ReadLine(1000);
            }
            return info;
            
        }

        private void DumpZigBeeInfo(ZigBeeInfo info)
        {
            Debug.Print("MY: {0}", info.MY);
            Debug.Print("SH: {0}", info.SH);
            Debug.Print("SL: {0}", info.SL);
            Debug.Print("NI: {0}", info.NI);
            Debug.Print("Parent Network Address: {0}", info.ParentNetworkAddress);
            Debug.Print("Device Type: {0}", info.DeviceType);
            Debug.Print("Status :{0}", info.Status);
            Debug.Print("Profile ID :{0}", info.ProfileID);
            Debug.Print("Manufacturer {0}", info.ManufacturerID);
        }


     }
}
