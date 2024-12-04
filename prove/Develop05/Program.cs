using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static List<Goal> _goals = new List<Goal>();
    static List<Goal> _treasureChest = new List<Goal>();

    static void Main(string[] args)
    {
        int option = 0;
        while (option != 6)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create a new goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        option = int.Parse(Console.ReadLine());
        
        if (option == 1)
        {
            CreateGoal();
        }
        else if (option == 2)
        {
            ListGoals();
        }
        else if (option == 3)
        {
            SaveGoals();
        }
        else if (option == 4)
        {
            LoadGoals();
        }
        else if (option == 5)
        {
            RecordGoals();
        }
        else if (option == 6)
        {
            Console.WriteLine("Exiting...");
            Thread.Sleep(1000);
            Console.WriteLine("Program Ended!");
            Thread.Sleep(500);
            Console.Clear();
            Environment.Exit(0);
        }
    }
}

    static void CreateGoal()
    {
        Console.WriteLine("What Kind of Goal do you want to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        string _goalType = Console.ReadLine();

        Console.Write("Enter your goal name: ");
        string _goalName = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        string _goalDescription = Console.ReadLine();

        Console.WriteLine("Enter how many debloons this goal is worth: ");
        int _debloons; // = int.Parse(Console.ReadLine());
        while (!int.TryParse(Console.ReadLine(), out _debloons))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for debloons:");
        }
        
        // string _debloons = Console.ReadLine();
        // int.Parse(_debloons);

        if (_goalType == "1")
        {   
            SimpleGoals simpleGoal = new SimpleGoals(_goalName, _goalDescription, _debloons);
            _goals.Add(simpleGoal);
        }    
        if (_goalType == "2")
        {
            ChecklistGoals checklistGoal = new ChecklistGoals(_goalName, _goalDescription, _debloons);
            _goals.Add(checklistGoal);
        }
        if (_goalType == "3")
        {
            EternalGoal eternalGoal = new EternalGoal(_goalName, _goalDescription, _debloons);
            _goals.Add(eternalGoal);
        }
    }
    
    private static void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. [ ] {_goals[i].GetTitle()} ({_goals[i].GetDescription()})");
            Thread.Sleep(500);
        }   
    } 

    public static void SaveGoals()
        {
            string filename = "Goal.txt";

            using (StreamWriter output = new StreamWriter(filename))
            {
                foreach (var goal in _goals)
                {
                    output.WriteLine($"{goal.GetTitle()} |{goal.GetDescription()} |{goal.GetDebloons()}");
                }
                Console.WriteLine("Successfully saved your file!");
            }
        }
    public static void LoadGoals()
        {
        string filename = "Goal.txt";

            if (!File.Exists(filename))
            {
                Console.WriteLine("Goal file does not exist. Make sure to save goals before loading.");
                return;
            }

        _goals.Clear();

        Console.WriteLine("Loading goals from file... ");

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string goalTitle = parts[0].Trim();
                        string goalDescription = parts[1].Trim();
                        if (int.TryParse(parts[2].Trim(), out int debloons))
                        {
                            SimpleGoals loadedGoal = new SimpleGoals(goalTitle, goalDescription, debloons);
                            _goals.Add(loadedGoal);
                        }
                    }
                }
                Console.WriteLine("Goals successfully loaded:");
                ListGoals();
                }
            } // Display the loaded goals
            
            catch (Exception) 
            {
                Console.WriteLine($"Error reading the file");
            }         
        }
        
        public static void RecordGoals()
        {
            Console.WriteLine("Which goal would you like to report on?");
            LoadGoals(); // Display the current goals

            Console.WriteLine("Enter the number of the goal you've completed (or 0 to exit):");

            int userInput = -1;
            int totalDebloons = 0;

            while (userInput != 0)
            {
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    if (userInput == 0)
                    {
                        Console.WriteLine($"Exiting. Your total debloons: {totalDebloons}");
                        break;
                    }

                    if (userInput > 0 && userInput <= _goals.Count)
                    {
                        // Select the goal based on user input
                        Goal selectedGoal = _goals[userInput - 1];

                        // Check the type of goal and handle accordingly
                        if (selectedGoal is SimpleGoals simpleGoal)
                        {
                            if (simpleGoal.IfCompleted())
                            {
                                totalDebloons += simpleGoal.SetAward();
                                Console.WriteLine($"Great job! You earned {simpleGoal.GetDebloons()} debloons!");
                                _goals.Remove(selectedGoal); // Remove the goal once completed
                            }
                            else
                            {
                                Console.WriteLine("This goal is not yet completed.");
                            }
                        }
                        else if (selectedGoal is ChecklistGoals checklistGoal)
                        {
                            int bonusPoints = checklistGoal.AddBonusPoints();
                            totalDebloons += selectedGoal.SetAward();
                            Console.WriteLine($"Checklist goal completed! You earned {bonusPoints} debloons.");
                            _goals.Remove(selectedGoal); // Remove the goal once completed
                        }
                        else if (selectedGoal is EternalGoal eternalGoal)
                        {
                            if (eternalGoal.IfCompleted())
                            {
                                totalDebloons += eternalGoal.GetDebloons();
                                Console.WriteLine($"Eternal goal progress recorded! You earned {eternalGoal.GetDebloons()} debloons!");
                            }
                            else
                            {
                                Console.WriteLine("This eternal goal is not yet completed.");
                            }
                        }

                        Console.WriteLine($"Your current total debloons: {totalDebloons}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal number. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine($"Final total debloons: {totalDebloons}");
        }


    
    // public static void RecordGoals()
    // {
    //     Console.WriteLine("Which goal would you like to report on?");
    //     LoadGoals();
        

    //     Console.WriteLine("Enter the number of the goal that you've completed. (enter 0 to exit)");
        
    //     int _userInput = -1;
    //     int _totalDebloons = 0;

    //     while (_userInput != 0)
    //     {
    //         if (int.TryParse(Console.ReadLine(), out _userInput))
    //         {
    //             if (_userInput == 0)
    //             {
    //                 Console.WriteLine("Exiting");
    //                 Thread.Sleep(500);
    //                 break;
    //             }

    //             if (_userInput > 0 && _userInput <= _goals.Count)
    //             {
    //                 Goal selectedGoal = _goals[_userInput - 1];

    //                 if (selectedGoal is SimpleGoals simpleGoals)
    //                 {
    //                     if (simpleGoals.IfCompleted())
    //                     {
    //                         _totalDebloons += simpleGoals.GetDebloons();
    //                         Console.WriteLine();
    //                         Console.WriteLine($"Congratulations! You've earned {simpleGoals.GetDebloons()} debloons!");
    //                         Console.WriteLine();
    //                         // Console.WriteLine($"You have {_totalDebloons} debloons."
    //                         // _goals.Remove(selectedGoal);
    //                     }
    //                 }
    //                 else if (selectedGoal is ChecklistGoals checklistGoals)
    //                 {
    //                     int _bonusPoints = checklistGoals.AddBonusPoints();
    //                     _totalDebloons += _bonusPoints;
    //                     Console.WriteLine($"You earned bonus points! Your now have {_totalDebloons} debloons!");
    //                     // _goals.Remove(selectedGoal);
    //                 }
                    
    //                 else if (selectedGoal is EternalGoal eternalGoal)
    //                 {
    //                     if (eternalGoal.IfCompleted())
    //                     {
    //                         _totalDebloons += eternalGoal.GetDebloons();
    //                         Console.WriteLine($"Good job on finishing your eternal goal! You got {eternalGoal.GetDebloons()} debloons!");
    //                         // Console.WriteLine($"You have {_totalDebloons} debloons!");
    //                     }
    //                 }
                
    //             Console.WriteLine($"Your total debloons: {_totalDebloons}");
    //             }
    //         }
    //     }
    //     Console.WriteLine($"Ultimate count of debloons: {_totalDebloons}");
    }


