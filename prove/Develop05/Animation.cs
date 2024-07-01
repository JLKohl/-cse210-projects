namespace Develop05;

public class Animation
{
    private List<string> animationStrings;


    public Animation()
    {
        animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
    }
    
    public void DisplayAnimation()
    {
      
        
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);//1000 is equal to one second
            Console.Write("\b \b"); //(need two backslashes for doubles) in c# this makes the console backspace over itself so it will reprint the same line.
            
        }

    }
}