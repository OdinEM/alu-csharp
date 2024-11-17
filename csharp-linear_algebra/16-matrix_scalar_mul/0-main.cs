using System;

class Program
{
    static void Main(string[] args)
    {
        // Test case 1: 2D matrix
        double[,] matrix2D = { { 1, 2 }, { 3, 4 } };
        double scalar2D = 2;
        
        Console.WriteLine("2D Matrix Test:");
        Console.WriteLine("Original matrix:");
        PrintMatrix(matrix2D);
        Console.WriteLine($"Scalar: {scalar2D}");
        Console.WriteLine("Result:");
        PrintMatrix(MatrixMath.MultiplyScalar(matrix2D, scalar2D));

        // Test case 2: 3D matrix
        double[,] matrix3D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double scalar3D = 0.5;
        
        Console.WriteLine("\n3D Matrix Test:");
        Console.WriteLine("Original matrix:");
        PrintMatrix(matrix3D);
        Console.WriteLine($"Scalar: {scalar3D}");
        Console.WriteLine("Result:");
        PrintMatrix(MatrixMath.MultiplyScalar(matrix3D, scalar3D));

        // Test case 3: Invalid matrix
        double[,] matrixInvalid = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
        
        Console.WriteLine("\nInvalid Matrix Test:");
        Console.WriteLine("Original matrix:");
        PrintMatrix(matrixInvalid);
        Console.WriteLine($"Scalar: {scalar2D}");
        Console.WriteLine("Result:");
        PrintMatrix(MatrixMath.MultiplyScalar(matrixInvalid, scalar2D));
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
