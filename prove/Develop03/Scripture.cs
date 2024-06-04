


public class Scripture
{
    private List<Word> _words = new List<Word>();

    public Scripture()
    {

    }

    public Object[] LoadScripture(string scripture)
    {
        //create four loop to create an array of Word objects. Loop through words[]assigning string value to Word objects


        Object[] words = scripture.Split(" ");
        
        int index = 0;

        foreach ( string word in words)
        {
      
        }

        return words;
    }

    public void RemoveRandomWords(Object[] words)
    {
        //flip a couple words. random, mark words as hidden
        // random word hider set _hidden to True

        //take some randome word indexes

        Random random = new Random();
        int index = random.Next(words.Length);

        string source = words[index].ToString();

        Console.Write($"{index}, {source}");
   
    }

    public string ConstructScripture( Object[] words)
    {
        string constructedScripture = string.Join(" ", words);
        string text = $"{constructedScripture}";
        return text;
    }

}
