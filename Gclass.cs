namespace Oops_Concepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Overriding Concepts.
    /// </summary>
    internal class Gclass : Fclass
    {
        /// <summary>
        /// Overriding method.
        /// </summary>
        public override void Overriding()
        {
            Console.WriteLine("Child class");
        }

        /// <summary>
        /// Method Hiding.
        /// </summary>
        public new void Overriding2()
        {
            Console.WriteLine("Child class");
        }
    }
}
