
using System.Runtime.CompilerServices;

public class Prompt {
  
    public  List<string> _prompts = new List<string>(){
        
        "this is prompt one",
        "this is prompt two",
        "this is prompt three",
        "this is prompt four",
        "this is prompt five"

    };
     public int DisplayPrompt(){

        var Random = new Random();
        int index = Random.Next(_prompts.Count);

        return index;
     }
}
