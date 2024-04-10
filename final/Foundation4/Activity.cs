public abstract class Activity
{
    protected string _Date;
    protected int _DurationMinutes;
    public Activity(string Date, int DurationMinutes)
    {
        _Date = Date;
        _DurationMinutes = DurationMinutes;
    }
    
    public int GetDurationMinutes()
    {
        return _DurationMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_Date} , ({_DurationMinutes} min)";
    }

}