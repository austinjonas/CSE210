using System;

class Program
{
    

    static void Main(string[] args)
    {
        DisplayMessage();
        
        string username = GetUserName("Please enter your name: ");
        int userNumber = FavoriteNumber();
        
        int squareNumber = SquareNumber(userNumber);
        
        DisplayResult(username, squareNumber);
         
    }    

    //this is the welcome message
    static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
    
    static string GetUserName(string prompt)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            
            return name;
        }

    static int FavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favNumber = Console.ReadLine();
        int number = int.Parse(favNumber);
        
        return number;

    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, your square number is {square}.");
    }
        
    
}