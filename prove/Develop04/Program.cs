using System;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {

        bool stop = false;
        do
        {
            Activities activity = new Activities();
            activity.StartProgram();
            string _userInput = Console.ReadLine();
            
            Breathing _breathingActivity = new(); 
            
            switch (_userInput)
            {
                case "1":
                    string welcomeMessage = _breathingActivity.GetStartingMessage();
                    _breathingActivity.DisplaySpinner(2);
                    Console.WriteLine(welcomeMessage);
                    Console.WriteLine();
                    Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.");
                    _breathingActivity.DisplaySpinner(5);
                    Thread.Sleep(1000);
                    _breathingActivity.StartBreathingActivity();
                    break;
    
                case "2":
                    Console.WriteLine("Listening activity selected");
                    break;
                case "3":
                    Console.WriteLine("Listening activity selected");
                    break;
                case "q":
                    stop = true;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        } while (!stop);

        Console.WriteLine("Program stopped.");

    }
}
