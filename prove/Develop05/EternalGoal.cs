class EternalGoal : Goal
{
    // Eternal goal completion and points added
    public EternalGoal() : base() {}
    public EternalGoal(string[] parts) : base(parts) {}
    public override int CompleteGoal()
    {
        return GetPoints();
    }
}