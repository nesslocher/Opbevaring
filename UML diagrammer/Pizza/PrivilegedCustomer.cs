using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProjekt
{
    internal class PrivilegedCustomer : Customer
    {

        //nedarvning fra Customer 
        private double discount;
        //hvordan ordner jeg percentage discount?????

        public PrivilegedCustomer(string name) : base(name)
        {
            discount = 0;
        }

        public double GetDiscount() => discount;
        public void SetDiscount(double percentage)
        {
            discount = percentage;
        }
    }
}
