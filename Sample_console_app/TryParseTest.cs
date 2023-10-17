using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_console_app
{
    internal class TryParseTest
    {
        public void checkTryParse()
        {
            string numberAsString = "128";
            int parsedValue;

            bool success = int.TryParse(numberAsString, out parsedValue);

            if (success)
            {
                Console.WriteLine("Parsing successful - number is " + parsedValue);
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }
        }
    }
}
