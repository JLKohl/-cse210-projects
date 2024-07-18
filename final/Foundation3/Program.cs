using System;
using Foundation3;

class Program
{
    static void Main(string[] args)
    {

        LectureEvent lecture = new LectureEvent("Lecture","The most effective Ways to Stay Happy", "Mental health experts from around the world will be sharing the top ways to keep an upbeat attitude.", "10:30am",
            "11/21/2988", "Happiness Day to Day", 230, new Address("105 Hampton Dr.", "Springfiled", "MO", 24333));

        ReceptionEvent reception = new ReceptionEvent("Reception","Area Artist Meet-up", "Come join us in meeting the area artist, mix and mingle and make some friends", "11:00 am", "07/15/2987", "thisisanemail@gmail.com", new Address("230 Terrace Hights", "Battlefiled", "VA", 65714));

        OutdoorEvent outdoor = new OutdoorEvent("Outdoor Event","County School Fair", "Come support the local County School in a fun out Family Fair. All funds go to school programs", "12:00pm",
            "5/20/2988", "75℉, sunny", new Address("6000 W Stuart Ln", "Galax", "CA", 90210));

        List<Event> events = new List<Event>();
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);
        
        Console.WriteLine("------------Standard Details-------------");
        
        foreach(Event evt in events)
        {
            Console.WriteLine(evt.StandardEvent());
        }

        Console.WriteLine("------------Short Description-------------");


        foreach (Event evt in events)
        {
            Console.WriteLine(evt.ShortDescription());
        }
        
        Console.WriteLine("-------------Full Details------------");
        
        foreach(Event evt in events)
        {
            Console.WriteLine(evt.DetailedEvent());
        }

    }
}