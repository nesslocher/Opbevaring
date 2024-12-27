using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
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

        public string GetFirstName() => firstName;
        public string GetLastName() => lastName;

        public Name Copy() => new Name(firstName, lastName);

        public override bool Equals(object obj)
        {
            if (obj is Name name)
            {
                return firstName == name.firstName && lastName == name.lastName; 
            }
            return false;
        }
            

        public override string ToString() => $"{firstName} {lastName}";    
    }
}
