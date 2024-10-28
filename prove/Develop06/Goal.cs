public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsComplete { get; set; }

    public Goal(string name, string description)
    {
        Name = name;
        Description = description;
        IsComplete = false;
    }

    public abstract void RecordEvent();
    public abstract int GetPoints();
    public abstract string GetDetailsString();
    public abstract string GetSaveString();
}
