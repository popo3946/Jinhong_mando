using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// Keypress object 
    /// </summary>
    public class KeyPress
    {
        /// <summary>
        /// E3C number
        /// </summary>
        public byte E3C;
        /// <summary>
        /// Key value
        /// </summary>
        public byte Key;
    }

    /// <summary>
    /// Keypad Object Interface
    /// </summary>
    public interface IKeypad
    {
        /// <summary>
        /// Get key press. 
        /// </summary>
        /// <returns>KeyPress object</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ChecksumException">Checksum Error</exception>
        KeyPress GetKeypress();

        /// <summary>
        /// Get the responding value of key.
        /// </summary>
        /// <param name="keyId">id of key: 0-16</param>
        /// <returns>KeyValue</returns>
        /// <remarks>It might support more key than 16 in future.</remarks>
        /// <exception cref="ArgumentException">Wrong arguement</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte GetKeyValue(byte keyId);
    }

    internal class Keypad : NCDBase, IKeypad
    {
        public Keypad(NCDController objNCD)
            : base(objNCD)
        {

        }

        /// <summary>
        /// Get Key press 
        /// </summary>
        /// <returns>KeyPress object</returns>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        /// <exception cref="ChecksumException">Checksum Error</exception>
        KeyPress IKeypad.GetKeypress()
        {
            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            if (n != 254)
            {
                throw new ChecksumException();
            }
            int e3c = ReadByte2();
            if (e3c == -1)
            {
                throw new TimeoutException();
            }
            int key = ReadByte2();
            if (key == -1)
            {
                throw new TimeoutException();
            }

            int checksum = ReadByte2();
            if (checksum == -1)
            {
                throw new TimeoutException();
            }
            if (checksum != ((n + e3c + key) & 255))
            {
                throw new ChecksumException();
            }
            KeyPress keyPress = new KeyPress();
            keyPress.E3C = (byte)e3c;
            keyPress.Key = (byte)key;
            return keyPress;
        }

        /// <summary>
        /// Get the responding value of key
        /// </summary>
        /// <param name="keyId">id of key, from 0 to 15</param>
        /// <returns>KeyValue</returns>
        /// <remarks>it might support more key than 16 in future</remarks>
        /// <exception cref="ArgumentException">Wrong arguement</exception>
        /// <exception cref="TimeoutException">Read Timeout</exception>
        byte IKeypad.GetKeyValue(byte keyId)
        {
            if (keyId > 15)
            {
                throw new ArgumentOutOfRangeException("Key Id", keyId, "The valid valud should range from 0 to 15");
            }

            mNCD.Purge();
            //mNCD.WriteByte(252);    // enter command mode, 252 for keypad
            //mNCD.WriteByte((byte)(keyId + 18));  // key id

            WriteBytes(252, (byte)(keyId + 18));

            int n = ReadByte2();
            if (n == -1)
            {
                throw new TimeoutException();
            }
            return (byte)n;
        }
    }
}
