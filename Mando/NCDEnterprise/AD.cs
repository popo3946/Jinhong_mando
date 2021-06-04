using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// Interface for AD12 
    /// </summary>
    public interface IAD12
    {
        /// <summary>
        /// Read 8 bits value of specific bank.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank) </param>
        /// <returns> <para>Array of interger type.</para>
        /// <para>The length of the array is 16. Each value(0-255) indicates analog value for each of the 16 channels.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,192</description>
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 0</description>
        /// </item>
        /// <item>
        /// <description>254,193</description> 
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 1</description>
        /// </item>
        /// <item>
        /// <description>254,194</description> 
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 2 </description>
        /// </item>
        /// </list>
        /// When the above commands are sent to the controller, the controller will respond with 16 bytes of data indicating analog values from 0 to 255 for each of the 16 channels. 
        /// Data will be sent in the following order from left to right:
        /// Channel 0, 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15 </remarks>
        int[] Read8BitsValuesOfBank(byte bank);

        /// <summary>
        /// Read 8 bits value of specific channel in specific bank.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank)</param>
        /// <param name="channel">Channel Number: 0-15 (0 for first channel)</param>
        /// <returns><para>0-255</para>The value indicates analog value for the specific channel.</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,195</description>
        /// <description>Read Single Channel at a Time, 8-Bit A/D Device Bank 0</description>
        /// </item>
        /// <item>
        /// <description>254,203</description>
        /// <description>Read Single Channel at a Time, 8-Bit A/D Device Bank 1</description>
        /// </item>
        /// <item>
        /// <description>254,208</description>
        /// <description>Read Single Channel at a Time, 8-Bit A/D Device Bank 2</description>
        /// </item>        
        /// </list>
        /// </remarks>
        int Read8BitsValue(byte bank, byte channel);

        /// <summary>
        /// Read 12 bits value of specific bank.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank)</param>
        /// <returns> <para>Array of interger type.</para>
        /// <para>The length of the array is 16. Each value(0-4095) indicates analog values for each of the 16 channels.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,196</description>
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 0</description>
        /// </item>
        /// <item>
        /// <description>254,197</description>
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 1</description>
        /// </item>
        /// <item>
        /// <description>254,198</description>
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 2</description>
        /// </item>        
        /// </list>
        /// When the above commands are sent to the controller, the controller will respond with 32 bytes of data indicating analog values from 0 to 
        /// 255 for each of the 16 channels. Data will be sent in the following order from left to right: Channel 0 LSB, 0 MSB, 1 LSB, 1 MSB, 2 LSB,
        /// 2 MSB, 3 LSB, 3 MSB, 4 LSB, 4 MSB, 5 LSB, 5 MSB, 6 LSB, 6 MSB, 7 LSB, 7 MSB, 8 LSB, 8MSB, 9 LSB, 9 MSB, 10 LSB, 10 MSB, 11 LSB, 11 MSB, 
        /// 12 LSB, 12 MSB, 13 LSB, 13 MSB, 14 LSB, 14 MSB, 15 LSB, 15 MSB.        
        /// </remarks>
        int[] Read12BitsValuesOfBank(byte bank);

        /// <summary>
        /// Read 12 bits value of specific channel in specific bank.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank)</param>
        /// <param name="channel">Channel Number: 0-15 (0 for first channel)</param>
        /// <returns><para>0-4095</para>The value indicates analog value for the specific channel. </returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,199</description>
        /// <description>Read Single Channel at a Time, 12-Bit A/D Device Bank 0</description>
        /// </item>
        /// <item>
        /// <description>254,207</description>
        /// <description>Read Single Channel at a Time, 12-Bit A/D Device Bank 1</description>
        /// </item>
        /// <item>
        /// <description>254,209</description>
        /// <description>Read Single Channel at a Time, 12-Bit A/D Device Bank 2</description>
        /// </item>        
        /// </list>
        /// </remarks>
        int Read12BitsValue(byte bank, byte channel);

        /// <summary>
        /// Read 8 bits values of specific bank with checksum.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank)</param>
        /// <returns> <para>Array of interger type.</para>
        /// <para>The length of the array is 16. Each value(0-255) indicates analog values for each of the 16 channels.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ChecksumException">Checksum Error</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,200</description>
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 0 (Packet Format)</description>
        /// </item>
        /// <item>
        /// <description>254,201</description> 
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 1 (Packet Format)</description>
        /// </item>
        /// <item>
        /// <description>254,202</description> 
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 2 (Packet Format)</description>
        /// </item>
        /// </list>
        /// When the above commands are sent to the controller, the controller will respond with 18 bytes of data indicating analog values from 0 to 
        /// 255 for each of the 16 channels. Also included in the data structure is a Header Byte (254), and a Checksum Byte (which is the total
        /// value of 254 + all 16 bytes of data). The checksum byte only contains the lower 8 bits of data. Data will be sent in the following order from left to right:
        /// Header Byte 254, Channel 0, 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, Checksum Value</remarks>  
        int[] Read8BitsValuesOfBank2(byte bank);

        /// <summary>
        /// Read 12 bits values of specific bank with checksum.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank)</param>
        /// <returns> <para>Array of interger type.</para>
        /// <para>The length of the array is 16. Each value(0-4095) indicates analog values for each of the 16 channels.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ChecksumException">Checksum Error</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,204</description>
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 0 (Packet Format)</description>
        /// </item>
        /// <item>
        /// <description>254,205</description> 
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 1 (Packet Format)</description>
        /// </item>
        /// <item>
        /// <description>254,206</description> 
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 2 (Packet Format)</description>
        /// </item>
        /// </list>
        /// When the above commands are sent to the controller, the controller will respond with 34 bytes of data indicating analog values from 0 to 4095 
        /// for each of the 16 channels. Also included in the data structure is a Header Byte (254), and a Checksum Byte (which is the total value of 254 + all 16 bytes of data). 
        /// Data will be sent in the following order from left to right: Header Byte 254, Channel 0 LSB, 0 MSB, 1 LSB, 1 MSB, 2 LSB, 2 MSB, 3 LSB, 3 MSB, 4 LSB, 4 MSB, 
        /// 5 LSB, 5 MSB, 6 LSB, 6 MSB, 7 LSB, 7 MSB, 8 LSB, 8 MSB, 9 LSB, 9 MSB, 10 LSB, 10 MSB, 11 LSB, 11 MSB, 12 LSB, 12 MSB, 13 LSB, 13 MSB, 14 LSB, 14 MSB, 15 LSB, 
        /// 15MSB, Checksum Value.</remarks> 
        int[] Read12BitsValuesOfBank2(byte bank);

    }

    /// <summary>
    /// Interface for AD8
    /// </summary>
    public interface IAD8
    {
        /// <summary>
        /// Read 8-bit A/D value for specific channel.
        /// </summary>
        /// <param name="channel">Channel number: 0-7, 0 for first channel</param>
        /// <returns><para>0-255</para>
        /// The value indicates the voltage on the selected input channel.</returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,150</description>
        /// <description>Read 8-Bit A/D Channel 1</description>
        /// </item>
        /// <item>
        /// <description>254,151</description>
        /// <description>Read 8-Bit A/D Channel 2</description>
        /// </item>
        /// <item>
        /// <description>254,152</description>
        /// <description>Read 8-Bit A/D Channel 3</description>
        /// </item>
        /// <item>
        /// <description>254,153</description>
        /// <description>Read 8-Bit A/D Channel 4</description>
        /// </item>
        /// <item>
        /// <description>254,154</description>
        /// <description>Read 8-Bit A/D Channel 5</description>
        /// </item>
        /// <item>
        /// <description>254,155</description>
        /// <description>Read 8-Bit A/D Channel 6</description>
        /// </item>
        /// <item>
        /// <description>254,156</description>
        /// <description>Read 8-Bit A/D Channel 7</description>
        /// </item>
        /// <item>
        /// <description>254,157</description>
        /// <description>Read 8-Bit A/D Channel 8</description>
        /// </item>        
        /// </list>
        /// </remarks>
        int Read8BitsValue(byte channel);

        /// <summary>
        /// Read 8-bit value for all channels.
        /// </summary>
        /// <returns> <para>Array of interger type.</para>
        /// <para>The length of the array is 8. Each value(0-255) indicates analog value for each of 8 channels.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,166</description>
        /// <description>Read 8-Bit A/D All Channels</description>
        /// </item>
        /// </list>
        /// </remarks>
        int[] ReadAllChannels8BitsValues();

        /// <summary>
        /// Read 10-bit A/D value for specific channel.
        /// </summary>
        /// <param name="channel">Channel number: 0-7, 0 for first channel</param>
        /// <returns><para>0-1023</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,158</description>
        /// <description>Read 10-Bit A/D Channel 1</description>
        /// </item>
        /// <item>
        /// <description>254,159</description>
        /// <description>Read 10-Bit A/D Channel 2</description>
        /// </item>
        /// <item>
        /// <description>254,160</description>
        /// <description>Read 10-Bit A/D Channel 3</description>
        /// </item>
        /// <item>
        /// <description>254,161</description>
        /// <description>Read 10-Bit A/D Channel 4</description>
        /// </item>
        /// <item>
        /// <description>254,162</description>
        /// <description>Read 10-Bit A/D Channel 5</description>
        /// </item>
        /// <item>
        /// <description>254,163</description>
        /// <description>Read 10-Bit A/D Channel 6</description>
        /// </item>
        /// <item>
        /// <description>254,164</description>
        /// <description>Read 10-Bit A/D Channel 7</description>
        /// </item>
        /// <item>
        /// <description>254,165</description>
        /// <description>Read 10-Bit A/D Channel 8</description>
        /// </item>        
        /// </list>
        /// <para>The controller returns 2 bytes indicating the voltage on the selected input channel.</para>
        /// <para>The first returned value is the Most Significant Byte MSB, 
        /// the second byte sent to your computer will be the Least Significant Byte LSB.</para> 
        /// Using the formula VALUE= (LSB + (MSB * 256)), where VALUE will equate to a numeric value from 0 to 1023.        
        /// </remarks>
        int Read10BitsValue(byte channel);

        /// <summary>
        /// Read 10 bits value for all channels.
        /// </summary>
        /// <returns><para>Array of interger type.</para>
        /// <para>The length of the array is 8. Each value(0-1023) indicates the voltage of each channel.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,167</description>
        /// <description>Read 10-Bit A/D All Channels</description>
        /// </item>
        /// </list>
        /// </remarks>
        int[] ReadAllChannels10BitsValues();

        /// <summary>
        /// Read 10-bit A/D value for specific channel and get temperature in centigrade.
        /// </summary>
        /// <param name="channel">Channel number: 0-7, 0 for first channel</param>
        /// <returns><para>Temperature value in centigrade.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        double ReadDegC(byte channel);

        /// <summary>
        /// Read 10-bit A/D value for specific channel and get temperature in fahrenheit.
        /// </summary>
        /// <param name="channel">Channel number: 0-7, 0 for first channel</param>
        /// <returns><para>Temperature value in fahrenheit.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        double ReadDegF(byte channel);
    }

    internal class AD12 : NCDBase, IAD12
    {

        public AD12(NCDController objNCD)
            : base(objNCD)
        {
        }

        /// <summary>
        /// Read 8 bits value of specific bank.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank) </param>
        /// <returns> <para>Array of interger type.</para>
        /// <para>The length of the array is 16. Each value(0-255) indicates analog value for each of the 16 channels.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,192</description>
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 0</description>
        /// </item>
        /// <item>
        /// <description>254,193</description> 
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 1</description>
        /// </item>
        /// <item>
        /// <description>254,194</description> 
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 2 </description>
        /// </item>
        /// </list>
        /// When the above commands are sent to the controller, the controller will respond with 16 bytes of data indicating analog values from 0 to 255 for each of the 16 channels. 
        /// Data will be sent in the following order from left to right:
        /// Channel 0, 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15 </remarks>
        int[] IAD12.Read8BitsValuesOfBank(byte bank)
        {
            if (bank > 2)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bank, "The value should be from 0 to 2.");
            }

            int [] data = new int[16];
            EnterCommand();
            WriteByte((byte)(192 + bank));
            for (int i = 0; i < 16; i++)
            {
                data[i] = _Read8BitsValue();                
            }
            return data;

        }

        /// <summary>
        /// Read 8 bits value of specific channel in specific bank.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank)</param>
        /// <param name="channel">Channel Number: 0-15 (0 for first channel)</param>
        /// <returns><para>0-255</para>The value indicates analog value for the specific channel.</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,195</description>
        /// <description>Read Single Channel at a Time, 8-Bit A/D Device Bank 0</description>
        /// </item>
        /// <item>
        /// <description>254,203</description>
        /// <description>Read Single Channel at a Time, 8-Bit A/D Device Bank 1</description>
        /// </item>
        /// <item>
        /// <description>254,208</description>
        /// <description>Read Single Channel at a Time, 8-Bit A/D Device Bank 2</description>
        /// </item>        
        /// </list>
       /// </remarks>
        int IAD12.Read8BitsValue(byte bank, byte channel)
        {

            if (channel > 16)
            {
                throw new ArgumentOutOfRangeException("Channel ID", channel, "The value should be from 0 to 16");
            }

            if (bank > 2)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bank, "The value should be from 0 to 2.");
            }

            byte v1 = 195;   // default is bank 0
            switch (bank)
            {
                case 0:
                    v1 = 195;
                    break;
                case 1:
                    v1 = 203;
                    break;
                case 2:
                    v1 = 208;
                    break;
                default:
                    break;
            }
            EnterCommand();
            WriteByte(v1);
            WriteByte(channel);
            return _Read8BitsValue();

        }

        /// <summary>
        /// Read 12 bits value of specific bank.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank)</param>
        /// <returns> <para>Array of interger type.</para>
        /// <para>The length of the array is 16. Each value(0-4095) indicates analog values for each of the 16 channels.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,196</description>
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 0</description>
        /// </item>
        /// <item>
        /// <description>254,197</description>
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 1</description>
        /// </item>
        /// <item>
        /// <description>254,198</description>
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 2</description>
        /// </item>        
        /// </list>
        /// When the above commands are sent to the controller, the controller will respond with 32 bytes of data indicating analog values from 0 to 
        /// 255 for each of the 16 channels. Data will be sent in the following order from left to right: Channel 0 LSB, 0 MSB, 1 LSB, 1 MSB, 2 LSB,
        /// 2 MSB, 3 LSB, 3 MSB, 4 LSB, 4 MSB, 5 LSB, 5 MSB, 6 LSB, 6 MSB, 7 LSB, 7 MSB, 8 LSB, 8MSB, 9 LSB, 9 MSB, 10 LSB, 10 MSB, 11 LSB, 11 MSB, 
        /// 12 LSB, 12 MSB, 13 LSB, 13 MSB, 14 LSB, 14 MSB, 15 LSB, 15 MSB.
        /// </remarks>
        int[] IAD12.Read12BitsValuesOfBank(byte bank)
        {
            if (bank > 2)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bank, "The value should be from 0 to 2.");
            }

            int[] data = new int[16];
            EnterCommand();
            WriteByte((byte)(196 +bank));
            for (int i = 0; i < 16; i++)
            {
                data[i] = _Read16BitsValueForAD12();
            }
            return data;
        }

        /// <summary>
        /// Read 12 bits value of specific channel in specific bank.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank)</param>
        /// <param name="channel">Channel Number: 0-15 (0 for first channel)</param>
        /// <returns><para>0-4095</para>The value indicates analog value for the specific channel. </returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,199</description>
        /// <description>Read Single Channel at a Time, 12-Bit A/D Device Bank 0</description>
        /// </item>
        /// <item>
        /// <description>254,207</description>
        /// <description>Read Single Channel at a Time, 12-Bit A/D Device Bank 1</description>
        /// </item>
        /// <item>
        /// <description>254,209</description>
        /// <description>Read Single Channel at a Time, 12-Bit A/D Device Bank 2</description>
        /// </item>        
        /// </list>
        /// </remarks>
        int IAD12.Read12BitsValue(byte bank, byte channel)
        {
            if (channel > 16)
            {
                throw new ArgumentOutOfRangeException("Channel ID", channel, "The value should be from 0 to 16");
            }

            if (bank > 2)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bank, "The value should be from 0 to 2.");
            }

            byte v1 = 199;   // default is bank 0
            switch (bank)
            {
                case 0:
                    v1 = 199;
                    break;
                case 1:
                    v1 = 207;
                    break;
                case 2:
                    v1 = 209;
                    break;
                default:
                    break;
            }
            EnterCommand();
            WriteByte(v1);
            WriteByte(channel);
            return _Read16BitsValueForAD12();
        }

        /// <summary>
        /// Read 8 bits values of specific bank with checksum.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank)</param>
        /// <returns> <para>Array of interger type.</para>
        /// <para>The length of the array is 16. Each value(0-255) indicates analog values for each of the 16 channels.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ChecksumException">Checksum Error</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,200</description>
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 0 (Packet Format)</description>
        /// </item>
        /// <item>
        /// <description>254,201</description> 
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 1 (Packet Format)</description>
        /// </item>
        /// <item>
        /// <description>254,202</description> 
        /// <description>Read 16 Channels at a Time, 8-Bit A/D Device Bank 2 (Packet Format)</description>
        /// </item>
        /// </list>
        /// When the above commands are sent to the controller, the controller will respond with 18 bytes of data indicating analog values from 0 to 
        /// 255 for each of the 16 channels. Also included in the data structure is a Header Byte (254), and a Checksum Byte (which is the total
        /// value of 254 + all 16 bytes of data). The checksum byte only contains the lower 8 bits of data. Data will be sent in the following order from left to right:
        /// Header Byte 254, Channel 0, 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, Checksum Value</remarks>         
        int[] IAD12.Read8BitsValuesOfBank2(byte bank)
        {
            if (bank > 2)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bank, "The value should be from 0 to 2.");
            }

            int[] data = new int[16];
            EnterCommand();
            WriteByte((byte)(200 + bank));
            int checksum = _Read8BitsValue();
            if (checksum != 254)
            {
                throw new ChecksumException("Header Data Error");
            }
            int value = 0;
            for (int i = 0; i < 16; i++)
            {
                value = _Read8BitsValue();
                checksum = checksum + value;
                data[i] = value;
            }
            value = _Read8BitsValue();
            int t = checksum -((int)( checksum / 256)) * 256;
            if (value != t )
            {
                throw new ChecksumException("Checksum Error");
            }
            return data;

        }

        /// <summary>
        /// Read 12 bits values of specific bank with checksum.
        /// </summary>
        /// <param name="bank">Bank Number: 0-2 (0 for first bank)</param>
        /// <returns> <para>Array of interger type.</para>
        /// <para>The length of the array is 16. Each value(0-4095) indicates analog values for each of the 16 channels.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ChecksumException">Checksum Error</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,204</description>
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 0 (Packet Format)</description>
        /// </item>
        /// <item>
        /// <description>254,205</description> 
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 1 (Packet Format)</description>
        /// </item>
        /// <item>
        /// <description>254,206</description> 
        /// <description>Read 16 Channels at a Time, 12-Bit A/D Device Bank 2 (Packet Format)</description>
        /// </item>
        /// </list>
        /// When the above commands are sent to the controller, the controller will respond with 34 bytes of data indicating analog values from 0 to 4095 
        /// for each of the 16 channels. Also included in the data structure is a Header Byte (254), and a Checksum Byte (which is the total value of 254 + all 16 bytes of data). 
        /// Data will be sent in the following order from left to right: Header Byte 254, Channel 0 LSB, 0 MSB, 1 LSB, 1 MSB, 2 LSB, 2 MSB, 3 LSB, 3 MSB, 4 LSB, 4 MSB, 
        /// 5 LSB, 5 MSB, 6 LSB, 6 MSB, 7 LSB, 7 MSB, 8 LSB, 8 MSB, 9 LSB, 9 MSB, 10 LSB, 10 MSB, 11 LSB, 11 MSB, 12 LSB, 12 MSB, 13 LSB, 13 MSB, 14 LSB, 14 MSB, 15 LSB, 
        /// 15MSB, Checksum Value.</remarks>  
        int[] IAD12.Read12BitsValuesOfBank2(byte bank)
        {
            if (bank > 2)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bank, "The value should be from 0 to 2.");
            }

            int[] data = new int[16];
            EnterCommand();
            WriteByte((byte)(204 + bank));
            int checksum = _Read8BitsValue();
            if (checksum != 254)
            {
                throw new ChecksumException("Head Data Error");
            }
            int value = 0;
            for (int i = 0; i < 16; i++)
            {
                int lsb = _Read8BitsValue();
                int msb = _Read8BitsValue();
                value = msb * 256 + lsb;
                checksum = checksum + msb + lsb;
                data[i] = value;
                
            }
            value = _Read8BitsValue();

            int t = checksum - ((int)(checksum / 256)) * 256;
            if (value != t)
            {
                throw new ChecksumException("Checksum Error");
            }
            return data;
        }


        /// <summary>
        /// Read 8 bit value.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        int _Read8BitsValue()
        {
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return n;
        }

        /// <summary>
        /// Read 16 bit value, lsb first.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        int _Read16BitsValueForAD12()
        {
            int value = 0;
            int lsb = _Read8BitsValue();
            int msb = _Read8BitsValue();
            value = msb * 256 + lsb;
            return value;

        }

        /// <summary>
        /// Read 16 bit value, msb first.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        int _Read16BitsValue()
        {
            int value = 0;
            int msb = _Read8BitsValue();
            int lsb = _Read8BitsValue();
            value = msb * 256 + lsb;
            return value;
        }       
    }

    internal class AD8 : NCDBase, IAD8
    {

        public AD8(NCDController objNCD)
            : base(objNCD)
        {
        }

        /// <summary>
        /// Read 8-bit A/D value for specific channel.
        /// </summary>
        /// <param name="channel">Channel number: 0-7, 0 for first channel</param>
        /// <returns><para>0-255</para>
        /// The value indicates the voltage on the selected input channel.</returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,150</description>
        /// <description>Read 8-Bit A/D Channel 1</description>
        /// </item>
        /// <item>
        /// <description>254,151</description>
        /// <description>Read 8-Bit A/D Channel 2</description>
        /// </item>
        /// <item>
        /// <description>254,152</description>
        /// <description>Read 8-Bit A/D Channel 3</description>
        /// </item>
        /// <item>
        /// <description>254,153</description>
        /// <description>Read 8-Bit A/D Channel 4</description>
        /// </item>
        /// <item>
        /// <description>254,154</description>
        /// <description>Read 8-Bit A/D Channel 5</description>
        /// </item>
        /// <item>
        /// <description>254,155</description>
        /// <description>Read 8-Bit A/D Channel 6</description>
        /// </item>
        /// <item>
        /// <description>254,156</description>
        /// <description>Read 8-Bit A/D Channel 7</description>
        /// </item>
        /// <item>
        /// <description>254,157</description>
        /// <description>Read 8-Bit A/D Channel 8</description>
        /// </item>        
        /// </list>
        /// </remarks>
        int IAD8.Read8BitsValue(byte channel)
        {
            if (channel > 7)
            {
                throw new ArgumentOutOfRangeException("Channel ID", channel, "The value should be from 0 to 7");
            }

            //EnterCommand();
            //WriteByte((byte)(150 + channel));

            WriteBytes(254, (byte)(150 + channel));

            int value = _Read8BitsValue();
            return value;
        }


        /// <summary>
        /// Read 8-bit value for all channels.
        /// </summary>
        /// <returns> <para>Array of interger type.</para>
        /// <para>The length of the array is 8. Each value(0-255) indicates analog value for each of 8 channels.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,166</description>
        /// <description>Read 8-Bit A/D All Channels</description>
        /// </item>
        /// </list>
        /// </remarks>
        int[] IAD8.ReadAllChannels8BitsValues()
        {
            int[] data = new int[8];
            //EnterCommand();
            //WriteByte(166);

            WriteBytes(254, 166);

            for (int i = 0; i < 8; i++)
            {
                data[i] = _Read8BitsValue();
            }
            return data;

        }

        /// <summary>
        /// Read 10-bit A/D value for specific channel.
        /// </summary>
        /// <param name="channel">Channel number: 0-7, 0 for first channel</param>
        /// <returns><para>0-1023</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,158</description>
        /// <description>Read 10-Bit A/D Channel 1</description>
        /// </item>
        /// <item>
        /// <description>254,159</description>
        /// <description>Read 10-Bit A/D Channel 2</description>
        /// </item>
        /// <item>
        /// <description>254,160</description>
        /// <description>Read 10-Bit A/D Channel 3</description>
        /// </item>
        /// <item>
        /// <description>254,161</description>
        /// <description>Read 10-Bit A/D Channel 4</description>
        /// </item>
        /// <item>
        /// <description>254,162</description>
        /// <description>Read 10-Bit A/D Channel 5</description>
        /// </item>
        /// <item>
        /// <description>254,163</description>
        /// <description>Read 10-Bit A/D Channel 6</description>
        /// </item>
        /// <item>
        /// <description>254,164</description>
        /// <description>Read 10-Bit A/D Channel 7</description>
        /// </item>
        /// <item>
        /// <description>254,165</description>
        /// <description>Read 10-Bit A/D Channel 8</description>
        /// </item>        
        /// </list>
        /// <para>The controller 2 bytes indicating the voltage on the selected input channel.</para>
        /// <para>The first returned value is the Most Significant Byte MSB, 
        /// the second byte sent to your computer will be the Least Significant Byte LSB.</para> 
        /// Using the formula VALUE= (LSB + (MSB * 256)), where VALUE will equate to a numeric value from 0 to 1023.
        /// </remarks>
        int IAD8.Read10BitsValue(byte channel)
        {
            if (channel > 7)
            {
                throw new ArgumentOutOfRangeException("Channel ID", channel, "The value should be from 0 to 7");
            }
            //EnterCommand();
            //WriteByte((byte)(158 + channel));

            WriteBytes(254, (byte)(158 + channel));
            return _Read16BitsValue();
        }

        /// <summary>
        /// Read 10 bits value for all channels.
        /// </summary>
        /// <returns><para>Array of interger type.</para>
        /// <para>The length of the array is 8. Each value(0-1023) indicates the voltage of each channel.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,167</description>
        /// <description>Read 10-Bit A/D All Channels</description>
        /// </item>
        /// </list>
        /// </remarks>
        int[] IAD8.ReadAllChannels10BitsValues()
        {
            int[] data = new int[8];
            //EnterCommand();
            //WriteByte(167);

            WriteBytes(254, 167);

            for (int i = 0; i < 8; i++)
            {
                data[i] = _Read16BitsValue();
            }
            return data;

        }

        /// <summary>
        /// Read 10-bit A/D value for specific channel and get temperature in centigrade.
        /// </summary>
        /// <param name="channel">Channel number: 0-7, 0 for first channel</param>
        /// <returns><para>Temperature value in centigrade.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        double IAD8.ReadDegC(byte channel)
        {
            if (channel > 7)
            {
                throw new ArgumentOutOfRangeException("Channel ID", channel, "The value should be from 0 to 7");
            }
            //EnterCommand();
            //WriteByte((byte)(158 + channel));

            WriteBytes(254, (byte)(158 + channel));

            return _Read16BitsValue() * 5 * 19.5 / 1024;

        }

        /// <summary>
        /// Read 10-bit A/D value for specific channel and get temperature in fahrenheit.
        /// </summary>
        /// <param name="channel">Channel number: 0-7, 0 for first channel</param>
        /// <returns><para>Temperature value in fahrenheit.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        double IAD8.ReadDegF(byte channel)
        {
            return ((IAD8)this).ReadDegC(channel) * 1.8 + 32;
        }

        /// <summary>
        /// Read 8 bit value.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        int _Read8BitsValue()
        {
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return n;
        }


        /// <summary>
        /// Read 16 bit value, msb first.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        int _Read16BitsValue()
        {
            int value = 0;
            int msb = _Read8BitsValue();
            int lsb = _Read8BitsValue();
            value = msb * 256 + lsb;
            return value;
        }        
    }
}
