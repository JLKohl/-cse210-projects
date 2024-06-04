
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference()
    {
        _book = "unknown";
        _chapter = 0;
        _startVerse = 0;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        string text = $"{_book} {_chapter}:{_startVerse}";
        return text;
    }

    public string GetReferenceRange()
    {
        string text = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        return text;
    }
}