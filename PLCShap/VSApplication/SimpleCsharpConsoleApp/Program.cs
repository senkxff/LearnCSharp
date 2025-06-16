namespace SimpleCsharpConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("****************************");
            Console.WriteLine("********WELCOM!!!***********");
            Console.WriteLine("****************************");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ReadLine();
        }
    }
}
