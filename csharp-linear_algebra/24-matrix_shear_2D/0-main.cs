using System;
using MatrixShear2D;  // Include the correct namespace here

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 1, 2 }, { 3, 4 } };
        char direction = 'x';
        double factor = 1.2;

        double[,] result = MatrixMath.Shear2D(matrix, direction, factor);  // Calling the Shear2D method

        Console.WriteLine("Sheared Matrix:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j].ToString("0.00") + " ");  // Ensure two decimal places
            }
            Console.WriteLine();
        }
    }
}
