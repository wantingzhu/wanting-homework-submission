using System;

namespace Console_App.classes;

public class Brand
{
    public string Name { get; set; }
    public string Country { get; set; }
    public Brand(string name, string country)
    {
      Name = name;
      Country = country;
    }
}
