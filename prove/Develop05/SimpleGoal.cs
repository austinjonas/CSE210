
class SimpleGoals : Goal
{
    public SimpleGoals(string _goalName, string _goalDescription, int _debloons) 
        : base(_goalName, _goalDescription, _debloons) { }

    string _userGoal;
    public override string SetGoal()
    {
        Console.WriteLine("What is your simple goal? ");
        _userGoal = Console.ReadLine();
        return _userGoal;
    }

    public bool IfCompleted()
    {
        Console.WriteLine("Have you achieved your goal? (Yes or No): ");
        string _achieved = Console.ReadLine();

        if (_achieved == "Yes")
        {
        return true;
        }

        if (_achieved == "No")
        {
        return false;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'");
            return false;
        }
    }

    int _pointsAwarded;
    
    public override int SetAward()
    {
        Console.WriteLine("How many points do you want for earning your goal? ");
        _pointsAwarded = Console.Read();
        return _pointsAwarded;
    }
}