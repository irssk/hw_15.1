using System;

public class Potato : Product
{
    private decimal BasePrice;
    private decimal Count;

    public Potato(decimal basePrice, decimal count)
    {
        BasePrice = basePrice;
        Count = count;
    }

    public override decimal GetTotalPrice()
    {
        return BasePrice * Count;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Product: Potato, Price: {BasePrice}, Count: {Count}, Total price: {GetTotalPrice()}");
    }
}