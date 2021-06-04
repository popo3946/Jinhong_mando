using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    public interface IFusion
    {

        /// <summary>
        /// Turn off individual relay in a given bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns>        
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,100+RelayNumber(0-7), BankNumber(0-32)</description>
        /// <description>Turn Off Individual Relay in Bank</description>
        /// </item>
        /// </list>
        /// A Bank Number of 0 indicates to turn off the selected relay in all banks.
        /// </remarks>
        bool TurnOffRelayInBank(byte relayId, byte bankId);

        /// <summary>
        /// Turn on individual relay in a given bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns>        
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,108+RelayNumber(0-7), BankNumber(0-32)</description>
        /// <description>Turn On Individual Relay in Bank</description>
        /// </item>
        /// </list>
        /// A Bank Number of 0 indicates to turn on the selected relay in all banks.
        /// </remarks>
        bool TurnOnRelayInBank(byte relayId, byte bankId);

        /// <summary>
        /// Get status of an individual relay in a given bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns>ON or OFF</returns>        
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,116+RelayNumber(0-7), BankNumber(0-32)</description>
        /// <description>Get Status of an Individual Relay in Bank</description>
        /// </item>
        /// </list>
        /// A BANK NUMBER OF 0 IS INVALID FOR THIS COMMAND. RETURNED RESULTS MAY BE UNPREDICTABLE.
        /// </remarks>
        RelayStatus GetStatusInBank(byte relayId, byte bankId);



        /// <summary>
        /// Set status of all relays at one time in a given bank.
        /// </summary>
        /// <param name="status">8-bit status of relays: 0-255
        /// <para>A value of 0 turns off all the relays. A value of 255 turns on all the relays. 
        /// Other values set the status of the relays in the equivalent binary pattern of the RelayData parameter value.</para></param>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>        
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,140,Status(0-255),Bank(0-32)</description>
        /// <description>Set Statues of Relays in Bank</description>
        /// </item>
        /// </list>
        /// This allows you to easily set the status of 8 relays at one time.
        /// <para>A Bank Number of 0 applies this command to all relay banks.</para>
        /// </remarks>
        bool SetAllRelaysStatusInBank(byte status, byte bankId);


        /// <summary>
        /// Get status of all relays in a given bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 1-32</param>
        /// <returns><para>0-255</para>The value indicats the status of all 8 relays., -1 for fail</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,124,Bank(1-32)</description>
        /// <description>Get Status of All Relays in Bank</description>
        /// </item>
        /// </list>        
        /// </remarks>
        int GetAllRelaysStatusInBank(byte bankId);

    }

    class Fusion : NCDBase, IFusion
    {
        public Fusion(NCDController objNCD)
            : base(objNCD)
        {

        }

        /// <summary>
        /// Turn off individual relay in a given bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns>        
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,100+RelayNumber(0-7), BankNumber(0-32)</description>
        /// <description>Turn Off Individual Relay in Bank</description>
        /// </item>
        /// </list>
        /// A Bank Number of 0 indicates to turn off the selected relay in all banks.
        /// </remarks>
        bool IFusion.TurnOffRelayInBank(byte relayId, byte bankId)
        {
            mNCD.WriteBytesAPI((byte)254, (byte)(100 + relayId), bankId);
            byte[] data = mNCD.ReadBytesApi();
            if (data != null)
            {
                if (data.Length == 2)
                {
                    if (data[0] == bankId)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Turn on individual relay in a given bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns>        
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,108+RelayNumber(0-7), BankNumber(0-32)</description>
        /// <description>Turn On Individual Relay in Bank</description>
        /// </item>
        /// </list>
        /// A Bank Number of 0 indicates to turn on the selected relay in all banks.
        /// </remarks>
        bool IFusion.TurnOnRelayInBank(byte relayId, byte bankId)
        {
            mNCD.WriteBytesAPI((byte)254, (byte)(108 + relayId), (byte)bankId);
            byte[] data = mNCD.ReadBytesApi();
            if (data != null)
            {
                if (data.Length == 2)
                {
                    if (data[0] == bankId)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Get status of an individual relay in a given bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns>ON or OFF</returns>        
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,116+RelayNumber(0-7), BankNumber(0-32)</description>
        /// <description>Get Status of an Individual Relay in Bank</description>
        /// </item>
        /// </list>
        /// A BANK NUMBER OF 0 IS INVALID FOR THIS COMMAND. RETURNED RESULTS MAY BE UNPREDICTABLE.
        /// </remarks>
        RelayStatus IFusion.GetStatusInBank(byte relayId, byte bankId)
        {
            mNCD.WriteBytesAPI((byte)254, (byte)(116 + relayId), (byte)bankId);
            byte[] data = mNCD.ReadBytesApi();
            if (data != null)
            {
                if (data.Length == 1)
                {
                    return data[0] > 0 ? RelayStatus.ON : RelayStatus.OFF;
                }
            }
            return RelayStatus.FAIL;

        }


        /// <summary>
        /// Set status of all relays at one time in a given bank.
        /// </summary>
        /// <param name="status">8-bit status of relays: 0-255
        /// <para>A value of 0 turns off all the relays. A value of 255 turns on all the relays. 
        /// Other values set the status of the relays in the equivalent binary pattern of the RelayData parameter value.</para></param>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>        
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,140,Status(0-255),Bank(0-255)</description>
        /// <description>Set Statues of Relays in Bank</description>
        /// </item>
        /// </list>
        /// This allows you to easily set the status of 8 relays at one time.
        /// <para>A Bank Number of 0 applies this command to all relay banks.</para>
        /// </remarks>
        bool IFusion.SetAllRelaysStatusInBank(byte status, byte bankId)
        {
            mNCD.WriteBytesAPI((byte)254, (byte)140, status, bankId);
            byte[] data = mNCD.ReadBytesApi();
            if (data != null)
            {
                if (data.Length == 2)
                {
                    if (data[0] == bankId && data[1] == status)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Get status of all relays in a given bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 1-255</param>
        /// <returns><para>0-255</para>The value indicats the status of all 8 relays. -1 for fail</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,124,Bank(1-32)</description>
        /// <description>Get Status of All Relays in Bank</description>
        /// </item>
        /// </list>        
        /// </remarks>
        int IFusion.GetAllRelaysStatusInBank(byte bankId)
        {
            mNCD.WriteBytesAPI((byte)254, (byte)124, bankId);
            byte[] data = mNCD.ReadBytesApi();
            if (data != null)
            {
                if (data.Length == 1)
                {
                    return data[0];
                }
            }
            return -1; // fail
        }

    }
}
