class OutdoorGathering : Event
{
    public string _weather = "";
    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public new void DisplayFull()
    {
        Console.Write(base.DisplayFull());
        Console.WriteLine($"The weather for the outdoor gathering will be: {_weather}.");
    }
    public new void DisplayShort()
    {
        base.DisplayShort(GetEventType(), GetEventTitle(), GetDate());
    }
    public new void DisplayStandard()
    {
        string standardDetails = base.DisplayStandard(GetEventTitle(), GetEventDescription(), GetDate().ToString(), GetEventAddress().FullAddress());
        Console.WriteLine(standardDetails);
    }
}