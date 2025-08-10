// Swimming stores number of laps (50 meters each).

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distanceKm = _laps * 50.0 / 1000.0;
        double distanceMiles = distanceKm * 0.62; 
        return distanceMiles;
    }

    public override double GetSpeed()
    {
        double minutes = GetLengthMinutes();
        double distance = GetDistance();
        if (minutes <= 0 || distance <= 0) return 0;
        return (distance / minutes) * 60.0;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        if (distance <= 0) return 0;
        return (double)GetLengthMinutes() / distance;
    }
}
