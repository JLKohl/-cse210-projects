
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    

    public Reference(string book, int chapter, int startVerse)
    {
        CreateReference(book, chapter, startVerse, startVerse);
    }
    
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        CreateReference(book, chapter, startVerse, endVerse);
    }

    public void CreateReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        string text; 
        
        if ( _endVerse == _startVerse)
        {
          text = $"{_book} {_chapter}:{_startVerse}";           
        }
        else
        {
           text = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }

        return text;
    }
    
}