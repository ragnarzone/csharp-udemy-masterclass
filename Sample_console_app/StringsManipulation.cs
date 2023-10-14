namespace Sample_console_app
{
    internal class StringsManipulation
    {
        public void manipulateString()
        {
            string name;
            Console.WriteLine("Please enter your name and press enter : ");
            name = Console.ReadLine();
            string myNameUpperCase = String.Format("Upper case : {0}", name.ToUpper());
            Console.WriteLine(myNameUpperCase);
        }
    }
}
