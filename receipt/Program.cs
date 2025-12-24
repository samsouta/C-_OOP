using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string[] itemName = new string[20];
        int[] qty = new int[20];
        double[] price = new double[20];
        double[] total = new double[20];

        int count = 0;
        double subTotal = 0;

        while (true)
        {
            Console.Write("Enter item name: ");
            itemName[count] = Console.ReadLine();

            if (itemName[count].ToLower() == "exit")
                break;

            Console.Write("Enter quantity: ");
            qty[count] = int.Parse(Console.ReadLine());

            Console.Write("Enter unit price (RM): ");
            price[count] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total[count] = qty[count] * price[count];
            subTotal += total[count];

            count++;
            Console.WriteLine();
        }

        Console.WriteLine("=============================================================");
        Console.WriteLine("              NASI KANDAR PENANG TOWN");
        Console.WriteLine("   A12, GLOMAC SQUARE JLN SS6/5A");
        Console.WriteLine("         47301 KJ PETALING JAYA SELANGOR");
        Console.WriteLine("                 TEL: 03788C7786");
        Console.WriteLine("=============================================================");
        Console.WriteLine("Invoice No: 20251216022309        16/12/25");
        Console.WriteLine("Cashier : DAY CASHIER             02:23:09");
        Console.WriteLine("-------------------------------------------------------------");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(
                $"{itemName[i],-20}{price[i],8:F2} x {qty[i],-2}{total[i],10:F2}"
            );
        }

        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"Total Item: {count}    Sub Total: {subTotal:F2}");
        Console.WriteLine($"Total Qty : {count}    Rounding : 0.00");
        Console.WriteLine($"                     Total : {subTotal:F2}");
        Console.WriteLine("-------------------------------------------------------------");

        Console.Write("Enter CASH amount (RM): ");
        double cash = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double change = cash - subTotal;

        Console.WriteLine($"CASH   : RM {cash:F2}");
        Console.WriteLine($"CHANGE : RM {change:F2}");
        Console.WriteLine("=============================================================");
        Console.WriteLine("                 THANK YOU COME AGAIN");
        Console.WriteLine("=============================================================");
    }
}
