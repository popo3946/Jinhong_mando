using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// IPWM Object Interface
    /// </summary>
    public interface IPWM
    {
        /// <summary>
        /// Set PWM value on specific output channel.
        /// </summary>
        /// <param name="channel">Channel Number: 0-7 </param>
        /// <param name="level">PWM Value: 0-255</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,Channel(0-7),PWM Value(0-255)</description>
        /// <description>Set Output Channel PWM Value</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool SetLevel(byte channel, byte level);

        /// <summary>
        /// Set all output channels to the same PWM value.
        /// </summary>
        /// <param name="level">PWM Value: 0-255</param>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,0,PWM Value(0-255)</description>
        /// <description>Set All Output Channels Same PWM Value</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool SetLevelOfAllChannels(byte level);

        /// <summary>
        /// Store the currently selected PWM value for all 8 channels as the default power-up values.
        /// </summary>
        /// <param name="level">PWM Value: 0-255</param>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,9,PWM Value(0-255)</description>
        /// <description>Store Startup PWM Values</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool StoreStartupValues(byte level);

        /// <summary>
        /// Set startup mode.
        /// </summary>
        /// <param name="immediately">True or False <para>'True' for all 8 channels to begin cycling immediately.</para>
        /// <para>'False' for each channel rising slowly to its stored default Powerup PWM Value, beginning with output channel 1.</para></param>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,10,1</description>
        /// <description>Set Startup Mode (cycling immedialtely)</description>
        /// </item>
        /// <item>
        /// <description>254,10,0</description>
        /// <description>Set Startup Mode (rising slowly)</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool SetStartupMode(bool immediately);
    }

    class PWM : NCDBase, IPWM 
    {
        public PWM(NCDController objNCD)
            : base(objNCD)
        {

        }

        /// <summary>
        /// Set PWM value on specific output channel.
        /// </summary>
        /// <param name="channel">Channel Number: 0-7 </param>
        /// <param name="level">PWM Value: 0-255</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IPWM.SetLevel(byte channel, byte level)
        {
            if (channel > 7)
            {
                throw new ArgumentOutOfRangeException("Channel ID", channel, "The value should range from 0 to 7");
            }
            WriteBytes(254, (byte)(channel + 1), level);

            return true;
        }

        /// <summary>
        /// Set all output channels to the same PWM value.
        /// </summary>
        /// <param name="level">PWM Value: 0-255</param>
        /// <returns><para>True for success</para></returns>
        bool IPWM.SetLevelOfAllChannels(byte level)
        {
            WriteBytes(254, 0, level);
            return true;
        }

        /// <summary>
        /// Store the currently selected PWM value for all 8 channels as the default power-up values.
        /// </summary>
        /// <param name="level">PWM Value: 0-255</param>
        /// <returns><para>True for success</para></returns>
        bool IPWM.StoreStartupValues(byte level)
        {
            WriteBytes(254, 9, level);
            return true;
        }

        /// <summary>
        /// Set startup mode.
        /// </summary>
        /// <param name="immediately">True for success <para>'True' for all 8 channels to begin cycling immediately.</para>
        /// <para>'False' for each channel rising slowly to its stored default Powerup PWM Value, beginning with output channel 1.</param>
        /// <returns><para>True for success</para></returns>
        bool IPWM.SetStartupMode(bool immediately)
        {
            byte v = (byte)(immediately ? 1 : 0);
            WriteBytes(254, 10, v);
            return true;
        }        
    }
}
