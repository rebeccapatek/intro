using System;
using System.Threading;
namespace Intro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What is your sign? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! I'm figuring out your chart to see who you're meant to be with. Please wait.");
            var milliseconds = 3000;
            Thread.Sleep(milliseconds);
            Console.WriteLine($"...");
            Thread.Sleep(milliseconds);
            Console.WriteLine($"Your soul-mate is William Shatner.");
        }
    }
}
