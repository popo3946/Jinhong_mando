using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{

    /// <summary>
    /// NCD.Math contains help functions for calculate bit and byte 
    /// </summary>
    public class Math
    {

        /// <summary>
        /// Get bit value of spacific position
        /// </summary>
        /// <param name="value">byte value, from 0 to 255</param>
        /// <param name="pos">bit position , from 0 to 7</param>
        /// <returns>0 or 1</returns>
        public static byte GetBitValue(byte value, byte pos)
        {
            return (byte)(GetBitBoolValue(value, pos) ? 1 : 0);
        }

        /// <summary>
        /// Get bool value of specific position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static bool GetBitBoolValue(byte value, byte pos)
        {
            if (pos > 7)
            {
                throw new ArgumentOutOfRangeException("Pos", pos, "The value should range from 0 to 7");

            }
            return (value & (1 << pos)) > 0 ;
        }

        /// <summary>
        /// Set the specific bit to specific value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pos"></param>
        /// <param name="isBitOn"></param>
        /// <returns>value with specific bit set</returns>
        public static byte SetBitBoolValue(byte value, byte pos, bool isBitOn)
        {
            if (pos > 7)
            {
                throw new ArgumentOutOfRangeException("Pos", pos, "The value should range from 0 to 7");

            }
            byte v1 = (byte)(1 << pos);
            byte v2 = (byte)(v1 | value);
            v2 = (byte)(v2 - v1);
            v1 = (byte)((isBitOn ? 1 : 0) << pos);
            v2 = (byte)(v2 + v1);
            return v2;

        }

        /// <summary>
        /// Set the specific bit to specific value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pos"></param>
        /// <param name="bitValue">0 for turn off, other value to turn on</param>
        /// <returns>value with specific bit set</returns>
        public static byte SetBitValue(byte value, byte pos, byte bitValue)
        {
            return SetBitBoolValue(value, pos, bitValue > 0);
        }



    }
}
