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

        Scripture one = new Scripture();

        one.LoadScripture(scripture);

        Scripture construction = new Scripture();
       
        Console.WriteLine($"{reference.GetReference()}: {construction.ConstructScripture(one.LoadScripture(scripture))}");


    

        //runtime loop while for enter 

        // while{
             
        // }

    }
}