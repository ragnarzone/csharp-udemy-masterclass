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
            
            TryParseTest tryParseTest = new TryParseTest();
            tryParseTest.checkTryParse();
        }
    }
}