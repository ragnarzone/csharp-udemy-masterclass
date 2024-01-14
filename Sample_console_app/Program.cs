namespace Sample_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Methods methods = new Methods();
            //methods.triggerGreetFriend();

            //Console.WriteLine(methods.calculate());

            //TryCatchFinally tryCatchFinally = new TryCatchFinally();
            //tryCatchFinally.triggerTest();

            //TryParseTest tryParseTest = new TryParseTest();
            //tryParseTest.checkTryParse();

            Game game1;
            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = "3.5";
            game1.releaseDate = "01.07.2016";

            game1.Display();
        }
    }
}