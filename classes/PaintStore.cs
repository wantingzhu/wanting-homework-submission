using System;

namespace Console_App.classes;

public class PaintStore
{
    public PaintProduct[] Products{get; set;}
    public PaintStore()
  {
    Products = new PaintProduct[0];
  }
}
