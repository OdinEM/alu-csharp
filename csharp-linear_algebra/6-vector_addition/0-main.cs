using System;

class Program
{
    static void Main(string[] args)
    {
        // Test 2D vectors
        double[] v1 = new double[] { 1, 2 };
        double[] v2 = new double[] { 3, 4 };
        double[] result = VectorMath.Add(v1, v2);
        
        Console.WriteLine("2D Vector Addition:");
        PrintVector(result);

        // Test 3D vectors
        double[] v3 = new double[] { 1, 2, 3 };
        double[] v4 = new double[] { 4, 5, 6 };
        double[] result2 = VectorMath.Add(v3, v4);
        
        Console.WriteLine("\n3D Vector Addition:");
        PrintVector(result2);

        // Test invalid case
        double[] v5 = new double[] { 1, 2, 3, 4 };
        double[] result3 = VectorMath.Add(v1, v5);
        
        Console.WriteLine("\nInvalid Case:");
        PrintVector(result3);
    }

    static void PrintVector(double[] vector)
    {
        Console.Write("(");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i]);
            if (i < vector.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine(")");
    }
}
