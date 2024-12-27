using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProjekt
{
    internal class Pizza
    {
        private string name;
        private double initialPrice; //tænker prisen uden toppings
        private int numberOfToppings;
        private const int MAX_NUMBER_OF_TOPPINGS = 5;
        private List<Topping> toppings;

        public Pizza(string name, double initialPrice)
        {
            this.name = name;
            this.initialPrice = initialPrice;
            this.numberOfToppings = 0;
            this.toppings = new List<Topping>();
        }

        public int GetNumberOfTOppings() => numberOfToppings;
        public void AddTopping(Topping topping)
        {
            toppings.Add(topping);
            numberOfToppings++;
        }

        //public void RemoveTOpping(string toppingName)
        //{
        //    Topping toppingToRemove = toppings.Find(t => t.Name() == toppingName); //find et item i toppings og ud fra den condition; fjern den
        //    //t => t.Name() == toppingName er en lambda expression
        //    //t representerer alle items i 'toppings'
        //    //t.Name() method call af Topping item 
        //    //t.Name() == toppingName; hvis topping matcher toppingName (condition)

        //    if (toppingToRemove != null)
        //    {
        //        toppings.Remove(toppingToRemove);
        //        numberOfToppings--;
        //    }
        //}

        public void RemoveTopping(string toppingName)
        {
            Topping toppingToRemove = null;

            foreach (Topping topping in toppings)
            {
                if (topping.GetName() == toppingName)
                {
                    toppingToRemove = topping;
                    break;
                }
            }

            if (toppingToRemove != null)
            {
                toppings.Remove(toppingToRemove);
                numberOfToppings--;
            }
        }

        public double GetTotalPrice()
        {
            double totalPrice = initialPrice;
            foreach (var topping in toppings)
            {
                totalPrice += topping.GetPrice();
            }
            return totalPrice;
        }
    }
}
