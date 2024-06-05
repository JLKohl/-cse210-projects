
using System.Threading.Tasks.Dataflow;
using System.Text.RegularExpressions;
using System.Reflection.Metadata.Ecma335;

public class Word
{
    
    private string _scriptureWord;//place word objects as string into this
    private bool _hidden = false;

    public Word(string word)
    {
        _scriptureWord =  word;
    }

    public string GetWord()
    {
        if (_hidden)
        {
            //return as ____
            return Regex.Replace(_scriptureWord, "[^0-9.]", "_");
        }
        else
        {
            return _scriptureWord;
        }

    }

    public void SetHidden(bool hidden){

        this._hidden = hidden;
    }

}