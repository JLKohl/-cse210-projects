
using System.Security.Cryptography;

public class Journal{

    public string _write;
    public List<Entry> _entries = new List<Entry>();
    public string _fileName;   

    public void DisplayEntries(){

        Console.WriteLine($"{_entries}");

        foreach (Entry entries in _entries)
        {
            entries.Display();
        }

    }

    public void SaveFile(){
        
    }
    
    public void LoadFile(){

    }

    public void Quit(){

    }

}