using System;
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



        Scripture test = new Scripture();

        test.RemoveRandomWords(one.LoadScripture(scripture));


    

        //runtime loop while for enter 

        // while{
             
        // }

    }
}