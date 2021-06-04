using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise.ProXR
{
    /// <summary>
    /// Defines the interface of Advance Configuration.
    /// </summary>
    public interface IAdvanceConfiguration
    {
        /// <summary>
        /// Sets the repetition value of sending command to the controller. 
        /// </summary>
        /// <param name="repsValue">Repetition value , 1 - 255.</param>
        /// <remarks>
        /// The repetition value controls how many times relay status data is sent to the Relay control chips.
        /// Normally, the value is 1. But if you experience relays that turn themselves off when activated, 
        /// try changing the Reps value to any number from 2 to 255 and see what happens. 
        /// It takes more than a second to process each relay control command when the value is set to 255.
        /// </remarks>
        void SetRepetitionsValue(byte repsValue);

        /// <summary>
        /// Reads the repetition value of sending command to the controller. 
        /// </summary>
        /// <returns>-1: Failed,1 - 255: Repetition value.</returns>
        long GetRepetitionsValue();

        /// <summary>
        /// Sets all key variables inside the controller to Safe Parameters. 
        /// </summary>
        /// <remarks>
        /// If for some reason, the controller does not seem be functioning properly, 
        /// or it appears you have lost communication, 
        /// try sending this command and see if it recovers.
        /// </remarks>
        void RecoverSafeParameter();

        /// <summary>
        /// Sets the character delay value. 
        /// </summary>
        /// <remarks>
        /// The Character Delay value determines the spacing between data bytes sent from 
        /// the controller back to your PC. By default, delayValue is set to 35, 
        /// which is known to be a conservatively safe value. 
        /// The minimum allows delayValue value is 3 (we have not seen a PC that can handle this setting). 
        /// If you want to boost performance, set the delayValue lower. 
        /// A value of 7-10 should provide greatly improved communication speed.
        /// </remarks>
        /// <param name="delayValue">Character delay value, 3 - 255.</param>
        void SetCharacterDelay(byte delayValue);

        /// <summary>
        /// Reads the stored character delay value from the controller.
        /// </summary>
        /// <returns>-1: Failed,3 - 255: Character delay value.</returns>
        long ReadCharacterDelay();

        /// <summary>
        /// Sets the attached banks value. 
        /// </summary>
        /// <param name="bankValue">Attached banks value£¬1-32.</param>
        /// <remarks>
        /// The ProXR series controllers are shipped as though the customer has 256 relays attached. 
        /// This allows the controller to be instantly compatible with several XR expansion boards, right out of the box. 
        /// However, you can gain a performance increase by setting the attached banks value to the actual 
        /// number of relays you are using.
        /// </remarks>
        void SetAttachedBanks(byte bankValue);

        /// <summary>
        /// Reads the attached banks value. 
        /// </summary>
        /// <returns>-1: Failed,1-32 : Attached banks value</returns>
        /// <remarks>
        /// This command reports back a value from 1 to 32, indicating how many relays are attached to the relayId controller.
        /// </remarks>
        long ReadAttachedBanks();

        /// <summary>
        /// Sets the test cycle bank value.
        /// </summary>
        /// <param name="bankValue">Number of banks to be tested, 0-32</param>
        /// <remarks>
        /// When the ProXR series controllers are powered up in Configuration mode (all dip switches in the off position), 
        /// the first instruction the controller processes is a function that tests all the on board relays. 
        /// By default, the ProXR controller will test 4 banks of relays, 
        /// which is the maximum number of relays that we currently product on a single circuit board. 
        /// If you have a controller with fewer relays, you can use this function to speed up the test cycle by 
        /// setting the controller to the actual number of relay banks on your ProXR controller.
        /// </remarks>
        void SetTestCycle(byte bankValue);

        /// <summary>
        /// Reads the test cycle bank value.
        /// </summary>
        /// <returns>-1: Failed,0 - 32: number of banks to be tested</returns>
        /// <remarks>
        /// This command reports back a value from 0 to 32, indicating how many relays are tested 
        /// when the controller is powered up in configuration mode (all dip switches in the off position).
        /// </remarks>
        long ReadTestCycle();

        /// <summary>
        /// Restores internal parameters to the factory default settings.
        /// </summary>
        /// <remarks>
        /// This command operates in configuration mode only (all dip switches in the off position). 
        /// </remarks>
        void RestoreFactorySettings();
    }


    internal class CAdvanceConfiguration : NCDBase , IAdvanceConfiguration
    {
        public CAdvanceConfiguration(NCDController objNCD) : base(objNCD)
        {

        }

        /// <summary>
        /// Sets the repetition value of sending command to the controller. 
        /// </summary>
        /// <param name="repsValue">Repetition value , 1 - 255.</param>
        /// <remarks>
        /// The repetition value controls how many times relay status data is sent to the Relay control chips.
        /// Normally, the value is 1. But if you experience relays that turn themselves off when activated, 
        /// try changing the Reps value to any number from 2 to 255 and see what happens. 
        /// It takes more than a second to process each relay control command when the value is set to 255.
        /// </remarks>
        void IAdvanceConfiguration.SetRepetitionsValue(byte repsValue)
        {
            //EnterCommand();
            //WriteByte(50);
            //// 137 Set the Reps Value
            //WriteByte(137);
            //WriteByte(repsValue);

            WriteBytes(254, 50, 137, repsValue);

        }

        /// <summary>
        /// Reads the repetition value of sending command to the controller. 
        /// </summary>
        /// <returns>-1: Failed,1 - 255: Repetition value.</returns>
        long IAdvanceConfiguration.GetRepetitionsValue()
        {
            //EnterCommand();
            //WriteByte(50);
            //// 136 Read the Reps Value
            //WriteByte(136);

            WriteBytes(254, 50, 136);

            return ReadByte2();
        }

        /// <summary>
        /// Sets all key variables inside the controller to Safe Parameters. 
        /// </summary>
        /// <remarks>
        /// If for some reason, the controller does not seem be functioning properly, 
        /// or it appears you have lost communication, 
        /// try sending this command and see if it recovers.
        /// </remarks>
        void IAdvanceConfiguration.RecoverSafeParameter()
        {
            //EnterCommand();
            //WriteByte(50);
            //// 147 Recovery Attempt to Safe Parameters
            //WriteByte(147);

            WriteBytes(254, 50, 147);

        }

        /// <summary>
        /// Sets the character delay value. 
        /// </summary>
        /// <remarks>
        /// The Character Delay value determines the spacing between data bytes sent from 
        /// the controller back to your PC. By default, delayValue is set to 35, 
        /// which is known to be a conservatively safe value. 
        /// The minimum allows delayValue value is 3 (we have not seen a PC that can handle this setting). 
        /// If you want to boost performance, set the delayValue lower. 
        /// A value of 7-10 should provide greatly improved communication speed.
        /// </remarks>
        /// <param name="delayValue">Character delay value, 3 - 255.</param>
        void IAdvanceConfiguration.SetCharacterDelay(byte delayValue)
        {
            //EnterCommand();
            //WriteByte(50);
            //// 139,delayValue Setting the Character Delay Value
            //WriteByte(139);
            //WriteByte(delayValue);

            WriteBytes(254, 50, 139, delayValue);

        }

        /// <summary>
        /// Reads the stored character delay value from the controller.
        /// </summary>
        /// <returns>-1: Failed,3 - 255: Character delay value.</returns>
        long IAdvanceConfiguration.ReadCharacterDelay()
        {
            //EnterCommand();
            //WriteByte(50);
            //// Reading the Character Delay Value
            //WriteByte(138);

            WriteBytes(254, 50, 138);

            return ReadByte2();
        }

        /// <summary>
        /// Sets the attached banks value. 
        /// </summary>
        /// <param name="bankValue">Attached banks value£¬1-32.</param>
        /// <remarks>
        /// The ProXR series controllers are shipped as though the customer has 256 relays attached. 
        /// This allows the controller to be instantly compatible with several XR expansion boards, right out of the box. 
        /// However, you can gain a performance increase by setting the attached banks value to the actual 
        /// number of relays you are using.
        /// </remarks>
        void IAdvanceConfiguration.SetAttachedBanks(byte bankValue)
        {
            //EnterCommand();
            //WriteByte(50);
            //// 141 Setting the Attached Banks Value
            //WriteByte(141);
            //WriteByte(bankValue);

            WriteBytes(254, 50, 141, bankValue);

        }

        /// <summary>
        /// Reads the attached banks value. 
        /// </summary>
        /// <returns>-1: Failed,1-32 : Attached banks value</returns>
        /// <remarks>
        /// This command reports back a value from 1 to 32, indicating how many relays are attached to the relayId controller.
        /// </remarks>
        long IAdvanceConfiguration.ReadAttachedBanks()
        {
            //EnterCommand();
            //WriteByte(50);
            //// 140 Reading the Attached Banks Value
            //WriteByte(140);

            WriteBytes(254, 50, 140);

            return ReadByte2();
        }

        /// <summary>
        /// Sets the test cycle bank value.
        /// </summary>
        /// <param name="bankValue">Number of banks to be tested, 0-32</param>
        /// <remarks>
        /// When the ProXR series controllers are powered up in Configuration mode (all dip switches in the off position), 
        /// the first instruction the controller processes is a function that tests all the on board relays. 
        /// By default, the ProXR controller will test 4 banks of relays, 
        /// which is the maximum number of relays that we currently product on a single circuit board. 
        /// If you have a controller with fewer relays, you can use this function to speed up the test cycle by 
        /// setting the controller to the actual number of relay banks on your ProXR controller.
        /// </remarks>
        void IAdvanceConfiguration.SetTestCycle(byte bankValue)
        {
            //EnterCommand();
            //WriteByte(50);
            //// 146 Setting the Test Cycle Value
            //WriteByte(146);
            //WriteByte(bankValue);

            WriteBytes(254, 50, 146, bankValue);

        }

        /// <summary>
        /// Reads the test cycle bank value.
        /// </summary>
        /// <returns>-1: Failed,0 - 32: number of banks to be tested</returns>
        /// <remarks>
        /// This command reports back a value from 0 to 32, indicating how many relays are tested 
        /// when the controller is powered up in configuration mode (all dip switches in the off position).
        /// </remarks>
        long IAdvanceConfiguration.ReadTestCycle()
        {
            //EnterCommand();
            //WriteByte(50);
            //// 145 Reading the Test Cycle Value
            //WriteByte(145);

            WriteBytes(254, 50, 145);

            return ReadByte2();
        }

        /// <summary>
        /// Restores internal parameters to the factory default settings.
        /// </summary>
        /// <remarks>
        /// This command operates in configuration mode only (all dip switches in the off position). 
        /// </remarks>
        void IAdvanceConfiguration.RestoreFactorySettings()
        {
            //EnterCommand();
            //WriteByte(50);
            //// 144 Restoring Factory Default Settings
            //WriteByte(144);

            WriteBytes(254, 50, 144);
        }

    }
}
