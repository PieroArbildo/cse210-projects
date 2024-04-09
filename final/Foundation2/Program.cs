using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 1, 1500, 1);
        Product product2 = new Product("Celphone", 2, 400, 2);
        Product product3 = new Product("Earphones", 3, 450, 3);
      
        Address address1 = new Address("E30 TH St.", "Hialeah", "Miami", "USA");
        Address address2 = new Address("25D Broadway.", "Tribeca", "NY", "USA");
        Address address3 = new Address("Av.Benavides 2025.", "Surco", "Lima", "Peru");

        Customer customer1 = new Customer("Lia T.", address1);
        Customer customer2 = new Customer("Gigi F.", address2);
        Customer customer3 = new Customer("Piero A", address3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product2);
        order3.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalCost());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalCost());

        Console.WriteLine("\nOrder 3:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order3.GetTotalCost());
    }
}