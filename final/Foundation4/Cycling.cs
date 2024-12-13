class Cycling : Activity
{
    public override double CalculateActivityTime(int distance, int speed)
    {
        return (double)distance / speed * 60;
    }
    public override double CalculateDistance(int pace, int activityTimeMinutes)
    {
        return (double)activityTimeMinutes * pace / 60;
    }
    public override double CalculateSpeed(int pace)
    {
        return (double)60 / pace;
    }

    public override double CalculatePace(int activityTimeMinutes, int distance)
    {
       return (double)activityTimeMinutes / distance;
    }
    public override string WriteSummary()
    {
        return $"\n{GetDateTime().ToString("dd MMM yyyy")} Cycling ({CalculateActivityTime(GetDistance(),GetSpeed())} min)-Distance {GetDistance()}, Speed {GetSpeed()} MPH, Pace: {GetPace()} minutes per {GetUnitOfMeasurement()}\n";
    }
}
