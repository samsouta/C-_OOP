using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

class Program
{

    // ===== Twilio Credentials =====
    // static string accountSid = "";
    // static string authToken = "";
    // static string twilioNumber = "";

    static void Main()
    {
        // ===== Login =====
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (username == "yu chan" && password == "leeyuchan")
        {
            Console.WriteLine("Login successful haha");
        }
        else
        {
            Console.WriteLine("Invalid login.");
            return;
        }

        // ===== Phone Number =====
        Console.Write("Enter your phone number : ");
        string phoneNumber = Console.ReadLine();

        // ===== Generate OTP =====
        Random rnd = new Random();
        int otp = rnd.Next(100000, 999999);

        // ===== Send OTP =====
        TwilioClient.Init(accountSid, authToken);

        MessageResource.Create(
            body: "Your OTP code is : " + otp,
            from: new Twilio.Types.PhoneNumber(twilioNumber),
            to: new Twilio.Types.PhoneNumber(phoneNumber)
        );

        Console.Write("Enter the OTP you received: ");
        string userOtp = Console.ReadLine();

        // ===== Verify OTP =====
        if (userOtp == otp.ToString())
        {
            Console.WriteLine("OTP verified, Loginnn done.");
        }
        else
        {
            Console.WriteLine("Invalid OTP.");
        }

        Console.ReadKey();
    }
}
