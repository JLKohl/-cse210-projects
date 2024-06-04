


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
            index++;
        }

        return words;
    }

    public void RemoveRandomWords(Object[] words)
    {
        //flip a couple words. random, mark words as hidden
        // random word hider set _hidden to True

        // Random random = new Random();
        // int index = random.Next(words.Length);

        string source = words[0].ToString();

        // Replace all occurrences of one char with another.
        //convert objects in array to word objects
   
    }

    public string ConstructScripture( Object[] words)
    {
        string constructedScripture = string.Join(" ", words);
        string text = $"{constructedScripture}";
        return text;
    }

}
