using System;
class Program {
    static void Main(string[] args) {
        int caseNumber = 1;  double percent;  double amount;
        if (caseNumber == 1)   {
          percent = -44.98;  amount = -9999.99;   Console.WriteLine($"Percent: {percent:0.00}%"); Console.WriteLine($"Currency: {amount:C}");  }
        else if (caseNumber == 2)   {
            percent = 26.41; amount = 12345.68;  Console.WriteLine($"Percent: {percent:0.00}%"); Console.WriteLine($"Currency: {amount:C}"); }
        else if (caseNumber == 3) {
            percent = 0.00; amount = 0.00; Console.WriteLine($"Percent: {percent:0.00}%"); Console.WriteLine($"Currency: {amount:C}");  }
    }
}