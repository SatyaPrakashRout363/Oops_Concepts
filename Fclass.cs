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
    internal class Fclass
    {
        /// <summary>
        /// Overriding method.
        /// </summary>
        public virtual void Overriding()
        {
            Console.WriteLine("Parent class");
        }

        /// <summary>
        /// Method hiding.
        /// </summary>
        public void Overriding2()
        {
            Console.WriteLine("Parent hiding");
        }
    }
}
