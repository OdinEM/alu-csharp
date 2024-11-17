using System;

/// <summary>
/// The main class for testing the MatrixMath.Determinant method.
/// </summary>
public class MainClass
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    public static void Main(string[] args)
    {
        double[,] matrix2x2 = {
            { 1, 2 },
            { 3, 4 }
        };

        double[,] matrix3x3 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        double determinant2x2 = MatrixMath.Determinant(matrix2x2);
        double determinant3x3 = MatrixMath.Determinant(matrix3x3);

        Console.WriteLine("Determinant of 2x2 matrix:");
        Console.WriteLine(determinant2x2);

        Console.WriteLine("Determinant of 3x3 matrix:");
        Console.WriteLine(determinant3x3);
    }
}
