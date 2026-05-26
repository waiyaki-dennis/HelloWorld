using System;
using System.Collections.Generic;

// 1. Setup the project database (Names linked to unit counts)
var projectDatabase = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
{
    { "Alpha", 3 },    // < 5 -> Open for sale
    { "Beta", 7 },     // 5-10 -> Fully sold
    { "Gamma", 12 },   // 12+ -> Planning phase / Coming soon
    { "Zion", 11 }     // Exactly 11 -> No existing projects rule
};

while (true)
{
    Console.Write("enter project name(or type 'exit' to quit):");
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input)) continue;
    input = input.Trim();

    // Handle exit
    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("#investwithconfidence");
        break;
    }

    // 2. Check if the project name exists in our database
    if (projectDatabase.TryGetValue(input, out int projectNumber))
    {
        // 3. Evaluate status based on business logic
        if (projectNumber >= 5 && projectNumber <= 10)
        {
            Console.WriteLine("project fully sold");
        }
        else if (projectNumber < 5)
        {
            Console.WriteLine("project in open for sale");
        }
        else if (projectNumber == 11)
        {
            Console.WriteLine("am sorry no Existing projects");
        }
        else // Handles 12+ units (The Fix for Gamma)
        {
            Console.WriteLine("Project is in the planning phase - Coming Soon!");
        }
    }
    else
    {
        // If the typed name is completely missing from the dictionary
        Console.WriteLine("Project name not found in the database.");
    }

    Console.WriteLine();
}
