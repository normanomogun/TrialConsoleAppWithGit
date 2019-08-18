using System;

namespace TrialConsoleAppWithGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi My Name is Shanice");
            Console.WriteLine("I am here to help");
            Console.WriteLine("What is your name?");
            var usersName = Console.ReadLine();
            
            Console.WriteLine($"Hi {usersName}, how may i help today.");
            Console.WriteLine($"Today is a sunny day and todays date is {DateTime.Now}");
        }
    }
}
