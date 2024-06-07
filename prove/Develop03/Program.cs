using System;
using System.Runtime.InteropServices;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        string text = "Therefore, let your hearts be comforted concerning Zion; "+
        "for all flesh is in mine hands; be still and know that I am God.";

        Reference reference = new Reference("D&C", 101, 16);
        
        Scripture scripture = new Scripture();
        scripture.LoadScripture(text);
        scripture.LoadReference("D&C", 101, 16);
        Console.WriteLine(scripture.GetScripture());
        
        Console.WriteLine("Press Enter to remove words or type 'quit' to end program.");
        string input = Console.ReadLine();

        while (input != "quit" && scripture.HasMoreWords())
        {
            
            scripture.RemoveRandomWords();
            Console.WriteLine(scripture.GetScripture());
            
            Console.WriteLine("Press Enter to remove words or type 'quit' to end program.");
            input = Console.ReadLine();
        }
        
    }
}
