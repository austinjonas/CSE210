using System.Runtime.CompilerServices;

class ScriptureToMemorize
{

    private List<string> _fullVerses = new List<string>();
    public void ScriptureList()
    {
        ScriptureBuilder scripture = new();
        string verse1 = scripture.StringCombiner(0);
        string verse2 = scripture.StringCombiner(1);
        string verse3 = scripture.StringCombiner(2);

        _fullVerses.Add(verse1);
        _fullVerses.Add(verse2);
        _fullVerses.Add(verse3);
    }
   
    public Random random = new Random();
    public string GetRandomVerse()
    {
        int selectedVerse = random.Next(_fullVerses.Count);
        return _fullVerses[selectedVerse];
    }

    public void WriteVerse()
    {
        string verse = GetRandomVerse();
        Console.WriteLine(verse);
    }
    
    // public void WriteVerses()
    // {
    //     for(int i = 0; i < _fullVerses.Count; i++)
    //     {
    //         Console.WriteLine($"{_fullVerses[i]}");
    //     }
    // }

    // public void HideRandomWords()
    // {
    //     Random random = new();

    //     for(int i = 0; i < _fullVerses.Count; i++)
    //     {
    //         var words = _fullVerses[i].Split(' ').ToList();

    //         var wordsToHide = new HashSet<int>();
    //         while(wordsToHide.Count < 3 && wordsToHide.Count < words.Count)
    //         {
    //             wordsToHide.Add(random.Next(words.Count));
    //         }

    //         foreach (var index in wordsToHide)
    //         {
    //             words[index] = "____";
    //         }

    //         _fullVerses[i] = string.Join(" ", words);
    //     }
    // }
}