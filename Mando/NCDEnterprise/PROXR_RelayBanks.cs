using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace NCDEnterprise
{

    /// <summary>
    /// Represents the interface of Relay Banks.
    /// </summary>
    public interface IRelayBanks
    {
        /// <summary>
        /// Direct commands to a selected relay bank.  
        /// All subsequent commands will be sent to the selected relay bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,49,BankNumber(0-32)</description>
        /// <description>Direct Commands to Selected Relay Bank</description>
        /// </item>
        /// </list>
        /// A Bank Number of 0 indicates to select all relay banks.
        /// </remarks>        
        bool SelectBank(byte bankId);

        /// <summary>
        /// Turn off individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,RelayNumber(0-7)</description>
        /// <description>Turn Off Individual Relay</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool TurnOffRelay(byte relayId);

        /// <summary>
        /// Turn on individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,8+RelayNumber(0-7)</description>
        /// <description>Turn On Individual Relay</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool TurnOnRelay(byte relayId);

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
        /// Get status of an individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
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
        /// <description>254,16+RelayNumber(0-7)</description>
        /// <description>Get Status of an Individual Relay</description>
        /// </item>
        /// </list> 
        ///A BANK NUMBER OF 0 IS INVALID FOR THIS COMMAND. RETURNED RESULTS MAY BE UNPREDICTABLE.</remarks>
        RelayStatus GetStatus(byte relayId);

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
        /// Turn on automatic relay refreshing.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,25</description>
        /// <description>Turn On Automatic Relay Refreshing</description>
        /// </item>
        /// </list>
        /// <para>Setting Automatically Stored when in Configuration Mode.</para>
        /// Default relay refreshing is turned on. Meaning every time you send a relay control command, the relays will respond to your commands.
        /// </remarks>
        bool TurnOnAutoRelayRefresh();

        /// <summary>
        /// Turn off automatic relay refreshing. 
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,26</description>
        /// <description>Turn Off Automatic Relay Refreshing</description>
        /// </item>
        /// </list>
        /// <para>Setting Automatically Stored when in Configuration Mode.</para> 
        /// Turning off relay refreshing allows you to control when the relays actually switch. 
        /// When refreshing is turned off, you can send relay control commands to the ProXR controller,
        /// and the controller will work just like normal, but the relays will never change state.
        /// </remarks>
        bool TurnOffAutoRelayRefresh();

        /// <summary>
        /// Store relay refreshing mode
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,35</description>
        /// <description>Store Relay Refreshing Mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool StoreRefreshSettings();

        /// <summary>
        /// Read default powerup refreshing Status.
        /// </summary>
        /// <returns>ON or OFF</returns>        
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,36</description>
        /// <description>Report Back Stored Refresh Settings</description>
        /// </item>
        /// </list>
        /// </remarks>
        AutoRefreshSetting ReportStoredRefreshSettings();

        /// <summary>
        /// Manually refresh relay bank. Set status of all relays at one time.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,37</description>
        /// <description>Manually Refresh Relay Bank</description>
        /// </item>
        /// </list>
        /// <para>This command stores the current status of relay refreshing in non-volatile memory.
        ///  The next time the relay controller is powered up, refreshing will be set to the stored status.</para>
        /// </remarks>
        bool ManuallyRefresh();
        
        /// <summary>
        /// Turn all relays on.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,30</description>
        /// <description>Turn On All Relays</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool TurnOnAllRelays();

        /// <summary>
        /// Turn all relays on in a given bank.
        /// </summary>
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
        /// <description>254,130,Bank(0-32)</description>
        /// <description>Turn On All Relays in Bank</description>
        /// </item>
        /// </list>
        /// A Bank Number of 0 indicates to turn on all relays in all banks.
        /// </remarks>
        bool TurnOnAllRelaysInBank(byte bankId);

        /// <summary>
        /// Turn off all relays in current selected bank.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,29</description>
        /// <description>Turn Off All Relays</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool TurnOffAllRelays();

        /// <summary>
        /// Turn all relays off in a given bank.
        /// </summary>
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
        /// <description>254,129,Bank(0-32)</description>
        /// <description>Turn Off All Relays in Bank</description>
        /// </item>
        /// </list>
        /// A Bank Number of 0 indicates to turn off all relays in all banks.
        /// </remarks>
        bool TurnOffAllRelaysInBank(byte bankId);

        /// <summary>
        /// Invert status of all relays.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,31</description>
        /// <description>Invert All Relays</description>
        /// </item>
        /// </list>
        /// Relays that were on turn off, relays that were off turn on.
        /// </remarks>
        bool InvertAllRelays();

        /// <summary>
        /// Invert status of all relays in a given bank.
        /// </summary>
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
        /// <description>254,131,Bank(0-32)</description>
        /// <description>Invert All Relays in Bank</description>
        /// </item>
        /// </list>
        /// A Bank Number of 0 indicates to invert all relays in all banks.
        /// </remarks>
        bool InvertAllRelaysInBank(byte bankId);

        /// <summary>
        /// Reverse pattern of relays in current selected bank.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,32</description>
        /// <description>Reverse All Relays</description>
        /// </item>
        /// </list>       
        /// </remarks>
        bool ReverseAllRelays();

        /// <summary>
        /// Reverse pattern of relays in a given bank.
        /// </summary>
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
        /// <description>254,132,Bank(0-32)</description>
        /// <description>Reverse All Relays in Bank</description>
        /// </item>
        /// </list>
        /// A Bank Number of 0 indicates to reverse all relays in all banks.
        /// </remarks>
        bool ReverseAllRelaysInBank(byte bankId);

        /// <summary>
        /// Tests 2-Way communications between PC and the relay controller.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,33</description>
        /// <description>Test 2-Way Communications with Controller</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool Test2Ways();

        /// <summary>
        /// Report back the selected relay bank number.
        /// </summary>
        /// <returns>0-32<para>0 indicates all banks.</para></returns>        
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,34</description>
        /// <description>Report the Selected Relay Bank</description>
        /// </item>
        /// </list>
        /// </remarks>
        byte GetSelectedBank();

        /// <summary>
        /// Set status of all relays directly in current selected bank. 
        /// </summary>
        /// <param name="status">8-bit status of relays: 0-255
        /// <para>A value of 0 turns off all the relays. A value of 255 turns on all the relays. 
        /// Other values set the status of the relays in the equivalent binary pattern of the RelayData parameter value.</para></param>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,40,Status(0-255)</description>
        /// <description>Set Statues of Relays</description>
        /// </item>
        /// </list> 
        /// This allows you to easily set the status of 8 relays at one time. 
        /// </remarks>
        bool SetRelayStatus(byte status);

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
        bool SetRelayStatusInBank(byte status, byte bankId);

        /// <summary>
        /// Store status of relays in current selected bank into memory. 
        /// </summary>
        /// <returns><para>True for success</para></returns>        
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,42</description>
        /// <description>Store Power Up Default Status</description>
        /// </item>
        /// </list>        
        /// The next time power is applied to the controller, relays will return to the stored on/off status. 
        /// </remarks>
        bool StorePowerUpSatus();

        /// <summary>
        /// Store status of relays in a given bank into memory. 
        /// </summary>
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
        /// <description>254,142,Bank(0-32)</description>
        /// <description>Store Power Up Default Status in Bank</description>
        /// </item>
        /// </list> 
        /// The next time power is applied to the controller, relays will return to the stored on/off state.
        /// <para>A Bank Number of 0 stores pattern of all relays in all banks.</para>
        /// </remarks>
        bool StorePowerUpSatusInBank(byte bankId);

        /// <summary>
        /// Read the stored power-up default status of relays in current selected bank.
        /// </summary>
        /// <returns>Array that holds the status of current selected bank</returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,43</description>
        /// <description>Read Power Up Default Status</description>
        /// </item>
        /// </list> 
        /// Returns null if fail to read from COM port. The array contains one item if not all banks are selected.
        /// </remarks>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte[] ReadPowerUpDefaultStatus();

        /// <summary>
        /// Read stored power-up default status of relays in a given bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns>Array that holds the status of current given bank.</returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,143,Bank(0-32)</description>
        /// <description>Read Power Up Default Status in Bank</description>
        /// </item>
        /// </list> 
        /// Returns null if fail to read from COM port. The array contains one item if not all banks are selected.
        /// A Bank Number of 0 reports back 26 bytes of data, indicating the stored pattern of all 26 banks.
        /// </remarks>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte[] ReadPowerUpDefaultStatusInBank(byte bankId); 

        /// <summary>
        /// Turn on one relay only, safe break before make.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-255</param>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,46,Relay(0-255)</description>
        /// <description>Turn On One Relay ONLY</description>
        /// </item>
        /// </list> 
        /// </remarks>
        bool TurnOnOneRelayOnly(byte relayId);

        /// <summary>
        /// Turn off a relay specified by its relay number.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-255 </param>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,47,Relay(0-255)</description>
        /// <description>Turn Off One Relay Specified by Relay Number</description>
        /// </item>
        /// </list> 
        /// </remarks>
        bool TurnOffRelayAdvanced(byte relayId);

        /// <summary>
        /// Turn on a relay specified by its relay number.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-255 </param>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,48,Relay(0-255)</description>
        /// <description>Turn On One Relay Specified by Relay Number</description>
        /// </item>
        /// </list> 
        /// </remarks>
        bool TurnOnRelayAdvanced(byte relayId);
        
        /// <summary>
        /// Get status of all relays in current selected bank.
        /// </summary>
        /// <returns>Array of byte type.
        /// <para>The array contains one item(0-255) if not all banks are selected.</para>
        /// <para>If the currently selected relay bank is 0, the array will contains 32 bytes indicating the status of all 32 relay banks.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,24</description>
        /// <description>Get Status of All Relays</description>
        /// </item>
        /// </list> 
        /// </remarks>
        byte[] GetAllStatus();

        /// <summary>
        /// Get status of all relays in all banks.
        /// </summary>
        /// <returns>Array of byte type.
        /// <para>The array will contains 32 bytes indicating the status of all 32 relay banks.</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,124,0</description>
        /// <description>Get Status of All Relays in All Banks</description>
        /// </item>
        /// </list>        
        /// </remarks>
        byte[] GetRelaysStatusInAllBanks();

        /// <summary>
        /// Get status of all relays in a given bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 1-32</param>
        /// <returns><para>0-255</para>The value indicats the status of all 8 relays.</returns>
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
        byte GetAllRelaysStatusInBank(byte bankId);
    }
    
    internal class CRelayBanks : NCDBase , IRelayBanks
    {

        public CRelayBanks(NCDController objNCD) : base(objNCD)
        {

        }

        /// <summary>
        /// Directs commands to a selected relay bank.  
        /// All subsequent commands will be sent to the selected relay bank.
        /// </summary>
        /// <param name="bankId">Bank number, 0 - 32</param>
        /// <remarks>
        /// <exception cref="ArgumentOutOfRangeException">Wrong arguments</exception>
        /// <returns> true for success</returns>
        /// A Bank Value of 0 applies this command to all relay banks.
        /// </remarks>
        bool IRelayBanks.SelectBank(byte bankId)
        {
            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            }
            //// 49,0-32 Direct Commands to bankId
            WriteBytes(254, 49, bankId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Turns off individual relays in the current selected bank.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Wrong arguments</exception>
        /// <returns> true for success</returns>
        /// <param name="relayId">Relay number, 0 - 7</param>
        bool IRelayBanks.TurnOffRelay(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should be from 0 to 7");
            }
            WriteBytes(254, relayId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn on individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IRelayBanks.TurnOnRelay(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should be from 0 to 7");
            }
            
            // 8-15 Turn On Individual Relays
            WriteBytes(254, (byte)(relayId + 8));
            return mNCD.GetAck();
        }

        /// <summary>
        /// Turns off individual relays in the given bank.
        /// </summary>
        /// <param name="relayId">Relay number, 0 - 7</param>
        /// <param name="bankId">Bank number, 0 - 32</param>
        /// <exception cref="ArgumentOutOfRangeException">Wrong arguments</exception>
        /// <returns> true for success</returns>
        /// <remarks>
        /// A Bank Value of 0 applies this command to all relay banks.
        /// </remarks>
        bool IRelayBanks.TurnOffRelayInBank(byte relayId, byte bankId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should be from 0 to 7");
            }

            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            }

            // 100-107, Bank Turn Off Individual Relays in Bank
            WriteBytes(254, (byte)(relayId + 100), bankId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Turns on individual relays in the given bank.
        /// </summary>
        /// <param name="relayId">Relay number, 0 - 7</param>
        /// <param name="bankId">Bank number, 0 - 32</param>
        /// <exception cref="ArgumentOutOfRangeException">Wrong arguments</exception>
        /// <remarks>
        /// A Bank Value of 0 applies this command to all relay banks.
        /// </remarks>
        bool IRelayBanks.TurnOnRelayInBank(byte relayId, byte bankId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should be from 0 to 7");
            }

            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            }
            //// 108-115 Turn On Individual Relays in Bank
            WriteBytes(254, (byte)(relayId + 108), bankId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Get status of an individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <returns>ON or OFF</returns>        
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>CURRENT SELECTED Bank Number OF 0 IS INVALID FOR THIS COMMAND.RETURNED RESULTS MAY BE UNPREDICTABLE.</remarks>
        RelayStatus IRelayBanks.GetStatus(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should be from 0 to 7");
            }
            //// 16-23 Get the status of an Individual Relay
            WriteBytes(254, (byte)(relayId + 16));

            int n = ReadByte2();
            if (n == -1 )
            {
                throw new TimeoutException();
            }
            return (RelayStatus)n;
        }


        /// <summary>
        /// Gets the status of an individual relay in the given bank.
        /// </summary>
        /// <param name="relayId">Relay number, 0 - 7</param>
        /// <param name="bankId">Bank number, 0 - 32</param>
        /// <exception cref="ArgumentException">Wrong arguments</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <returns>ON or OFF</returns>
        /// <remarks>
        /// A BANK VALUE OF 0 IS INVALID FOR THIS COMMAND.RETURNED RESULTS MAY BE UNPREDICTABLE.
        /// </remarks>
        RelayStatus IRelayBanks.GetStatusInBank(byte relayId, byte bankId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should be from 0 to 7");
            }

            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            }

            //// 116-123, Bank Get the status of an Individual Relay in Bank
            WriteBytes(254, (byte)(116 + relayId), bankId);
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (RelayStatus)n;
        }

        /// <summary>
        /// Turns on auto relayId refresh .
        /// </summary>
        /// <remarks>
        /// Meaning every time you send a relay control command, the relays will respond to your commands.
        /// </remarks>
        /// <returns> true for success</returns>
        bool IRelayBanks.TurnOnAutoRelayRefresh()
        {
            // 25 Turn On Automatic Relay Refreshing
            WriteBytes(254, 25);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Turns off auto relay refresh. 
        /// </summary>
        /// <remarks>
        /// Turning off relay refreshing allows you to control when the relays actually switch. 
        /// When refreshing is turned off, you can send relay control commands to the ProXR controller,
        /// and the controller will work just like normal, but the relays will never change state.
        /// </remarks>
        /// <returns> true for success</returns>
        bool IRelayBanks.TurnOffAutoRelayRefresh()
        {
            // 26 Turn Off Automatic Relay Refreshing
            WriteBytes(254, 26);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Stores relay refreshing mode
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.StoreRefreshSettings()
        {
            // 35 Store Relay Refreshing Mode
            WriteBytes(254, 35);

            return mNCD.GetAck();
        }


        /// <summary>
        /// Reads the stored refresh settings.
        /// </summary>
        /// <returns>ON or OFF</returns>
        AutoRefreshSetting IRelayBanks.ReportStoredRefreshSettings()
        {
            // 36 Report Back Stored Refresh Settings
            WriteBytes(254, 36);
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (AutoRefreshSetting)n;
        }

        /// <summary>
        /// Manually refresh relay bank.
        /// <para>Set status of all relays at one time.</para>
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.ManuallyRefresh()
        {
            // 37 Manually Refresh Relay Bank
            WriteBytes(254, 37);

            return mNCD.GetAck();
        }
         
        /// <summary>
        /// Turn all relays on.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.TurnOnAllRelays()
        {
            // 30 Turn All Relays On
            WriteBytes(254, 30);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn all relays on in a given bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns>  
        bool IRelayBanks.TurnOnAllRelaysInBank(byte bankId)
        {
            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            }

            // 130, Bank Turn All Relays On in Bank
            WriteBytes(254, 130, bankId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn off all relays in current selected bank.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.TurnOffAllRelays()
        {
            EnterCommand();
            // 29 Turn All Relays Off
            WriteByte(29);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn all relays off in a given bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns> 
        bool IRelayBanks.TurnOffAllRelaysInBank(byte bankId)
        {
            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            }

            // 129 Bank, Turn All Relays Off in Bank
            WriteBytes(254, 129, bankId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Invert status of all relays.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.InvertAllRelays()
        {
            // 31 Invert All Relays
            WriteBytes(254, 31);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Invert status of all relays in a given bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.InvertAllRelaysInBank(byte bankId)
        {
            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            }
            // 131 Bank, Invert All Relays in Bank
            WriteBytes(254, 131, bankId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Reverse pattern of relays in current selected bank.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.ReverseAllRelays()
        {
            // 32 Reverse All Relays
            WriteBytes(254, 32);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Reverse pattern of relays in a given bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.ReverseAllRelaysInBank(byte bankId)
        {
            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            } 
            // 132, Bank Reverse All Relays in Bank
            WriteBytes(254, 132, bankId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Tests 2-Way communications between PC and the relay controller.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.Test2Ways()
        {
            // 33 Test 2-Way Communications with Controller
            WriteBytes(254, 33);

            int n = ReadByte2();

            return n == 85 || n == 86;
        }

        /// <summary>
        /// Report back the selected relay bank number.
        /// </summary>
        /// <returns>0-32<para>0 indicates all banks.</para></returns> 
        byte IRelayBanks.GetSelectedBank()
        {
            // 34 Report to User the Selected Relay Bank
            WriteBytes(254, 34);

            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;
        }

        /// <summary>
        /// Set status of all relays directly in current selected bank. 
        /// </summary>
        /// <param name="status">8-bit status of relays: 0-255
        /// <para>A value of 0 turns off all the relays. A value of 255 turns on all the relays. 
        /// Other values set the status of the relays in the equivalent binary pattern of the RelayData parameter value.</para></param>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.SetRelayStatus(byte status)
        {
            // 40, RelayData Set the status of Relays
            WriteBytes(254, 40, status);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Set status of all relays at one time in a given bank.
        /// </summary>
        /// <param name="status">8-bit status of relays: 0-255</param>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.SetRelayStatusInBank(byte status, byte bankId)
        {
            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            }
            //// 140, Set Status of All Relays at One Time
            WriteBytes(254, 140, status, bankId);

            return mNCD.GetAck();
        }


        /// <summary>
        /// Store status of relays in current selected bank into memory. 
        /// </summary>
        /// <returns><para>True for success</para></returns>   
        bool IRelayBanks.StorePowerUpSatus()
        {
            // 42 Store Power Up Default status  $$$
            WriteBytes(254, 42);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Store status of relays in a given bank into memory. 
        /// </summary>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.StorePowerUpSatusInBank(byte bankId)
        {
            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            }

            // 142, Bank Store Power Up Default status in Bank
            WriteBytes(254, 142, bankId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Read the stored power-up default status of relays in current selected bank.
        /// </summary>
        /// <returns>Array that holds the status of current selected bank.</returns>
        /// <remarks>
        /// Returns null if fail to read from COM port. The array contains one item if not all banks are selected.
        /// </remarks>
        byte[] IRelayBanks.ReadPowerUpDefaultStatus()
        {
            long SelectedBank;
            SelectedBank = ((IRelayBanks)this).GetSelectedBank();

            // 43 Read Power Up Default status
            WriteBytes(254, 43);

            if (SelectedBank != 0)
            {
                byte[] status = new byte[1];
                int n = ReadByte2();
                if (n == -1)
                {
                    throw new TimeoutException();
                }
                status[0] = (byte)n;
                return status;
            }
            else
            {
                byte m;
                byte[] status = new byte[32];
                for (m = 0; m < 32; m++)
                {
                    int n = ReadByte2();
                    if (n == -1)
                    {
                        throw new TimeoutException();
                    }
                    status[m] = (byte)n;
                }
                return status;
            }
        }

        /// <summary>
        /// Read stored power-up default status of relays in a given bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 0-32</param>
        /// <returns>Array that holds the status of current given bank.</returns>
        byte[] IRelayBanks.ReadPowerUpDefaultStatusInBank(byte bankId)
        {
            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            }

            // 143, Bank Read Power Up Default status in Bank
            WriteBytes(254, 143, bankId);

            if (bankId != 0)
            {
                byte[] status = new byte[1];
                int n = ReadByte2();
                if (n == -1)
                {
                    throw new TimeoutException();
                }
                status[0] = (byte)n;
                return status;
            }
            else
            {
                byte m;
                byte[] status = new byte[32];
                for (m = 0; m < 32; m++)
                {
                    int n = ReadByte2();
                    if (n == -1)
                    {
                        throw new TimeoutException();
                    }
                    status[m] = (byte)n;
                }
                return status;
            }
        }

        /// Turn on one relay only, safe break before make.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-255</param>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.TurnOnOneRelayOnly(byte relayId)
        {
            // 46 Relay(0-255) Turn On One Relay ONLY, Safe Break Before Make
            WriteBytes(254, 46, relayId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn off a relay specified by its relay number.
        /// </summary>
        /// <param name="relayId">Relay Number: 0 - 255 </param>
        /// <returns> true for success</returns>
        bool IRelayBanks.TurnOffRelayAdvanced(byte relayId)
        {
            // 47 Relay(0-255) Turn Off a Relay Specified by its Relay Number 85
            WriteBytes(254, 47, relayId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn on a relay specified by its relay number.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-255</param>
        /// <returns><para>True for success</para></returns>
        bool IRelayBanks.TurnOnRelayAdvanced(byte relayId)
        {
            // 48 Relay(0-255) Turn On a Relay Specified by its Relay Number
            WriteBytes(254, 48, relayId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Get status of all relays in current selected bank.
        /// </summary>
        byte[] IRelayBanks.GetAllStatus()
        {
            long SelectedBank;
            long n;

            SelectedBank = ((IRelayBanks)this).GetSelectedBank();

            // 24 Get the status of All Relays
            WriteBytes(254, 24);

            if (SelectedBank == -1)
            {
                return null;
            }

            if (SelectedBank == 0)
            {
                byte[] status = new byte[32];
                for (n = 0; n < 32; n++)
                {
                    status[n] = (byte)ReadByte2();
                }
                return status;
            }
            else
            {
                byte[] status = new byte[1];
                status[0] = (byte)ReadByte2();
                return status;
            }
        }

        /// <summary>
        /// Gets the status of all relays in the given bank.
        /// </summary>
        /// <param name="bankId">Bank number, 1 - 32</param>
        /// <returns>byte that holds the status of current selected bank</returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte IRelayBanks.GetAllRelaysStatusInBank(byte bankId)
        {
            if (bankId == 0 || bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "Invalid bank id");
            }
            return _GetAllRelaysStatusInBank(bankId)[0];
        }

        /// <summary>
        /// Gets the status of all relays in the given bank.
        /// </summary>
        /// <returns>Array that holds the status of current selected bank</returns>
        /// <remarks>
        /// The array contains one item if not all banks are selected.
        /// A Bank Number of 0 gets the status of all relays in all 32 banks.
        /// </remarks>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte[] IRelayBanks.GetRelaysStatusInAllBanks()
        {
            return _GetAllRelaysStatusInBank(0);
        }



        /// <summary>
        /// Gets the status of all relays in the given bank.
        /// </summary>
        /// <param name="bankId">Bank number, 0 - 32</param>
        /// <returns>Array that holds the status of current selected bank</returns>
        /// <remarks>
        /// Returns null if fail to read from COM port. The array contains one item if not all banks are selected.
        /// A Bank Number of 0 gets the status of all relays in all 32 banks.
        /// </remarks>
        byte[] _GetAllRelaysStatusInBank(byte bankId)
        {
            if (bankId > 32)
            {
                throw new ArgumentOutOfRangeException("Bank ID", bankId, "The value should be from 0 to 32");
            }

            long n;
            // 124, Bank Get the status of All Relays in Bank
            WriteBytes(254, 124, bankId);

            if (bankId == 0)
            {
                byte[] status = new byte[32];
                for (n = 0; n < 32; n++)
                {
                    status[n] = (byte)ReadByte2();
                }
                return status;
            }
            else
            {
                byte[] status = new byte[1];
                status[0] = (byte)ReadByte2();
                return status;
            }
        }
    }
}
