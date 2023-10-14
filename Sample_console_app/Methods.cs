using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_console_app
{
    internal class Methods
    {
        public string friend1 = "Frank";
        public string friend2 = "Michael";
        public string friend3 = "Wlad";

        public void greetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + " , my friend!");
        }

        public void triggerGreetFriend()
        {
            greetFriend(friend1);
            greetFriend(friend2);
            greetFriend(friend3);
        }

        public int calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;
            return result;
        }
    }
}
