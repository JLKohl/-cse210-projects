namespace Develop05;

public class SimpleGoal : Goal
{
    
    
    public SimpleGoal(int points, string name, string description) : base(points, name, description)
    {
        
    }
    
    public override string DisplayGoals()
    {
        string display = $"{DisplayCompleted()} {_name} ({_description}) This goal is worth {_points} points.";
        
        return display;
    }
  
    public override string SerializeGoals()
    {
        return $"Simple Goal: {_name}~{_description}~{_points}~{_isComplete}";
    }

    public override Goal DeserializeGoals(string line)
    {
        // Code to deserialize goals
            string[] parts = line.Split('~');
            int points = int.Parse(parts[2]);
            string name = parts[0]; 
            string description = parts[1];
            Goal goal = new SimpleGoal(points, name, description);
            // Add goal to list or perform any other necessary operations
        
        return new SimpleGoal(points, name, description);
    
    }

    public override void RecordEvent()
    {
        _totalPoints += _points;
        if (_totalPoints == _points)
        {
            MarkCompleted();
        }
        Console.WriteLine($"Congratulations you have earned {_points}");
        Console.WriteLine($"You now have {_totalPoints} point total.");
    }
    


    
}