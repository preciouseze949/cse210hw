public class SimpleGoal : Goal
{
    private int points;

    public SimpleGoal(string name, string description, int points) : base(name, description)
    {
        this.points = points;
    }

    public override void RecordEvent()
    {
        IsComplete = true;
    }

    public override int GetPoints()
    {
        return IsComplete ? points : 0;
    }

    public override string GetDetailsString()
    {
        return $"{(IsComplete ? "[X]" : "[ ]")} {Name} - {Description}";
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{Name}|{Description}|{points}|{IsComplete}";
    }
}
