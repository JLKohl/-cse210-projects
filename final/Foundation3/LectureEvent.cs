namespace Foundation3;

public class LectureEvent : Event
{
    private string _lecture;
    private int _capacity;

    public LectureEvent(string eventType, string eventTitle, string description, string time, string date, string lecture, int capacity, Address address) : base( eventType, eventTitle, description,
        time, date, address)
    {
        _lecture = lecture;
        _capacity = capacity;
    }

    public override string EventDetails()
    {
        return $"Lecture: {_lecture} \n Event Capacity: {_capacity} ";
    }
    
}