using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a variable to accumulate the output string
        string output = "";

        // Loop to generate the first digit
        for (int i = 0; i < 10; i++)
        {
            // Loop to generate the second digit
            for (int j = i + 1; j < 10; j++)
            {
                // Append each combination in the required format
                output += $"{i:D2}{j:D2}, ";
            }
        }

        // Remove the trailing comma and space, and print the final result followed by a newline
        Console.WriteLine(output.TrimEnd(',', ' '));
    }
}
