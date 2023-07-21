namespace Oops_Concepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// User Defined Exceptions.
    /// </summary>
    internal class HException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HException"/> class.
        /// </summary>
        /// <param name="message">messgae.</param>
        public HException(string message)
            : base(message)
        {
        }
    }
}
