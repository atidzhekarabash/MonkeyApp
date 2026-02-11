using System;

namespace MyMonkeyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("All monkeys:\n" + MonkeyHelper.GetMonkeys());

            Console.WriteLine("Results by name:\n" + MonkeyHelper.GetMonkeyByName("capucinus"));

            Console.WriteLine("Random monkey:\n" + MonkeyHelper.GetRandomMonkey());

        }
    }
}
