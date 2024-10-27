using System;
using System.Data;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Scripture App");
        ScriptureBuilder scripture = new(); 
        
        ScriptureToMemorize _fullScripture = new();
        _fullScripture.ScriptureList();

        VerseModifier verseModifier = new();
        
        verseModifier.HideRandomWords();
        Console.WriteLine();
        
        // _fullScripture.HideRandomWords();

        // Console.WriteLine("\nVerses with Hidden Words: ");
        // _fullScripture.WriteVerse();



        //test for use random verse
        // VerseModifier verse = new();
        // verse.UseRandomVerse();
          
        //prints out the verses
        // Console.WriteLine(scripture.StringCombiner(0));
        // Console.WriteLine(scripture.StringCombiner(1));
        // Console.WriteLine(scripture.StringCombiner(2));
        // ScriptureBuilder scripture = new();

    }
}