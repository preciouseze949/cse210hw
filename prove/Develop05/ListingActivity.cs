using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public void Run()
    {
        Start();
        Random rand = new Random();
        int timer = 0;
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Pause(5); // Countdown for 5 seconds to think
        List<string> items = new List<string>();
        Console.WriteLine("Please start listing items. Type 'done' when finished.");

        while (timer < Duration)
        {
            string item = Console.ReadLine()!;
            if (item.ToLower() == "done") break;
            items.Add(item);
            timer += 1; // Assuming each item takes 1 second to input
        }
        Console.WriteLine($"You listed {items.Count} items.");
        End();
    }
}
