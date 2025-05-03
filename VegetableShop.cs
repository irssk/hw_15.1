using System.Collections.Generic;
using System;

public class VegetableShop
{
    private List<Product> _products = new List<Product>();

    public void AddProducts(List<Product> products)
    {
        _products.AddRange(products);
    }

    public void PrintProductsInfo()
    {
        decimal total = 0;

        foreach (var product in _products)
        {
            product.PrintInfo();
            total += product.GetTotalPrice();
        }

        Console.WriteLine($"Total products price: {total}");
    }
}
