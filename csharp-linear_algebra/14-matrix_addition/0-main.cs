using System;

class Program
{
    static void Main(string[] args)
    {
        // Test case 1: 2D matrices
        double[,] matrix2D_1 = { { 1, 2 }, { 3, 4 } };
        double[,] matrix2D_2 = { { 2, 4 }, { 6, 8 } };
        
        Console.WriteLine("2D Matrices Test:");
        PrintMatrix(MatrixMath.Add(matrix2D_1, matrix2D_2));

        // Test case 2: 3D matrices
        double[,] matrix3D_1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[,] matrix3D_2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
        
        Console.WriteLine("\n3D Matrices Test:");
        PrintMatrix(MatrixMath.Add(matrix3D_1, matrix3D_2));

        // Test case 3: Different sized matrices
        double[,] matrixDiff1 = { { 1, 2 }, { 3, 4 } };
        double[,] matrixDiff2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        
        Console.WriteLine("\nDifferent Sized Matrices Test:");
        PrintMatrix(MatrixMath.Add(matrixDiff1, matrixDiff2));

        // Test case 4: Invalid matrices
        double[,] matrixInvalid1 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
        double[,] matrixInvalid2 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
        
        Console.WriteLine("\nInvalid Matrices Test:");
        PrintMatrix(MatrixMath.Add(matrixInvalid1, matrixInvalid2));
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
