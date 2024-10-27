using System;
// public class StringCombiner
// {
//     public string CombinedString {get; private set;}
//     public StringCombiner(List<string> books, List<string> reference, List<string> verses)
//     {
//         CombinedString = string.Join(" ", books) + " " + string.Join(" ", reference) + string.Join(" ", verses);
//     }
// }
public class ScriptureBuilder
{ 
    
    private List<string> books = new()
    {
        "1 Nephi",
        "Helaman",
        "Moroni",
    };

    private List<string> reference = new()
    {
        "1:12",
        "5:12",
        "10:5",
    };
    private List<string> verses = new()
    {
        "And it came to pass that as he read, he was filled with the Spirit of the Lord.",
        "remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation.", 
        "And by the power of the Holy Ghost ye may know the truth of all things.",
    };

     public string StringCombiner(int x)
    {
        string newstring = $"{books[x]} {reference[x]} {verses[x]}";
        return newstring;
    }
}