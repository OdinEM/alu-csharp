using System;
class Program {
    static void Main(string[] args)
    {
        int caseNumber = 1; double percent = caseNumber == 1 ? -44.98 : caseNumber == 2 ? 26.41 : 0.00; double amount = caseNumber == 1 ? -9999.99 : caseNumber == 2 ? 12345.68 : 0.00;
        Console.WriteLine($"Percent: {percent:0.00}%"); Console.WriteLine($"Currency: {amount:C}"); 
        caseNumber = 2; percent = caseNumber == 1 ? -44.98 : caseNumber == 2 ? 26.41 : 0.00; amount = caseNumber == 1 ? -9999.99 : caseNumber == 2 ? 12345.68 : 0.00;
        Console.WriteLine($"Percent: {percent:0.00}%"); Console.WriteLine($"Currency: {amount:C}");
        caseNumber = 3; percent = caseNumber == 1 ? -44.98 : caseNumber == 2 ? 26.41 : 0.00;  amount = caseNumber == 1 ? -9999.99 : caseNumber == 2 ? 12345.68 : 0.00;       
        Console.WriteLine($"Percent: {percent:0.00}%"); Console.WriteLine($"Currency: {amount:C}");
    }
}