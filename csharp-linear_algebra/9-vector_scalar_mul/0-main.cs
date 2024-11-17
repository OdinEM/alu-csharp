using System;

class Program
{
    static void Main(string[] args)
    {
        // Test case 1: 2D vector
        double[] vector2D = new double[] {1, 2};
        double scalar2D = 3;
        Console.WriteLine("2D Vector Test:");
        PrintVector(VectorMath.Multiply(vector2D, scalar2D));

        // Test case 2: 3D vector
        double[] vector3D = new double[] {1, 2, 3};
        double scalar3D = 0.5;
        Console.WriteLine("\n3D Vector Test:");
        PrintVector(VectorMath.Multiply(vector3D, scalar3D));

        // Test case 3: Invalid vector
        double[] vectorInvalid = new double[] {1, 2, 3, 4};
        Console.WriteLine("\nInvalid Vector Test:");
        PrintVector(VectorMath.Multiply(vectorInvalid, scalar2D));
    }

    static void PrintVector(double[] vector)
    {
        Console.Write("Result: (");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i]);
            if (i < vector.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine(")");
    }
}
