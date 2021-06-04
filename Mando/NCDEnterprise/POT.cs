using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// Potentiometer Object Interface
    /// </summary>
    public interface IPotentiometer
    {
        /// <summary>
        /// Set wiper position of the selected potentiometer to a selected value.
        /// </summary>
        /// <param name="value">value of pot: 0-255</param>
        /// <param name="pot">id of pot: 0-255</param>
        /// <returns>True for success</returns>
        bool SetPotValue(byte pot, byte value);

        /// <summary>
        /// Set wiper position of all potentiometers to a selected value.
        /// </summary>
        /// <param name="value">0-255</param>
        /// <returns>True for success</returns>
        bool SetAllPotsValue(byte value);
        
        /// <summary>
        /// Store a powerup default wiper position for the selected potentiometer.
        /// </summary>
        /// <param name="value">value for start up: 0-255</param>
        /// <param name="pot">id of pot: 0-47</param>
        /// <returns>True for success</returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool SetStartupValue(byte pot, byte value);
        
        /// <summary>
        /// Read value indicating the default power up wiper position.
        /// </summary>
        /// <param name="pot">id of pot: 0-47</param>
        /// <returns>value of startup</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        byte ReadStartupValue(byte pot);

    }

    internal class Potentiometer : NCDBase, IPotentiometer
    {
        public Potentiometer(NCDController objNCD)
            : base(objNCD)
        {
        }
        /// <summary>
        /// This methodes set the wiper position of the selected potentiometer to a selected value
        /// </summary>
        /// <param name="value">value of pot, 0 - 255</param>
        /// <param name="pot">id of pot, 0 - 255</param>
        /// <returns>true for success</returns>
        bool IPotentiometer.SetPotValue(byte pot, byte value)
        {
            WriteBytes(254, 170, pot, value);

            return mNCD.GetAck();
        }

        /// <summary>
        /// Set All wiper position of all potentiometers to a selected value
        /// </summary>
        /// <param name="value">0 - 255</param>
        /// <returns>true for success</returns>
        bool IPotentiometer.SetAllPotsValue(byte value)
        {
            WriteBytes(254, 171, value);

            return mNCD.GetAck();
        }
        
        /// <summary>
        /// Stores a powerup default wiper position for the selected potentiometer
        /// </summary>
        /// <param name="value">value for start up 0 - 255</param>
        /// <param name="pot">id of pot, 0 - 47</param>
        /// <returns>true for success</returns>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        bool IPotentiometer.SetStartupValue(byte pot, byte value)
        {
            if(pot > 47)
            {
                throw new ArgumentOutOfRangeException("Pot ID", pot, "Pot ID should be range from 0 to 47");
            }
            WriteBytes(254, 172, pot, value);

            return mNCD.GetAck();

        }

        
        /// <summary>
        /// Read value indicating the default power up wiper position
        /// </summary>
        /// <param name="pot">id of pot, 0 - 47</param>
        /// <returns>value of startup</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ArgumentException">Wrong Argument</exception>
        byte IPotentiometer.ReadStartupValue(byte pot)
        {
            if(pot > 47)
            {
                throw new ArgumentOutOfRangeException("Pot ID", pot, "Pot ID should be range from 0 to 47");
            }
            WriteBytes(254, 173, pot);

            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;
            
        }        
    }
}
