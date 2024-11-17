using System;

/// <summary>
/// The main class for testing the MatrixMath.Transpose method.
/// </summary>
public class MainClass
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    public static void Main(string[] args)
    {
        double[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        double[,] result = MatrixMath.Transpose(matrix);

        Console.WriteLine("Transposed Matrix:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
