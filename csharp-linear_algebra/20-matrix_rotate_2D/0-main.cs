using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = new double[,] {
            { 2, -1 },
            { 4, -3 }
        };
        double angle = Math.PI / 2;  // 90 degrees

        double[,] rotated = MatrixMath.Rotate2D(matrix, angle);
        PrintMatrix(rotated);
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == matrix.GetLength(1) - 1)
                    Console.Write($"{matrix[i, j]}");
                else
                    Console.Write($"{matrix[i, j]}, ");
            }
            Console.WriteLine();
        }
    }
}
