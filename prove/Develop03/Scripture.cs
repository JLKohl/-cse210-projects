


using System.Diagnostics;

public class Scripture
{
    private List<string> _words = new List<string>();

    public Scripture()
    {

    }

    public void LoadScripture(string scripture)
    {
        //create four loop to create an array of Word objects. Loop through words[]assigning string value to Word objects
        Object[] words = scripture.Split(" ");
    
        foreach (string word in words){

            string wordString = words.ToString();
            _words.Add(wordString);

        }

    }

    public void RemoveRandomWords()
    {
        //flip a couple words. random, mark words as hidden
        // random word hider set _hidden to True

        //get words from list

        //take some randome word indexes
        Random random = new Random();
        int index = random.Next(_words.Count);
        string randomIndex = _words[index].ToString();

 
        //take word index and set as hidden

        Word scriptureWord = new Word(_words);

  
        if (sciptureWord == randomIndex){

            scriptureWord == hidden;
        }
   
    }

    public string ConstructScripture( Object[] words)
    {
        string constructedScripture = string.Join(" ", words);
        string text = $"{constructedScripture}";
        return text;
    }

}
