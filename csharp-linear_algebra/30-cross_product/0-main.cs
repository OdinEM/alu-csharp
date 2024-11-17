using System;

/// <summary>
/// The main class for testing the VectorMath.CrossProduct method.
/// </summary>
public class MainClass
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    public static void Main(string[] args)
    {
        double[] vector1 = { 1, 2, 3 };
        double[] vector2 = { 4, 5, 6 };

        double[] result = VectorMath.CrossProduct(vector1, vector2);

        Console.WriteLine("Cross Product:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}
