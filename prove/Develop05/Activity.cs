using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {Name}...");
        Console.WriteLine(Description);
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    public void End()
    {
        Console.WriteLine($"Well done! You completed the {Name} for {Duration} seconds.");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{new string('.', 3 - i % 4)}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
