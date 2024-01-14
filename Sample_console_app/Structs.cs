using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_console_app
{
    struct Game
    {
        // structs are value types not reference types as classes
        // cannot have a null reference, only if Nullable is used
        // structs do not support inheritance
        // can not create default constructors
        //public Game()
        //{

        //}

        public string name;
        public string developer;
        public string rating;
        public string releaseDate;

        public void Display()
        {
            Console.WriteLine(name);
            Console.WriteLine(developer);
            Console.WriteLine(rating);
            Console.WriteLine(releaseDate);
        }
    }
}
