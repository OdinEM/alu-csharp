using System;
class Program
{
    static void Main(string[] args)
    {
        int caseNumber = 2; // 1: Negative, 2: Positive, 3: Zero
        double percent = caseNumber == 1 ? -44.98 : caseNumber == 2 ? 75.53 : 0.00;
        double amount = caseNumber == 1 ? -9999.99 : caseNumber == 2 ? 98765.43 : 0.00;
        Console.WriteLine($"Percent: {percent:0.00}%{(caseNumber == 1 ? " tip" : "")}");
        Console.WriteLine($"Currency: {amount:C}");
    }
}