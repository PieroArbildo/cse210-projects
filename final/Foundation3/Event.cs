public class Event
{
    private string _Title;
    private string _Description;
    private string _Date;
    private string _Time;
    private Address _address;
    
    public Event(string Title,string Description,string Date,string Time, Address Address)
    {
        _Title = Title;
        _Description = Description;
        _Date = Date;
        _Time = Time;
        _address = Address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_Title}, Description: {_Description}, Date: {_Date}, Time: {_Time}, Address: {_address.GetAddressDetails()}.";
    }
    
    public string GetFullDetails()
    {
        return $"Title: {_Title}, Description: {_Description}, Date: {_Date}, Time: {_Time}, Address: {_address.GetAddressDetails()}.";
    }
    public string GetShortDescription()
    {
        return $"Title: {_Title}, Date: {_Date}.";
    }
}