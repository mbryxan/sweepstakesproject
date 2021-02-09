using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int RegistrationNumber { get; set; }

        // Create a constructor
        public Contestant()
        // Inside the constructor, set the FirstName, LastName, and EmailAddress properties equal to user input
        {
            FirstName = UserInterface.SetFirstName();
            LastName = UserInterface.SetLastName();
            EmailAddress = UserInterface.SetEmailAddress();
            //RegistrationNumber = UserInterface.SetRegistrationNumber();

            
            // Use methods on the static UserInterface class to get the user input
        }
    }
}
