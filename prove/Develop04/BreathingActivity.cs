using System.Security.Principal;

public class BreathingActivity : Activity
{
    public void CountDown()
    {
        for (int i=7; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);//1000 is equal to one second
            Console.Write("\b \b"); //(need two backslashes for doubles) in c# this makes the console backspace over itself so it will reprint the same line.
            
        }
    }

    public void CountUp()
    {
        for (int i=0; i < 7; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);//1000 is equal to one second
            Console.Write("\b \b"); //(need two backslashes for doubles) in c# this makes the console backspace over itself so it will reprint the same line.
            
        }
    }
    
    public BreathingActivity(string activityName, string activityStartMessage, string activityEndMessage) : base(activityName, activityStartMessage,activityEndMessage)
    {
        
    }

    public void RunBreathingActivity()
    {
        
        Console.WriteLine(' ');
        Console.WriteLine(' ');
        
        while (DateTime.Now < _endTime)
        {
            Console.Write("breath in..." );
            CountUp();
            Console.Write(' ');
            Console.Write("\nbreath out...");
            CountDown();
            Console.WriteLine(" ");
        }

        Console.WriteLine(' ');
        Console.WriteLine(' ');
        

    }
}