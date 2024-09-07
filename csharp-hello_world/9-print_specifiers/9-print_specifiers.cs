using System;
class Program
{
    static void Main(string[] args)
    {
        double percent = 75.53;
        double amount = 98765.43;

        Console.WriteLine($"Percent: {percent:0.00}% tip");
        Console.WriteLine($"Currency: ${amount:0,0.00}");
    }
}