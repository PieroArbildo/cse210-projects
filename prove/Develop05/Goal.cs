public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    public Goal(string name,string description,string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public void GetShortName()
    {
        Console.WriteLine(_shortName);
    }
    public void GetDescription()
    {
        Console.WriteLine(_description);
    }
    public void GetPoints()
    {
        Console.WriteLine(_points);
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete(); 
    public  string GetDetailString()
    {
        return $"{_shortName} {_description} {_points}";
    }
    public abstract string GetStringRepresentation();
    public abstract string ToSave();
}