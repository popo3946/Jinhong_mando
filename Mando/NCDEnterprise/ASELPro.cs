using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
   // /// <summary>
   // /// ASEL Pro Object Interface
   // /// </summary>
   //public interface IASELPro
   //{
   //    /// <summary>
   //    /// Connect an input to output channel A.
   //    /// </summary>
   //    /// <param name="input">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <returns><para>True for success</para></returns> 
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,1,Input(1-16)</description>
   //    /// <description>Set Output Channel A to Desired Input (ASELPro)</description>
   //    /// </item>
   //    /// <item>
   //    /// <description>254,1,Input(1-8)</description>
   //    /// <description>Set Output Channel A to Desired Input (8S2SPro)</description>
   //    /// </item>        
   //    /// </list>
   //    /// </remarks>
   //    bool SetInputToChannelA(byte input);
   //
   //    /// <summary>
   //    /// Connect an input to output channel B.
   //    /// </summary>
   //    /// <param name="input">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <returns><para>True for success</para></returns> 
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,2,Input(1-16)</description>
   //    /// <description>Set Output Channel B to Desired Input (ASELPro)</description>
   //    /// </item>
   //    /// <item>
   //    /// <description>254,2,Input(1-8)</description>
   //    /// <description>Set Output Channel B to Desired Input (8S2SPro)</description>
   //    /// </item>        
   //    /// </list>
   //    /// </remarks>        
   //    bool SetInputToChannelB(byte input);
   //
   //    /// <summary>
   //    /// Connect two inputs to channel A and B respectively.
   //    /// </summary>
   //    /// <param name="inputA">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <param name="inputB">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <returns><para>True for success</para></returns> 
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,3,InputA(1-16), InputB(1-16)</description>
   //    /// <description>Set Output Channel A and B Simultaneously (Friendly)) for ASELPro</description>
   //    /// </item>
   //    /// <item>
   //    /// <description>254,3,InputA(1-8), InputB(1-8)</description>
   //    /// <description>Set Output Channel A and B Simultaneously (Friendly)) for 8S2SPro</description>
   //    /// </item>        
   //    /// </list>
   //    /// </remarks> 
   //    bool SetInputToChannelAB(byte inputA, byte inputB);
   //
   //    /// <summary>
   //    /// Connect two inputs to channel A and B respectively FAST Mode.  
   //    /// </summary>
   //    /// <param name="inputA">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <param name="inputB">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <returns><para>True for success</para></returns> 
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,4,InputA(1-16), InputB(1-16)</description>
   //    /// <description>Set Output Channel A and B Simultaneously (Fast) for ASELPro</description>
   //    /// </item>
   //    /// <item>
   //    /// <description>254,4,InputA(1-8), InputB(1-8)</description>
   //    /// <description>Set Output Channel A and B Simultaneously (Fast) for 8S2SPro</description>
   //    /// </item>        
   //    /// </list>
   //    /// <para>This is fast way, supported by version 5.0 + firmware only.</para>
   //    /// </remarks>
   //    bool SetInputToChannelAB_Fast(byte inputA, byte inputB);
   //
   //    /// <summary>
   //    /// Report back the currently sotred E3C devcie number.
   //    /// </summary>
   //    /// <returns>E3C Device Number</returns>
   //    /// <exception cref="TimeoutException">Read Timeout</exception>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,10</description>
   //    /// <description>Get E3C Device Number</description>
   //    /// </item>
   //    /// </list>
   //    /// <para>Identical to E3C command 247.</para>
   //    /// </remarks>
   //    byte GetE3CNumber();
   //
   //    /// <summary>
   //    /// Report the current input channel routed to channel A.
   //    /// </summary>
   //    /// <returns>ID of Input Channel<para>1-16 for ASELPro</para><para>1-8 for 8S2SPRO</para></returns>
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,11</description>
   //    /// <description>Report the Input Currently Routed to Output A</description>
   //    /// </item>
   //    /// </list>
   //    /// </remarks>
   //    byte GetCurrentInputToChannelA();
   //
   //    /// <summary>
   //    /// Report the current input channel routed to channel B.
   //    /// </summary>
   //    /// <returns>ID of Input Channel<para>1-16 for ASELPro</para><para>1-8 for 8S2SPRO</para></returns>
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,12</description>
   //    /// <description>Report the Input Currently Routed to Output B</description>
   //    /// </item>
   //    /// </list>
   //    /// </remarks>
   //    byte GetCurrentInputToChannelB();
   //
   //    /// <summary>
   //    /// Store the current input channel selection for output channels A and B in Non-Volatile Memory.
   //    /// </summary>
   //    /// <returns><para>True for success</para></returns>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,13</description>
   //    /// <description>Store Current Route Pattern as Powerup Default</description>
   //    /// </item>
   //    /// </list>
   //    /// </remarks>
   //    bool StorePowerupDefault();
   //
   //    /// <summary>
   //    /// Report default powerup input route for channel A.
   //    /// </summary>
   //    /// <returns>ID of Input Channel<para>1-16 for ASELPro</para><para>1-8 for 8S2SPRO</para></returns>
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,14</description>
   //    /// <description>Report Default Powerup Route Pattern for Channel A</description>
   //    /// </item>
   //    /// </list>
   //    /// </remarks>
   //    byte GetPowerupDefaultToChannelA();
   //
   //    /// <summary>
   //    /// Report default powerup input route for channel B.
   //    /// </summary>
   //    /// <returns>ID of Input Channel<para>1-16 for ASELPro</para><para>1-8 for 8S2SPRO</para></returns>
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,14</description>
   //    /// <description>Report Default Powerup Route Pattern for Channel B</description>
   //    /// </item>
   //    /// </list>
   //    /// </remarks>
   //    byte GetPowerupDefaultToChannelB();
   //
   //    /// <summary>
   //    /// Store a MAP Value used to swap the Upper and Lower Rows of Inputs on the ASELPRO.
   //    /// </summary>
   //    /// <param name="swap"><para>True or False.</para><para>'True' swaps lower and upper eight rows of inputs most commonly used with JALCO connectors.</para>
   //    /// <para>'False' sets the inputs to standard map.</para></param>
   //    /// <returns><para>True for success</para></returns>
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,15,1</description>
   //    /// <description>Set Mapping Value (swaps lower and upper eight rows of inputs)</description>
   //    /// </item>
   //    /// <item>
   //    /// <description>254,15,0</description>
   //    /// <description>Set Mapping Value (sets the inputs to standard map)</description>
   //    /// </item>        
   //    /// </list>
   //    /// <para>It works with Version 4.0 firmware and later ONLY.</para>
   //    /// </remarks>
   //    bool SetMappingValue(bool swap);
   //
   //    /// <summary>
   //    /// Read the current map setting.
   //    /// </summary>
   //    /// <returns><para>True or False</para>Ture for swap mode. False for standard mode</returns>
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    /// <remarks>
   //    /// <list type="table">
   //    /// <listheader>
   //    /// <term>Command</term>
   //    /// <term>Function</term>
   //    /// </listheader>
   //    /// <item>
   //    /// <description>254,16</description>
   //    /// <description>Get Mapping Value</description>
   //    /// </item>
   //    /// </list>
   //    /// </remarks>
   //    bool GetMappingValue();
   //
   //}

   //class ASELPro : NCDBase, IASELPro 
   //{
   //
   //    public ASELPro(NCDController objNCD)
   //        : base(objNCD)
   //    {
   //
   //    }
   //
   //    /// <summary>
   //    /// Connects an input to output channel A.
   //    /// </summary>
   //    /// <param name="input">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <returns><para>True for success</para></returns> 
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    bool IASELPro.SetInputToChannelA(byte input)
   //    {
   //        if (input > 16 || input < 1)
   //        {
   //            throw new ArgumentOutOfRangeException("Input", input, "The value should range from 1 to 16");
   //        }
   //        //EnterCommand();
   //        //WriteByte(1);
   //        //WriteByte(input);
   //
   //        WriteBytes(254, 1, input);
   //
   //        return mNCD.GetAck();
   //    }
   //
   //
   //    /// <summary>
   //    /// Connects an input to output channel B.
   //    /// </summary>
   //    /// <param name="input">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <returns><para>True for success</para></returns> 
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    bool IASELPro.SetInputToChannelB(byte input)
   //    {
   //        if (input > 16 || input < 1)
   //        {
   //            throw new ArgumentOutOfRangeException("Input", input, "The value should range from 1 to 16");
   //        }
   //        //EnterCommand();
   //        //WriteByte(2);
   //        //WriteByte(input);
   //
   //        WriteBytes(254, 2, input);
   //
   //        return mNCD.GetAck();
   //    }
   //
   //    /// <summary>
   //    /// Connects two input to channel A and B respectively.
   //    /// </summary>
   //    /// <param name="inputA">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <param name="inputB">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <returns><para>True for success</para></returns>
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    bool IASELPro.SetInputToChannelAB(byte inputA, byte inputB)
   //    {
   //        if (inputA > 16 || inputA < 1)
   //        {
   //            throw new ArgumentOutOfRangeException("Input", inputA, "The value should range from 1 to 16");
   //        }
   //        if (inputB > 16 || inputB < 1)
   //        {
   //            throw new ArgumentOutOfRangeException("Input", inputB, "The value should range from 1 to 16");
   //        }
   //
   //        //EnterCommand();
   //        //WriteByte(3);
   //        //WriteByte(inputA);
   //        //WriteByte(inputB);
   //
   //        WriteBytes(254, 3, inputA, inputB);
   //
   //        return mNCD.GetAck();
   //    }
   //
   //    /// <summary>
   //    /// <para>Connects two input to channel A and B respectively. </para>
   //    /// This is fast way, supported by version 5.0 + firmware only.
   //    /// </summary>
   //    /// <param name="inputA">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <param name="inputB">1-16 for ASELPro<para>1-8 for 8S2SPro</para> </param>
   //    /// <returns><para>True for success</para></returns> 
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    bool IASELPro.SetInputToChannelAB_Fast(byte inputA, byte inputB)
   //    {
   //        if (inputA > 16 || inputA < 1)
   //        {
   //            throw new ArgumentOutOfRangeException("Input", inputA, "The value should range from 1 to 16");
   //        }
   //        if (inputB > 16 || inputB < 1)
   //        {
   //            throw new ArgumentOutOfRangeException("Input", inputB, "The value should range from 1 to 16");
   //        }
   //
   //        //EnterCommand();
   //        //WriteByte(4);
   //        //WriteByte((byte)(inputB * 16 + inputA));
   //
   //        WriteBytes(254, 4, (byte)(inputB * 16 + inputA));
   //
   //        return mNCD.GetAck();
   //    }
   //
   //    /// <summary>
   //    /// Reports back the currently sotred E3C devcie number.
   //    /// </summary>
   //    /// <returns>E3C number</returns>
   //    /// <exception cref="TimeoutException">Read Timeout</exception>
   //    byte IASELPro.GetE3CNumber()
   //    {
   //        //EnterCommand();
   //        //WriteByte(10);
   //
   //        WriteBytes(254, 10);
   //
   //        int n = ReadByte2();
   //        if (n == -1)
   //        {
   //            throw new TimeoutException();
   //        }
   //        return (byte)n;
   //    }
   //
   //    /// <summary>
   //    /// Reports the current input channel routed to channel A.
   //    /// </summary>
   //    /// <returns>ID of Input Channel<para>1-16 for ASELPro</para><para>1-8 for 8S2SPRO</para></returns>
   //    /// <exception cref="TimeoutException">Read Timeout</exception>
   //    byte IASELPro.GetCurrentInputToChannelA()
   //    {
   //        //EnterCommand();
   //        //WriteByte(11);
   //
   //        WriteBytes(254, 11);
   //
   //        int n = ReadByte2();
   //        if (n == -1)
   //        {
   //            throw new TimeoutException();
   //        }
   //        return (byte)n;
   //        
   //    }
   //
   //    /// Reports the current input channel routed to channel B.
   //    /// </summary>
   //    /// <returns>ID of Input Channel<para>1-16 for ASELPro</para><para>1-8 for 8S2SPRO</para></returns>
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    byte IASELPro.GetCurrentInputToChannelB()
   //    {
   //        //EnterCommand();
   //        //WriteByte(12);
   //
   //        WriteBytes(254, 12);
   //
   //        int n = ReadByte2();
   //        if (n == -1)
   //        {
   //            throw new TimeoutException();
   //        }
   //        return (byte)n;
   //    }
   //
   //    /// <summary>
   //    /// Store the current input channel selection for output channels A and B in Non-Volatile Memory.
   //    /// </summary>
   //    /// <returns><para>True or False</para></returns>
   //    bool IASELPro.StorePowerupDefault()
   //    {
   //        //EnterCommand();
   //        //WriteByte(13);
   //
   //        WriteBytes(254, 13);
   //
   //        return mNCD.GetAck();
   //    }
   //
   //    /// <summary>
   //    /// Reports default powerup input route for channel A.
   //    /// </summary>
   //    /// <returns>ID of Input Channel<para>1-16 for ASELPro</para><para>1-8 for 8S2SPRO</para></returns>
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    byte IASELPro.GetPowerupDefaultToChannelA()
   //    {
   //        //EnterCommand();
   //        //WriteByte(14);
   //
   //        WriteBytes(254, 14);
   //
   //        int n1 = ReadByte2();
   //        int n2 = ReadByte2();
   //        if (n1 == -1 || n2 == -1)
   //        {
   //            throw new TimeoutException();
   //        }
   //        return (byte)n1;
   //    }
   //
   //    /// <summary>
   //    /// Reports default powerup input route for channel B.
   //    /// </summary>
   //    /// <returns>ID of Input Channel<para>1-16 for ASELPro</para><para>1-8 for 8S2SPRO</para></returns>
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    byte IASELPro.GetPowerupDefaultToChannelB()
   //    {
   //        //EnterCommand();
   //        //WriteByte(14);
   //
   //        WriteBytes(254, 14);
   //
   //        int n1 = ReadByte2();
   //        int n2 = ReadByte2();
   //        if (n1 == -1 || n2 == -1)
   //        {
   //            throw new TimeoutException();
   //        }
   //        return (byte)n2;
   //    }
   //
   //    /// <summary>
   //    /// <para>Stores a MAP Value used to swap the Upper and Lower Rows of Inputs on the ASELPRO.</para>
   //    /// It works with Version 4.0 firmware and later ONLY.
   //    /// </summary>
   //    /// <param name="swap">True or False.<para>'True' swaps lower and upper eight rows of inputs most commonly used with JALCO connectors.</para>
   //    /// <para>'False' sets the inputs to standard map.</para></param>
   //    /// <returns><para>True for success</para></returns>
   //    /// <exception cref="ArgumentException">Wrong Arguement</exception>
   //    bool IASELPro.SetMappingValue(bool swap)
   //    {
   //        //EnterCommand();
   //        //WriteByte(15);
   //
   //        WriteBytes(254, 15);
   //
   //        if(swap)
   //        {
   //            WriteByte(1);
   //        }
   //        else
   //        {
   //            WriteByte(0);
   //        }
   //        return mNCD.GetAck();
   //    }
   //
   //    /// <summary>
   //    /// Read the current map setting.
   //    /// </summary>
   //    /// <returns><para>True or False</para>Ture for swap mode. False for standard mode</returns>
   //    /// <exception cref="TimeoutException">Read Timeout</exception>
   //    bool IASELPro.GetMappingValue()
   //    {
   //        //EnterCommand();
   //        //WriteByte(16);
   //
   //        WriteBytes(254, 16);
   //
   //        int n = ReadByte2();
   //        if (n == -1)
   //        {
   //            throw new TimeoutException();
   //        }
   //        return n == 1;
   //    }
   //
   //}
}
