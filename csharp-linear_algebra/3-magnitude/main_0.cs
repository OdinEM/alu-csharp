using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector = new double[] { 3, -7 };
        Console.Write($"{VectorMath.Magnitude(vector)}");
    }
}
