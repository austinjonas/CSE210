using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Austin Jonas", "Geometry");
        MathAssignment assignment1 = new MathAssignment("Austin Jonas", "Geometry", "Section 7.3", "Problems 8-19");
        WritingAssignment assignment2 = new WritingAssignment("Austin Jonas", "Geometry", "Harry potter");
        
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());
        Console.WriteLine(assignment2.GetWritingAssignment());  
    }    
}
