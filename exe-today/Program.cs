
using System;

class Program
{
    static void Main()
    {
        LUCCanteenOrder order = new LUCCanteenOrder();

        LUCCanteenFood food = new LUCCanteenFood(
            "Nasi Lemak",
            11.45,
            "Malaysian",
            true
        );

        LUCCanteenBeverages drink = new LUCCanteenBeverages(
            "Coca-Cola",
            2.99,
            "Medium",
            true
        );

        order.AddItem(food);
        order.AddItem(drink);

        order.DisplayOrder();

        Console.WriteLine(
            "Total Price: RM" + order.ComputeSum().ToString("0.00")
        );

        Console.WriteLine(
            "Date & Time: " + DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt")
        );

        Console.ReadKey();
    }
}
