public class ChecklistGoal : Goal
{
    private int points;
    private int targetCount;
    private int bonusPoints;
    private int currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description)
    {
        this.points = points;
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        currentCount = 0;
    }

    public override void RecordEvent()
    {
        currentCount++;
        if (currentCount >= targetCount)
        {
            IsComplete = true;
        }
    }

    public override int GetPoints()
    {
        return IsComplete ? points + bonusPoints : points;
    }

    public override string GetDetailsString()
    {
        return $"{(IsComplete ? "[X]" : "[ ]")} {Name} - {Description} (Completed {currentCount}/{targetCount} times)";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{Name}|{Description}|{points}|{targetCount}|{bonusPoints}|{IsComplete}";
    }
}
