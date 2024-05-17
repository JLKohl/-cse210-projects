
using System.Runtime.CompilerServices;

public class Prompt {
  
    public  List<string> _prompts = new List<string>(){
        
        "What is something that made you smile today?",
        "Who did you help today?",
        "What is something new you learned today?",
        "How did you see Gods hand in your life today?",
        "What was the best thing you ate today?"

    };
     public string DisplayPrompt(){

        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        string newPromt = _prompts[ index ];

        return newPromt;
     }
}
