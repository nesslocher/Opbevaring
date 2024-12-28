using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_order_system
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();
        public decimal TotalAmount { get; set; }

        public void AddItem(MenuItem item)
        {
            Items.Add(item);
            Console.WriteLine($"{item.Name} added to order");
            CalculateTotal();
        }

        public void RemoveItem(MenuItem item)
        {
            Items.Remove(item);
            Console.WriteLine($"{item.Name} removed from order");
            CalculateTotal();
        }

        public void CalculateTotal()
        {
            TotalAmount = 0;
            foreach (MenuItem item in Items)
            {
                TotalAmount += item.Price;
            }
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine($"\nOrder ID: {OrderID}");
            Console.WriteLine("Order Items:");
            foreach (var item in Items)
            {
                item.DisplayDetails();
            }
            Console.WriteLine($"Total Amount: {TotalAmount:C}");
        }
    }
}
