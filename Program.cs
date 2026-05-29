class Property
{
    // Attributes
    public string Name;
    public string Location;
    public double Price;
    public int Units;
    public string status;

    // Method inside the class
    public void DisplayInfo()
    {
        Console.WriteLine("Property: " + Name);
        Console.WriteLine("Location: " + Location);
        Console.WriteLine("Price: Ksh " + Price);
        Console.WriteLine("Units Available: " + Units);
        Console.WriteLine("status:" + status);
        Console.WriteLine("---------------------------");
    }
}

class Program
{
    static void Main()
    {
        // Creating objects from the Property class
        Property alpha = new Property();
        alpha.Name = "Alpha";
        alpha.Location = "Thika Road";
        alpha.Price = 4500000;
        alpha.Units = 3;
        alpha.status = "open for sale";

        Property beta = new Property();
        beta.Name = "Beta";
        beta.Location = "Kiambu Road";
        beta.Price = 12000000;
        beta.Units = 7;
        beta.status ="coming soon";

        Property gamma = new Property();
        gamma.Name = "gamma";
        gamma.Location = "Ruiru";
        gamma.Price = 8000000;
        gamma.Units = 4;
        gamma. status ="sold out";


        // Display both properties
        alpha.DisplayInfo();
        beta.DisplayInfo();
        gamma.DisplayInfo();
    }
}