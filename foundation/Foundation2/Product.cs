public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to calculate total cost of the product
    public double GetTotalCost()
    {
        return price * quantity;
    }

    // Getter for product name
    public string GetName()
    {
        return name;
    }

    // Getter for product ID
    public string GetProductId()
    {
        return productId;
    }
}
