public class SimpleGoal:Goal
{
    private string _points;
    private bool _isComplete;
    public SimpleGoal(string name, string description,string points):base(name,description,points)
    {
        _points = points;
    }
    public int GetPoints()
    {
        return int.Parse(_points);
    }
    public override void RecordEvent()
    {
       _isComplete = true;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public  bool IsComplete(bool valor=false)
    {
        return valor;
    }
    public override string GetStringRepresentation()
    {
        if(_isComplete==false)
        {
            return $" 1. [ ] {_shortName} ({_description})";
        }
        else
        {
            return $" 1. [x] {_shortName} ({_description})";
        }      
    }
    public override string ToSave()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points}";
    }
}