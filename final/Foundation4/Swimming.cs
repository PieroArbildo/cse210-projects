public class Swimming : Activity 
{
 private int _Laps;

    public Swimming(string Date, int DurationMinutes, int Laps) 
        : base(Date, DurationMinutes)
    {
        _Laps = Laps;
        _DurationMinutes = DurationMinutes;
    }

    public override double GetDistance()
    {
        double distanceKm = _Laps * 50 / 1000;
        return distanceKm;
    }

    public override double GetSpeed()
    {
        double distanceKm = GetDistance();
        double speedKph = distanceKm / _DurationMinutes * 60;
        return speedKph;
    }

    public override double GetPace()
    {
        double distanceKm = GetDistance();
        double paceMinPerKm = _DurationMinutes / distanceKm;
        return paceMinPerKm;
    }

    public override string GetSummary()
    {
        double distanceKm = GetDistance();
        double speedKph = GetSpeed();
        double paceMinPerKm = GetPace();

        return $"{base.GetSummary()} Swimming - Distancia: {distanceKm} km, Velocidad: {speedKph} kph, Ritmo: {paceMinPerKm} min/km";
    }

}