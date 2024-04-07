public class EternalGoal:Goal
{
    private string _points;
    public EternalGoal(string name, string description,string points):base(name,description,points)
    {
     _points=points;
    }
    public int GetPoints()
    {
        return int.Parse(_points);
    }
    public override void RecordEvent()
    {   
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $" 2. [ ] {_shortName} ({_description})";
    }
    public override string ToSave()
    {
        return $"EternalGoal,{_shortName},{_description},{_points}";
    }
}