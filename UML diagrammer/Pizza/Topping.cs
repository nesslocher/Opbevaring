using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProjekt
{
    public class Topping
    {
        private string name;
        private double price;

        public Topping(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string GetName() => name;

        public double GetPrice() => price;

        public void SetPrice(double price) => this.price = price;
    }
}
