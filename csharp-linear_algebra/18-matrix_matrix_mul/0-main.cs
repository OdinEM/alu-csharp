using System;

class Program
{
    static void Main(string[] args)
    {
        // Test case 1: Valid multiplication (2x2 * 2x2)
        double[,] matrix1_2x2 = { { 1, 2 }, { 3, 4 } };
        double[,] matrix2_2x2 = { { 1, 0 }, { 0, 1 } };
        
        Console.WriteLine("2x2 * 2x2 Matrix Test:");
        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1_2x2);
        Console.WriteLine("Matrix 2:");
        PrintMatrix(matrix2_2x2);
        Console.WriteLine("Result:");
        PrintMatrix(MatrixMath.Multiply(matrix1_2x2, matrix2_2x2));

        // Test case 2: Valid multiplication (2x3 * 3x2)
        double[,] matrix1_2x3 = { { 1, 2, 3 }, { 4, 5, 6 } };
        double[,] matrix2_3x2 = { { 7, 8 }, { 9, 10 }, { 11, 12 } };
        
        Console.WriteLine("\n2x3 * 3x2 Matrix Test:");
        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1_2x3);
        Console.WriteLine("Matrix 2:");
        PrintMatrix(matrix2_3x2);
        Console.WriteLine("Result:");
        PrintMatrix(MatrixMath.Multiply(matrix1_2x3, matrix2_3x2));

        // Test case 3: Invalid multiplication (2x2 * 3x3)
        double[,] matrix1_2x2_invalid = { { 1, 2 }, { 3, 4 } };
        double[,] matrix2_3x3_invalid = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
        
        Console.WriteLine("\nInvalid Multiplication Test (2x2 * 3x3):");
        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1_2x2_invalid);
        Console.WriteLine("Matrix 2:");
        PrintMatrix(matrix2_3x3_invalid);
        Console.WriteLine("Result:");
        PrintMatrix(MatrixMath.Multiply(matrix1_2x2_invalid, matrix2_3x3_invalid));
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine("]");
        }
    }
}
