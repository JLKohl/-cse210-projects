
using System.Threading.Tasks.Dataflow;
using System.Text.RegularExpressions;

public class Word
{
    
    private string _scriptureWord;//place word objects as string into this
    private bool _hidden = false;

    public Word(string word)
    {
        _scriptureWord = word;
    }

    public string GetWord(string word)
    {
        if (_hidden)
        {
            //return as ____
            _scriptureWord = Regex.Replace(_scriptureWord, "[^0-9.]", "_");
        }
        else
        {
            _scriptureWord = _scriptureWord;
        }

        return _scriptureWord;
    }

}