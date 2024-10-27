using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(2);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(1, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1000, 342342);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


        
    }
    
}


//random number guesser program:
// Random randomGenerator = new Random();
        // int magicNumber = randomGenerator.Next(1, 100);

        // int guess = 0;
        
        // while ( guess!= magicNumber)
        // {
        //     Console.Write("What is your guess ");
        //     guess = int.Parse(Console.ReadLine());

        //     if (guess == magicNumber)
        //     {
        //         Console.WriteLine("That's correct!");
        //     }
        //     else if (guess <= magicNumber)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else if (guess >= magicNumber)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        // }