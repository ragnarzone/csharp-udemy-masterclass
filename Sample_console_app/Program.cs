namespace Sample_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            //methods.triggerGreetFriend();

            Console.WriteLine(methods.calculate());
        }
    }
}