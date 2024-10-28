using System;

public static class GoalFactory
{
    public static Goal CreateGoal()
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Financial Goal");
        Console.Write("Select an option: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                return new SimpleGoal(name, description, points);
            case "2":
                return new EternalGoal(name, description, points);
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                return new ChecklistGoal(name, description, points, targetCount, bonusPoints);
            case "4":
                Console.Write("Enter financial target amount: ");
                decimal financialTarget = decimal.Parse(Console.ReadLine());
                return new FinancialGoal(name, description, points, financialTarget);
            default:
                Console.WriteLine("Invalid choice. Returning to menu.");
                return null;
        }
    }
}
