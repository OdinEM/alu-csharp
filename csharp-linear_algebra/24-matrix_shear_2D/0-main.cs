using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Case 1: Valid square matrix with x-direction shear
        double[,] matrix1 = new double[,] {
            { 1, 2 },
            { 3, 4 }
        };
        Console.WriteLine("Test Case 1: X-direction shear");
        PrintMatrix(MatrixMath.Shear2D(matrix1, 'x', 2));

        // Test Case 2: Valid square matrix with y-direction shear
        double[,] matrix2 = new double[,] {
            { 1, 2 },
            { 3, 4 }
        };
        Console.WriteLine("\nTest Case 2: Y-direction shear");
        PrintMatrix(MatrixMath.Shear2D(matrix2, 'y', 2));

        // Test Case 3: Invalid direction
        Console.WriteLine("\nTest Case 3: Invalid direction");
        PrintMatrix(MatrixMath.Shear2D(matrix1, 'z', 2));

        // Test Case 4: Non-square matrix
        double[,] matrix4 = new double[,] {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        Console.WriteLine("\nTest Case 4: Non-square matrix");
        PrintMatrix(MatrixMath.Shear2D(matrix4, 'x', 2));
    }

    // Helper method to print matrix
    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]:F2} ");
            }
            Console.WriteLine();
        }
    }
}
