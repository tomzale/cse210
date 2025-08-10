// Simple goal: can be completed once for points.
public class SimpleGoal : Goal
{
    private int _points;
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description)
    {
        _points = points;
        _isComplete = false;
    }

    // record event: if not done, mark done and return points
    public override int RecordEvent()
    {
        if (_isComplete) return 0;
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatusString()
    {
        string box = _isComplete ? "[X]" : "[ ]";
        return $"{box} {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        // Simple|name|description|points|isComplete
        return $"Simple|{GetName()}|{GetDescription()}|{_points}|{_isComplete}";
    }

    // helper for loading: mark as complete without awarding points
    public void ForceComplete() => _isComplete = true;
}
