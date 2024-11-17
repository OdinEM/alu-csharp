using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 1, 2 }, { 3, 4 } };
        char direction = 'x';
        double factor = 1.2;

        double[,] result = MatrixMath.Shear2D(matrix, direction, factor);

        Console.WriteLine("Sheared Matrix:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j].ToString("0.0") + " ");
            }
            Console.WriteLine();
        }
    }
}
