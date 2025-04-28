using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNameGenerator
{
    public class NamesGenerator
    {
        private static string[] firstNames = { "James", "Michael", "Robert", "John", "David", "William", "Richard", "Joseph", "Thomas", "Charles" };
        private static string[] lastNames = { "Smith", "Brown", "Johnson", "Jones", "Williams", "Thomas", "Miller", "Davis", "Taylor", "Jackson", "Martin" };

        public static string GenerateName()
        {
            var rand = new Random();
            string randomFirstName = firstNames[rand.Next(firstNames.Length)];
            string randomLastName = lastNames[rand.Next(lastNames.Length)];

            return $"{randomFirstName} {randomLastName}";
        }
    }
}
