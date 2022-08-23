using System;

namespace HelloYouCS
{
    internal class HelloYouCS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. What is your name?");
            string name = "";
            name = Console.ReadLine();
            if (string.IsNullOrEmpty(name)) {
                return;
            }//if
            Console.WriteLine(string.Format("Hello, {0}.", name));
        }
    }
}
