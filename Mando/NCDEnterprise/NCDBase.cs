using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{


    /// <summary>
    /// Status of relay
    /// </summary>
    public enum RelayStatus
    {
        FAIL = -1,
        /// <summary>
        /// Off
        /// </summary>
        OFF = 0,
        /// <summary>
        /// On
        /// </summary>
        ON = 1
        
    }

    /// <summary>
    /// Setting of Auto Refresh 
    /// </summary>
    public enum AutoRefreshSetting
    {
        /// <summary>
        /// Off
        /// </summary>
        OFF = 0,
        /// <summary>
        /// On
        /// </summary>
        ON = 1
    }


    // This class contains base function for all
    internal class NCDBase
    {

        protected  NCDController mNCD = null;

        public NCDBase(NCDController objNCD)
        {
            mNCD = objNCD;
        }

        // Write Byte 
        public void WriteByte(byte data)
        {
            mNCD.WriteByte(data);
        }

        /// <summary>
        /// Write data in api format
        /// </summary>
        /// <param name="data"></param>
        public void WriteBytesApi(params byte[] data)
        {
            mNCD.WriteBytesAPI(data);
        }

        /// <summary>
        /// Read data in api format
        /// </summary>
        /// <returns></returns>
        public byte[] ReadBytesApi()
        {
            return mNCD.ReadBytesApi();
        }

        /// <summary>
        /// write a byte array
        /// </summary>
        /// <param name="data"></param>
        public void WriteBytes(params byte[] data)
        {
            mNCD.WriteBytes(data);
        }

        // Write String
        public void WriteString(string text)
        {
            mNCD.WriteString(text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int ReadByte2()
        {
            int nRtn = -1;  // for read failure
            nRtn = mNCD.ReadByte();
            return nRtn;
        }

        public long ReadByteForWireless()
        {
            throw new NotImplementedException();
        }

        public void EnterCommand()
        {
            mNCD.Purge();
            WriteByte(254); // Enter command mode
        }

        /// <summary>
        /// Calbute the time value from ms to NCD's time format
        /// Duration Interval : 0=(10 milliseconds * Duration) + 10
        ///                     64=(5 seconds * Duration) + 5
        /// Duration: 0 to 63
        /// </summary>
        /// <param name="time">time: milliseconds</param>
        /// <returns>NCD time format Byte</returns>
        public static byte GetTimeByte(long time)
        {
            if (time < 10)
            {
                time = 10;
            }
            if (time > 32000)
            {
                time = 32000;
            }
            if (time < 640)
            {
                return (byte)(time / 10);
            }
            else
            {
                return (byte)(64 + (time - 500) / 500);
            }
        }

        /// <summary>
        /// test2way function for IOADR8 or 16
        /// </summary>
        /// <returns>true for OK, false for Failed</returns>

        public bool Test2WayForIOADR8X16X()
        {
            long status;
            WriteByte(254);
            WriteByte(0);
            WriteByte(0); 
            status = ReadByte2();
            if (status == 85)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public void SetDefaultForIOADR8X16X()
        {
            WriteByte(254);
            WriteByte(0);
            WriteByte(1);
        }
    }
}
