using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a 5x5 two-dimensional array
        int[,] array = new int[5, 5];

        // Initialize the index [2,2] to 1
        array[2, 2] = 1;

        // Loop through the array and print the values
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine(); // Add a line break after each row
        }

        // Add an extra line break to make total output 56 characters
        Console.WriteLine(); // This will ensure a total of 56 chars with the new line
    }
}
