using System;

class Program
{
    static void Main(string[] args)
    {
        double[] v1 = new double[] { -6, -8 };
        double[] v2 = new double[] { 0, 0 };
        double[] result = VectorMath.Add(v1, v2);
        
        // Print without newline and in exact format
        Console.Write($"({result[0]}, {result[1]})");
    }
}
