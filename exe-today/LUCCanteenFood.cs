using System;

public class LUCCanteenFood : LUCCanteenMenu
{
    public string Cuisine { get; set; }
    public bool IsVege { get; set; }

    public LUCCanteenFood(string name, double price, string cuisine, bool isVege)
        : base(name, price)
    {
        Cuisine = cuisine;
        IsVege = isVege;
    }

    public override void Display()
    {
        Console.WriteLine("Food: " + Name);
        Console.WriteLine("Cuisine: " + Cuisine);
        Console.WriteLine("Price: RM" + Price.ToString("0.00"));
        Console.WriteLine("Vegetarian: " + IsVege);
        Console.WriteLine();
    }
}
