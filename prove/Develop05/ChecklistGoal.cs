class ChecklistGoals : Goal
{

    public ChecklistGoals(string _goalName, string _goalDescription, int _debloons) 
        : base(_goalName, _goalDescription, _debloons) { }

    private int _bonusPoints;
    // private int _completionsRequired;
    // private int _completionPoints;
    private string _userInputBonus;
    string _userGoal;
    public override string SetGoal()
    {
        Console.WriteLine("What is your checklist goal?: ");
        _userGoal = Console.ReadLine();
        return _userGoal;
    }

    public int AddBonusPoints()
    {
        Console.Write("How many bonus points will you get for completing the activity?");
        _userInputBonus = Console.ReadLine();
        _bonusPoints = int.Parse(_userInputBonus);
        return GetDebloons() + _bonusPoints;
    }

    public override int SetAward()
    {
        return 1;
    }
}