// Eternal goal: never complete, you get points every time
public class EternalGoal : Goal
{
    private int _pointsPerEvent;

    public EternalGoal(string name, string description, int pointsPerEvent) : base(name, description)
    {
        _pointsPerEvent = pointsPerEvent;
    }

    public override int RecordEvent()
    {
        // always award points
        return _pointsPerEvent;
    }

    public override bool IsComplete() => false;

    public override string GetStatusString()
    {
        return $"[∞] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        // Eternal|name|description|points
        return $"Eternal|{GetName()}|{GetDescription()}|{_pointsPerEvent}";
    }
}
