using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do{   
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(0, 101);

            int userGuess;

            do{
                Console.Write("what is your guess? ");
                string userNumberGuess = Console.ReadLine();
                userGuess = int.Parse(userNumberGuess);

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            }while(userGuess != magicNumber);

            if (userGuess == magicNumber)
            {
                Console.WriteLine("you guessed it!");
            }

            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine();
        }while(playAgain == "yes");
    }   


}