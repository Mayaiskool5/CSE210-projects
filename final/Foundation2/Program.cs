using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Vikki's...A Unique Boutique", "Aiken", "South Carolina", "USA");
        Customer customer1 = new Customer("Vikki", address1);

        Ordering order1 = new Ordering(customer1);
        order1.AddProduct(new Product("Prom Dress", "SP001", 40.00, 1));
        order1.AddProduct(new Product("Ball Gown", "LC002", 559.99, 1));

        Console.WriteLine("Order Details:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost()}");
        Console.WriteLine();

        Address address2 = new Address("June's Place", "Rexburg", "Idaho", "Russia");
        Customer customer2 = new Customer("June", address2);

        Ordering order2 = new Ordering(customer2);
        order2.AddProduct(new Product("Coffee, Black", "ID003", 4.00, 4));
        order2.AddProduct(new Product("Hot Chocolate", "EX004", 2.50, 2));

        Console.WriteLine("Order Details:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.GetTotalCost()}");
        Console.WriteLine("");
        Console.WriteLine();
    }
}