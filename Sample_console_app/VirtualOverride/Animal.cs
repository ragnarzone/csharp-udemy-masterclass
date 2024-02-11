using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_console_app.VirtualOverride
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        // constructor
        public Animal(string name, int age) {
            Name = name; 
            Age = age;
            IsHungry = true;
        }

        // an empty virtual method MakeSound for other classes to override
        public virtual void MakeSound()
        {

        }

        // a virtual method called Eat which sub classes can override
        public virtual void Eat()
        {
            // check if animal is hungry
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        // virtual method play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
