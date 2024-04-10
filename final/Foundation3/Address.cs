public class Address
{
    private string _Street;
    private string _City;
    private string _StateOrProvince;
    private string _Country;
    public Address(string Street,string City,string StateOrProvince,string Country)  
    {
        _Street = Street;
        _City = City;
        _StateOrProvince = StateOrProvince; 
        _Country = Country;
    }
    public string GetAddressDetails()
    {
        return $"{_Street}, {_City}, {_Country}";
    }
}