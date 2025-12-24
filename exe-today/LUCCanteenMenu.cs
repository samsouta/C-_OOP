using System;

public abstract class LUCCanteenMenu
{
    public string Name { get; set; }
    public double Price { get; set; }

    public LUCCanteenMenu(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void Display();
}
