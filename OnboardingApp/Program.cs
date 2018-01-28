using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new User();
            person.FirstName = AskQuestion("What is your first name?");
            person.LastName = AskQuestion("What is your last name?");
            var owner = new User();
            owner.IsOwner = AskQuestion("Are you the Account Owner?");
            Console.WriteLine("hello " + person.FirstName);
            Console.WriteLine("Thanks for banking with us, Mr. " + person.LastName);
        }

        private static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }

}

