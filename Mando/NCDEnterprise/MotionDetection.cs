using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// Interface for motion detection
    /// </summary>
    public interface IMotionDetection
    {
        /// <summary>
        /// Report if there is any motions detected.
        /// </summary>
        /// <returns>0-15 <para>The first four bits represent which quadrature has motion.</para> </returns>
        /// <exception cref="TimeoutException">Read Timeout </exception>
        byte DetectAnyMotion();

        /// <summary>
        /// Report if there is any motions in specified quadrature.
        /// </summary>
        /// <param name="quad">quadrature queried. 
        /// 0 for bank 0 - 7
        /// 1 for bank 8 - 15
        /// 2 for bank 16 - 23
        /// 3 for bank 24 - 32
        /// </param>
        /// <returns>A byte ranged from 0 to 255, each bits represent a bank. 1 for motion detected</returns>
        /// <exception cref="ArgumentException">Wrong Arguement</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte DetectMotionOfQuadrature(byte quad);

        /// <summary>
        /// Set the scan depth.
        /// </summary>
        /// <param name="depth">depth for scan: 1-32</param>
        /// <returns>True for success</returns>
        bool SetScanDepth(byte depth);

        /// <summary>
        /// Get the depth of scan.
        /// </summary>
        /// <returns>Depth of scan</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte GetScanDepth();

        /// <summary>
        /// Get motion status of bank.
        /// </summary>
        /// <param name="bank">id of the bank: 0-31</param>
        /// <returns>0-255, each bit represent a channel in bank, 1 for motion detected</returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte GetMotionInBank(byte bank);

        /// <summary>
        /// Set the autoclear mode.
        /// </summary>
        /// <param name="autoclear">true for autoclear</param>
        /// <returns>True for success</returns>
        bool SetAutoclearMode(bool autoclear);


        /// <summary>
        /// Get the autoclear mode.
        /// </summary>
        /// <returns>Status of autoclear mode</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        bool GetAutoclearMode();

        /// <summary>
        /// Get value of powerup default autoclear mode.
        /// </summary>
        /// <returns>Value of autoclear</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        bool GetPowerupDefaultAutoclearMode();


        /// <summary>
        /// Clear motion data in specified bank.
        /// </summary>
        /// <param name="bankId">id of the bank: 0-31. 0 for first bank</param>
        /// <returns>True for success</returns>
        /// <exception cref="ArgumentException">Wrong Arguement</exception>
        bool ClearMotionDataInBank(byte bankId);


        /// <summary>
        /// Clear motion in All banks.
        /// </summary>
        /// <returns>True for success</returns>
        bool ClearMotionInAllBanks();        
    }

    internal class MotionDetection : NCDBase, IMotionDetection 
    {
        public MotionDetection(NCDController objNCD):base(objNCD)
        {

        }

        /// <summary>
        /// report if there is any motions detected
        /// </summary>
        /// <returns>0 - 15, the first four bits represent which quadrature has motion </returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte IMotionDetection.DetectAnyMotion()
        {
            //EnterCommand2();
            //WriteByte(0);

            WriteBytes(253, 0);

            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;
        }

        /// <summary>
        /// report if there is any motions in specified quadrature
        /// 
        /// </summary>
        /// <param name="quad">quadrature queried. 
        /// 0 for bank 0 - 7
        /// 1 for bank 8 - 15
        /// 2 for bank 16 - 23
        /// 3 for bank 24 - 32
        /// </param>
        /// <returns>a byte ranged from 0 to 255, each bits represent a bank. 1 for motion detected</returns>
        /// <exception cref="ArgumentException">Wrong arguement</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte IMotionDetection.DetectMotionOfQuadrature(byte quad)
        {
            if (quad > 3)
            {
                throw new ArgumentOutOfRangeException("Quadrature", quad, "Value should range from 0 to 3");
            }
            //EnterCommand2();
            //WriteByte((byte)(quad + 1));

            WriteBytes(253, (byte)(quad + 1));

            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;
            
        }

        /// <summary>
        /// Get the depth of scan
        /// </summary>
        /// <returns>depth of scan</returns>
        /// <exception cref="TimeoutException">Read timeout</exception>
        byte IMotionDetection.GetScanDepth()
        {
            //EnterCommand2();
            //WriteByte(5);

            WriteBytes(253, 5);

            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;

        }

        /// <summary>
        /// Set the scan depth
        /// 
        /// </summary>
        /// <param name="depth">depth for scan. from 1 to 32</param>
        /// <returns></returns>
        bool IMotionDetection.SetScanDepth(byte depth)
        {
            if (depth > 32)
            {
                throw new ArgumentOutOfRangeException("Depth", depth, "Value should range from 1 to 32");
            }
            //EnterCommand2();
            //WriteByte(6);
            //WriteByte(depth);

            WriteBytes(253, 6, depth);

            return mNCD.GetAck();
        }




        /// <summary>
        /// Get motion status of bank
        /// </summary>
        /// <param name="bank">id of the bank, ranges from 0 to 31</param>
        /// <returns>byte ranged from 0 to 255, each bit represent a a channel in bank, 1 for motion detected</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        byte IMotionDetection.GetMotionInBank(byte bank)
        {
            if(bank > 31)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bank, "Value should range from 0 to 31");
            }

            //EnterCommand2();
            //WriteByte((byte)(bank + 9));

            WriteBytes(253, (byte)(bank + 9));

            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;
        }


        /// <summary>
        /// Set the autoclear mode
        /// </summary>
        /// <param name="autoclear">true for autoclear</param>
        /// <returns>true for success</returns>
        bool IMotionDetection.SetAutoclearMode(bool autoclear)
        {
            //EnterCommand2();
            if (autoclear)
            {
                WriteBytes(253, 43);
            }
            else
            {
                WriteBytes(253, 42);
            }
            return mNCD.GetAck();
        }

        /// <summary>
        /// Get the autoclear mode
        /// </summary>
        /// <returns>status of autoclear mode</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        bool IMotionDetection.GetAutoclearMode()
        {
            //EnterCommand2();
            //WriteByte(44);

            WriteBytes(253, 44);

            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return n != 0;            

        }


        /// <summary>
        /// Get value of powerup default autoclear mode 
        /// </summary>
        /// <returns>value of autoclear</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        bool IMotionDetection.GetPowerupDefaultAutoclearMode()
        {
            //EnterCommand2();
            //WriteByte(45);

            WriteBytes(253, 45);

            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return n != 0;            

        }


        /// <summary>
        /// Clear motion data in specified bank
        /// </summary>
        /// <param name="bankId">id of the bank, from 0 to 31. 0 for first bank</param>
        /// <returns>true for success</returns>
        /// <exception cref="ArgumentException">Wrong Arguement</exception>
        bool IMotionDetection.ClearMotionDataInBank(byte bankId)
        {
            if (bankId > 31)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "Value should range from 0 to 31");
            }
            //EnterCommand2();
            //WriteByte(46);
            //WriteByte((byte)(bankId + 1));

            WriteBytes(253, 46, (byte)(bankId + 1));

            return mNCD.GetAck();
        }


        /// <summary>
        /// Clear motion in All banks
        /// </summary>
        /// <returns>true for success</returns>
        bool IMotionDetection.ClearMotionInAllBanks()
        {
            //EnterCommand2();
            //WriteByte(46);
            //WriteByte(0);

            WriteBytes(253, 46, 0);

            return mNCD.GetAck();
        }

        ///// <summary>
        ///// Help function for motion detection 
        ///// </summary>
        //private void EnterCommand2()
        //{
        //    mNCD.Purge();
        //    WriteByte(253); // Enter command mode
        //}

    }
}
