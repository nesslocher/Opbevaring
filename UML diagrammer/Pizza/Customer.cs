using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProjekt
{
    internal class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string GetName() => name;

    }
}
