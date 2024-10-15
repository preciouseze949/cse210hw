using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize the order with a customer
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();  // Initialize an empty list of products
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order, including shipping
    public double GetTotalCost()
    {
        double totalCost = 0;
        
        // Calculate the total cost of all products
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add the shipping cost based on customer's location
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        totalCost += shippingCost;

        return totalCost;
    }

    // Method to return the packing label for the order
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to return the shipping label for the order
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerDetails()}";
    }
}
