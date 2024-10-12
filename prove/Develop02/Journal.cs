using System.Reflection.Metadata;
using System.Collections.Generic;

public class Journal
{   
    Prompt newPrompt = new();
    public List<string> entries = new List<string>();
    public List<string> prompts = new List<string>();
    public List<DateTime> datetime = new();
    //public Prompt randomPrompt = new Prompt();

    public void WriteJournal()
    {
        string prompt = newPrompt.GetPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("enter here: ");
        string entry = Console.ReadLine();
        entries.Add(entry);
        prompts.Add(prompt);
        //adds the current date/time into the datetime list above.
        datetime.Add(DateTime.Now);
    }
// goal in the next one is to save the date/time, prompt, and entry
    
    public void DisplayJournal()
    {
        Console.WriteLine("here's your entry: ");
        
        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine($"{datetime[i]} | \n{prompts[i]} | \n{entries[i]}\n");
        }
    }

    public void SaveToFile()
    {
        string filename = "JournalEntries.txt";

        using (StreamWriter output = new StreamWriter(filename))
        {
            for (int i = 0; i < entries.Count; i++)
            {
                output.WriteLine($"{datetime[i]} | {prompts[i]} | {entries[i]}");
            }
            Console.WriteLine("Successfully saved your file!");
        }
    }

    public void LoadFile()
    {
        string filename = "JournalEntries.txt";
        using (StreamReader reader = new StreamReader(filename))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] parts = line.Split('|');
                datetime.Add(DateTime.Parse(parts[0]));
                prompts.Add(parts[1]);
                entries.Add(parts[2]);

                line = reader.ReadLine();
            }
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