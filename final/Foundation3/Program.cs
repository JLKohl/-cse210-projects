using System;
using Foundation2;
using Foundation3;

class Program
{
    static void Main(string[] args)
    {

        LectureEvent lecture = new LectureEvent("Lecture","The most effective Ways to Stay Happy", "Mental health experts from around the world will be sharing the top ways to keep an upbeat attitude.", "10:30am",
            "11/21/2988", "how to test code", 230, new Address("105 Hampton Dr.", "Springfiled", "MO", 24333));

        ReceptionEvent reception = new ReceptionEvent("Reception","reception test", "this is a test for the Reception", "11:00 am", "07/15/2987", "thisisanemail@gmail.com", new Address("230 Terrace Hights", "Battlefiled", "VA", 65714));

        OutdoorEvent outdoor = new OutdoorEvent("Outdoor Event","Test Outdoor Event", "this is a test outdoor event", "12:00pm",
            "5/20/2988", "75℉, sunny", new Address("6000 W Stuart Ln", "Galax", "CA", 90210));
        
        Console.WriteLine("------------Standard Details-------------");
        Console.WriteLine(lecture.StandardEvent());
        Console.WriteLine("");
        Console.WriteLine(reception.StandardEvent());
        Console.WriteLine("");
        Console.WriteLine(outdoor.StandardEvent());
        Console.WriteLine("");
        Console.WriteLine("------------Short Description-------------");
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine("");
        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine("");
        Console.WriteLine(outdoor.ShortDescription());
        Console.WriteLine("");
        Console.WriteLine("-------------Full Details------------");
        Console.WriteLine(lecture.LectureDetails());
        Console.WriteLine(lecture.StandardEvent());
        Console.WriteLine("");
        Console.WriteLine(reception.GetEmail());
        Console.WriteLine(reception.StandardEvent());
        Console.WriteLine("");
        Console.WriteLine(outdoor.WeatherForecast());
        Console.WriteLine(outdoor.StandardEvent());
    }
}