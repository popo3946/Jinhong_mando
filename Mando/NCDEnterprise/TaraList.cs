using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// Interface for TaraList controller
    /// </summary>
    public interface ITaraList
    {
        /// <summary>
        /// Synchoronize the time with PC's time
        /// </summary>
        /// <returns>true for success, false for failure, the function will fail in "run" mode</returns>
        bool SyncTimeWithPcTime();

        /// <summary>
        /// Set the time manually
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool SetTimeManually(DateTime t);

        /// <summary>
        /// Get current time from the device
        /// </summary>
        /// <returns>Time of the device, return DateTime.MinValue if failed</returns>
        DateTime GetTime();


        /// <summary>
        /// reboot the device
        /// </summary>
        void Reboot();

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
        RelayStatus GetRelayStatusInBank(byte relayId, byte bankId);

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
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte GetAllRelaysStatusInBank(byte bankId);

        /// <summary>
        /// Switch to computer control
        /// </summary>
        /// <param name="relayId">Relay ID, 0 - 7</param>
        /// <param name="bankId">Bank Number: 0 - 32</param>
        /// <returns>true for success</returns>
        bool SwitchToComputerControl(byte relayId, byte bankId);

        /// <summary>
        /// Switch to device control
        /// </summary>
        /// <param name="relayId">Relay ID, 0 - 7</param>
        /// <param name="bankId">Bank Number: 0 - 32</param>
        /// <returns>true for success</returns>
        bool SwitchToDeviceControl(byte relayId, byte bankId);

        /// <summary>
        /// Switch all relays in specific bank to computer control
        /// </summary>
        /// <param name="bankId">bank id, 0 - 32, 0 for all banks</param>
        /// <returns>true for success</returns>
        bool SwitchAllRelaysToComputerControl(byte bankId);

        /// <summary>
        /// Switch all Relays to Device Control
        /// </summary>
        /// <param name="bankId">bank id, 0 -32, 0 for all banks,</param>
        /// <returns>true for success, </returns>
        bool SwitchAllRelaysToDeviceControl(byte bankId);

        /// <summary>
        /// Query if the computer controls
        /// </summary>
        /// <param name="relayId">relay id, 0 - 7</param>
        /// <param name="bankId">Bank Number: 1 - 32</param>
        /// <returns>true for computer controls</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        bool IsComputerControls(byte relayId, byte bankId);

        /// <summary>
        /// Query if the device controls
        /// </summary>
        /// <param name="relayId">relay id, 0 - 7</param>
        /// <param name="bankId">Bank Number: 1 - 32</param>
        /// <returns>true for devcie controls</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        bool IsDeviceControls(byte relayId, byte bankId);

        /// <summary>
        /// Query who has the controls for each relays in specific bank
        /// </summary>
        /// <param name="bankId">Bank Number: 1 - 32</param>
        /// <returns>byte for 8 relays' status, each bit represents a relay, bit0 for first relay, bit value of 1 means control by computer, 0 for computer</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte GetAllRelaysControlsStatusInBank(byte bankId);

    }


    internal class TaraList : NCDBase, ITaraList 
    {
        public TaraList(NCDController objNCD)
            : base(objNCD)
        {
        }
        
        /// <summary>
        /// sync the time of the chip with the time of the pc
        /// </summary>
        /// <returns>true for success, the function will failure if it is in run mode</returns>
        bool ITaraList.SyncTimeWithPcTime()
        {
            DateTime now = DateTime.Now.AddSeconds(1);  // always add 1 seconds as there is a delay when settig
            return SetTime(now.AddSeconds(1));
        }


        DateTime ITaraList.GetTime()
        {
            DateTime t = DateTime.MinValue;
            try
            {
                mNCD.Purge();
                mNCD.WriteBytesWithSleep(1, 65, 99);
                int hours = 0;
                int minutes = 0;
                int seconds = 0;
                int day = 0;
                int month = 0;
                int year = 0;

                bool b = true;
                while (b)
                {
                    b = false;
                    int dataRead = mNCD.ReadByte();
                    if (dataRead != -1)
                    {
                        seconds = HelpFunctions.ConvertFromBCD((byte)dataRead);
                    }
                    else
                    {
                        break;
                    }

                    dataRead = mNCD.ReadByte();
                    if (dataRead != -1)
                    {
                        minutes = HelpFunctions.ConvertFromBCD((byte)dataRead);
                    }
                    else
                    {
                        break;
                    }

                    dataRead = mNCD.ReadByte();
                    if (dataRead != -1)
                    {
                        hours = HelpFunctions.ConvertFromBCD((byte)dataRead);
                    }
                    else
                    {
                        break;
                    }

                    dataRead = mNCD.ReadByte();
                    if (dataRead != -1)
                    {
                        day = HelpFunctions.ConvertFromBCD((byte)dataRead);
                    }
                    else
                    {
                        break;
                    }

                    dataRead = mNCD.ReadByte();
                    if (dataRead != -1)
                    {
                        month = HelpFunctions.ConvertFromBCD((byte)dataRead);
                    }
                    else
                    {
                        break;
                    }

                    dataRead = mNCD.ReadByte();
                    if (dataRead != -1)
                    {
                        //day of the week
                    }
                    else
                    {
                        break;
                    }

                    dataRead = mNCD.ReadByte();
                    if (dataRead != -1)
                    {
                        year = HelpFunctions.ConvertFromBCD((byte)dataRead) + 2000;
                    }
                    else
                    {
                        break;
                    }

                    dataRead = mNCD.ReadByte();
                    if (dataRead != -1)
                    {
                        int checksum = HelpFunctions.ConvertFromBCD((byte)dataRead);
                    }
                    else
                    {
                        break;
                    }


                    t = new DateTime(year, month, day, hours, minutes, seconds);

                }



            }
            catch
            {

            }

            return t;
        }

        void ITaraList.Reboot()
        {
            mNCD.WriteBytesWithSleep(1, 64, 246);
        }

        private bool SetTime(DateTime t)
        {
            if (mNCD.Test2Ways2() != 86)    // not in config mode
            {
                return false;
            }

            DateTime now = t;  // always add 1 seconds as there is a delay when settig

            int checksum = 0;
            byte _sec = HelpFunctions.ConvertToBCD((byte)now.Second);
            checksum += _sec;

            byte _minute = HelpFunctions.ConvertToBCD((byte)now.Minute);
            checksum += _minute;

            byte _hour = HelpFunctions.ConvertToBCD((byte)now.Hour);
            checksum += _hour;

            byte _dayOfMonth = HelpFunctions.ConvertToBCD((byte)now.Day);
            checksum += _dayOfMonth;

            byte _month = HelpFunctions.ConvertToBCD((byte)now.Month);
            checksum += _month;

            byte _dayOfWeek = HelpFunctions.ConvertToBCD((byte)now.DayOfWeek);
            checksum += _dayOfWeek;

            byte _year = HelpFunctions.ConvertToBCD((byte)(now.Year - 2000));
            checksum += _year;

            checksum = checksum % 0x100;
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(1, 65, 100, _sec, _minute, _hour, _dayOfMonth, _month, _dayOfWeek, _year, (byte)checksum);
            System.Threading.Thread.Sleep(500);
            if (ReadByte2() == 85)
            {
                return true;
            }
            return false;

        }

        bool ITaraList.SetTimeManually(DateTime t)
        {
            return SetTime(t);
        }

        bool ITaraList.TurnOnRelayInBank(byte relayId, byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 254, (byte)(108 + relayId), bankId);
            int v = mNCD.ReadByte();
            return v == 85;
        }

        bool ITaraList.TurnOffRelayInBank(byte relayId, byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 254, (byte)(100 + relayId), bankId);
            int v = mNCD.ReadByte();
            return v == 85;
        }

        bool ITaraList.TurnOnAllRelaysInBank(byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 254, 130, bankId);
            if (!mNCD.UsingComPort)
            {
                mNCD.Sleep(1000);   //  this command take longer time in network mode
            }
            int v = mNCD.ReadByte();
            return v == 85;
        }

        bool ITaraList.TurnOffAllRelaysInBank(byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 254, 129, bankId);
            if (!mNCD.UsingComPort)
            {
                mNCD.Sleep(1000);   //  this command take longer time in network mode
            }
            int v = mNCD.ReadByte();
            return v == 85;
        }

        RelayStatus ITaraList.GetRelayStatusInBank(byte relayId, byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 254, (byte)(116 + relayId), bankId);
            mNCD.Sleep(10);
            int isOn = mNCD.ReadByte();
            if (isOn > 0)
            {
                return RelayStatus.ON;
            }
            else if (isOn == 0)
            {
                return RelayStatus.OFF;
            }
            throw new TimeoutException();
        }

        byte ITaraList.GetAllRelaysStatusInBank(byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 254, 124, bankId);
            int status = mNCD.ReadByte();
            if (status != -1)
            {
                return (byte)status;
            }
            throw new TimeoutException();
        }

        bool ITaraList.SwitchToComputerControl(byte relayId, byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 64, (byte)(108 + relayId), bankId);
            int v = mNCD.ReadByte();
            return v == 85;
        }

        bool ITaraList.SwitchToDeviceControl(byte relayId, byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 64, (byte)(100 + relayId), bankId);
            int v = mNCD.ReadByte();
            return v == 85;
        }

        bool ITaraList.SwitchAllRelaysToComputerControl(byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 64, 130, bankId);
            if(!mNCD.UsingComPort)
            {
                mNCD.Sleep(1000);
            }
            int v = mNCD.ReadByte();
            return v == 85;
        }

        bool ITaraList.SwitchAllRelaysToDeviceControl(byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 64, 129, bankId);
            if (!mNCD.UsingComPort)
            {
                mNCD.Sleep(1000);
            }
            int v = mNCD.ReadByte();
            return v == 85;
        }

        bool ITaraList.IsComputerControls(byte relayId, byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 64, (byte)(116 + relayId), bankId);
            int isOn = mNCD.ReadByte();
            if (isOn > 0)
            {
                return true;
            }
            else if (isOn == 0)
            {
                return false;
            }
            throw new TimeoutException();
        }

        bool ITaraList.IsDeviceControls(byte relayId, byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 64, (byte)(116 + relayId), bankId);
            int isOn = mNCD.ReadByte();
            if (isOn > 0)
            {
                return false;
            }
            else if (isOn == 0)
            {
                return true;
            }
            throw new TimeoutException();
        }

        byte ITaraList.GetAllRelaysControlsStatusInBank(byte bankId)
        {
            mNCD.Purge();
            mNCD.WriteBytesWithSleep(2, 64, 124, bankId);
            int status = mNCD.ReadByte();
            if (status > -1)
            {
                return (byte)status;
            }
            throw new TimeoutException();
        }

    }
}
