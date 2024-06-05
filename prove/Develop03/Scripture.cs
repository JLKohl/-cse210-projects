


using System.Diagnostics;
using System.Text;

public class Scripture
{
    private List<Word> _words = new List<Word>();

    public Scripture()
    {

    }

    public void LoadScripture(string scripture)
    {
        //create four loop to create an array of Word objects. Loop through words[]assigning string value to Word objects
        Object[] words = scripture.Split(" ");
    
        foreach (string word in words){

            Word wordString = new Word(word);
            _words.Add(wordString);

        }

    }

    public void RemoveRandomWords()
    {
        //flip a couple words. random, mark words as hidden
        // random word hider set _hidden to True

        //take some randome word indexes
        Random random = new Random();
        int randomIndex = random.Next(_words.Count);


 
        //take word index and set as hidden
        //need to watch out for colisions, if number 15 is random you shouldnt be able to pick 15 again. 
        for (int i = 0; i < _words.Count; i++){
            
            if (i == randomIndex)//you can check to see if i is containted in an array of integers
            {
                this._words[i].SetHidden(true);
            }
           
        }
        
   
    }

    public string ConstructScripture()
    {
        StringBuilder builder = new StringBuilder();

        foreach (Word word in _words){
            builder.Append(word.GetWord() + " ");
        }

        return builder.ToString();
    }

}
