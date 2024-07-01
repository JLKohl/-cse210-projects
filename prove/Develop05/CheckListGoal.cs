namespace Develop05;

public class CheckListGoal : Goal
{
    private int _howManyTimesToComplete;
    private bool _isComplete;
    private int _howManyCompleted = 0;
    private int _bonusPoints;
    

    public CheckListGoal(int points, string name, string description, int bonusPoints, int howManyTimesToComplete,int howManyCompleted) : base(points, name,
        description)
    {
        _howManyTimesToComplete = howManyTimesToComplete;
        _bonusPoints = bonusPoints;
        _howManyCompleted = howManyCompleted;
    }
    
    public override string DisplayGoals()
    {
        string display = $"{DisplayCompleted()} {_name} ({_description}) This goal is worth {_points} points. -- You have completed {_howManyCompleted} out of {_howManyTimesToComplete} goals";
        
        return display;
    }
    public override string SerializeGoals()
    {
        return $"Check List Goal: {_name}~{_description}~{_points}~{_bonusPoints}~{_howManyTimesToComplete}~{_howManyCompleted}";
    }

    public override Goal DeserializeGoals(string line)
    {
        
        string[] parts = line.Split('~');
        int points = int.Parse(parts[2]);
        string name = parts[0]; 
        string description = parts[1];
        int bonusPoints = int.Parse(parts[3]);
        int howManyTimesToComplete = int.Parse(parts[4]);
        int howManyCompeted = int.Parse(parts[5]);
            // Add goal to list or perform any other necessary operations
        
        return new CheckListGoal(points, name, description,bonusPoints, howManyTimesToComplete, howManyCompeted);
        
    }
    
    public override void RecordEvent()
    {
        _howManyCompleted++;
        if (_howManyCompleted >= _howManyTimesToComplete)
        {
            MarkCompleted();
            _totalPoints += _bonusPoints;
            Console.WriteLine($"Congratulations you have earned a bonus of {_bonusPoints} points");
        }
        _totalPoints += _points;
        Console.WriteLine($"Congratulations you have earned {_points}");
        Console.WriteLine($"You now have {_totalPoints} point total.");
    }
}