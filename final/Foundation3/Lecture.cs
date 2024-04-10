public class Lecture : Event
{
    private string _Speaker;
    private int _Capacity;

    public Lecture(string Title, string Description, string Date, string Time, Address Address, string Speaker, int Capacity)
    :base(Title, Description, Date, Time, Address)
   
    {
        _Speaker = Speaker;
        _Capacity = Capacity;
    }

    public new string GetFullDetails()
    {
        return $"{base.GetFullDetails()} Speaker: {_Speaker} Capacity: {_Capacity}";
    }
    public new string GetShortDescription()
    {
        return $"Type: Lecture, {base.GetShortDescription()}";
    }
}