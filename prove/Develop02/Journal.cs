
using System.Security.Cryptography;
using  System.IO;

public class Journal{

    // public string _write;
    public List<Entry> _entries = new List<Entry>();


    public void DisplayEntries(){

        foreach (Entry entries in _entries)
        {
            entries.Display();
        }

    }

    public void SaveEntries(string filename){

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._entry}");
            }
            
        }
    }
    
    public void LoadFile(string filename)
    {

        string[] lines = System.IO.File.ReadAllLines(filename);

        _entries.Clear();
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            Entry entry = new Entry();

            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];

            _entries.Add(entry);
        }
           
    }


}