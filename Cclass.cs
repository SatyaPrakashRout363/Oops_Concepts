namespace Oops_Concepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Cclass for inheritance.
    /// </summary>
    internal class Cclass : Bclass
    {
        /// <summary>
        /// Abstract method.
        /// </summary>
        /// <returns>return the list of string on sorting manner.</returns>
        public override List<string> Displaylistsortingorder()
        {
            List<string> result = new List<string>();
            result.Add("Abc");
            result.Add("Obc");
            result.Add("Cbc");
            result.Add("Dbc");
            result.Add("Lbc");
            result.Add("Fbc");
            result.Add("Gbc");
            result.Add("Hbc");
            result.Add("Ibc");
            result.Add("Zbc");
            result.Add("Rbc");
            result.Add("Pbc");
            result.Add("AGc");
            result.Add("Vbc");
            result.Sort();

            return result;
        }
    }
}
