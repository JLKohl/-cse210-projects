using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.Write("Enter number: ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }while(userNumber != 0);

        
        Console.WriteLine($"the sum is {numbers.Sum()} ");
        Console.WriteLine($"the sum is {numbers.Average()} ");
        Console.WriteLine($"the sum is {numbers.Max()} ");

    }
}