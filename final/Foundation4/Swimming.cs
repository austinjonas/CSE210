class Swimming : Activity
{
    private int _swimmingLaps;
    public int GetSwimmingLaps()
    {
        return _swimmingLaps;
    }
    public void SetSwimmingLaps(int swimmingLaps)
    {
        _swimmingLaps = swimmingLaps;
    }

    public override double CalculateActivityTime(int distance, int speed)
    {
        return (double)distance / speed * 60;
    }
    public override double CalculateDistance(int pace, int activityTimeMinutes)
    {
        return (double)GetSwimmingLaps() * 50 / 1000 *.62;
    }
    public override double CalculateSpeed(int pace)
    {
        return (double)(GetDistance() / GetActivityTimeMinutes() * 60) * 60;
    }

    public override double CalculatePace(int activityTimeMinutes, int distance)
    {
       return (double)activityTimeMinutes / (distance / 100);
    }
    public override string WriteSummary()
    {
        return $"\n{GetDateTime().ToString("dd MMM yyyy")} Swimming: ({CalculateActivityTime(GetDistance(),GetSpeed())} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} MPH, Pace: {GetPace()} minute(s) per {GetUnitOfMeasurement()}\n";
    }
}