namespace Foundation4;

public class Cycling : Exercise
{
    private double _speed;
  
    public Cycling( string activity, double minutes, double speed) : base(activity, minutes)
    {
       _speed = speed;
    }

    public override double CalculateDistance()
    {
        return 0;
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