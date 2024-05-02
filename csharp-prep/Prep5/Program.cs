using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("welcome to the program!");
        }
        DisplayWelcome();

        static string PromptUserName()
        {
            Console.Write("what is your name? ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("what is your favorite number? ");
            string userInput = Console.ReadLine();
            int favoriteNumber = int.Parse(userInput);

            return favoriteNumber;
        }

        static int SquareNumber(int number){
            return number * number;
        }
   
        static void DisplayResults(string name, int number){
               Console.WriteLine($"{name}, the square of your number is {number}");
        }
        DisplayResults(PromptUserName(), SquareNumber(PromptUserNumber()));
    }
}