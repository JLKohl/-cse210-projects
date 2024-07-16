

namespace Foundation3;

public class Event
{
    private string _eventType;
    private string _eventTitle;
    private string _description;
    private string _time;
    private string _date;
    private Address _address;

    public Event(string eventType, string eventTitle, string description, string time, string date, Address address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _time = time;
        _date = date;
        _address = address;
    }
    
    public string StandardEvent()
    {
        return $" Event Title: {_eventTitle} \n Description: {_description} \n Start Time: {_time} \n Date: {_date} \n Address: {_address.GetAddress()}";
    }
    
    

    public string ShortDescription()
    {
        return $" Event Type: {_eventType} \n Event Title: {_eventTitle} \n Date: {_date} ";
    }
    
}