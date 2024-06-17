using System.Data;


    public class Activity
    {
        private string _activityName;
        private string _activityStartMessage;
        private string _activityEndMessage;
        private int _activityDuration;
        protected DateTime _startTime;
        protected DateTime _endTime;

    public Activity(string activityName, string activityStartMessage, string activityEndMessage)
    {
        _activityName = activityName;
        _activityStartMessage = activityStartMessage;
        _activityEndMessage = activityEndMessage;
        
    }
    
    public string GetName(){
    
        return _activityName;
    }

    public string GetStartMessage()
    {
        return _activityStartMessage;
    }
    public void GetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like the session to last? ");
        string userInput = Console.ReadLine();
        _activityDuration = int.Parse(userInput);
        
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_activityDuration);
    }

    public void GetStartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine($"This activity will {_activityStartMessage}");
        GetDuration();
        
        Console.Clear();
        Console.WriteLine($"Get Ready");
        DateTime stopAnimation = DateTime.Now;
        Animation beginningAnimation = new Animation();
        while (DateTime.Now < stopAnimation.AddSeconds(5))
        {
            beginningAnimation.DisplayAnimation();
        }
        Console.Clear();
    }
    
    public void GetEndActivty()
    { 
        
        Console.WriteLine("Well Done!");

        Animation activityEnd = new Animation();
        activityEnd.DisplayAnimation();
        
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityEndMessage} activity");
        activityEnd.DisplayAnimation();
        
        Console.Clear();
    }
    
}
    