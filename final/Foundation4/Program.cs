using System;
using Foundation4;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();
        
        Running running = new Running("Running",89, 3);
        Swimming swimming = new Swimming("Swimming", 60, 20);
        Cycling cycling = new Cycling("Cycling", 90, 11, 2.5);
        exercises.Add(running);
        exercises.Add(swimming);
        exercises.Add(cycling);
        
        

        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummery());
        }
       
    }
}