class Lecture : Event
{
    private string _speaker = "";
    private int _capacity;

    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public new void DisplayFull()
    {
        Console.Write(base.DisplayFull());
        Console.Write($"Lecture will be given by: {_speaker}\nBuilding capacity is {_capacity}");
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