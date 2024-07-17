namespace Foundation4;

public class Running : Exercise
{
    private double _distance;

    public Running( string activity, int minutes, int distance) : base(activity, minutes)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double CalculatePace()
    {
        return 60/ CalculateSpeed();
    }


}