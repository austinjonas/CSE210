using System.Runtime.CompilerServices;

public class VerseModifier
{
    private ScriptureToMemorize _scriptureToMemorize = new();
    private string _currentVerse;
    private string _modifiedVerse;
    private HashSet<int> hiddenWordInstances = new();
    private Random random = new();

    
    public VerseModifier()
    {
        _scriptureToMemorize.ScriptureList();
        UseRandomVerse();
    }

    public void UseRandomVerse()
    {
        _currentVerse = _scriptureToMemorize.GetRandomVerse();
        Console.WriteLine("Original Verse: " + _currentVerse);
        _modifiedVerse = _currentVerse;
        hiddenWordInstances.Clear();
    }

    public void HideRandomWords()
    {
    if (_modifiedVerse == null)
    {
        Console.WriteLine("No verse available. Fix the code.");
        return;
    }

    var words = _modifiedVerse.Split(' ').ToList();
    var wordsToHide = new HashSet<int>();
    int dontHideExtraWords = Math.Min(3, words.Count);

    while (wordsToHide.Count < dontHideExtraWords)
    {
        int index = random.Next(words.Count);
        if(!hiddenWordInstances.Contains(index))
        {
        wordsToHide.Add(new Random().Next(words.Count));
        }
    }

    foreach (var index in wordsToHide)
    {
        words[index] = "____";
    }

    _modifiedVerse = string.Join(" ", words);
    Console.WriteLine(_modifiedVerse);

    Console.WriteLine("\nPress Enter to hide more words from the current verse, or type 'exit' to quit:");
    string input = Console.ReadLine();

    if(input?.ToLower() == "exit")
    {
        return;
    }

    HideRandomWords();

    }
}