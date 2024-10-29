// Cycling.cs
public class Cycling : Activity
{
    private double _speed; // speed in mph

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (GetSpeed() * GetMinutes()) / 60; // Calculate distance based on speed and time
    }

    public override double GetSpeed()
    {
        return _speed; // mph
    }

    public override double GetPace()
    {
        return 60 / _speed; // min per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Cycling - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
