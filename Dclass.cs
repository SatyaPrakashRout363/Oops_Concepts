namespace Oops_Concepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Dclass for Encapsulation.
    /// </summary>
    internal class Dclass
    {
        /// <summary>
        /// defined the int type number.
        /// </summary>
        private int number;

        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        public int Value
        {
            get { return this.number; }
            set { this.number = value; }
        }

        /// <summary>
        /// Gets and display only the negative number.
        /// </summary>
        public void DisplaytheNegativeNumber()
        {
            if (this.Value < 0)
            {
                Console.WriteLine("Negative Number" + this.Value.ToString());
            }
            else
            {
                Console.WriteLine("Its a Positive Number");
            }
        }
    }
}
