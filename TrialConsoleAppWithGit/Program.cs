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
            Console.WriteLine("Do you like ice cream, i can search for where to get the best ice cream around you");
			Console.WriteLine("Do you like swimming, i can search for places around you");
            Console.WriteLine("cornwall is a nice place");
        }
    }
}
