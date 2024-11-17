using System;

/// <summary>
/// The main class for testing the MatrixMath.Inverse2D method.
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
            { 4, 7 },
            { 2, 6 }
        };

        double[,] result = MatrixMath.Inverse2D(matrix);

        Console.WriteLine("Inverse Matrix:");
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
