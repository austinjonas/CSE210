using System;

public class Program
{
    static void Main(string[] args)
    {
        //calling the class, allows the class to be used in this file.
        Journal newJournal = new();
        Journal displayJournal = new();

        List<string> prmpt = new List<string>();
        int option = 0;
        while (option != 5)
        {
            //put options here
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                newJournal.WriteJournal();
            }
            else if (option == 2)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Console.WriteLine($"Date: {dateText} - Prompt: ???");
                displayJournal.DisplayJournal();
            }
            else if (option == 3)
            {

            }
            else if (option == 4)
            {
                // saveToFile.SaveToFile()
            }
            else if (option == 5)
            {

            }
        }
    }
}