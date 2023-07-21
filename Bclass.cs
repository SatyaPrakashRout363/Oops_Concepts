namespace Oops_Concepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Abstract Class Implements the Interface.
    /// </summary>
    internal abstract class Bclass : Interface1
    {
        /// <summary>
        /// Amethod including Array and dictionary collection concept.
        /// </summary>
        public void Amethod()
        {
            string value = "Automation QA";

            char[] ch = value.ToCharArray();
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i <= ch.Length - 1; i++)
            {
                if (dic.ContainsKey(ch[i]))
                {
                    dic[ch[i]]++;
                }
                else
                {
                    dic.Add(ch[i], 1);
                }
            }

            foreach (KeyValuePair<char, int> item in dic)
            {
                Console.WriteLine("Keys: " + item.Key + "Value: " + item.Value);
            }
        }

        /// <summary>
        /// Bmethod.
        /// </summary>
        public void Bmethod()
        {
            string value = "QA Testing";
            value.Exmethod();
        }

        /// <summary>
        /// get the assembly file name by using reflection concept.
        /// </summary>
        /// <returns>get the filename.</returns>
        public string Getassemblyfilename()
        {
           Assembly assemblies = Assembly.GetExecutingAssembly();
           string name = assemblies.GetName().FullName;
           return name;
        }

        /// <summary>
        /// Abstract method.
        /// </summary>
        /// <returns>return the list of string on sorting manner.</returns>
        public abstract List<string> Displaylistsortingorder();
    }
}
