public class Running : Activity
{
    private double _Distance;
    public Running(string Date, int DurationMinutes, double Distance) 
        : base(Date, DurationMinutes)
    {
        _Distance = Distance;
    }
    public override double GetDistance()
    {
        return _Distance;
    }
    public override double GetSpeed()
    {
        return _Distance / _DurationMinutes * 60;
    }

    public override double GetPace()
    {
        return _DurationMinutes / _Distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance: {_Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}