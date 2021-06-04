using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{

    internal class ZR2X : NCDBase, IR2X
    {
        public ZR2X(NCDController objNCD)
            : base(objNCD)
        {

        }

        /// <summary>
        /// Turn off individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-1</param>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <returns> true for success</returns>
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
            return mNCD.GetAck();  // r1x/r2x works in one way in this command, but in new version, it works in two way.
            
        }

        /// <summary>
        /// Turns on individual relay in the current selected bank.
        /// </summary>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <param name="relayId">Relay number, 0 - 1</param>
        /// <returns> true for success</returns>
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
            return mNCD.GetAck();  // r1x/r2x works in one way in this command, but in new version, it works in two way.

        }

        /// <summary>
        /// Gets the status of an individual relay in the current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number, 0 - 1</param>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <returns>ON or OFF</returns>
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
        /// Gets the status of an individual relay in the given bank.
        /// </summary>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <returns> a byte from 0-3 indicating the on/off state of the relays when power is first applied to the board. 
        /// </returns>
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
        /// Stores the current status of the relays in a given bank into memory. 
        /// </summary>
        /// <returns> true for success</returns>
        bool IR2X.StorePowerUpSatus()
        {
            EnterCommand();
            WriteByte(8);
            return mNCD.GetAck();

        }


        /// <summary>
        /// Reads the stored power-up default status of the relays in current selected bank.
        /// </summary>
        /// <returns> a byte from 0-3 indicating the on/off state of the relays when power is first applied to the board. 
        /// </returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
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

        /// <summary>
        /// Set the status of both relays at one time
        /// </summary>
        /// <param name="r1">status of relay 1</param>
        /// <param name="r2">status of relay 2</param>
        /// <returns></returns>
        bool IR2X.SetStatusOfBothRelays(RelayStatus r1, RelayStatus r2)
        {
            byte status = (byte)((r1 == RelayStatus.ON) ? 1 : 0);
            status = (byte)(status + (r2 == RelayStatus.ON ? 1 : 0));
            return _SetStatusRelays(status);
        }

        /// <summary>
        /// Set the status of both relays at one time
        /// </summary>
        /// <param name="status">status of two relays</param>
        /// <returns>true for success</returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
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
            return mNCD.GetAck();

        }
    }

}
