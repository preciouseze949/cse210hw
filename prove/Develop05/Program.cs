using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine()!;

            if (choice == "1")
            {
                var breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                var reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (choice == "3")
            {
                var listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program! Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}
