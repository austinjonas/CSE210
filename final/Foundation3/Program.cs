using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Lecture newLecture = new Lecture();
        Address addressBook = new Address();
        newLecture.SetEventAddress("184 W N St.", "American Fark", "UT", "America");
        newLecture.SetCapacity(1000);
        newLecture.SetEventDescription("This is a really good event with a really long speech");
        newLecture.SetDate(new DateTime(2024, 12, 17));
        newLecture.SetEventTitle("Ted talk");
        newLecture.SetEventType("Lecture");
        newLecture.SetSpeaker("Arnold Schwarznigger");
        Console.WriteLine();
        newLecture.DisplayFull();
        Console.WriteLine();
        newLecture.DisplayShort();
        Console.WriteLine();
        newLecture.DisplayStandard();
        

        Reception reception = new Reception();
        reception.SetDate(DateTime.Now); // we could change this to be whenever.
        reception.SetEventDescription("Wedding Reception");
        reception.SetEventAddress("432 Butt lane", "Highland", "Utah", "America");
        reception.SetEventTitle("Austin's wedding reception");
        reception.SetEventType("Reception");
        reception.SetRsvp("RSVP@gmail.com");   
        Console.WriteLine();
        reception.DisplayFull();
        Console.WriteLine();
        reception.DisplayShort();
        Console.WriteLine();
        reception.DisplayStandard();       

        OutdoorGathering og = new OutdoorGathering();
        og.SetDate(DateTime.Now); // we could change this to be whenever.
        og.SetEventDescription("this is a peace gathering in public");
        og.SetEventAddress("234 Cool st.", "Rexburg", "Idaho", "America");
        og.SetEventTitle("Outdoor Gathering.");
        og.SetEventType("Outdoor Gathering.");
        og.SetWeather("Bright and sunny, 85 degrees.");
        Console.WriteLine();
        og.DisplayFull();
        Console.WriteLine();
        og.DisplayShort();
        Console.WriteLine();
        og.DisplayStandard();
    }
}