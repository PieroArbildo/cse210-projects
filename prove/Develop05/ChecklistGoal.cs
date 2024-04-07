public class ChecklistGoal:Goal
{
    private int _amount;
    private int _target=0;
    private int _bonus;
    private string _points;
    public ChecklistGoal(int target,int bonus,string name, string description,string points):base(name,description,points)
    {
        _target = target;
        _bonus = bonus;
        _amount = 0;
        _points = points;
    }
    public int GetAmount()
    {
        return _amount;
    }
    public int GetPoints()
    {
        return int.Parse(_points);
    }
    public int GetTarget()
    {
        return _target;
    }
     public int GetBonus()
    {
        return _bonus;
    }
    public override void RecordEvent()
    {
        if (_target >= _amount)
        {
            IsComplete();
        }
    }
    public override bool IsComplete()
    {
        if (_amount >= _target)
        {
            return true;
        }
        else
        {
            return false;
    }
    }
    public void IncreaseAmount()
    {
    _amount++;
    if (_amount >= _target)
    {
        IsComplete();
    }
    }
    public  string GetDetailString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        if(IsComplete() == false)
        {
            return $" 3. [ ] {_shortName} ({_description}) --- Currently completed: {_amount}/{_target})";
        }
        else
          return $" 3. [x] {_shortName} ({_description}) --- Currently completed: {_amount}/{_target})";
    }
    public override string ToSave()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_amount},{_target},{_bonus},{_points}";
    }
}