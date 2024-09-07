using System;
class Program {
    static void Main(string[] args) {
        double percent; double amount;
        percent = -44.98;   amount = -9999.99;
        Console.WriteLine($"Percent: {percent:0.00}%"); Console.WriteLine($"Currency: {amount:C}");
        percent = 26.41;  amount = 12345.68;
        Console.WriteLine($"Percent: {percent:0.00}%"); Console.WriteLine($"Currency: {amount:C}");
        percent = 0.00;  amount = 0.00;
        Console.WriteLine($"Percent: {percent:0.00}%"); Console.WriteLine($"Currency: {amount:C}");
    }
}