
using System.Reflection.Metadata.Ecma335;

public class Entry {

    public string _entry;
    public string _date;
    public string _prompt;


    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt} \n{_entry}");
    }
    
}