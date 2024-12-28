using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_order_system
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string ContactInfo {  get; set; }
        public Order CurrentOrder { get; set; } //Ved at give CurrentOrder data typen Order gør vi det
                                                //muligt for den at holde en instance i Order class

        public void PlaceOrder(Order order)
        {
            CurrentOrder = order;
            Console.WriteLine($"Order {order.OrderID} placed by {Name}.");
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer ID: {CustomerID}, Name: {Name}, Contact: {ContactInfo}");
        }

    }
}
