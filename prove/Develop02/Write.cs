using System;
using System.IO;

public class Write
{
    public void WriteJournal()
    {
    Console.WriteLine("Write here:");
    string userJournal = Console.ReadLine();

    // saves the entry as a file
    string filename = "myFile.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

        string firstName = parts[0];
        string lastName = parts[1];
    }
    }
}