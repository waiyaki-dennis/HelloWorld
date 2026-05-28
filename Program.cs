using System;

class PropertyChecker
{
    static void WelcomeMessage(string companyName)
    {
        Console.WriteLine("Welcome to " + companyName + " Property Management System");
    }

    static string GetStatus(int units)
    {
        if (units < 5)
            return "Open for sale";
        else if (units <= 10)
            return "Fully sold";
        else
            return "Coming soon";
    }

    static string GetPropertyType(int price)
    {
        if (price < 5000000)
            return "Affordable Housing";
        else if (price <= 20000000)
            return "Mid Range Property";
        else
            return "Luxury Property";
    }

    static void Main()
    {
        WelcomeMessage("Alleth Investment");
        Console.WriteLine("--------------------------------------------------");

        // 1. Check Unit Availability Statuses
        Console.WriteLine("Alpha | Status: " + GetStatus(3));
        Console.WriteLine("Beta  | Status: " + GetStatus(7));
        Console.WriteLine("Gamma | Status: " + GetStatus(12));
        
        Console.WriteLine("--------------------------------------------------");

        // 2. Check Property Type Classifications by Price
        Console.WriteLine("Property at 3,500,000 Kes   -> " + GetPropertyType(3500000));
        Console.WriteLine("Property at 12,000,000 Kes  -> " + GetPropertyType(12000000));
        Console.WriteLine("Property at 45,000,000 Kes  -> " + GetPropertyType(45000000));
    }
}