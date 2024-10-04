using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        nurse._headWear = "Nurses cap";
        nurse._gloves = "Nitrile";
        nurse._shoes = "Orthopedic sneakers";
        nurse._upperGarment = "Scrubs";
        nurse._lowerGarment = "Scrubs";
        nurse._accessory = "Stethoscope";

        Costume detective = new();
        detective._headWear = "fedora";
        detective._gloves = "leather";
        detective._shoes = "loafers";
        detective._upperGarment = "trenchcoat";
        detective._lowerGarment = "slacks";
        detective._accessory = "magnifying glass";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();



    }
}

//how to build a list simpler:
//List<int> myList = new();