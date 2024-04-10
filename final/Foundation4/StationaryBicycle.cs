public class StationaryBicycle : Activity
{
    private double _Speed;
    public StationaryBicycle(string Date, int DurationMinutes, double speed) 
        : base(Date, DurationMinutes)
    {
        _Speed = speed;
    }
    public override double GetSpeed()
    {
        return _Speed;
    }
    public override double GetDistance()
    {
        return 0;
    }
    public override double GetPace()
    {
        return 0;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} StationaryBicycle - Speed: {_Speed} mph";
    }

}