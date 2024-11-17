using System;

/// <summary>
/// The main class for testing the MatrixMath.Shear2D method.
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
            { 1, 2 },
            { 3, 4 }
        };
        char direction = 'x';
        double factor = 1.5;

        double[,] result = MatrixMath.Shear2D(matrix, direction, factor);

        Console.WriteLine("Sheared Matrix:");
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
