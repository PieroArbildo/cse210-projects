public class OutdoorGathering : Event
{
    private string _WeatherForecast;

    public OutdoorGathering(string Title, string Description, string Date, string Time, Address Address, string WeatherForecast) 
        : base(Title, Description, Date, Time, Address)
    {
        _WeatherForecast = WeatherForecast;
    }

    public new string GetFullDetails()
    {
        return $"{base.GetFullDetails()} Type: Outdoor Gathering , Weather Forecast: {_WeatherForecast}";
    }
    public new string GetShortDescription()
    {
        return $"Type: Outdoor Gathering, {base.GetShortDescription()}";
    }
}