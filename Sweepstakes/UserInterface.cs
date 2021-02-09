using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    // Make this class static
    // Create methods to get user input for the properties on the contestant class
    // These methods should return a string of what the user typed in
    public static class UserInterface
    {
        
        public static string SetFirstName()
        {
            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();
            return FirstName;        
        }

        public static string SetLastName()
        {
           Console.WriteLine("What is your last name?");
            string LastName = Console.ReadLine();
            return LastName;
        }
        public static string SetEmailAddress()
        {
            Console.WriteLine("What is your email address?");
            string EmailAddress = Console.ReadLine();
            return EmailAddress;
        }
        public static int SetRegistrationNumber()
        { 
            Console.WriteLine("What is your registration number?");
            string userInput = Console.ReadLine();
            int RegistrationNumber = Int32.Parse(userInput);
            return RegistrationNumber;     
        }
    }
}
