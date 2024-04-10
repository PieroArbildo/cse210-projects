public class Reception : Event
{
    private string _RSVPEmail;

    public Reception(string Title, string Description, string Date, string Time, Address Address, string RSVPEmail) 
        : base(Title, Description, Date, Time, Address)
    {
        _RSVPEmail = RSVPEmail;
    }

    public new string GetFullDetails()
    {
        return $"{base.GetFullDetails()} Type: Reception, RSVP Email: {_RSVPEmail}";
    }
    public new string GetShortDescription()
    {
        return $"Type: Reception, {base.GetShortDescription()}";
    }
}