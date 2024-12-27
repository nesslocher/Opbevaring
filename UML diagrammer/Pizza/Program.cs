namespace PizzaProjekt
{
   class Program
    {
        //spørg søren om constructors er nødvendige 
        static void Main(string[] args)
        {
            var customer = new PrivilegedCustomer("Martin Remmer");
            customer.SetDiscount(5);

            var pizza = new Pizza("Hawaii", 10.0);
            pizza.AddTopping(new Topping("ost", 1.0));
            pizza.AddTopping(new Topping("Oliven", 1.5));
            pizza.AddTopping(new Topping("idfk", 2.0));

            var order = new PizzaOrder(customer);
            order.AddPizza(pizza);

            Console.WriteLine($"Customer: {customer.GetName()}");
            Console.WriteLine($"Total price: {order.GetTotalPrice()}");
        }
    }
}
