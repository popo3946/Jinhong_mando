using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// R2x Object interface
    /// </summary>
    public interface IR2X
    {
        /// <summary>
        /// Turn off specific relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0 - 1</param>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <returns><para>True or False</para>
        /// <para>True for turn off relay successfully.</para></returns>
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
        /// <description>254,2</description>
        /// <description>Turn Off Relay 2</description>
        /// </item> 
        /// </list>
        /// </remarks>
        bool TurnOffRelay(byte relayId);

        /// <summary>
        /// Turn on specific relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0 - 1</param>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <returns><para>True or False</para>
        /// <para>True for turn on relay successfully.</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,1</description>
        /// <description>Turn On Relay 1</description>
        /// </item>
        /// <item>
        /// <description>254,3</description>
        /// <description>Turn On Relay 2</description>
        /// </item> 
        /// </list>
        /// </remarks>
        bool TurnOnRelay(byte relayId);

        /// <summary>
        /// Get status of specific relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0 - 1</param>
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
        /// <description>254,4</description>
        /// <description>Get Relay 1 Status</description>
        /// </item>
        /// <item>
        /// <description>254,5</description>
        /// <description>Get Relay 2 Status</description>
        /// </item> 
        /// </list>
        /// </remarks>
        RelayStatus GetStatus(byte relayId);

        /// <summary>
        /// Get status of both relays in current selected bank.
        /// </summary>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <returns><para>Return Byte 0: Both Relays are Off</para>
        /// <para>Return Byte 1: Relay 1 is On, Relay 2 is Off</para>
        /// <para>Return Byte 2: Relay 2 is On, Relay 1 is Off</para>
        /// <para>Return Byte 3: Both Relays are On</para>
        ///</returns>
        ///<remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,7</description>
        /// <description>Get Status of Both Relays</description>
        /// </item>
        /// </list>        
        ///</remarks>
        byte GetStatusOfBothRelays();

        /// <summary>
        /// Set status of both relays at one time.
        /// </summary>
        /// <param name="r1">Status of Relay 1: ON or OFF</param>
        /// <param name="r2">Status of Relay 2: ON or OFF</param>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,6,0</description>
        /// <description>Turn Off Both Relays</description>
        /// </item>
        /// <item>
        /// <description>254,6,1</description>
        /// <description>Turn On Relay 1, Turn Off Relay 2</description>
        /// </item>
        /// <item>
        /// <description>254,6,2</description>
        /// <description>Turn On Relay 2, Turn Off Relay 1</description>
        /// </item>
        /// <item>
        /// <description>254,6,3</description>
        /// <description>Turn On Both Relays</description>
        /// </item>    
        /// </list>
        /// </remarks>
        bool SetStatusOfBothRelays(RelayStatus r1, RelayStatus r2);

        /// <summary>
        /// Set status of both relays at one time.
        /// </summary>
        /// <param name="status">Status of two relays: 0-3</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,6,0</description>
        /// <description>Turn Off Both Relays</description>
        /// </item>
        /// <item>
        /// <description>254,6,1</description>
        /// <description>Turn On Relay 1, Turn Off Relay 2</description>
        /// </item>
        /// <item>
        /// <description>254,6,2</description>
        /// <description>Turn On Relay 2, Turn Off Relay 1</description>
        /// </item>
        /// <item>
        /// <description>254,6,3</description>
        /// <description>Turn On Both Relays</description>
        /// </item>    
        /// </list>
        /// </remarks>
        bool SetStatusOfBothRelays(byte status);

        /// <summary>
        /// Store current status of relays into memory. 
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,8</description>
        /// <description>Store Relay Status as Power-Up Default</description>
        /// </item>
        /// </list>
        /// <para>This command will store the current on/off state of the relays in non-volatile EEPROM. 
        /// The next time power is applied, the relays will automatically return to the store on/off state.</para>
        /// </remarks>
        bool StorePowerUpSatus();

        /// <summary>
        /// Read the stored power-up default status of relays in current selected bank.
        /// </summary>
        /// <returns><para>0-3</para>
        /// <para>Return Byte 0: Both Relays are Off on Power-Up</para>
        /// <para>Return Byte 1: Relay 1 is On, Relay 2 is Off on Power-Up</para>
        /// <para>Return Byte 2: Relay 2 is On, Relay 1 is Off on Power-Up</para>
        /// <para>Return Byte 3: Both Relays are On when Powered-Up</para></returns>        
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,9</description>
        /// <description>Retrieve Startup Default State of the Relays</description>
        /// </item>
        /// </list>
        /// </remarks>
        byte ReadPowerUpDefaultStatus();
    }

    internal class R2X : NCDBase, IR2X
    {
        public R2X(NCDController objNCD)
            : base(objNCD)
        {

        }

        /// <summary>
        /// Turn off specific relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0 - 1</param>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <returns><para>True or False</para>
        /// <para>True for turn off relay successfully.</para></returns>
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
        /// <description>254,2</description>
        /// <description>Turn Off Relay 2</description>
        /// </item> 
        /// </list>
        /// </remarks>
        bool IR2X.TurnOffRelay(byte relayId)
        {
            if (relayId > 1)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 1");
            }
            EnterCommand();
            if (relayId == 0)
            {
                WriteByte(0);
            }
            else
            {
                WriteByte(2);
            }
            //mNCD.GetAck();  // r1x/r2x works in one way in this command, but in new version, it works in two way.
            return true;
        }

        /// <summary>
        /// Turn on specific relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0 - 1</param>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <returns><para>True or False</para>
        /// <para>True for turn on relay successfully.</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,1</description>
        /// <description>Turn On Relay 1</description>
        /// </item>
        /// <item>
        /// <description>254,3</description>
        /// <description>Turn On Relay 2</description>
        /// </item> 
        /// </list>
        /// </remarks>         
        bool IR2X.TurnOnRelay(byte relayId)
        {
            if (relayId > 1)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 1");
            }
            EnterCommand();
            if (relayId == 0)
            {
                WriteByte(1);
            }
            else
            {
                WriteByte(3);
            }
            //mNCD.GetAck();  // r1x/r2x works in one way in this command, but in new version, it works in two way.
            return true;

        }

        /// <summary>
        /// Get status of specific relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0 - 1</param>
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
        /// <description>254,4</description>
        /// <description>Get Relay 1 Status</description>
        /// </item>
        /// <item>
        /// <description>254,5</description>
        /// <description>Get Relay 2 Status</description>
        /// </item> 
        /// </list>
        /// </remarks>
        RelayStatus IR2X.GetStatus(byte relayId)
        {
            if (relayId > 1)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 1");
            }
            EnterCommand();
            if (relayId == 0)
            {
                WriteByte(4);
            }
            else
            {
                WriteByte(5);
            }
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (RelayStatus)n;

        }

        /// <summary>
        /// Get status of both relays in current selected bank.
        /// </summary>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <returns><para>Return Byte 0: Both Relays are Off</para>
        /// <para>Return Byte 1: Relay 1 is On, Relay 2 is Off</para>
        /// <para>Return Byte 2: Relay 2 is On, Relay 1 is Off</para>
        /// <para>Return Byte 3: Both Relays are On</para>
        ///</returns>
        ///<remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,7</description>
        /// <description>Get Status of Both Relays</description>
        /// </item>
        ///</remarks>
        byte IR2X.GetStatusOfBothRelays()
        {
            EnterCommand();
            WriteByte(7);
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;

        }

        /// <summary>
        /// Set status of both relays at one time
        /// </summary>
        /// <param name="r1">Status of Relay 1: ON or OFF</param>
        /// <param name="r2">Status of Relay 2: ON or OFF</param>
        /// <returns><para>True for success</para></returns>
        bool IR2X.SetStatusOfBothRelays(RelayStatus r1, RelayStatus r2)
        {
            byte status = (byte)((r1 == RelayStatus.ON) ? 1 : 0);
            status = (byte)(status + (r2 == RelayStatus.ON ? 1 : 0));
            return _SetStatusRelays(status);
        }

        /// <summary>
        /// Set status of both relays at one time
        /// </summary>
        /// <param name="status">Status of two relays: 0-3</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,6,0</description>
        /// <description>Turn Off Both Relays</description>
        /// </item>
        /// <item>
        /// <description>254,6,1</description>
        /// <description>Turn On Relay 1, Turn Off Relay 2</description>
        /// </item>
        /// <item>
        /// <description>254,6,2</description>
        /// <description>Turn On Relay 2, Turn Off Relay 1</description>
        /// </item>
        /// <item>
        /// <description>254,6,3</description>
        /// <description>Turn On Both Relays</description>
        /// </item>         
        /// </remarks>
        bool IR2X.SetStatusOfBothRelays(byte status)
        {
            if (status > 3)
            {
                throw new ArgumentOutOfRangeException("Status", status, "Value should range from 0 to 3.");
            }
            return _SetStatusRelays(status);
        }

        private bool _SetStatusRelays(byte status)
        {
            EnterCommand();
            WriteByte(6);
            WriteByte(status);
            return true;
            //return mNCD.GetAck();

        }

        /// <summary>
        /// Store current status of relays into memory. 
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,8</description>
        /// <description>Store Relay Status as Power-Up Default</description>
        /// </item>
        /// </list>
        /// <para>This command will store the current on/off state of the relays in non-volatile EEPROM. 
        /// The next time power is applied, the relays will automatically return to the store on/off state.</para>
        /// </remarks>
        bool IR2X.StorePowerUpSatus()
        {
            EnterCommand();
            WriteByte(8);
            //mNCD.GetAck();
            return true;
        }

        /// <summary>
        /// Read the stored power-up default status of relays in current selected bank.
        /// </summary>
        /// <returns><para>0-3</para>
        /// <para>Return Byte 0: Both Relays are Off on Power-Up</para>
        /// <para>Return Byte 1: Relay 1 is On, Relay 2 is Off on Power-Up</para>
        /// <para>Return Byte 2: Relay 2 is On, Relay 1 is Off on Power-Up</para>
        /// <para>Return Byte 3: Both Relays are On when Powered-Up</para></returns>        
        ///<exception cref="TimeoutException">Read Timeout</exception>
        ///<remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,9</description>
        /// <description>Retrieve Startup Default State of the Relays</description>
        /// </item>
        /// </list>
        ///</remarks>
        byte IR2X.ReadPowerUpDefaultStatus()
        {
            EnterCommand();
            WriteByte(9);
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;

        }
    }
}
