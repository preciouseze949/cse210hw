public class EternalGoal : Goal
{
    private int points;

    public EternalGoal(string name, string description, int points) : base(name, description)
    {
        this.points = points;
    }

    public override void RecordEvent()
    {
        // Eternal goals do not mark as complete
    }

    public override int GetPoints()
    {
        return points;
    }

    public override string GetDetailsString()
    {
        return $"{(IsComplete ? "[X]" : "[ ]")} {Name} - {Description} (Eternal)";
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{Name}|{Description}|{points}|{IsComplete}";
    }
}
