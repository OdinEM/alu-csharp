using System;

class Program
{
    static void Main(string[] args)
    {
        // Use a loop to generate numbers from 0 to 98
        for (int i = 0; i <= 98; i++)
        {
            // Print each number in decimal and hexadecimal format
            Console.Write($"{i} = {i:X}\n");
        }
    }
}
