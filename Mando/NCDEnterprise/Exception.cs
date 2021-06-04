using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{

    /// <summary>
    /// Exception for Checksum Error
    /// </summary>
    public class ChecksumException : Exception
    {
        /// <summary>
        /// Construct
        /// </summary>
        public ChecksumException ()
        {

        }

        /// <summary>
        /// Construct
        /// </summary>
        /// <param name="message"></param>
        public ChecksumException (string message)
            : base(message)
        {
        }

        /// <summary>
        /// Construct
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public ChecksumException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
