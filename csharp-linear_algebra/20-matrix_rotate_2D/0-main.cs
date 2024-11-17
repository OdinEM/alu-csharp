using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = new double[,] {
            { 1, 2 },
            { 3, 4 }
        };
        double angle = 90 * Math.PI / 180;

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        double[,] rotated = MatrixMath.Rotate2D(matrix, angle);
        
        Console.WriteLine("\nRotated Matrix ({0} degrees):", angle * 180 / Math.PI);
        PrintMatrix(rotated);

        // Test invalid matrix
        double[,] invalid = new double[,] {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        
        Console.WriteLine("\nTesting invalid matrix:");
        PrintMatrix(MatrixMath.Rotate2D(invalid, angle));
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0:F2}\t", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
