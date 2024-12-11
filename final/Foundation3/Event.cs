using System.Dynamic;

public abstract class Event
{
    private string _eventTitle = "";
    private string _eventDescription = "";
    private DateTime _eventDate;
    private string _eventType = "";
    private Address _eventAddress;

    protected Address GetEventAddress()
    {
        return _eventAddress;
    }

    public Event()
    {
        _eventAddress = new Address();
    }


    //Event Title
    protected string GetEventTitle()
    {
        return _eventTitle;
    }
    public void SetEventTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }

    // event description
    public string GetEventDescription()
    {
        return _eventDescription;
    }
    public void SetEventDescription(string eventDescription)
    {
        _eventDescription = eventDescription;
    }

    public DateTime GetDate()
    {
        return _eventDate;
    }
    public void SetDate(DateTime eventDate)
    {
        _eventDate = eventDate;
    }

    public string GetEventType()
    {
        return _eventType;
    }
    public void SetEventType(string eventType)
    {
        _eventType = eventType;
    }

    public void SetEventAddress(string street, string city, string state, string country)
    {
        _eventAddress.AddAddress(street, city, state, country);
    }

    protected string DisplayStandard(string eventTitle, string eventDescription, string eventDate, string eventAddress)
    {
        Console.WriteLine($"-----Standard {_eventType} ad-----");
        return $"Title:{eventTitle}.\nDescription: {eventDescription}.\nDate/Time: {eventDate}., \nAddress: {_eventAddress.FullAddress()}.";
    }

    protected string DisplayFull()
    {
        Console.WriteLine($"-----Full {_eventType} ad-----");
        return $"{_eventTitle}, {_eventDescription}, {_eventDate}, {_eventAddress.FullAddress()})";
    }

    protected void DisplayShort(string eventType, string eventTitle, DateTime dateTime)
    {
        Console.WriteLine($"-----Short {_eventType} ad-----");
        Console.WriteLine($"Short Message:Type of event: {eventType}, Event title: {eventTitle}, Date: {dateTime.ToShortDateString()}");
    }
}