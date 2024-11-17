class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 1, 2 }, { 3, 4 } };
        char direction = 'x';
        double factor = 2.5;

        double[,] result = MatrixMath.Shear2D(matrix, direction, factor);

        Console.WriteLine("Resulting Matrix:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
