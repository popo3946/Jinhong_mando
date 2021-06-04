using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// Interface for Reactor controller
    /// </summary>
    public interface IReactor
    {
        /// <summary>
        /// Turn off individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0-7</param>
        /// <returns><para>True or False</para>
        /// <para>True for turn off relay successfully.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,0</description>
        /// <description>Turn Off Relay 1</description>
        /// </item>
        /// <item>
        /// <description>254,1</description>
        /// <description>Turn Off Relay 2</description>
        /// </item> 
        /// <item>
        /// <description>254,2</description>
        /// <description>Turn Off Relay 3</description>
        /// </item>
        /// <item>
        /// <description>254,3</description>
        /// <description>Turn Off Relay 4</description>
        /// </item> 
        /// <item>
        /// <description>254,4</description>
        /// <description>Turn Off Relay 5</description>
        /// </item>
        /// <item>
        /// <description>254,5</description>
        /// <description>Turn Off Relay 6</description>
        /// </item> 
        /// <item>
        /// <description>254,6</description>
        /// <description>Turn Off Relay 7</description>
        /// </item>
        /// <item>
        /// <description>254,7</description>
        /// <description>Turn Off Relay 8</description>
        /// </item>        
        /// </list>
        /// </remarks>
        bool TurnOffRelay(byte relayId);

        /// <summary>
        /// Turn on individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0-7</param>
        /// <returns><para>True or False</para>
        /// <para>True for turn on relay successfully.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,8</description>
        /// <description>Turn On Relay 1</description>
        /// </item>
        /// <item>
        /// <description>254,9</description>
        /// <description>Turn On Relay 2</description>
        /// </item> 
        /// <item>
        /// <description>254,10</description>
        /// <description>Turn On Relay 3</description>
        /// </item>
        /// <item>
        /// <description>254,11</description>
        /// <description>Turn On Relay 4</description>
        /// </item> 
        /// <item>
        /// <description>254,12</description>
        /// <description>Turn On Relay 5</description>
        /// </item>
        /// <item>
        /// <description>254,13</description>
        /// <description>Turn On Relay 6</description>
        /// </item> 
        /// <item>
        /// <description>254,14</description>
        /// <description>Turn On Relay 7</description>
        /// </item>
        /// <item>
        /// <description>254,15</description>
        /// <description>Turn On Relay 8</description>
        /// </item>        
        /// </list>
        /// </remarks>
        bool TurnOnRelay(byte relayId);

        /// <summary>
        /// Get status of individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <returns><para>ON or OFF</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,16</description>
        /// <description>Get status of Relay 1</description>
        /// </item>
        /// <item>
        /// <description>254,17</description>
        /// <description>Get status of Relay 2</description>
        /// </item> 
        /// <item>
        /// <description>254,18</description>
        /// <description>Get status of Relay 3</description>
        /// </item>
        /// <item>
        /// <description>254,19</description>
        /// <description>Get status of Relay 4</description>
        /// </item> 
        /// <item>
        /// <description>254,20</description>
        /// <description>Get status of Relay 5</description>
        /// </item>
        /// <item>
        /// <description>254,21</description>
        /// <description>Get status of Relay 6</description>
        /// </item> 
        /// <item>
        /// <description>254,22</description>
        /// <description>Get status of Relay 7</description>
        /// </item>
        /// <item>
        /// <description>254,23</description>
        /// <description>Get status of Relay 8</description>
        /// </item>        
        /// </list>
        /// </remarks>
        RelayStatus GetStatus(byte relayId);

        /// <summary>
        /// Get status of all relays at one time in current selected bank.
        /// </summary>
        /// <returns><para>0-255 for R8x Pro</para>
        /// <para>0-15 for R4x Pro</para>
        /// <para>The binary pattern of the value returned directly corresponds to the on/off status of each relay.</para></returns>        
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,24</description>
        /// <description>Get status of All Relays </description>
        /// </item>
        /// </list>
        /// </remarks>
        byte GetStatusOfAllRelays();

        /// <summary>
        /// Read 8 bits AD value of specific channel.
        /// </summary>
        /// <param name="channel">Channel Number: 0-7(0 for first channel)</param>
        /// <returns><para>0-255</para>The value indicates analog value for the specific channel.</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// </remarks>
        int ReadADValue(byte channel);

        /// <summary>
        /// Read 8 bits Pivot value of specific channel.
        /// </summary>
        /// <param name="channel">Channel Number: 0-7(0 for first channel)</param>
        /// <returns><para>0-255</para>The value indicates analog value for the specific channel.</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// </remarks>
        int ReadPivotValue(byte channel);

        /// <summary>
        /// Return control of relay to reactor board
        /// </summary>
        /// <param name="relayId">realy id, 0 - 7</param>
        /// <returns>true for success, false for failure</returns>
        bool ReturnRelay(byte relayId);

        /// <summary>
        /// Return control of all relays to reactor board
        /// </summary>
        /// <returns>true for success, false for failure</returns>
        bool ReturnAllRelays();

        /// <summary>
        /// Set all relays status
        /// </summary>
        /// <param name="status">status of all 8 relays, each bit represent a relay, bit value 1 for on, bit value 0 for off</param>
        /// <returns></returns>
        bool SetAllRelaysStatus(byte status);

    }

    internal class Reactor : NCDBase, IReactor 
    {
        public Reactor(NCDController objNCD)
            :base(objNCD)
        {

        }

        /// <summary>
        /// Turn off individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0-7</param>
        /// <returns><para>True or False</para>
        /// <para>True for turn off relay successfully.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IReactor.TurnOffRelay(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 7");
            }
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 254, relayId);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn on individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0-7</param>
        /// <returns><para>True or False</para>
        /// <para>True for turn on relay successfully.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IReactor.TurnOnRelay(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 7");
            }
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 254, (byte)(relayId + 8));
            return mNCD.GetAck();
        }

        /// <summary>
        /// Get status of individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <returns><para>ON or OFF</para></returns>
        RelayStatus IReactor.GetStatus(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 7");
            }
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 254, 24);
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            int s = n & (1 << relayId);
            if(s > 0)
            {
                return RelayStatus.ON;
            }
            return RelayStatus.OFF;
        }

        /// <summary>
        /// Get status of all relays at one time in current selected bank.
        /// </summary>
        /// <returns><para>0-255 for R8x Pro</para>
        /// <para>0-15 for R4x Pro</para>
        /// <para>The binary pattern of the value returned directly corresponds to the on/off status of each relay.</para></returns>        
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte IReactor.GetStatusOfAllRelays()
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 254, 24);
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;
        }


        /// <summary>
        /// Read 8 bits AD value of specific channel.
        /// </summary>
        /// <param name="channel">Channel Number: 0-7(0 for first channel)</param>
        /// <returns><para>0-255</para>The value indicates analog value for the specific channel.</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// </remarks>
        int IReactor.ReadADValue(byte channel)
        {
            if (channel > 7)
            {
                throw new ArgumentOutOfRangeException("Channel ID", channel, "The value should be from 0 to 7");
            }

            mNCD.WriteBytesWithSleep(2, 254, (byte)(150 + channel));

            int value = _Read8BitsValue();
            return value;
        }

        /// <summary>
        /// Read 8 bits Pivot value of specific channel.
        /// </summary>
        /// <param name="channel">Channel Number: 0-7(0 for first channel)</param>
        /// <returns><para>0-255</para>The value indicates analog value for the specific channel.</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// </remarks>
        int IReactor.ReadPivotValue(byte channel)
        {
            if (channel > 7)
            {
                throw new ArgumentOutOfRangeException("Channel ID", channel, "The value should be from 0 to 7");
            }

            mNCD.WriteBytesWithSleep(2, 64, (byte)(150 + channel));

            int value = _Read8BitsValue();
            return value;
        }


        bool IReactor.ReturnRelay(byte relayId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 64, 0, relayId);
            return mNCD.GetAck();
        }

        bool IReactor.ReturnAllRelays()
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(1, 64, 1);
            return mNCD.GetAck();
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
        /// Set all relays status
        /// </summary>
        /// <param name="status">status of all 8 relays, each bit represent a relay, bit value 1 for on, bit value 0 for off</param>
        /// <returns></returns>
        bool IReactor.SetAllRelaysStatus(byte status)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 254, 40, status);
            return mNCD.GetAck();
        }

    }
}
