using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 6);

        int guess = 0;
        
        while ( guess!= magicNumber)
        {
            Console.Write("What is your guess ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magicNumber)
            {
                Console.WriteLine("That's correct!");
            }
            else if (guess <= magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess >= magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }
    }
}