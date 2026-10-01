using System;

namespace Console_App.classes;

public class Order
{
    public DateTime CreatedAt { get;} 
    public decimal TotalPrice { get; set; }
    public OrderItem[] OrderItems { get; set; }
    public decimal GetTotalOrderPrice()
    {
        decimal totalPrice = 0;
        foreach (OrderItem item in OrderItems)
        {
            totalPrice+=item.GetOneItemTotalPrice();
        }
        return totalPrice;
    }
    public Order(OrderItem[] orderItems)
    {
        CreatedAt = DateTime.Now;
        OrderItems = orderItems;
        TotalPrice = GetTotalOrderPrice();
    }
   
    public void DisplayOrder()
    {
        Console.WriteLine("\nShow Order Details:");
        Console.WriteLine($"Created At: {CreatedAt}");
        foreach (OrderItem item in OrderItems)
        {
            item.Product.DisplayInfo();
            Console.WriteLine($"Quantity: {item.Quantity}");
            Console.WriteLine($"This Item Total Price: {item.GetOneItemTotalPrice()}");
        }
        Console.WriteLine($"Total Price: {TotalPrice}");
    }
}
