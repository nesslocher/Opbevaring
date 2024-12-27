using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole
{
    public class Name
    {
        private string firstName;
        private string lastName;

        public Name(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;  //eller; return $"{firstName} {lastName}";
        }

        public void SetFirstName(string name)
        {
            firstName = name;
        }

        public void SetLastName(string name)
        {
            lastName = name;
        }


    }
}
