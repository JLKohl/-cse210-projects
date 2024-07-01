namespace Develop05;

public class SimpleGoal : Goal
{
    
    
    public SimpleGoal(int points, string name, string description, bool isComplete) : base(points, name, description, isComplete)
    {
        
    }
    
    public SimpleGoal()
    {
        
    }
    
    public override string DisplayGoals()
    {
        string display = $"{DisplayCompleted()} Simple Goal: {_name} ({_description}) This goal is worth {_points} points.";
        
        return display;
    }
  
    public override string SerializeGoals()
    {
        return $"Simple Goal:~{_name}~{_description}~{_points}~{_isComplete}";
    }

    public override Goal DeserializeGoals(string line)
    {
        // Code to deserialize goals
            string[] parts = line.Split('~');
            int points = int.Parse(parts[3]);
            string name = parts[1]; 
            string description = parts[2];
            bool isComplete = bool.Parse(parts[4]);
            Goal goal = new SimpleGoal(points, name, description, isComplete);
            // Add goal to list or perform any other necessary operations
        
        return new SimpleGoal(points, name, description, isComplete);
    
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