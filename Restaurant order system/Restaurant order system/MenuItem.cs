using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_order_system
{
    public class MenuItem
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"ItemID: {ItemID} Name: {Name}, Price: {Price:C}");
        }
    }
}
