using System;

namespace test_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var module = new SomeModule();
            Console.Write("What is your name? ");
            module.Name = Console.ReadLine();
            Console.WriteLine(module.Greeting);
        }
    }
}
