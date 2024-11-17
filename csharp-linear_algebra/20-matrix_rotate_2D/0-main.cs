using System;

namespace MatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double angle = Math.PI / 2; // 90 degrees

            double[,] rotatedMatrix = MatrixMath.Rotate2D(matrix, angle);

            // Print the rotated matrix
            for (int i = 0; i < rotatedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < rotatedMatrix.GetLength(1); j++)
                {
                    Console.Write(rotatedMatrix[i, j] + " ");
                }
                Console.WriteLine();   

            }
        }
    }
}
