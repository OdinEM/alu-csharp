using System;

class Array
{
    // Method to print an array in reverse order
    public static void Reverse(int[] array)
    {
        // Check if the array is null or empty
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }

        // Loop through the array in reverse order and print the elements
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            if (i > 0)
                Console.Write(" ");
        }

        Console.WriteLine();
    }
}
