// Activity.cs
public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected int GetMinutes() => _minutes; // Method to access minutes

    public abstract double GetDistance(); // Abstract method for distance
    public abstract double GetSpeed();    // Abstract method for speed
    public abstract double GetPace();     // Abstract method for pace

    public virtual string GetSummary()
    {
        return $"{_date} - Duration: {_minutes} min";
    }
}
