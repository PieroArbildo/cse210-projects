public class Address
{
    private string _Country;
    private string  _Street;
    private string _City;
    private string _StateOrProvince;

    public Address( string Street, string City,string StateOrProvince,string Country)
    {
        _Country = Country;
        _Street = Street;
        _City = City;
        _StateOrProvince = StateOrProvince;
    }
    public string GetCountry()
    {
        return _Country;
    }
    public string GetStreet()
    {
        return _Street;
    }
    public string GetCity()
    {
        return _City;
    }
     public string StateOrProvince()
    {
        return _StateOrProvince;
    }
    public bool  IsInUsa()
    {
        if (_Country.ToLower() == "usa" || _Country.ToLower() == "ee.uu" || _Country.ToLower() == "united states")
        {
            return true;
        }
        else
        return false;
    }
    public string GetFullAddress()
    {
        return $"{_Street}\n{_City}, {_StateOrProvince}\n{_Country}";
    }
}