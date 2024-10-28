public class FinancialGoal : Goal
{
    private int points;
    private decimal financialTarget;

    public FinancialGoal(string name, string description, int points, decimal financialTarget) : base(name, description)
    {
        this.points = points;
        this.financialTarget = financialTarget;
    }

    public override void RecordEvent()
    {
        IsComplete = true;
    }

    public override int GetPoints()
    {
        return points;
    }

    public override string GetDetailsString()
    {
        return $"{(IsComplete ? "[X]" : "[ ]")} {Name} - {Description} (Financial Goal: Target {financialTarget:C})";
    }

    public override string GetSaveString()
    {
        return $"FinancialGoal|{Name}|{Description}|{points}|{financialTarget}|{IsComplete}";
    }
}
