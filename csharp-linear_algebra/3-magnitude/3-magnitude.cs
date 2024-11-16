using System;

/// <summary>
/// Provides mathematical operations for vectors.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the magnitude (length) of a vector.
    /// </summary>
    /// <param name="vector">The vector array (2D or 3D)</param>
    /// <returns>The magnitude of the vector, rounded to 2 decimal places. Returns -1 if vector is invalid.</returns>
    public static double Magnitude(double[] vector)
    {
        // Check if vector is null or empty
        if (vector == null || vector.Length == 0)
            return -1;

        // Check if vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
            return -1;

        // Calculate sum of squares
        double sumOfSquares = 0;
        foreach (double component in vector)
        {
            sumOfSquares += Math.Pow(component, 2);
        }

        // Calculate magnitude and round to 2 decimal places
        double result = Math.Sqrt(sumOfSquares);
        
        // Handle special case for zero vector
        if (result == 0)
            return 0;
            
        return Math.Round(result, 2);
    }
}
