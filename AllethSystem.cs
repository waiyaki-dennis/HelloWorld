using System;
using System.Collections.Generic;

namespace AllethPropertyApp
{
    // 1. The Property Class
    public class Property
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int UnitsAvailable { get; set; }

        // Constructor to easily create new properties
        public Property(string name, int price, int unitsAvailable)
        {
            Name = name;
            Price = price;
            UnitsAvailable = unitsAvailable;
        }

        // Reusable method to determine the status based on unit count
        public string GetStatus()
        {
            if (UnitsAvailable < 5)
                return "Open for sale";
            else if (UnitsAvailable <= 10)
                return "Fully sold";
            else
                return "Coming soon";
        }

        // Reusable method to determine the property type segment based on price
        public string GetPropertyType()
        {
            if (Price < 5000000)
                return "Affordable Housing";
            else if (Price <= 20000000)
                return "Mid Range Property";
            else
                return "Luxury Property";
        }
    }

    // 2. The Client Class
    public class Client
    {
        public string Name { get; set; }
        public int Budget { get; set; }

        // Constructor to initialize a client
        public Client(string name, int budget)
        {
            Name = name;
            Budget = budget;
        }

        // The core method requested: Checks if the client can afford a specific property
        public bool CanAfford(Property property)
        {
            // Returns true if budget is greater than or equal to the property price
            return this.Budget >= property.Price;
        }
    }

    // 3. The Main App Entry Point
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome Header
            Console.WriteLine("==================================================");
            Console.WriteLine("    ALLETH INVESTMENT PROPERTY MANAGEMENT SYSTEM  ");
            Console.WriteLine("==================================================");
            Console.WriteLine();

            // Setup our Property inventory using the constructor
            Property alpha = new Property("Alpha", 3500000, 3);    // 3.5M (Affordable, Open)
            Property beta = new Property("Beta", 12000000, 7);     // 12M (Mid Range, Sold)
            Property gamma = new Property("Gamma", 45000000, 15);  // 45M (Luxury, Coming Soon)

            // Setup our Clients using the constructor
            Client sarah = new Client("Sarah Jenkins", 15000000);  // 15M Budget
            Client michael = new Client("Michael Chen", 4000000);   // 4M Budget

            // Track our clients and properties in lists for easy looping
            List<Client> clients = new List<Client> { sarah, michael };
            List<Property> properties = new List<Property> { alpha, beta, gamma };

            Console.WriteLine("--- PROPERTY MARKET SEGMENTS ---");
            foreach (var prop in properties)
            {
                // Using clean String Interpolation ($) to format currency and details
                Console.WriteLine($"{prop.Name,-6} | Price: {prop.Price:N0} Kes | Type: {prop.GetPropertyType(),-18} | Status: {prop.GetStatus()}");
            }
            
            Console.WriteLine();
            Console.WriteLine("--- CLIENT AFFORDABILITY CHECKS ---");

            // Loop through each client and test them against properties
            foreach (var client in clients)
            {
                foreach (var prop in properties)
                {
                    // Call the CanAfford method, passing the property object as a parameter
                    if (client.CanAfford(prop))
                    {
                        // String interpolation with unicode checkmarks
                        Console.WriteLine($"{client.Name} - {prop.Name}: Can Afford ✓");
                    }
                    else
                    {
                        // String interpolation with unicode X marks
                        Console.WriteLine($"{client.Name} - {prop.Name}: Cannot Afford ✗");
                    }
                }
                Console.WriteLine(); // Add a blank line spacing between clients
            }

            Console.WriteLine("==================================================");
            Console.WriteLine("#investwithconfidence");
            Console.WriteLine("==================================================");
        }
    }
}