using Foundation2;

namespace Foundation3;

public class ReceptionEvent : Event
{
    private string _email;
    
    public ReceptionEvent(string eventType, string eventTitle, string description, string time, string date, string email, Address address) : base(eventType, eventTitle, description,
        time, date, address)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return $" Registration E-mail: {_email}";
    }
    
}