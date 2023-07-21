namespace Oops_Concepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Define Normal class.
    /// </summary>
    public class Aclass
    {
        /// <summary>
        /// Used the Logic of Interface,Abstract class and method, Inheritance.
        /// </summary>
        public void AbstractInterfaceInheritance()
        {
            Cclass cclass = new Cclass();

            ////Implemented Extension Method.
            cclass.Bmethod();

            //// Implemented Array concepts and dictionary collection.
            cclass.Amethod();

            ////Implemented Reflection in between Getassemblyfilename method.
            cclass.Getassemblyfilename();

            //// Implemented List collection logic.
            cclass.Displaylistsortingorder();
        }

        /// <summary>
        /// Used the Encapsulation Logic.
        /// </summary>
        public void Encapsulation()
        {
            Dclass dclass = new Dclass();
            dclass.Value = 3;
            dclass.DisplaytheNegativeNumber();
        }

        /// <summary>
        /// Used Overloading concepts including Constructor and static method.
        /// </summary>
        public void Overloading()
        {
            Eclass eclass = new Eclass(123);
            Eclass eclass1 = new Eclass("QA");

            eclass.Overmethod(false);
            eclass.Overmethod(363);

            Eclass.Staticmethod('Q');
            Eclass.Staticmethod("QA");
        }

        /// <summary>
        /// Used Overriding and method hiding concept.
        /// </summary>
        public void Overriding()
        {
            Gclass gclass = new Gclass();
            gclass.Overriding();
            gclass.Overriding2();
        }

        /// <summary>
        /// UserDefined Exception,try,catch block uses.
        /// </summary>
        public void UserDefinedExceptionHandling()
        {
            int[] a = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i <= a.Length; i++)
                {
                   int b = a[i];
                }
            }
            catch (Exception)
            {
                throw new HException("Index is not matching please revisit the array count");
            }
        }

        /// <summary>
        /// UserDefined Exception,try,catch and finally block uses.
        /// </summary>
        public void ExceptionHandling()
        {
            int[] a = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i <= a.Length; i++)
                {
                    int b = a[i];
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
            finally
            {
                Console.WriteLine("Finally Block Execution");
            }
        }

        /// <summary>
        /// Implemented the LamdaExpression and Predicate concepts.
        /// </summary>
        public void LamdaexpressionUses()
        {
            Iclass cls = new Iclass() { StudentId = 89, StudentDescription = "RBASPA", StudentName = "ABC" };
            Iclass cls1 = new Iclass() { StudentId = 45, StudentDescription = "VFINE", StudentName = "Def" };
            Iclass cls2 = new Iclass() { StudentId = 109, StudentDescription = "Zxsd", StudentName = "Zsx" };

            List<Iclass> list = new List<Iclass>();
            list.Add(cls1);
            list.Add(cls2);
            list.Add(cls);

            list.OrderByDescending(x => x.StudentDescription).OrderBy(x => x.StudentId);

            Predicate<string> value = new Predicate<string>(Iclass.Stringlength);
            bool status = value.Invoke("QA Automation");
            Console.WriteLine(status);
        }

    }
}
