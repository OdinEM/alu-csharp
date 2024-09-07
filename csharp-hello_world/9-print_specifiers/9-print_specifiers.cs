using System;
class Program
{
    static void Main(string[] args)
    {
        int caseNumber = 1; // 1: Negative, 2: Positive, 3: Zero
        double percent = caseNumber == 1 ? -44.98 : caseNumber == 2 ? 26.41 : 0.00;
        double amount = caseNumber == 1 ? -9999.99 : caseNumber == 2 ? 12345.68 : 0.00;
        Console.WriteLine($"Percent: {percent:0.00}%");
        Console.WriteLine($"Currency: {amount:C}");
    }
}