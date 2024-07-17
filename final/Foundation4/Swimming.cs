namespace Foundation4;

public class Swimming : Exercise
{
    private double _laps;
    
    public Swimming( string activity, double minutes, double laps) : base(activity, minutes)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    
    public override double CalculateSpeed()
    {
        return (CalculateDistance() / _minutes) * 60 ;
    }

    public override double CalculatePace()
    {
        return 60/ CalculateSpeed();
    }
}