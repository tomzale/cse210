using System;

// Base class for all activities.
// Stores date and length (minutes).
// Declares abstract methods for distance/speed/pace.
// Provides a single GetSummary() used by all derived classes.
public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    // Simple accessors (keeps members private).
    public string GetDate() => _date;
    public int GetLengthMinutes() => _lengthMinutes;

    // Derived classes must implement these (miles, mph, minutes per mile).
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // One place to make the summary string for all activities.
    // Uses the overriding methods above.
    public virtual string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string activityName = this.GetType().Name; // Running, Cycling, Swimming

        string distanceText = distance > 0 ? $"{distance:0.0}" : "0.0";
        string speedText = speed > 0 ? $"{speed:0.0}" : "0.0";
        string paceText = pace > 0 ? $"{pace:0.0}" : "N/A";

        return $"{GetDate()} {activityName} ({GetLengthMinutes()} min) - Distance {distanceText} miles, Speed {speedText} mph, Pace: {paceText} min per mile";
    }
}
