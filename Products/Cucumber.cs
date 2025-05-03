using System;

public class Cucumber : Product
{
    private decimal BasePrice;
    private decimal Count;

    public Cucumber(decimal basePrice, decimal count)
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
        Console.WriteLine($"Product: Cucumber, Price: {BasePrice}, Count: {Count}, Total price: {GetTotalPrice()}");
    }
}