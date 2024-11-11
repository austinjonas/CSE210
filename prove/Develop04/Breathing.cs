using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Breathing : Activities
{
    private string _endingMessage = "Good job completing the activity!";
    // public Breathing() : base() { }
    public Breathing()
    {
        string activityName = "breathing";
    }
    
    public void StartBreathingActivity()
    {
        Console.Clear();
        Console.WriteLine(GetStartingMessage());

        int durationInSeconds = GetActivityDuration();
        if (durationInSeconds <= 0) return;

        TimerProgram programTimer = new TimerProgram(durationInSeconds);
        Breathe(programTimer);
    }
        // int activityDuration = -1;
        // int spinnerDuration = -1;

    
        public void Breathe(TimerProgram programTimer)
        {
        int remainingTime = programTimer.GetRemainingTime();
       
        while (remainingTime > 0)
        {
            for (int i = 0; i < 5 && remainingTime > 0; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Breathe in: {5 - i}");
                    Thread.Sleep(1000); 
                    remainingTime--;    
                    
                }
                if (remainingTime <= 0) break;

            for (int i = 0; i < 5 && remainingTime > 0; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Breathe out: {5 - i}");
                    Thread.Sleep(1000); 
                    remainingTime--;     
                }

                if (remainingTime <= 0) break;
            }
            

            Console.Clear();
            Console.WriteLine(_endingMessage);
            
        }
}
