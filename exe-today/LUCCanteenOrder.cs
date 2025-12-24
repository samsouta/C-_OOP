using System;
using System.Collections.Generic;

public class LUCCanteenOrder
{
    private List<LUCCanteenMenu> items = new List<LUCCanteenMenu>();

    public void AddItem(LUCCanteenMenu item)
    {
        items.Add(item);
        Console.WriteLine(item.Name + " has been added to your order.");
    }

    public void DisplayOrder()
    {
        Console.WriteLine();
        Console.WriteLine("Your Order from LUC Canteen:\n");

        foreach (var item in items)
        {
            item.Display();
        }
    }

    public double ComputeSum()
    {
        double total = 0;

        foreach (var item in items)
        {
            total += item.Price;
        }

        return total;
    }
}
