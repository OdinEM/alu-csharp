using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a jagged array containing 3 arrays
        int[][] jaggedArray = new int[3][];

        // Initialize the first array
        jaggedArray[0] = new int[] { 0, 1, 2, 3 };
        
        // Initialize the second array
        jaggedArray[1] = new int[] { 0, 1, 2, 3, 4, 5, 6 };
        
        // Initialize the third array
        jaggedArray[2] = new int[] { 0, 1 };

        // Print the jagged array
        foreach (int[] array in jaggedArray)
        {
            foreach (int element in array)
            {
                Console.Write(element + " "); // Print each element followed by a space
            }
            Console.WriteLine(" "); // Print an additional space after each line
        }
    }
}
