using System.Drawing;
using System.Dynamic;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    } 
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();

    public void WriteShape()
    {
        Console.WriteLine(GetArea());
        Console.WriteLine(GetColor());
    }
}