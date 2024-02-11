using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_console_app
{
    // delegate is a type that can hold a reference to a method
    internal class DelegatesAndEvents
    {
        public static void Driver()
        {
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };
            Console.WriteLine("---Before---");
            foreach(string name in names) Console.WriteLine(name);

            names.RemoveAll(Filter);

            Console.WriteLine("---After---");
            foreach (string name in names) Console.WriteLine(name);
        }

        // a method to filter names List
        private static bool Filter(string s)
        {
            // return true if name contains letter 'i'
            return s.Contains("i");
        }

    }
}
