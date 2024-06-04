using System;
using System.Runtime.InteropServices;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        string scripture = "And it came to pass that he was obedient unto the word of the Lord, "+
        "wherefore he did as the Lord commanded him.";

        Scripture one = new Scripture();

        one.LoadScripture(scripture);

        Scripture construction = new Scripture();

        Console.Write(construction.ConstructScripture(one.LoadScripture(scripture)));


    

        //runtime loop while for enter 

        // while{
             
        // }

    }
}