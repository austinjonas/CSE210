using System.ComponentModel;

public abstract class Goal
    {
        private string _goalTitle;
        private string _goalDescription;
        private int _debloons;

        public Goal(string goalTitle, string goalDescription, int debloons)
        {
            _goalTitle = goalTitle;
            _goalDescription = goalDescription;
            _debloons = debloons;
        }

        public string GetTitle()
        {
            return _goalTitle;
        }
        public string GetDescription()
        {
            return _goalDescription;
        }
        public int GetDebloons()
        {
            return _debloons;
        }

        public abstract string SetGoal();
        public abstract int SetAward();
        // public abstract int TotalPoints();
        
        
        public List<string> _goals = new List<string>();
        // public List<string> prompts = new List<string>();
        public List<DateTime> datetime = new List<DateTime>();

        

        public string ListGoals()
        {
            return ListGoals();
        }
        
    }