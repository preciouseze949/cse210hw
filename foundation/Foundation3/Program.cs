// Program.cs
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create activities
        activities.Add(new Running("03 Nov 2022", 30, 3.0)); // 3 miles
        activities.Add(new Cycling("03 Nov 2022", 45, 15.0)); // 15 mph
        activities.Add(new Swimming("03 Nov 2022", 30, 20)); // 20 laps

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
