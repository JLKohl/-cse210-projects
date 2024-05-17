using System;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("menu: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
        Console.Write("Which option do you choose(1-5)? ");
        String userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);

      
        if (userNumber == 1){
            Console.WriteLine("one");

            Prompt newPrompt = new Prompt();
            newPrompt.DisplayPrompt();

            Entries entery = new Entries();
            
            Console.Write("> ");
            entery._entries = Console.ReadLine();

        }
        else if (userNumber == 2 ){
            Console.WriteLine("two");

        }
        else if (userNumber == 3 ){
            Console.WriteLine("three");

        }
        else if (userNumber == 4){
            Console.WriteLine("four");
        }




    }
}