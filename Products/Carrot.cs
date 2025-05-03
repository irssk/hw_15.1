using System;

public class Carrot : Product
{
    private decimal BasePrice;

    public Carrot(decimal basePrice)
    {
        BasePrice = basePrice;
    }

    public override decimal GetTotalPrice()
    {
        return BasePrice;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Product: Carrot, Price: {BasePrice}");
    }
}