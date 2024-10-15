using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address objects for the customers
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Address address2 = new Address("456 Orange Ave", "Toronto", "ON", "Canada");

        // Create Customer objects
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Product objects
        Product product1 = new Product("Laptop", "LPT123", 999.99, 1);
        Product product2 = new Product("Mouse", "MSE456", 49.99, 2);
        Product product3 = new Product("Keyboard", "KBD789", 89.99, 1);

        // Create Order1 for customer1 and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Create Order2 for customer2 and add products
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display details for order1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        // Display details for order2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
