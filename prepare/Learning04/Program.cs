using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment one = new Assignment("Jennifer Kohl", "Art History");

        Console.WriteLine(one.GetSummery());

        MathAssignment two = new MathAssignment("Jason Kohl", "Cool People", "7.5", "10-35");
        Console.WriteLine(two.GetSummery());
        Console.WriteLine(two.GetHomeworkList());

        WritingAssigment three = new WritingAssigment("Joseph Kohl", "getting buff", "I am the strongest kid");
        Console.WriteLine(three.GetSummery());
        Console.WriteLine(three.GetWritingInformation());
    }
}