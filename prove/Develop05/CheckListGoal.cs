namespace Develop05;

public class CheckListGoal : Goal
{
    private int _howManyTimesToComplete;
    private int _howManyCompleted = 0;
    private int _bonusPoints;
    

    public CheckListGoal(int points, string name, string description, int bonusPoints, int howManyTimesToComplete,int howManyCompleted, bool isComplete) : base(points, name,
        description, isComplete)
    {
        _howManyTimesToComplete = howManyTimesToComplete;
        _bonusPoints = bonusPoints;
        _howManyCompleted = howManyCompleted;
    }
    
    public CheckListGoal()
    {
        
    }
    
    public override string DisplayGoals()
    {
        string display = $"{DisplayCompleted()} Check List Goal: {_name} ({_description}) This goal is worth {_points} points. -- You have completed {_howManyCompleted} out of {_howManyTimesToComplete} goals";
        
        return display;
    }
    public override string SerializeGoals()
    {
        return $"Check List Goal:~{_name}~{_description}~{_points}~{_bonusPoints}~{_howManyTimesToComplete}~{_howManyCompleted}~{_isComplete}";
    }

    public override Goal DeserializeGoals(string line)
    {
        
        string[] parts = line.Split('~');
        int points = int.Parse(parts[3]);
        string name = parts[1]; 
        string description = parts[2];
        int bonusPoints = int.Parse(parts[4]);
        int howManyTimesToComplete = int.Parse(parts[5]);
        int howManyCompeted = int.Parse(parts[6]);
        bool isComplete = bool.Parse(parts[7]);
            // Add goal to list or perform any other necessary operations
        
        return new CheckListGoal(points, name, description,bonusPoints, howManyTimesToComplete, howManyCompeted, isComplete);
        
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