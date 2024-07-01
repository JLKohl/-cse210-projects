namespace Develop05;

public class EternalGoal : Goal
{
    public EternalGoal(int points, string name, string description, bool isComplete) : base(points, name, description, isComplete)
    {
        
    }
    public EternalGoal()
    {
        
    }
    
    public override string SerializeGoals()
    {
        return $"Eternal Goal:~{_name}~{_description}~{_points}";
    }
    
    public override string DisplayGoals()
    {
        string display = $"{DisplayCompleted()} Eternal Goal: {_name} ({_description}) This goal is worth {_points} points.";
        
        return display;
    }
    
    public override void RecordEvent()
    {
        _totalPoints += _points;
        Console.WriteLine($"Congratulations you have earned {_points}");
        Console.WriteLine($"You now have {_totalPoints} point total.");
    }

    public override Goal DeserializeGoals(string line)
    {
        
            string[] parts = line.Split('~');
            int points = int.Parse(parts[3]);
            string name = parts[1];
            string description = parts[2];
            bool isComplete = false;
            // Add goal to list or perform any other necessary operations
        
        return new EternalGoal(points,name,description, isComplete);
    }


}