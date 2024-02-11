using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_console_app.VirtualOverride
{
    public class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name, age) {
            IsHappy = true;
        }

        // here we override the virtual method Eat
        public override void Eat()
        {
            base.Eat(); // here call base classes method
        }

        // implement this method since it is not implemented in base class
        public override void MakeSound()
        {
            Console.WriteLine("Wuff!");
        }

        // check if the dog is happy if yes call the Play method from the base class
        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
