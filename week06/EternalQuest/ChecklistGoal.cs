// Checklist: needs several completions; gives points each time and bonus at the end.
public class ChecklistGoal : Goal
{
    private int _pointsPerEvent;
    private int _requiredCount;
    private int _currentCount;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int pointsPerEvent, int requiredCount, int bonus) : base(name, description)
    {
        _pointsPerEvent = pointsPerEvent;
        _requiredCount = requiredCount;
        _bonus = bonus;
        _currentCount = 0;
        _isComplete = false;
    }

    // record event: increment progress, award points + possibly bonus
    public override int RecordEvent()
    {
        if (_isComplete) return 0;

        _currentCount++;
        int earned = _pointsPerEvent;

        if (_currentCount >= _requiredCount)
        {
            _isComplete = true;
            earned += _bonus;
        }

        return earned;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatusString()
    {
        string box = _isComplete ? "[X]" : "[ ]";
        return $"{box} {GetName()} ({GetDescription()}) - Completed {_currentCount}/{_requiredCount}";
    }

    public override string GetStringRepresentation()
    {
        // Checklist|name|description|pointsPer|required|current|bonus|isComplete
        return $"Checklist|{GetName()}|{GetDescription()}|{_pointsPerEvent}|{_requiredCount}|{_currentCount}|{_bonus}|{_isComplete}";
    }

    // helpers for loading
    public void ForceSetCurrent(int current) => _currentCount = current;
    public void ForceComplete() => _isComplete = true;
}
