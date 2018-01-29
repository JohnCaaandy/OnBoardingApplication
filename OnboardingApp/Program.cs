using System;

namespace OnboardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new User();
            person.FirstName = AskQuestion("What is your first name?");
            person.LastName = AskQuestion("What is your last name?");
            Console.WriteLine("hello " + person.FirstName);

            person.IsOwner = AskQuestion("Are you the Account Owner? Please enter y for yes or n for no.");
            Console.WriteLine("Thanks for banking with us, " + person.FirstName + person.LastName);

            person.PinNumber = NewPin("What is your 4 digit pin number?");
            Console.ReadLine();

            Console.WriteLine("Okay, thank you " + person.FirstName);
            Console.ReadLine();

            
        }

        private static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        private static int NewPin(string p)
        {
            var response = AskQuestion(p);

            if (int.TryParse(response, out var number))
            {
                return number;
            }

            return NewPin(p);
        }
    }
}

