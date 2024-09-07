using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an empty string to hold the output
        string result = "";

        // Use a loop to generate numbers from 0 to 98
        for (int i = 0; i <= 98; i++)
        {
            // Append the number in decimal and hexadecimal format
            result += i.ToString() + " = " + i.ToString("X") + "\n";
        }

        // Print the result string in one go
        Console.Write(result);
    }
}
