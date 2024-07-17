namespace Foundation4;

public class Cycling : Exercise
{
    private double _speed;
    private double _distance;
    
    public Cycling( string activity, double minutes, double speed, double distance) : base(activity, minutes)
    {
       _speed = speed;
       _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    
    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60/ CalculateSpeed();
    }


}