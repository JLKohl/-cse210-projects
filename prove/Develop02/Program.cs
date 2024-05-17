using System;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Welcome to the Journal Program!");

        while (true){
            Console.WriteLine(" ");
            Console.WriteLine("menu: \n\n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            Console.Write("Which option do you choose(1-5)? ");
            String userInput = Console.ReadLine();
            Console.WriteLine(" ");
            int userNumber;

            try
            {
               userNumber = int.Parse(userInput); 
            }
            catch (System.Exception)
            {
                Console.WriteLine("invalid input, please try again.");
                continue;
            }
    
            if (userNumber == 1){
            
                Prompt newPrompt = new Prompt();
                Console.WriteLine(newPrompt.DisplayPrompt());

                Entry newEntery = new Entry();
                
                Console.Write("> ");
                newEntery._entries = Console.ReadLine();
                Console.WriteLine(" ");

            }
            else if (userNumber == 2 ){
                
                Journal journalEntres = new Journal();

                journalEntres.DisplayEntries();

            }
            else if (userNumber == 3 ){
                Console.WriteLine("three");

            }
            else if (userNumber == 4){
                Console.WriteLine("four");
            }
            else if (userNumber == 5){
                break;
            }
            else{
                Console.WriteLine("invalid input, please try again.");
            }
        }

        Console.WriteLine("now exiting program...");


    }
}