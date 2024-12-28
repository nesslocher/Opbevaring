using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_order_system
{
    public class Restaurant
    {
        public string RestaurantName { get; set; }
        public List<MenuItem> Menu { get; set; } = new List<MenuItem>();

        public List<Order> Orders { get; set; } = new List<Order>();

        public void AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
            Console.WriteLine($"{item.Name} added to the menu.");
        }

        public void RemoveMenuItem(MenuItem item)
        {
            Menu.Remove(item);
            Console.WriteLine($"{item.Name} removed from the menu.");
        }


        public void DisplayMenu()
        {
            Console.WriteLine($"\nMenu at {RestaurantName}");
            foreach (var item in Menu)
            {
                item.DisplayDetails();
            }
        }

        public void ShowAllOrders()
        {
            Console.WriteLine("\nAll Orders:");
            foreach (var order in Orders)
            {
                order.DisplayOrderDetails();
            }
        }


    }
}
