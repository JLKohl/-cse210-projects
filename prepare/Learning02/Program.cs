using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();

       job1._jobTitle = "Software Engineer";
       job1._company = "Disney";
       job1._startYear = 2040;
       job1._endYear = 2100;

       Job job2 = new Job();

       job2._jobTitle = "Mom";
       job2._company = "Kohl House";
       job2._startYear = 2010;
       job2._endYear = 3000;

       job1.Display();
       job2.Display();
;
    }
}