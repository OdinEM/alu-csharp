using System;
class Program
{
    static void Main(string[] args)
    {
        // Initialize variables with the correct values
        double percent = 26.41;
        double amount = 12345.68;
        Console.WriteLine($"Percent: {percent:0.00}%");
        Console.WriteLine($"Currency: ${amount:0,0.00}");
    }
}