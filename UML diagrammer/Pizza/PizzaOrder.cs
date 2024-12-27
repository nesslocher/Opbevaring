using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProjekt
{
    internal class PizzaOrder
    {
        private Customer customer;
        private List<Pizza> pizzas;

        public PizzaOrder(Customer customer)
        {
            this.customer = customer;
            this.pizzas = new List<Pizza>();
        }
        public Customer GetCustomer() => customer;
        public int GetNumberOfPizzas() => pizzas.Count;

        public void AddPizza(Pizza pizza) => pizzas.Add(pizza);

        public Pizza GetPizza(int index)
        {
            if (index >= 0 && index < pizzas.Count)
            {
                return pizzas[index];
            }
            throw new System.IndexOutOfRangeException("Invalid Pizza index");
        }
        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var pizza in pizzas)
            {
                total += pizza.GetTotalPrice();
            }
            return total;

        }
    }
}
