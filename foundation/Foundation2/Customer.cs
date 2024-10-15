public class Customer
{
    private string _name;
    private Address _address;

    // Constructor to initialize customer details
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer lives in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Method to return customer details for the shipping label
    public string GetCustomerDetails()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}
