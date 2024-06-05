using System;
using System.Runtime.InteropServices;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        string scripture = "Therefore, let your hearts be comforted concerning Zion;"+
        "for all flesh is in mine hands; be still and know that I am God.";

        Reference reference = new Reference("D&C", 101, 16);

        reference.GetReference();



        Console.WriteLine("\ntest one -----------------------------------------");
        Scripture one = new Scripture();
        one.LoadScripture(scripture);
        Console.Write(one.ConstructScripture());


        Console.WriteLine("\ntest two -----------------------------------------");
        Scripture two = new Scripture();
        two.LoadScripture(scripture);
        two.RemoveRandomWords();
        Console.Write(two.ConstructScripture());




        //runtime loop while for enter 

        // while{
             
        // }

    }
}