using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        Start();
        int timer = 0;
        while (timer < Duration)
        {
            Console.WriteLine("Breathe in...");
            Pause(4);
            Console.WriteLine("Breathe out...");
            Pause(4);
            timer += 8; // Each breathe in/out cycle takes 8 seconds
        }
        End();
    }
}
