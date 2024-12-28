using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_order_system
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a restaurant
            Restaurant myRestaurant = new Restaurant { RestaurantName = "et eller andet" };

            // Add menu items through user input
            Console.WriteLine("Add Menu Items to the Restaurant:");
            Console.Write("Enter the number of menu items: ");
            int menuCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < menuCount; i++)
            {
                Console.Write($"Enter name of item {i + 1}: ");
                string itemName = Console.ReadLine();

                Console.Write($"Enter price of item {i + 1}: ");
                decimal itemPrice = decimal.Parse(Console.ReadLine());

                MenuItem item = new MenuItem { ItemID = i + 1, Name = itemName, Price = itemPrice };
                myRestaurant.AddMenuItem(item);
            }

            // Display menu
            Console.WriteLine("\n--- Menu ---");
            myRestaurant.DisplayMenu();

            // Create a customer
            Console.WriteLine("\nEnter Customer Details:");
            Console.Write("Customer ID: ");
            int customerID = int.Parse(Console.ReadLine());

            Console.Write("Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Customer Contact Info: ");
            string contactInfo = Console.ReadLine();

            Customer customer1 = new Customer
            {
                CustomerID = customerID,
                Name = customerName,
                ContactInfo = contactInfo
            };

            // Place an order
            Order order1 = new Order { OrderID = 101 };

            Console.WriteLine("\nAdd Items to Order. Type Menu Item ID (0 to stop):");
            while (true)
            {
                Console.Write("Enter Item ID: ");
                int itemID = int.Parse(Console.ReadLine());

                if (itemID == 0)
                    break;

                MenuItem selectedItem = myRestaurant.Menu.Find(m => m.ItemID == itemID);
                if (selectedItem != null)
                {
                    order1.AddItem(selectedItem);
                    Console.WriteLine($"{selectedItem.Name} added to the order.");
                }
                else
                {
                    Console.WriteLine("Item not found. Try again.");
                }
            }

            customer1.PlaceOrder(order1);
            myRestaurant.Orders.Add(order1);

            // Display order details
            Console.WriteLine("\n--- Customer Order Details ---");
            customer1.DisplayCustomerDetails();
            order1.DisplayOrderDetails();

            // Display all orders
            Console.WriteLine("\n--- All Orders in Restaurant ---");
            myRestaurant.ShowAllOrders();
        }

        //Restaurant myRestaurant = new Restaurant { RestaurantName = "et eller andet" };

        //    //tilføj elementer til menu
        //    MenuItem Pizza = new MenuItem { ItemID = 1, Name = "Pizza", Price = 12 };
        //    MenuItem Burger = new MenuItem { ItemID = 2, Name = "Burger", Price = 8 };

        //    myRestaurant.AddMenuItem(Pizza);
        //    myRestaurant.AddMenuItem(Burger);

        //    //vis menu
        //    myRestaurant.DisplayMenu();

        //    //Kunde og bestilte elementer
        //    Customer customer1 = new Customer { CustomerID = 1, Name = "John Doe", ContactInfo = "john@example.com" };
        //    Order order1 = new Order { OrderID = 101 };
            
        //    order1.AddItem(Pizza);
        //    order1.AddItem(Burger);

        //    customer1.PlaceOrder(order1);
        //    myRestaurant.Orders.Add(order1);

        //    //vis customer og bestilte elementer
        //    customer1.DisplayCustomerDetails();
        //    order1.DisplayOrderDetails();

        //    //vis alle ordre
        //    myRestaurant.ShowAllOrders();
            
        //}


    }
}
