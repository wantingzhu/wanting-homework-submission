using System;
using Console_App.enums;
using Console_App.interfaces;

namespace Console_App.classes;

public class PaintProduct : IBuyable
{
    public decimal TaxRate { get; }
    public const decimal DefaultDiscount = 0.05m;
    public string Name { get; set; }
    public PaintType Type { get; set; }
    public PaintSpecification Specification { get; set; }
    public Brand Brand { get; set; }
    public decimal Price { get; set; }

    public PaintProduct(string name, PaintType type, PaintSpecification specification, decimal price, Brand brand)
    {
      Name = name;
      Type = type;
      Specification = specification;
      Price = price;
      TaxRate = 0.1m;
      Brand = brand;
    }
    public decimal GetFinalPrice()
    {
      return (Price * (1 + TaxRate) * (1 - DefaultDiscount));
    }
    public void DisplayInfo()
    {
      Console.WriteLine($"Name: {Name}");
      Console.WriteLine($"Type: {Type}");
      Specification.DisplaySpecification();
      Console.WriteLine($"Price: {Price}");
      Console.WriteLine($"Tax Rate: {TaxRate*100}%");
      Console.WriteLine($"Default Discount: {DefaultDiscount*100}%");
      Console.WriteLine($"Final Price: {GetFinalPrice()}");
    }
    public decimal GetMaxDiscount(int rate, bool isOverridable)
    {
      if (isOverridable)
      {
        return rate/100m;
      }
      else
      {
        return DefaultDiscount;
      }
    }

}
