using System;
using Console_App.enums;
namespace Console_App.classes;

public class PaintSpecification
{
    public string Color { get; set; }
    public int SizeInLiters { get; set; }
    public PaintSpecification(string color, int sizeInLiters)
    {
        Color = color;
        SizeInLiters = sizeInLiters;
    }
    
    public void DisplaySpecification()
    {
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Size in Liters: {SizeInLiters}L");
    }
 }

