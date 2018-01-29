using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingApp
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOwner { get; set; }
        public int PinNumber { get; set; }
        //public static string AskQuestion(string question)
        //{
        //    Console.WriteLine(question);
        //    return Console.ReadLine();
        //}
    }
}