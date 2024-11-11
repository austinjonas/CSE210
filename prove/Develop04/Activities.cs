
public class Activities
{
    string _startingMessage = "Menu Options: \n1.Start Breathing Activity \n2. Start reflecting activity \n3. Start Listening Activity \n4. Quit \nSelect a choice from the menu:";
    string _endingMessage = "";

    private string activityName;
    
    public string GetStartingMessage()
    {
        return $"Welcome to the" + activityName + " activity";
    }

    public void StartProgram()
    {
        Console.WriteLine(_startingMessage);
    }
    
    public static int GetActivityDuration()
    {
        Console.WriteLine("Enter how many seconds the activity will last:");
        string secondsRun = Console.ReadLine();
        int durationInSeconds;
        
        if (int.TryParse(secondsRun, out durationInSeconds) && durationInSeconds > 0)
        {
            return durationInSeconds;
        }
        else
        {
            Console.WriteLine("Please enter a positive number.");
            return -1;
        }
    }
    public int SpinnerDuration()
    {
        int spinnerDuration = 5;
        return spinnerDuration;
    }

    public void RunSpinner(int spinnerDuration)
    {
        if (spinnerDuration > 0)
        {
            // Simulate the activity duration using the DisplaySpinner method
            Console.WriteLine("Activity starting...");
            DisplaySpinner(spinnerDuration); // Show spinner for the activity's duration
            Console.WriteLine("Activity complete!");
        }
    }

    public void DisplaySpinner(int spinnerDuration)
    {
        string[] spinner = {"\\", "|", "/", "-", "|"};
        int milliseconds = spinnerDuration * 1000;
        int interval = 75;
        int index = 0;
        int count = 0;

        while (count < milliseconds)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(interval);
            Console.Write("\b \b");
            index++;
            index = (index + 1) % spinner.Length;
            count += interval;
        }
        // Console.Write("+");
        // Thread.Sleep(500);
        // Console.Write("\b \b"); // Erase the + character
        // Console.Write("-");
    }

    internal void DisplaySpinner()
    {
        throw new NotImplementedException();
    }
}

class TimerProgram
{
    private int _durationInSeconds;

    public TimerProgram(int durationInSeconds)
    {
        _durationInSeconds = durationInSeconds;
    }

    public int GetRemainingTime()
    {
        return _durationInSeconds;
    }

    public void Run()
    {
        Thread.Sleep(_durationInSeconds * 1000);
    }

    // internal int GetActivityDuration()
    // {
    //     throw new NotImplementedException();
    // }
}