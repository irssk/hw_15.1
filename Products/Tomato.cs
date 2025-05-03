using System;

public class Tomato : Product
{
    private decimal BasePrice;

    public Tomato(decimal basePrice)
    {
        BasePrice = basePrice;
    }

    public override decimal GetTotalPrice()
    {
        return BasePrice;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Product: Tomato, Price: {BasePrice}");
    }
}