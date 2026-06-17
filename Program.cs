using System;

namespace AllethPropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create three client objects with different budgets
            Client client1 = new Client("Sarah Jenkins", "+1-555-0198", 4200000, "thika road");
            Client client2 = new Client("Michael Chen", "+1-555-0243", 12500000, "ruiru");
            Client client3 = new Client("Elena Rostova", "+1-555-0311", 35000000, "nairobi");

            // 2. Call methods on each client
            Console.WriteLine("=== ALLETH PROPERTY BUYER PROFILES ===\n");
            
            client1.DisplayClient();
            client2.DisplayClient();
            client3.DisplayClient();
        }
    }

    public class Client
    {
        // Attributes (Properties)
        public string FullName { get; set; }
        public string Phone { get; set; }
        public double Budget { get; set; }
        public string PreferredLocation { get; set; }

        // Constructor taking all four values
        public Client(string fullName, string phone, double budget, string preferredLocation)
        {
            FullName = fullName;
            Phone = phone;
            Budget = budget;
            PreferredLocation = preferredLocation;
        }

        // Method to categorize the budget
        public string GetBudgetCategory()
        {
            if (Budget < 5000000)
            {
                return "First Time Buyer";
            }
            else if (Budget <= 20000000)
            {
                return "Mid Range Buyer";
            }
            else
            {
                return "Premium Buyer";
            }
        }

        // Method to cleanly print client details
        public void DisplayClient()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Name:               {FullName}");
            Console.WriteLine($"Phone:              {Phone}");
            Console.WriteLine($"Preferred Location: {PreferredLocation}");
            Console.WriteLine($"Budget:             {Budget:N0} ksh"); // Formats numbers with commas (e.g., 5,000,000)
            Console.WriteLine($"Category:           {GetBudgetCategory()}");
            Console.WriteLine("---------------------------------------------\n");
        }
    }
}