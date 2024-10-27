

using System;

public class Fraction
{
    int _top;
    int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return _top / _bottom;
    }
}
// using System;

// public class Fraction
// {
//     private int _topNumber;
//     private int _bottomNumber;
    
//     public Fraction()
//     {
//         _topNumber = 1;
//         _bottomNumber = 1;
        
//     }
//     public Fraction(int wholeNumber)
//     {
//         _topNumber = wholeNumber;
//         _bottomNumber = 1;
//     }
    
//     public Fraction(int top, int bottom)
//     {
//         _topNumber = top;
//         _bottomNumber = bottom;
//     }

//     public Fraction.GetFraction()
//     {

//     }

// }