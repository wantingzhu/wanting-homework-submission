namespace Console_App.classes;

public class OrderItem
{
    public PaintProduct Product { get; set; }
    public int Quantity { get; set; }

    public OrderItem(PaintProduct product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public decimal GetOneItemTotalPrice()
    {
        return Product.GetFinalPrice() * Quantity;
    }
}
