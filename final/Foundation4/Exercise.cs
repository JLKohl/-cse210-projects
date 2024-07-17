namespace Foundation4;

public abstract class Exercise
{
    private string _date;
    protected double _minutes;
    private string _activity;

    public Exercise(string activity, double minutes)
    {
        _date = DateTime.Today.ToString("dd MMM, yyyy"); 
        _minutes = minutes;
        _activity = activity;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public string GetSummery()
    {
        return $"{_date} | {_activity} ({_minutes} min) -- Distance: {CalculateDistance().ToString("F2")} miles, Speed: {CalculateSpeed().ToString("F2")}mph, Pace: {CalculatePace().ToString("F2")} min per mile";
    }

}