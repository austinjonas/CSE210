using System.Reflection.Metadata;

public class Journal
{   
    Prompt newPrompt = new();
    public List<string> entries = new List<string>();
    //public Prompt randomPrompt = new Prompt();

    public void WriteJournal()
    {
        string prompt = newPrompt.GetPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("enter here: ");
        string entry = Console.ReadLine();
        entries.Add(entry);
    }
// goal in the next one is to save the date/time, prompt, and entry
    
    public void DisplayJournal()
    {
        Console.WriteLine("here's your entry: ");
        foreach (string entry in entries)
        {
            Console.WriteLine($"{entry}");
        }
    }

    public void SaveToFile()
    {
        string filePath = "journal_entries.txt";

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            foreach (string entry in entries)
            {
                string prompt = newPrompt.GetPrompt();
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                writer.WriteLine($"{timestamp} | Prompt: {prompt} | Entry: {entry}");
            }
        }
    }

    public void ReadFile()
    {
        string filePath = "journal_entries.txt";
        if (File.Exists(filePath))
        {
            Console.WriteLine("Reading entries from file:");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine("No entries found. The journal is empty.");
        }
    }
}

public class Prompt 
    {
    public List<string> prompts = new List<string>
    {
        "Describe a challenge you faced today.",
        "What are you grateful for today?",
        "What is something you learned today?",
        "What made you laugh today?"
    };

    public Random random = new Random();

    // Show the prompt to the user
    
    public string GetPrompt()
    {
        int selectedPrompt = random.Next(prompts.Count);
        return prompts[selectedPrompt];
    }
    }