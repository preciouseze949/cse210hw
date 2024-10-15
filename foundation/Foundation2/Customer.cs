public class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to check if customer is in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    // Method to return customer details (for shipping label)
    public string GetCustomerDetails()
    {
        return $"{name}\n{address.GetFullAddress()}";
    }
}
