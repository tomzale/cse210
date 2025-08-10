// Cycling stores speed (mph) explicitly.
// Distance = speed * time(in hours).
public class Cycling : Activity
{
    private double _speedMph;

    public Cycling(string date, int lengthMinutes, double speedMph)
        : base(date, lengthMinutes)
    {
        _speedMph = speedMph;
    }

    public override double GetDistance()
    {
        double minutes = GetLengthMinutes();
        return (_speedMph * minutes) / 60.0;
    }

    public override double GetSpeed() => _speedMph;

    public override double GetPace()
    {
        if (_speedMph <= 0) return 0;
        return 60.0 / _speedMph; // minutes per mile
    }
}
