namespace Sample_console_app
{
    internal class StringsManipulation
    {
        public void manipulateString0()
        {
            string name;
            Console.WriteLine("Please enter your name and press enter : ");
            name = Console.ReadLine();
            string myNameUpperCase = String.Format("Upper case : {0}", name.ToUpper());
            Console.WriteLine(myNameUpperCase);
        }

        public void manipulateString1()
        {
            Console.Write("Enter the string here: ");
            // read first input string
            string input = Console.ReadLine();

            Console.Write("Enter a character to search: ");
            // read the character input to search
            char searchInput = Console.ReadLine()[0];

            // get the index of the character from the string
            int searchIndex = input.IndexOf(searchInput);

            // print the index as a search result on the console
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);
        }

        public void manipulateString2()
        {
            Console.Write("Enter first name: ");
            // read the first name
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            // rad the last name
            string lastName = Console.ReadLine();

            // concatenate the firstName and lastName variable and assign that to fullName variable.
            string fullName = string.Concat(firstName, " ", lastName);
            // print the full name to the console
            Console.WriteLine("Your full name is {0}", fullName);

            Console.ReadKey();
        }
    }
}
