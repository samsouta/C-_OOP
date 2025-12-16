using System;

class Program
{
    static int accountNumber = 0;
    static string accountName = "";
    static double balance = 0;

    static void Main()
    {
        int choice = 0;

        do
        {
            ShowMenu();
            Console.Write("\nEnter your choice : ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;

                case 2:
                    DepositMoney();
                    break;

                case 3:
                    WithdrawMoney();
                    break;

                case 4:
                    CheckBalance();
                    break;

                case 5:
                    Console.WriteLine("Thank you for banking with us!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }

    static void ShowMenu()
    {
        Console.WriteLine("Imaginary Online Banking Menu");
        Console.WriteLine("1. Create Account");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Check Balance");
        Console.WriteLine("5. Exit");
    }

    static void CreateAccount()
    {
        Console.Write("Enter Account Holder's Name : ");
        accountName = Console.ReadLine();

        Console.Write("Enter Initial Balance : ");
        balance = double.Parse(Console.ReadLine());

        accountNumber = 1;

        Console.WriteLine(
            "Account created successfully, your Account Number is : " 
            + accountNumber
        );
    }

    static void DepositMoney()
    {
        Console.Write("Enter Account Number : ");
        int accNo = int.Parse(Console.ReadLine());

        if (accNo == accountNumber)
        {
            Console.Write("Enter amount to deposit : ");
            double amount = double.Parse(Console.ReadLine());

            balance += amount;

            Console.WriteLine(
                "RM" + amount + " has been deposited. New Balance : RM" + balance + "."
            );
        }
        else
        {
            Console.WriteLine("Invalid Account Number.");
        }
    }

    static void WithdrawMoney()
    {
        Console.Write("Enter Account Number : ");
        int accNo = int.Parse(Console.ReadLine());

        if (accNo == accountNumber)
        {
            Console.Write("Enter amount to withdraw : ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= balance)
            {
                balance -= amount;

                Console.WriteLine(
                    "RM" + amount + " has been withdrawn. New Balance : RM" + balance + "."
                );
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Account Number.");
        }
    }

    static void CheckBalance()
    {
        Console.Write("Enter Account Number : ");
        int accNo = int.Parse(Console.ReadLine());

        if (accNo == accountNumber)
        {
            Console.WriteLine(
                "Current Balance : RM" + balance
            );
        }
        else
        {
            Console.WriteLine("Invalid Account Number.");
        }
    }
}
