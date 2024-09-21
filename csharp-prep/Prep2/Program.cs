using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Hello! I want to tell you your letter grade. Type in your % here: ");
        string gradeNumber = Console.ReadLine();
        int number = int.Parse(gradeNumber);

        string letter = "";

        if (number >= 90)
        {
            letter = "A"; 
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number <= 59)
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade letter is: {letter}.");
        
        if (number <= 70)
        {
            Console.WriteLine("You have failed the class and will need to take the course again.");
            Console.WriteLine("");
        }
        if (!(number <=70))
        {
            Console.WriteLine("You passed the class!");
            Console.WriteLine("");
        }
    }
}