public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor to initialize product details
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate the total cost of this product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Getter for product name
    public string GetName()
    {
        return _name;
    }

    // Getter for product ID
    public string GetProductId()
    {
        return _productId;
    }
}
