using System;

public class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("=== Eternal Quest Program ===");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal(GoalFactory.CreateGoal());
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    Console.Write("Enter goal number to record an event: ");
                    if (int.TryParse(Console.ReadLine(), out int goalIndex))
                    {
                        goalManager.RecordEvent(goalIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid goal number.");
                    }
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    Console.Write("Enter filename to save goals: ");
                    string saveFilePath = Console.ReadLine();
                    goalManager.SaveGoals(saveFilePath);
                    break;
                case "5":
                    Console.Write("Enter filename to load goals: ");
                    string loadFilePath = Console.ReadLine();
                    goalManager.LoadGoals(loadFilePath);
                    break;
                case "6":
                    exitProgram = true;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
