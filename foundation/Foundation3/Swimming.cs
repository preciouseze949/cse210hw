// Swimming.cs
public class Swimming : Activity
{
    private int _numberOfLaps; // number of laps

    public Swimming(string date, int minutes, int numberOfLaps) : base(date, minutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return (_numberOfLaps * 50) / 1000.0; // Convert laps to kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60; // kph
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance(); // min per km
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Swimming - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
