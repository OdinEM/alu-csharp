using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Define sides of the triangle
        double AB = 64;
        double BC = 121;

        // Calculate the hypotenuse AC
        double AC = Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(BC, 2));

        // Round to two decimal places
        AC = Math.Round(AC, 2);

        // Write result to a text file
        string filePath = "0-pythagoras.txt";
        File.WriteAllText(filePath, AC.ToString());

        // Output to console for confirmation
        Console.WriteLine($"The length of AC is {AC} and has been written to {filePath}");
    }
}
