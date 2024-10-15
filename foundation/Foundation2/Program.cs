using System;

class Program
{
    static void Main(string[] args)
    {
        // Create address objects
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Address address2 = new Address("456 Orange Ave", "Toronto", "ON", "Canada");

        // Create customer objects
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create product objects
        Product product1 = new Product("Laptop", "LPT123", 999.99, 1);
        Product product2 = new Product("Mouse", "MSE456", 49.99, 2);
        Product product3 = new Product("Keyboard", "KBD789", 89.99, 1);

        // Create order1 and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Create order2 and add products
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display order1 details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        // Display order2 details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
