using System;

class Program
{
    static void Main(string[] args)
    {   
        
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = string.Empty;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }    
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        } 
        else if(grade < 60)
        {
            letter = "F";
        }
        int remainder = grade % 10;
        string sign = string.Empty;

        if (remainder >=7){
            sign = "+";
        }
        if (remainder <3){
            sign = "-";
        }
        Console.WriteLine($"You got an  {letter}{sign}.");

        if (grade >= 70)
        {
            Console.WriteLine($"Congratualtions you passed!");
        }
        else 
        {
            Console.WriteLine($"Unfortunatly you did not pass, but your hair looks great!");
        }
    }
}