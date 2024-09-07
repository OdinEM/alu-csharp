using System;

class Program
{
    static void Main(string[] args)
    {
        // Use a loop to generate numbers from 0 to 99
        for (int i = 0; i < 100; i++)
        {
            // Print each number with leading zero if necessary and followed by ", " unless it's the last number
            Console.Write(i.ToString("D2"));
            
            // Only print ", " if it's not the last number
            if (i < 99)
            {
                Console.Write(", ");
            }
        }
        
        // Print a newline at the end
        Console.WriteLine();
    }
}
