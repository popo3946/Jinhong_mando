using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// Scan Object Interface
    /// </summary>
    public interface  IScan
    {
        /// <summary>
        /// Scan the status of bank
        /// </summary>
        /// <param name="channel">Channel Number: 0-255</param>
        /// <returns>8 bits status, each bits represents a channel's status</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte ScanValue(byte channel);

        /// <summary>
        /// scan multi channels 
        /// </summary>
        /// <param name="channel">first channel</param>
        /// <param name="channelsCount">count of channels</param>
        /// <returns>byte array, each byte for a channel</returns>
        byte[] ScanValue(byte channel, byte channelsCount);


    }

    internal class Scan : NCDBase, IScan
    {
        public Scan(NCDController objNCD):base(objNCD)
        {

        }

        /// <summary>
        /// Scan the status of bank
        /// </summary>
        /// <param name="channel">bank ID, 0 - 255</param>
        /// <returns>8 bits status, each bits represents a channel's status</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte IScan.ScanValue(byte channel)
        {
            WriteBytes(254, 175, channel);

            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="channelsCount">extra bank accout</param>
        /// <returns></returns>
        byte[] IScan.ScanValue(byte channel, byte channelsCount)
        {
            
            byte[] d = new byte[channelsCount + 1];
            mNCD.Purge();
            WriteBytes(254, 175, channel, channelsCount);
            for (int i = 0; i < channelsCount + 1; i++)
            {
                int n = ReadByte2();
                if (n == -1)
                {
                    throw new TimeoutException();
                }
                else
                {
                    d[i] = (byte)n;
                }
            }
            return d;
        }

    }

}
