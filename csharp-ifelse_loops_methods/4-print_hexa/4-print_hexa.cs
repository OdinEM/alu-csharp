using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an empty string to accumulate the results
        string result = "";

        // Loop from 0 to 98
        for (int i = 0; i <= 98; i++)
        {
            // Append each number in decimal and hexadecimal format to the result string
            result += $"{i} = 0x{i:X}\n";
        }

        // Print the entire result string in one go
        Console.Write(result);
    }
}
