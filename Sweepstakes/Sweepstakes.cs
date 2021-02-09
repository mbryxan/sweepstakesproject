using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //variables
        Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;

        //constructor
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }

        //method
        public void RegisterContestant(Contestant contestant)
        {
            // Take the contestant parameter and add it to the dictionary
            // Use the contestant's registration number as the key for the dictionary entry
            // Use the contestant object itself as the value for the dictionary entry
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public void PrintContestantinfo(Contestant contestant)
        {
            // Assume the contestant object is an object alreayd created with information
            // Print out all of the conctestant's information using Console.WriteLines
            Console.WriteLine("First Name: " + contestant.FirstName);
            Console.WriteLine("Last Name: " + contestant.LastName);
            Console.WriteLine("Email Address: " + contestant.EmailAddress);
            Console.WriteLine("Registration Number: " + contestant.RegistrationNumber);
        }
        public Contestant ContestantPickWinner()
        {
            // Find a way to select a random contestant from the contestants dictionary
            // Return that constant we grabbed from the dictionary

            Random random = new Random();
            return contestants[random.Next(contestants.Count)];
           
            
            
        }
    }
}


