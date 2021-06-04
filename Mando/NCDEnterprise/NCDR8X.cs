using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// R4xPro/R8xPro Object interface
    /// </summary>
    public interface IR8XPro
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
        /// Store current status of relays as power-up default in current selected bank.
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
        /// <description>Store Relay Pattern as Power-Up Default</description>
        /// </item>
        /// </list>
        /// <para>This command allows you to define the on/off status of all relays when 
        /// power is first applied to the board.</para>
        /// </remarks>
        bool StorePowerUpSatus();

        /// <summary>
        /// Get the stored power-up default status of relays in current selected bank.
        /// </summary>
        /// <returns><para>0-255 for R8x Pro</para>
        /// <para>0-15 for R4x Pro</para>
        /// <para>The binary pattern of the value returned directly corresponds to the on/off status of each relay.</para></returns>        
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,26</description>
        /// <description>Get the Power-Up Default Relay Pattern</description>
        /// </item>
        /// </list>
        /// </remarks>
        byte ReadPowerUpDefaultStatus();

        /// <summary>
        /// Turn on reporting mode.
        /// </summary>
        /// <returns><para>True for success</para></returns>        
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,27</description>
        /// <description>Turn Reporting Mode ON</description>
        /// </item>
        /// </list>        
        /// <para>Reporting mode, by default, is ON. That means every time a command is sent to the controller, 
        /// the controller will send code 85 back to the computer, indicating that the command has finished executing 
        /// your instructions.</para> We recommend leaving it on, but doing so requires 2-Way communication with the controller. 
        /// You should turn it off if you intend to use 1-Way communication only. 
        /// A delay between some commands may be required when using 1-Way communications. 
        /// For optimum reliability, leave reporting mode on and use 2-Way communications with the IProXR Series controllers.
        /// </remarks>
        bool TurnOnReportMode();

        /// <summary>
        /// Turn off reporting mode.
        /// </summary>
        /// <returns><para>True for success</para></returns>        
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,28</description>
        /// <description>Turn Reporting Mode OFF</description>
        /// </item>
        /// </list>        
        /// <para>Reporting mode, by default, is ON. That means every time a command is sent to the controller, 
        /// the controller will send code 85 back to the computer, indicating that the command has finished executing 
        /// your instructions.</para> We recommend leaving it on, but doing so requires 2-Way communication with the controller. 
        /// You should turn it off if you intend to use 1-Way communication only. 
        /// A delay between some commands may be required when using 1-Way communications. 
        /// For optimum reliability, leave reporting mode on and use 2-Way communications with the IProXR Series controllers.
        /// </remarks>
        bool TurnOffReportMode();


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
        /// <description>Turn All Relays ON</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool TurnOnAllRelays();

        /// <summary>
        /// Turn all relays off.
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
        /// <description>Turn All Relays OFF</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool TurnOffAllRelays();


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
        /// <para>All relays that are currently off turn on, all relays that were on turn off.</para>
        /// </remarks>
        bool InvertAllRelays();

        /// <summary>
        /// Reverse status of relays 12345678 to 87654321.
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
        /// <description>Reverse Relay Order</description>
        /// </item>
        /// </list>
        /// <para>This command does not permanently reassign relays, it only copies the status of the relays when executed.</para>
        /// </remarks>
        bool ReverseAllRelays();

        /// <summary>
        /// Tests 2-Way communication between PC and relay controller.
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
        /// <description>Test 2-Way Communication</description>
        /// </item>
        /// </list>
        /// <para>This command should be used for initial installations if 2-way communication is required. 
        /// It can also be used to detect the presence of a relay controller on the serial port.</para>
        /// </remarks>         
        bool Test2Ways();


        /// <summary>
        /// Set status of all relays at one time. 
        /// </summary>
        /// <param name="status"><para>0-15 for R4x Pro</para>
        /// <para>0-255 for R8x Pro</para></param>
        /// <returns><para>True for success</para></returns>  
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,40,0-15</description>
        /// <description>Set Status of All Relays (R4x Pro)</description>
        /// </item>
        /// <item>
        /// <description>254,40,0-255</description>
        /// <description>Set Status of All Relays (R8x Pro)</description>
        /// </item>
        /// </list>
        /// This allows you to easily set status of all relays at one time. 
        /// Status is a parameter value from 0-255. A value of 0 turns off all the relays. A value of 255 turns on all the relays. 
        /// Other values set the status of the relays in the equivalent binary pattern of the relayData parameter value.
        /// </remarks>
        bool SetRelayStatus(byte status);

        /// <summary>
        /// Program Emulation Device Number
        /// </summary>
        /// <param name="deviceNum">0-15</param>
        /// <returns><para>True for success</para></returns>  
        /// <exception cref="ArgumentException">Wrong Augument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,41,0-15</description>
        /// <description>Program Emulation Device Number</description>
        /// </item>
        /// </list>
        /// When the R4x/R8x Pro is NOT in emulation mode, this command can
        /// be used, along with its parameter of 0-15, to define the device number
        /// for use in emulation mode. Once programmed, you must remove
        /// power from the board and set the board to Emulation mode.
        /// </remarks>
        bool ProgramEmulationDeviceNumber(byte deviceNum);


        /// <summary>
        /// Store current pattern of all relays into memory bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 0-15</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>        
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,42,0-15</description>
        /// <description>Store Relay Pattern in Memory Bank</description>
        /// </item>
        /// </list>
        /// This command stores the current on/off setting of  all relays into a memory bank (0-15). 
        /// This command is useful for creating macros or for making sure certain relays are never activated simultaneously.
        /// </remarks>
        bool StoreRelayPatternInMemoryBank(byte bankId);


        /// <summary>
        /// Recall stored relay pattern from selected memory bank. 
        /// </summary>
        /// <param name="bankId">Bank Number: 0-15</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>        
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,43,0-15</description>
        /// <description>Recall Relay Pattern from Memory Bank</description>
        /// </item>
        /// </list>
        /// This command recalls a stored relay pattern from the user selected memory bank (0-15) 
        /// and update all relays on the board to the settings defined by command "254,42,0-15".
        /// </remarks>  
        bool RecallRelayPatternFromMemoryBank(byte bankId);

        /// <summary>
        /// Turn off all relays and then turn on the selected relay only. 
        /// </summary>
        /// <param name="relayId">Relay Number: 0-3 for R4x Pro, 0-7 for R8x Pro</param>
        /// <returns><para>True for success</para></returns>  
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,44,0-3</description>
        /// <description>Select a Relay for Activation (R4x Pro)</description>
        /// </item>
        /// <item>
        /// <description>254,44,0-7</description>
        /// <description>Select a Relay for Activation (R8x Pro)</description>
        /// </item>        
        /// </list>
        /// The command performs a safe "Break Before Make", ensuring that no two relays are ever activated at the same time.
        /// </remarks>
        bool SelectRelay(byte relayId);

        /// <summary>
        /// Turn on all relays and turn off the selected relay only.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-3 for R4x Pro, 0-7 for R8x Pro</param>
        /// <returns><para>True for success</para></returns>  
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,45,0-3</description>
        /// <description>Select a Relay for De-Activation (R4x Pro)</description>
        /// </item>
        /// <item>
        /// <description>254,45,0-7</description>
        /// <description>Select a Relay for De-Activation (R8x Pro)</description>
        /// </item>        
        /// </list>
        /// The command performs a safe "Break Before Make", ensuring that no two relays are ever activated at the same time.
        /// </remarks>
        bool DeselectRelay(byte relayId);

        /// <summary>
        /// Reverse current on/off status of the selected relay.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-3 for R4x Pro, 0-7 for R8x Pro</param>
        /// <returns><para>True for success</para></returns> 
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,46,0-3</description>
        /// <description>Toggle Status of the selected Relay (R4x Pro)</description>
        /// </item>
        /// <item>
        /// <description>254,46,0-7</description>
        /// <description>Toggle Status of the selected Relay (R8x Pro)</description>
        /// </item>        
        /// </list>
        /// This command reverses the current on/off status of the selected relay.
        /// </remarks>        
        bool ToggleRelay(byte relayId);
        
        /// <summary>
        /// Activate a relay for a user-defined period of time.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <param name="time"><para>Duration to turn on relay: 0-63</para> <para>Duration Interval: 0=(10 milliseconds x Duration) + 10 milliseconds</para>
        /// <para>To use the different modes of the timer, simply add together the values 
        /// for each parameter. Feed the total into the TIME variable above. Then select the relay to apply the timer to.</para></param>
        /// <param name="feedBack"><para>Flag for Feedback: True or False</para><para>Ture for turning on Feedback, False for turning off Feedback</para></param>
        /// <returns><para>True or False.</para>
        /// <para>Always return True if parameter feedback is False. If parameter feedback is True, return True for getting correct feedback.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,47,Time(0-255), Relay(0-3)</description>
        /// <description>Set Relay Timer (R4x Pro)</description>
        /// </item>
        /// <item>
        /// <description>254,47,Time(0-255), Relay(0-7)</description>
        /// <description>Set Relay Timer (R8x Pro)</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool SetRelayTimerInMilliSeconds(byte relayId, byte time, bool feedBack);

        /// <summary>
        /// Activate a relay for a user-defined period of time.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <param name="time"><para>Duration to turn on relay: 0-63</para> <para>Duration Interval: 64=(.5 seconds x Duration) + .5 seconds</para>
        /// <para>To use the different modes of the timer, simply add together the values 
        /// for each parameter. Feed the total into the TIME variable above. Then select the relay to apply the timer to.</para></param>
        /// <param name="feedBack"><para>Flag for Feedback: True or False</para><para>Ture for turning on Feedback, False for turning off Feedback</para></param>
        /// <returns><para>True or False.</para>
        /// <para>Always return True if parameter feedback is False. If parameter feedback is True, return True for getting correct feedback.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,47,Time(0-255), Relay(0-3)</description>
        /// <description>Set Relay Timer (R4x Pro)</description>
        /// </item>
        /// <item>
        /// <description>254,47,Time(0-255), Relay(0-7)</description>
        /// <description>Set Relay Timer (R8x Pro)</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool SetRelayTimerInSeconds(byte relayId, byte time, bool feedBack);

        /// <summary>
        /// Set the status of relays, apply a timer, set all relays to a new state once the timer has completed.
        /// </summary>
        /// <param name="startStatus">It indicats the status when timer start.<para>0-15(R4x Pro)</para><para>0-255(R8x Pro)</para></param>
        /// <param name="stopStatus">It indicats the status when timer stop.<para>0-15(R4x Pro)</para><para>0-255(R8x Pro)</para></param>
        /// <param name="time"><para>Duration to turn on relay: 0-63</para> <para>Duration Interval: 0=(10 milliseconds x Duration) + 10 milliseconds</para>
        /// <para>To use the different modes of the timer, simply add together the values 
        /// for each parameter. Feed the total into the TIME variable above. Then select the relay to apply the timer to.</para></param>
        /// <param name="feedBack"><para>Flag for Feedback: True or False</para><para>Ture for turning on Feedback, False for turning off Feedback</para></param>
        /// <returns><para>True or False.</para>
        /// <para>Always return True if parameter feedback is False. If parameter feedback is True, return True for getting correct feedback.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,48,Time(0-255), RPOn(0-15), RPOff(0-15)</description>
        /// <description>Relay Pattern Select on a Timer (R4x Pro)</description>
        /// </item>
        /// <item>
        /// <description>254,48,Time(0-255), RPOn(0-255), RPOff(0-255)</description>
        /// <description>Relay Pattern Select on a Timer (R8x Pro)</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool SetMultiRelayTimerInMilliSeconds(byte startStatus, byte stopStatus, byte time, bool feedBack);

        /// <summary>
        /// Set the status of relays, apply a timer, set all relays to a new state once the timer has completed.
        /// </summary>
        /// <param name="startStatus">It indicats the status when timer start.<para>0-15(R4x Pro)</para><para>0-255(R8x Pro)</para></param>
        /// <param name="stopStatus">It indicats the status when timer stop.<para>0-15(R4x Pro)</para><para>0-255(R8x Pro)</para></param>
        /// <param name="time"><para>Duration to turn on relay: 0-63</para> <para>Duration Interval: 64=(.5 seconds x Duration) + .5 seconds</para>
        /// <para>To use the different modes of the timer, simply add together the values 
        /// for each parameter. Feed the total into the TIME variable above. Then select the relay to apply the timer to.</para></param>
        /// <param name="feedBack"><para>Flag for Feedback: True or False</para><para>Ture for turning on Feedback, False for turning off Feedback</para></param>
        /// <returns><para>True or False.</para>
        /// <para>Always return True if parameter feedback is False. If parameter feedback is True, return True for getting correct feedback.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,48,Time(0-255), RPOn(0-15), RPOff(0-15)</description>
        /// <description>Relay Pattern Select on a Timer (R4x Pro)</description>
        /// </item>
        /// <item>
        /// <description>254,48,Time(0-255), RPOn(0-255), RPOff(0-255)</description>
        /// <description>Relay Pattern Select on a Timer (R8x Pro)</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool SetMultiRelayTimerInSeconds(byte startStatus, byte stopStatus, byte time, bool feedBack);
    }

    internal class R8XPro : NCDBase, IR8XPro
    {
        public R8XPro(NCDController objNCD)
            : base(objNCD)
        {

        }

        /// <summary>
        /// Turn off individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0-7</param>
        /// <returns><para>True or False</para>
        /// <para>True for turn off relay successfully.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IR8XPro.TurnOffRelay(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 7");
            }
            EnterCommand();
            WriteByte(relayId);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn on individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay number: 0-7</param>
        /// <returns><para>True or False</para>
        /// <para>True for turn on relay successfully.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IR8XPro.TurnOnRelay(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 7");
            }
            EnterCommand();
            WriteByte((byte)(relayId + 8));
            return mNCD.GetAck();
        }

        /// <summary>
        /// Get status of individual relay in current selected bank.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <returns><para>ON or OFF</para></returns>
        RelayStatus IR8XPro.GetStatus(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 7");
            }
            EnterCommand();
            WriteByte((byte)(relayId + 16));
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (RelayStatus)n;
        }

        /// <summary>
        /// Get status of all relays at one time in current selected bank.
        /// </summary>
        /// <returns><para>0-255 for R8x Pro</para>
        /// <para>0-15 for R4x Pro</para>
        /// <para>The binary pattern of the value returned directly corresponds to the on/off status of each relay.</para></returns>        
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte IR8XPro.GetStatusOfAllRelays()
        {
            EnterCommand();
            WriteByte(24);
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;
        }

        /// <summary>
        /// Store status of relays as power-up default in current selected bank.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IR8XPro.StorePowerUpSatus()
        {
            EnterCommand();
            WriteByte(25);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Get the stored power-up default status of relays in current selected bank.
        /// </summary>
        /// <returns><para>0-255 for R8x Pro</para>
        /// <para>0-15 for R4x Pro</para>
        /// <para>The binary pattern of the value returned directly corresponds to the on/off status of each relay.</para></returns>        
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte IR8XPro.ReadPowerUpDefaultStatus()
        {
            EnterCommand();
            WriteByte(26);
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;
        }

        /// <summary>
        /// Turn on reporting mode.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IR8XPro.TurnOnReportMode()
        {
            return mNCD.TurnOnReportMode();
        }

        /// <summary>
        /// Turn off reporting mode.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IR8XPro.TurnOffReportMode()
        {
            return mNCD.TurnOffReportMode();
        }


        /// <summary>
        /// Turn all relays on.
        /// </summary>
        /// <returns><para>True for success</para></returns> 
        bool IR8XPro.TurnOnAllRelays()
        {
            EnterCommand();
            WriteByte(30);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn all relays off.
        /// </summary>
        /// <returns><para>True for success</para></returns> 
        bool IR8XPro.TurnOffAllRelays()
        {
            EnterCommand();
            WriteByte(29);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Invert status of all relays.
        /// </summary>
        /// <returns><para>True for success</para></returns> 
        bool IR8XPro.InvertAllRelays()
        {
            EnterCommand();
            WriteByte(31);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Reverse relay order.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IR8XPro.ReverseAllRelays()
        {
            EnterCommand();
            WriteByte(32);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Tests 2-Ways communication between PC and relay controller.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool IR8XPro.Test2Ways()
        {
            return mNCD.Test2Ways();
        }


        /// <summary>
        /// Set status of all relays at one time. 
        /// </summary>
        /// <param name="status"><para>0-255 for R8x Pro</para>
        /// <para>0-15 for R4x Pro</para></param>
        /// <returns><para>True for success</para></returns>        
        /// <remarks>
        /// This allows you to easily set the status of 8 relays at one time. 
        /// Status is a parameter value from 0-255. A value of 0 turns off all the relays. A value of 255 turns on all the relays. 
        /// Other values set the status of the relays in the equivalent binary pattern of the relayData parameter value.
        /// </remarks>
        bool IR8XPro.SetRelayStatus(byte status)
        {
            EnterCommand();
            WriteByte(40);
            WriteByte(status);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Program Emulation Device Number
        /// </summary>
        /// <param name="deviceNum">0-15</param>
        /// <returns><para>True for success</para></returns>  
        /// <exception cref="ArgumentException">Wrong Augument</exception>
        bool IR8XPro.ProgramEmulationDeviceNumber(byte deviceNum)
        {
            if (deviceNum > 15)
            {
                throw new ArgumentOutOfRangeException("deviceNum", deviceNum, "The value should range from 0 to 15");
            }
            EnterCommand();
            WriteByte(41);
            WriteByte(deviceNum);
            return mNCD.GetAck();
        }


        /// <summary>
        /// Store current pattern of all relays into memory bank.
        /// </summary>
        /// <param name="bankId">Bank Number: 0-15</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IR8XPro.StoreRelayPatternInMemoryBank(byte bankId)
        {
            if (bankId > 15)
            {
                throw new ArgumentOutOfRangeException("bankId", bankId, "The value should range from 0 to 15");
            }
            EnterCommand();
            WriteByte(42);
            WriteByte(bankId);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Recall stored relay pattern from selected memory bank. 
        /// </summary>
        /// <param name="bankId">Bank Number: 0-15</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IR8XPro.RecallRelayPatternFromMemoryBank(byte bankId)
        {
            if (bankId > 15)
            {
                throw new ArgumentOutOfRangeException("bankId", bankId, "The value should range from 0 to 15");
            }
            EnterCommand();
            WriteByte(43);
            WriteByte(bankId);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn off all relays and then turns on the selected relay only. 
        /// </summary>
        /// <param name="relayId">Relay Number: 0-3 for R4x Pro, 0-7 for R8x Pro</param>
        /// <returns><para>True for success</para></returns>  
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IR8XPro.SelectRelay(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 7");
            }
            EnterCommand();
            WriteByte(44);
            WriteByte(relayId);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn on all relays and turn off the selected relay only.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-3 for R4x Pro, 0-7 for R8x Pro</param>
        /// <returns><para>True for success</para></returns>  
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IR8XPro.DeselectRelay(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 7");
            }
            EnterCommand();
            WriteByte(45);
            WriteByte(relayId);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Reverse current on/off status of the selected relay.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-3 for R4x Pro, 0-7 for R8x Pro</param>
        /// <returns><para>True for success</para></returns>
        bool IR8XPro.ToggleRelay(byte relayId)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 7");
            }
            EnterCommand();
            WriteByte(46);
            WriteByte(relayId);
            return mNCD.GetAck();
        }

        /// <summary>
        /// Activate a relay for a user-defined period of time.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <param name="time"><para>Duration to turn on relay: 0-63</para> <para>Duration Interval: 0=(10 milliseconds x Duration) + 10 milliseconds</para>
        /// <para>To use the different modes of the timer, simply add together the values 
        /// for each parameter. Feed the total into the TIME variable above. Then select the relay to apply the timer to.</para></param>
        /// <param name="feedBack"><para>Flag for Feedback:True or False</para><para>Ture for turning on Feedback, False for turning off Feedback</para></param>
        /// <returns><para>True or False.</para>
        /// <para>Always return True if parameter feedback is False. If parameter feedback is True, return True for getting correct feedback.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IR8XPro.SetRelayTimerInMilliSeconds(byte relayId, byte time, bool feedBack)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 7");
            }

            if (time > 63)
            {
                throw new ArgumentOutOfRangeException("Time", time, "The value should range from 0 to 63");
            }

            byte timeByte = GetTimeByteInMilliSeconds(time, feedBack);
            EnterCommand();
            WriteByte(47);
            WriteByte(timeByte);
            WriteByte(relayId);
            if (feedBack)
            {
                return mNCD.GetAck();
            }
            return true;
        }

        /// <summary>
        /// Activate a relay for a user-defined period of time.
        /// </summary>
        /// <param name="relayId">Relay Number: 0-7</param>
        /// <param name="time"><para>Duration to turn on relay: 0-63</para> <para>Duration Interval: 64=(.5 seconds x Duration) + .5 seconds</para>
        /// <para>To use the different modes of the timer, simply add together the values 
        /// for each parameter. Feed the total into the TIME variable above. Then select the relay to apply the timer to.</para></param>
        /// <param name="feedBack"><para>Flag for Feedback:True or False</para><para>Ture for turning on Feedback, False for turning off Feedback</para></param>
        /// <returns><para>True or False.</para>
        /// <para>Always return True if parameter feedback is False. If parameter feedback is True, return True for getting correct feedback.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IR8XPro.SetRelayTimerInSeconds(byte relayId, byte time, bool feedBack)
        {
            if (relayId > 7)
            {
                throw new ArgumentOutOfRangeException("Relay ID", relayId, "The value should range from 0 to 7");
            }

            if (time > 63)
            {
                throw new ArgumentOutOfRangeException("Time", time, "The value should range from 0 to 63");
            }

            byte timeByte =  GetTimeByteInSeconds(time, feedBack);
            EnterCommand();
            WriteByte(47);
            WriteByte(timeByte);
            WriteByte(relayId);
            if (feedBack)
            {
                return mNCD.GetAck();
            }
            return true;
        }

        /// <summary>
        /// Set the status of relays, apply a timer, set all relays to a new state once the timer has completed.
        /// </summary>
        /// <param name="startStatus">It indicats the status when timer start.<para>0-15(R4x Pro)</para><para>0-255(R8x Pro)</para></param>
        /// <param name="stopStatus">It indicats the status when timer stop.<para>0-15(R4x Pro)</para><para>0-255(R8x Pro)</para></param>
        /// <param name="time"><para>Duration to turn on relay: 0-63</para> <para>Duration Interval: 0=(10 milliseconds x Duration) + 10 milliseconds</para>
        /// <para>To use the different modes of the timer, simply add together the values 
        /// for each parameter. Feed the total into the TIME variable above. Then select the relay to apply the timer to.</para></param>
        /// <param name="feedBack"><para>Flag for Feedback:True or False</para><para>Ture for turning on Feedback, False for turning off Feedback</para></param>
        /// <returns><para>True or False.</para>
        /// <para>Always return True if parameter feedback is False. If parameter feedback is True, return True for getting correct feedback.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IR8XPro.SetMultiRelayTimerInMilliSeconds(byte startStatus, byte stopStatus, byte time, bool feedBack)
        {
            if (time > 63)
            {
                throw new ArgumentOutOfRangeException("Time", time, "The value should range from 0 to 63");
            }
            byte timeByte = GetTimeByteInMilliSeconds(time, feedBack);
            EnterCommand();
            WriteByte(48);
            WriteByte(timeByte);
            WriteByte(startStatus);
            WriteByte(stopStatus);
            if (feedBack)
            {
                return mNCD.GetAck();
            }
            return true;
 
        }

        /// <summary>
        /// Set the status of relays, apply a timer, set all relays to a new state once the timer has completed.
        /// </summary>
        /// <param name="startStatus">It indicats the status when timer start.<para>0-15(R4x Pro)</para><para>0-255(R8x Pro)</para></param>
        /// <param name="stopStatus">It indicats the status when timer stop.<para>0-15(R4x Pro)</para><para>0-255(R8x Pro)</para></param>
        /// <param name="time"><para>Duration to turn on relay: 0-63</para> <para>Duration Interval: 64=(.5 seconds x Duration) + .5 seconds</para>
        /// <para>To use the different modes of the timer, simply add together the values 
        /// for each parameter. Feed the total into the TIME variable above. Then select the relay to apply the timer to.</para></param>
        /// <param name="feedBack"><para>Flag for Feedback:True or False</para><para>Ture for turning on Feedback, False for turning off Feedback</para></param>
        /// <returns><para>True or False.</para>
        /// <para>Always return True if parameter feedback is False. If parameter feedback is True, return True for getting correct feedback.</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IR8XPro.SetMultiRelayTimerInSeconds(byte startStatus, byte stopStatus, byte time, bool feedBack)
        {
            if (time > 63)
            {
                throw new ArgumentOutOfRangeException("Time", time, "The value should range from 0 to 63");
            }
            byte timeByte = GetTimeByteInSeconds(time, feedBack);
            EnterCommand();
            WriteByte(48);
            WriteByte(timeByte);
            WriteByte(startStatus);
            WriteByte(stopStatus);
            if (feedBack)
            {
                return mNCD.GetAck();
            }
            return true;
        }

        byte GetTimeByteInMilliSeconds(byte value, bool feedBack)
        {
            byte b = (byte)(feedBack ? 128 : 0);
            return (byte)(value + b);

        }

        byte GetTimeByteInSeconds(byte value, bool feedBack)
        {
            byte b = (byte)(feedBack ? 128 : 0);
            return (byte)(value + 64 + b);
        }

    }
}
