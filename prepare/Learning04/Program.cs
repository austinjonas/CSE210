using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // creates a new list called "numbers"
        List<int> numbers = new List<int>();

        int inputNumber = -1;
        while (inputNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");   
            //user input option that converts their input to an int.
            string input = Console.ReadLine();
            inputNumber = int.Parse(Console.ReadLine());
            
            //adds numbers to the list
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
            
        }
        
        //compute and print the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}. ");
        
        //compute the average
        //this sets the word average as a float variable, after the =, it runs the
        //previously made sum as a float, then counts the total items in the numbers list
        //by using the .Count operation.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}. ");

        //compute and print the max
        int maxNumber = numbers.Max();
        Console.WriteLine($"The max is {maxNumber} ");


        
    }
}