using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// Represents the parameters of timer.
    /// </summary>
    public struct TimerParameters
    {
        /// <summary>
        /// Represents index of the timer, 0 - 15.
        /// </summary>
        public byte timerId;  

        /// <summary>
        /// Represents hours, 0 - 255.
        /// </summary>
        public long hours;   

        /// <summary>
        /// Represents minutes, 0 - 255.
        /// </summary>
        public long minutes; 

        /// <summary>
        /// Represents seconds, 0 - 255.
        /// </summary>
        public long seconds; 

        /// <summary>
        /// Represents Relay Number, 0 -255.
        /// </summary>
        public long relayId;  
    }

    /// <summary>
    /// Represents the timer interface.
    /// </summary>
    public interface ITimers
    {

        /// <summary>
        /// Sets simple duration timer, begins operation immediately.
        /// </summary>
        /// <param name="timerId">Timer Number: 0-15</param>
        /// <param name="hours">Hours: 0-255</param>
        /// <param name="minutes">Minutes: 0-255</param>
        /// <param name="seconds">Seconds: 0-255</param>
        /// <param name="relayId">Relay Number: 0-255</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,50,50+TimerNumber,Hours,Minutes,Seconds,RelayId</description>
        /// <description>Set Simple Duration Timer</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool SetDurationTimerImmediately(byte timerId, byte hours, byte minutes, byte seconds, byte relayId);

        /// <summary>
        /// Sets simple pulse timer, begins operation immediately.
        /// </summary>
        /// <param name="timerId">Timer Number: 0-15</param>
        /// <param name="hours">Hours: 0-255</param>
        /// <param name="minutes">Minutes: 0-255</param>
        /// <param name="seconds">Seconds: 0-255</param>
        /// <param name="relayId">Relay Number: 0-255</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,50,70+TimerNumber,Hours,Minutes,Seconds,RelayId</description>
        /// <description>Set Simple Pulse Timer</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool SetPulseTimerImmediately(byte timerId, byte hours, byte minutes, byte seconds, byte relayId);

        /// <summary>
        /// Sets duration timer, but does not begin operation until they are activated.
        /// </summary>
        /// <param name="timerId">Timer Number: 0-15</param>
        /// <param name="hours">Hours: 0-255</param>
        /// <param name="minutes">Minutes: 0-255</param>
        /// <param name="seconds">Seconds: 0-255</param>
        /// <param name="relayId">Relay Number: 0-255</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,50,90+TimerNumber,Hours,Minutes,Seconds,RelayId</description>
        /// <description>Set Duration Timer(need to be activated)</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool SetDurationTimer(byte timerId, byte hours, byte minutes, byte seconds, byte relayId);

        /// <summary>
        /// Sets pulse timer, but does not begin operation until they are activated.
        /// </summary>
        /// <param name="timerId">Timer Number: 0-15</param>
        /// <param name="hours">Hours: 0-255</param>
        /// <param name="minutes">Minutes: 0-255</param>
        /// <param name="seconds">Seconds: 0-255</param>
        /// <param name="relayId">Relay Number: 0-255</param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,50,110+TimerNumber,Hours,Minutes,Seconds,RelayId</description>
        /// <description>Set Pulse Timer(need to be activated)</description>
        /// </item>
        /// </list>
        /// </remarks>
        bool SetPulseTimer(byte timerId, byte hours, byte minutes, byte seconds, byte relayId);

        /// <summary>
        /// Activate timer. 
        /// </summary>
        /// <param name="lsb">Least Significant Byte: 0-255</param>
        /// <param name="msb">Most Significant Byte: 0-255</param>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,50,131,LSB,MSB</description>
        /// <description>Activate Timer</description>
        /// </item>
        /// </list>
        /// A binary 0 in any bit location indicates the timer is off 
        /// while a binary 1 in any bit location indicates the timer is on. 
        /// </remarks>
        bool ActivateTimers(byte lsb, byte msb);

        /// <summary>
        /// View current remain time for the selected timer.
        /// </summary>
        /// <param name="timerId">Timer Number: 0-15</param>
        /// <returns>Remain Time</returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,50,130,TimerNumber</description>
        /// <description>Query Selected Timer</description>
        /// </item>
        /// </list>
        /// </remarks>
        TimerParameters  TimerQuery(byte timerId);

        /// <summary>
        /// Sets the timer calibration value.
        /// </summary>
        /// <param name="calibrator">Calibration Value: 26576
        /// <para>Timing is generically recalibrated for 60 seconds using 8 timers. Our test controller calibration value was 26,576.
        /// In other words, a calibration value of 26,576 equals 1 second when the controller is only processing timing tasks.</para>
        /// <para>The calibration value was established on our prototype and may be off by as much as 3% based on individual resonator,
        /// processor, and temperature characteristics. Baud rate was set at 115.2K when this number was established. 
        /// The calibration value may need to be changed for other baud rates, but 115.2K baud is the best choice for calibration.</para></param>
        /// <returns><para>True for success</para></returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,50,132,LSB,MSB</description>
        /// <description>Set the Timer Calibration Value</description>
        /// </item>
        /// </list>
        /// <para>Calibrator = 26576</para>
        /// <para>LSB = (Calibrator And 255)</para>
        /// <para>MSB = (Calibrator And 65280) / 256</para>
        /// </remarks> 
        bool SetTimerCalibration(int calibrator);

        /// <summary>
        /// Reads the timer calibration value.
        /// </summary>
        /// <returns>Calibration Value</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,50,133</description>
        /// <description>Read the Timer Calibration Value</description>
        /// </item>
        /// </list>
        /// <para>This command returns two bytes of data. </para>
        /// <para>The first byte contains the Timer Calibrator LSB value.</para>
        /// <para>The second byte contains the Timer Calibrator MSB value.</para>
        /// <para>Calibrator = (LSB + (MSB * 256))</para>
        /// </remarks>
        int ReadTimerCalibration();
        
        /// <summary>
        /// Activates time calibrator markers.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,50,134</description>
        /// <description>Activate Calibrator Makers</description>
        /// </item>
        /// </list>
        /// Time calibrator markers are used to help calibrate the timer.
        /// </remarks>        
        bool ActivateCalibratorMarker();

        /// <summary>
        /// Deactivates time calibrator markers.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,50,135</description>
        /// <description>Deactivate Calibrator Markers</description>
        /// </item>
        /// </list> 
        /// Time calibrator markers are used to help calibrate the timer.
        /// </remarks>     
        bool DeactivateCalibratorMarker();
    }

    internal class CTimers : NCDBase , ITimers 
    {
        public CTimers(NCDController objNCD) : base(objNCD)
        {

        }

        /// <summary>
        /// Sets simple duration timer, begins operation immediately.
        /// </summary>
        /// <param name="timerId">Timer Number: 0-15</param>
        /// <param name="hours">Hours: 0-255</param>
        /// <param name="minutes">Minutes: 0-255</param>
        /// <param name="seconds">Seconds: 0-255</param>
        /// <param name="relayId">Relay Number: 0-255</param>
        /// <returns><para>True for success</para></returns>
        bool ITimers.SetDurationTimerImmediately(byte timerId, byte hours, byte minutes, byte seconds, byte relayId)
        {
            if (timerId > 15)
            {
                throw new ArgumentOutOfRangeException("Timer ID", timerId, "The value should be from 0 to 15");
            }

            WriteBytes(254, 50, (byte)(timerId + 50), hours, minutes, seconds, relayId); 

            return mNCD.GetAck();
        }

        /// <summary>
        /// Sets simple pulse timer, begins operation immediately.
        /// </summary>
        /// <param name="timerId">Timer Number: 0-15</param>
        /// <param name="hours">Hours: 0-255</param>
        /// <param name="minutes">Minutes: 0-255</param>
        /// <param name="seconds">Seconds: 0-255</param>
        /// <param name="relayId">Relay Number: 0-255</param>
        /// <returns><para>True for success</para></returns>
        bool ITimers.SetPulseTimerImmediately(byte timerId, byte hours, byte minutes, byte seconds, byte relayId)
        {
            if (timerId > 15)
            {
                throw new ArgumentOutOfRangeException("Timer ID", timerId, "The value should be from 0 to 15");
            }

            WriteBytes(254, 50, (byte)(timerId + 70), hours, minutes, seconds, relayId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Sets duration timer, but does not begin operation until they are activated.
        /// </summary>
        /// <param name="timerId">Timer Number: 0-15</param>
        /// <param name="hours">Hours: 0-255</param>
        /// <param name="minutes">Minutes: 0-255</param>
        /// <param name="seconds">Seconds: 0-255</param>
        /// <param name="relayId">Relay Number: 0-255</param>
        /// <returns><para>True for success</para></returns>
        bool ITimers.SetDurationTimer(byte timerId, byte hours, byte minutes, byte seconds, byte relayId)
        {
            if (timerId > 15)
            {
                throw new ArgumentOutOfRangeException("Timer ID", timerId, "The value should be from 0 to 15");
            }
            WriteBytes(254, 50, (byte)(timerId + 90), hours, minutes, seconds, relayId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Sets simple pulse timer, but does not begin operation until they are activated.
        /// </summary>
        /// <param name="timerId">Timer Number: 0-15</param>
        /// <param name="hours">Hours: 0-255</param>
        /// <param name="minutes">Minutes: 0-255</param>
        /// <param name="seconds">Seconds: 0-255</param>
        /// <param name="relayId">Relay Number: 0-255</param>
        /// <returns><para>True for success</para></returns>
        bool ITimers.SetPulseTimer(byte timerId, byte hours, byte minutes, byte seconds, byte relayId)
        {
            if (timerId > 15)
            {
                throw new ArgumentOutOfRangeException("Timer ID", timerId, "The value should be from 0 to 15");
            }

            WriteBytes(254, 50, (byte)(timerId + 110), hours, minutes, seconds, relayId);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Activate timer. 
        /// </summary>
        /// <param name="lsb">Least Significant Byte: 0-256</param>
        /// <param name="msb">Most Significant Byte: 0-256</param>
        /// <returns><para>True for success</para></returns>         
        /// <remarks>
        /// A binary 0 in any bit location indicates the timer is off 
        /// while a binary 1 in any bit location indicates the timer is on. 
        /// </remarks>
        bool ITimers.ActivateTimers(byte LSB, byte MSB)
        {
            WriteBytes(254, 50, 131, LSB, MSB);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Allows to see how much time remains before the timer expires.
        /// </summary>
        /// <param name="timerId">Timer number, 0 - 15</param>
        /// <returns>Return remain time.</returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        TimerParameters ITimers.TimerQuery(byte timerId)
        {
            TimerParameters parameters;
            parameters.timerId = timerId;
            WriteBytes(254, 50, 130, timerId);

            parameters.hours=ReadByte2();
            parameters.minutes = ReadByte2();
            parameters.seconds = ReadByte2();
            parameters.relayId = ReadByte2();
            if (parameters.hours < 0 || parameters.minutes < 0 || parameters.seconds < 0)
            {
                throw new TimeoutException();
            }
            return parameters;
        }

        /// <summary>
        /// Sets the timer calibration value.
        /// </summary>
        /// <param name="calibrator">Calibration Value:</param>
        /// <returns><para>True for success</para></returns>
        bool ITimers.SetTimerCalibration(int calibrator)
        {
            byte lsb;
            byte msb;
            lsb= (byte)(calibrator & 255);
            msb = (byte)((calibrator & 62580) / 256);
            WriteBytes(254, 50, 132, lsb, msb);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Reads the timer calibration value.
        /// </summary>
        /// <returns>Calibration Value.</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        int ITimers.ReadTimerCalibration()
        {
            byte LSB;
            byte MSB;
            WriteBytes(254, 50, 133);

            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }

            LSB = (byte)n;
            n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            MSB = (byte)n;

            return (int)(LSB + MSB * 256);
        }

        /// <summary>
        /// Activates time calibrator markers.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool ITimers.ActivateCalibratorMarker()
        {
            WriteBytes(254, 50, 134);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Deactivates time calibrator markers.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        bool ITimers.DeactivateCalibratorMarker()
        {
            WriteBytes(254, 50, 135);

            return mNCD.GetAck();
        }
    }
}