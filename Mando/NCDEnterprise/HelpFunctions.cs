using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// Static class contains all help functions
    /// </summary>
    public class HelpFunctions
    {
        /// <summary>
        /// Get specfic bit of byte
        /// </summary>
        /// <param name="v">value of the byte</param>
        /// <param name="pos">position of the bit</param>
        /// <returns>value of the bit, 0 or 1</returns>
        public static byte GetBit(byte v, byte pos)
        {
            if (pos > 7)
            {
                throw new ArgumentOutOfRangeException("Position", pos, "Position should range from 0 to 7");
            }
            byte result = v;
            byte value = (byte)(1 << pos);
            result = (byte)(v & value);
            result = (byte)(result > 0 ? 1 : 0);
            return result;

        }

        /// <summary>
        /// Set specific bit of the byte
        /// </summary>
        /// <param name="v">byte to be set</param>
        /// <param name="pos">bit position</param>
        /// <param name="bitValue">bit value, </param>
        /// <returns>byte processed</returns>
        public static byte SetBit(byte v, byte pos, byte bitValue)
        {
            if (pos > 7) 
            {
                throw new  ArgumentOutOfRangeException("Position", pos, "Position should range from 0 to 7");

            }
            if (bitValue > 1) 
            {
                throw new ArgumentOutOfRangeException("Bit Value", bitValue, "Bit Value should range from 0 to 1");
            }

            byte result = v;
            byte value = (byte)(1 << pos);
            result = (byte)(v | value);
            result = (byte)(result - value);
            value = (byte)(bitValue << pos);
            result = (byte)(result + value);
            return result;
        }


        /// <summary>
        /// Convert a byte to binary code decimal
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static byte ConvertToBCD(byte v)
        {
            byte a = (byte)(v / 10);
            byte b = (byte)(v % 10);
            return (byte)(a * 16 + b);
        }

        /// <summary>
        /// Convert a binary from BCD
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static byte ConvertFromBCD(byte v)
        {
            byte a = (byte)(v / 16);
            byte b = (byte)(v % 16);
            return (byte)(a * 10 + b);
        }

    }
}
