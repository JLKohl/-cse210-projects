using System;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   int userNumber;
        Prompt prompter = new Prompt();
        Journal journal = new Journal();

              

        Console.WriteLine(" ");
        Console.WriteLine("Welcome to the Journal Program!");

        while (true){
            Console.WriteLine("\nMenu: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            Console.Write("Which option do you choose(1-5)? ");
            String userInput = Console.ReadLine();
            Console.WriteLine(" ");


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
                Entry entry = new Entry();
                entry._prompt = prompter.DisplayPrompt();
                Console.WriteLine(entry._prompt);

                Console.Write("> ");
                
                entry._entry = Console.ReadLine();
                entry._date = DateTime.Now.ToString("MM/dd/yyyy");
                
                journal._entries.Add(entry);

            }
            else if (userNumber == 2 ){
                
                journal.DisplayEntries();
                
            }
            else if (userNumber == 3 ){

                Console.WriteLine("filename: ");
                string fileName = Console.ReadLine();


                journal.LoadFile(fileName);
                journal.DisplayEntries();               

            }
            else if (userNumber == 4){

                Console.WriteLine("filename: ");
                string fileName = Console.ReadLine();


                journal.SaveEntries(fileName);

                
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