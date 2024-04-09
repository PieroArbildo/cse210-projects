public class Customer
{
    private string _Name;
    private Address _Address;
public Customer(string name, Address address)
    {
        _Name = name;
        _Address = address;
    }
    public string GetName()
    {
        return _Name;
    }
    public Address GetAddress()
    {
        return _Address;
    }
    public bool IsInUSA()
    {
        return _Address.IsInUsa();
    }

}