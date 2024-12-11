class Reception : Event
{
    private string _Rsvp;

    public string GetRsvp()
    {
        return _Rsvp;
    }
    public void SetRsvp(string rsvp)
    {
        _Rsvp = rsvp;
    }
    public new void DisplayFull()
    {
        Console.Write(base.DisplayFull());
        Console.WriteLine($"\n Please email: {_Rsvp} to RSVP.");
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