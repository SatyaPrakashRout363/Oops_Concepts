namespace Oops_Concepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Sorinting class to implement Lambda Expressions.
    /// </summary>
    internal class Iclass
    {
        /// <summary>
        /// Gets or sets  the SyudentID.
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// Gets or sets the StudentName.
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// Define the SyudentID.
        /// </summary>
        public string StudentDescription { get; set; }

        /// <summary>
        /// Predicate concepts
        /// </summary>
        /// <param name="s">value.</param>
        /// <returns>boolean value.</returns>
        public static bool Stringlength(string s)
        {
            bool type = false;

            if (s.Length > 8)
            {
                type = true;
            }

            return type;
        }
    }
}
