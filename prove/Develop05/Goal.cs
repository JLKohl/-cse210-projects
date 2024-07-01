namespace Develop05;

public abstract class Goal
{
    protected int _points;
    protected string _name;
    protected string _description;
    protected int _totalPoints;
    protected bool _isComplete;

    public Goal(int points, string name, string description, bool isComplete)
    {
        _points = points;
        _name = name;
        _description = description;
        _isComplete = isComplete;

    }

    public Goal()
    {
        
    }
    public string DisplayName()
    {
        string displayName = $"{_name}";
        return displayName;
    }
    public void MarkCompleted()
    {
        _isComplete = true;
    }

    public string DisplayCompleted()
    {
        if (_isComplete == true)
        {
            return "[X]";
        
        }
        else
        {
            return "[ ]";
        }
        
    }
    public abstract void RecordEvent();


    public void DisplayTotal()
    {
        Console.WriteLine($"Your total points is: {_totalPoints}");
    }

    public int ReturnGoalPoints()
    {
        return _points;
    }

    public int ReturnTotal()
    {
        return _totalPoints;
    }
    public abstract string SerializeGoals();

    public abstract Goal DeserializeGoals(string line);

    public  abstract string DisplayGoals();
    
}