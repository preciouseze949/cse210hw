using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore;

    public void CreateGoal(Goal goal)
    {
        goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        Goal goal = goals[goalIndex];
        goal.RecordEvent();
        totalScore += goal.GetPoints();
        Console.WriteLine($"Event recorded for goal: {goal.Name}");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine($"\nTotal Score: {totalScore}\n");
    }

    public void SaveGoals(string filePath)
    {
        using StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine($"TotalScore|{totalScore}");
        foreach (Goal goal in goals)
        {
            writer.WriteLine(goal.GetSaveString());
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using StreamReader reader = new StreamReader(filePath);
        string line;
        Console.WriteLine("Loading goals from file:");
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split('|');
            if (parts[0] == "TotalScore")
            {
                totalScore += int.Parse(parts[1]); // Add to existing total score
            }
            else
            {
                Goal goal = parts[0] switch
                {
                    "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { IsComplete = bool.Parse(parts[4]) },
                    "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])) { IsComplete = bool.Parse(parts[4]) },
                    "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])) { IsComplete = bool.Parse(parts[6]) },
                    "FinancialGoal" => new FinancialGoal(parts[1], parts[2], int.Parse(parts[3]), decimal.Parse(parts[4])) { IsComplete = bool.Parse(parts[5]) },
                    _ => null
                };
                if (goal != null)
                {
                    goals.Add(goal);
                }
            }
        }

        Console.WriteLine("Goals loaded successfully!");
        DisplayGoals(); // Show loaded goals to the user
    }

    public int GetTotalScore()
    {
        return totalScore;
    }
}
