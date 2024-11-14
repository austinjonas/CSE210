using System;
using System.Drawing;
using System.Globalization;

class Program
{
    

    static void Main(string[] args)
    {
       
       List<Shape> shapes = new List<Shape>();
       
       
    
       Square square1 = new Square("Purple", 2); 
       shapes.Add(square1);
    //    square1.WriteShape();

       Rectangle rectangle1 = new Rectangle("brown", 2, 4);
       shapes.Add(rectangle1);
    //    rectangle1.WriteShape();

       Circle circle1 = new Circle("Blue", 1.3);
       shapes.Add(circle1);

       foreach(Shape sh in shapes)
       {
        string color = sh.GetColor();
        double area = sh.GetArea();

        Console.WriteLine($"The area is {area} for the {color} colored shape.");
       }
    //    circle1.WriteShape();
    }
}