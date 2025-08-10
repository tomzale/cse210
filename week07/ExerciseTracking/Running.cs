// Running stores distance (miles) explicitly.
public class Running : Activity
{
    private double _distanceMiles;

    public Running(string date, int lengthMinutes, double distanceMiles)
        : base(date, lengthMinutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance() => _distanceMiles;

    public override double GetSpeed()
    {
        double minutes = GetLengthMinutes();
        if (minutes <= 0 || _distanceMiles <= 0) return 0;
        return (_distanceMiles / minutes) * 60.0; // mph
    }

    public override double GetPace()
    {
        if (_distanceMiles <= 0) return 0;
        return (double)GetLengthMinutes() / _distanceMiles; // min per mile
    }
}
