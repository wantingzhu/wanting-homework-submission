using Console_App.enums;
using Console_App.classes;

public class Program
{
    public static void Main(string[] args)
    {
        PaintProduct paintProduct1 = new PaintProduct("Paint1", PaintType.BaseCoat, new PaintSpecification("red", 10), 100m, new Brand("Brand1", "Country1"));
        PaintProduct paintProduct2 = new PaintProduct("Paint2", PaintType.Glossy, new PaintSpecification("yellow", 20), 200m, new Brand("Brand2", "Country2"));
        PaintProduct paintProduct3 = new PaintProduct("Paint3", PaintType.Matte, new PaintSpecification("blue", 30), 300m, new Brand("Brand3", "Country3"));
        paintProduct1.DisplayInfo();
        paintProduct2.DisplayInfo();
        paintProduct3.DisplayInfo();
        Order crearOrder = new Order(new OrderItem[] {new OrderItem(paintProduct2, 2), new OrderItem(paintProduct3, 1)});
        crearOrder.DisplayOrder();  
    }
}
