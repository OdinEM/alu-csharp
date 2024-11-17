using System;

class Program
{
    static void Main(string[] args)
    {
        // Test case 1: 2D vectors
        double[] vector2D_1 = new double[] {1, 2};
        double[] vector2D_2 = new double[] {3, 4};
        Console.WriteLine("2D Vectors Test:");
        Console.WriteLine($"Dot Product: {VectorMath.DotProduct(vector2D_1, vector2D_2)}"); // Should be 11

        // Test case 2: 3D vectors
        double[] vector3D_1 = new double[] {1, 2, 3};
        double[] vector3D_2 = new double[] {4, 5, 6};
        Console.WriteLine("\n3D Vectors Test:");
        Console.WriteLine($"Dot Product: {VectorMath.DotProduct(vector3D_1, vector3D_2)}"); // Should be 32

        // Test case 3: Different sized vectors
        double[] vectorDiff1 = new double[] {1, 2};
        double[] vectorDiff2 = new double[] {1, 2, 3};
        Console.WriteLine("\nDifferent Sized Vectors Test:");
        Console.WriteLine($"Dot Product: {VectorMath.DotProduct(vectorDiff1, vectorDiff2)}"); // Should be -1

        // Test case 4: Invalid vectors
        double[] vectorInvalid1 = new double[] {1, 2, 3, 4};
        double[] vectorInvalid2 = new double[] {5, 6, 7, 8};
        Console.WriteLine("\nInvalid Vectors Test:");
        Console.WriteLine($"Dot Product: {VectorMath.DotProduct(vectorInvalid1, vectorInvalid2)}"); // Should be -1
    }
}
