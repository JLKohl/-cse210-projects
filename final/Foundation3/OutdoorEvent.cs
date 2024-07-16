namespace Foundation3;

public class OutdoorEvent : Event
{
    private string _weather;
    public OutdoorEvent(string eventType, string eventTitle, string description, string time, string date, string weather, Address address) : base(eventType, eventTitle, description,
        time, date, address)
    {
        _weather = weather;
    }

    public string WeatherForecast()
    {
        return $" Forecast for event: {_weather} ";
    }
    
}