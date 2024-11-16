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
        // Check if vector is null or not 2D/3D
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
            return -1;

        // Calculate sum of squares
        double sumOfSquares = 0;
        foreach (double component in vector)
        {
            sumOfSquares += component * component;
        }

        // Calculate and round magnitude to 2 decimal places
        return Math.Round(Math.Sqrt(sumOfSquares), 2);
    }
}
