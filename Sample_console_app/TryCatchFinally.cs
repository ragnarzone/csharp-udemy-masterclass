using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_console_app
{
    internal class TryCatchFinally
    {
        public void triggerTest()
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch(Exception)
            {
                Console.WriteLine("General exception");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            Console.ReadKey();
        }
    }
}
