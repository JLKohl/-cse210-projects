


using System.Diagnostics;
using System.Text;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _newReference;
    public Scripture()
    {

    }

    public void LoadScripture(string scripture)
    {
        //create four loop to create an array of Word objects. Loop through words[]assigning string value to Word objects
        String[] words = scripture.Split(" ");
    
        foreach (string word in words){

            Word wordClass = new Word(word);
            _words.Add(wordClass);

        }

    }

    public void LoadReference(string book, int chapter, int startVerse, int endVerse)
    {
        _newReference = new Reference(book, chapter, startVerse, endVerse );
    }
    
    public void LoadReference(string book, int chapter, int startVerse)
    {
        _newReference = new Reference(book, chapter, startVerse);
    }

    public void RemoveRandomWords()
    {

        Random random = new Random();
        int randomIndexOne = random.Next(_words.Count);
        int randomIndexTwo = random.Next(_words.Count);
        int randomIndexThree = random.Next(_words.Count);

        List<int> randomNumbers = GetRandomList();
        
        foreach (int number in randomNumbers){
            this._words[number].SetHidden(true);
        }
    }
    
    private List<int> GetRandomList() 
    {
        List<int> randomIndexes = new List<int>();
        Random random = new Random();

        while (randomIndexes.Count < 3 && randomIndexes.Count < GetNumberOfUnhiddenWordsRemaining())
        {
            int randomNumber = random.Next(_words.Count);

            if (!randomIndexes.Contains(randomNumber) && _words[randomNumber].NotHidden())
            {
                randomIndexes.Add(randomNumber);
            }
        }

        return randomIndexes;
    }

    public string ConstructScripture()
    {
        StringBuilder builder = new StringBuilder();

        foreach (Word word in _words){
            builder.Append(word.GetWord() + " ");
        }

        return builder.ToString();
    }

    public bool HasMoreWords()
    {
        return GetNumberOfUnhiddenWordsRemaining() > 0;
    }

    public int GetNumberOfUnhiddenWordsRemaining()
    {
        int unhidden = 0;
        
        foreach (Word word in _words){

            if (word.NotHidden())
            {
                unhidden++;
            }
        }
        
        return unhidden;
    }

    public string GetScripture()
    {

        return $" {_newReference.GetReference()}: {ConstructScripture()}";
    }

}
