public abstract class Activity
{
    private DateTime _dateTime;
    private int _activityTimeMinutes;
    private int _distance;
    private int _speed;
    private int _pace;
    private string _unitOfMeasurement;

    public virtual double CalculateActivityTime(int distance, int speed)
    {
        return 1;
    }

    public virtual double CalculateDistance(int pace, int activityTimeMinutes)
    {
        return 1;
    }

    public virtual double CalculateSpeed(int speed)
    {
        return 1;
    }

    public virtual double CalculatePace(int activityTime, int activityTimeMinutes)
    {
        return 1;
    }

    public DateTime GetDateTime()
    {
        return _dateTime;
    }
    public void SetDateTime(DateTime dateTime)
    {
        _dateTime = dateTime;
    }

    public int GetActivityTimeMinutes()
    {
        return _activityTimeMinutes;
    }

    public void SetActivityTimeMinutes(int activityTimeMinutes)
    {
        _activityTimeMinutes = activityTimeMinutes;
    }
    public int GetSpeed()
    {
        return _speed;
    }
    public void SetSpeed(int speed)
    {
        _speed = speed;
    }
    public int GetDistance()
    {
        return _distance;
    }
    public void SetDistance(int distance)
    {
        _distance = distance;
    }
    public int GetPace()
    {
        return _pace;
    }
    public void SetPace(int pace)
    {
        _pace = pace;
    }

    public string GetUnitOfMeasurement()
    {
        return _unitOfMeasurement;
    }
    public void SetUnitOfMeasurement(string unitOfMeasurement)
    {
        _unitOfMeasurement = unitOfMeasurement;
    }

    public virtual string WriteSummary()
    {
        return $"";
    }

}