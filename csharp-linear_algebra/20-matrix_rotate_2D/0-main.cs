using System;

/// <summary>
/// Main program class for testing matrix rotation.
/// </summary>
class Program
{
    /// <summary>
    /// Main entry point of the program.
    /// </summary>
    /// <param name="args">Command line arguments.</param>
    static void Main(string[] args)
    {
        double[,] matrix = new double[,] {
            { 1, 2 },
            { 3, 4 }
        };
        double angle = Math.PI / 2;  // 90 degrees

        double[,] rotated = MatrixMath.Rotate2D(matrix, angle);
        PrintMatrix(rotated);
    }

    /// <summary>
    /// Prints the contents of a matrix.
    /// </summary>
    /// <param name="matrix">The matrix to print.</param>
    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == matrix.GetLength(1) - 1)
                    Console.Write($"{matrix[i, j]}");
                else
                    Console.Write($"{matrix[i, j]}, ");
            }
            Console.WriteLine();
        }
    }
}
