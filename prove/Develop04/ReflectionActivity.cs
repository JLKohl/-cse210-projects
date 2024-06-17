

public class ReflectionActivity : Activity
{
    public ReflectionActivity(string activityName, string activityStartMessage, string activityEndMessage) : base(activityName, activityStartMessage,activityEndMessage)
    {
        
    }

    public void RunReflectionActivity()
    {
        ReflectionPrompts reflectionPrompter = new ReflectionPrompts();
        ReflectionPrompts reflectionQuestions = new ReflectionPrompts();
        
        Console.WriteLine(' ');
        Console.WriteLine(' ');
        
        Console.WriteLine(reflectionPrompter.DisplayReflectionPrompt());
        Thread.Sleep(1000);
        
        Console.WriteLine(" ");
        Console.WriteLine("When you have something in mind press Enter to continue");
        Console.ReadKey();
        
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.Write("Start in: ");
        for (int i=5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);//1000 is equal to one second
            Console.Write("\b \b"); //(need two backslashes for doubles) in c# this makes the console backspace over itself so it will reprint the same line.
            
        }
        
        while (DateTime.Now < _endTime)
        {
            Console.WriteLine(" ");
            Console.WriteLine(reflectionQuestions.DisplayReflectionQuestions());
            Animation promptQuestionAnimation = new Animation();
            promptQuestionAnimation.DisplayAnimation();

        }

        Console.WriteLine(' ');
        Console.WriteLine(' ');
        
    }
}