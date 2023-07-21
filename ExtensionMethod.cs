namespace Oops_Concepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// ExtensionMethod class.
    /// </summary>
    internal static class ExtensionMethod
    {
        /// <summary>
        /// Extension Methods.
        /// </summary>
        /// <param name="value">value.</param>
        public static void Exmethod(this string value)
        {
            Console.WriteLine("The Defined Value using extension methods is:"+ value);
        }
    }
}
