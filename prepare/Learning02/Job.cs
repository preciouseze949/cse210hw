using System;
{
    
}
public class Job
{
    public string _jobTitle;
    public string _location;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company})) {_location} {_startYear}-{_endYear}");
    }
}