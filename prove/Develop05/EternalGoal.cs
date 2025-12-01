class EternalGoal : Goal
{
    public EternalGoal() : base() {}
    public EternalGoal(string[] parts) : base(parts) {}
    public override int CompleteGoal()
    {
        return GetPoints();
    }
}