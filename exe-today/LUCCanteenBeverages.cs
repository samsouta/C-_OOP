using System;

public class LUCCanteenBeverages : LUCCanteenMenu
{
    public string Size { get; set; }
    public bool IsCarbonated { get; set; }

    public LUCCanteenBeverages(string name, double price, string size, bool isCarbonated)
        : base(name, price)
    {
        Size = size;
        IsCarbonated = isCarbonated;
    }

    public override void Display()
    {
        Console.WriteLine("Beverage: " + Name);
        Console.WriteLine("Size: " + Size);
        Console.WriteLine("Price: RM" + Price.ToString("0.00"));
        Console.WriteLine("Carbonated: " + IsCarbonated);
        Console.WriteLine();
    }
}
