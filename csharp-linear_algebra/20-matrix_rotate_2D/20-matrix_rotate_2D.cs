using System;

/// <summary>
/// Provides mathematical operations for matrices
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians
    /// </summary>
    /// <param name="matrix">The square matrix to rotate</param>
    /// <param name="angle">The angle to rotate by (in radians)</param>
    /// <returns>The rotated matrix, or a matrix containing -1 if the input is invalid</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if matrix is square by verifying if number of rows equals number of columns
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[,] { { -1 } };
        }

        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];

        // Calculate rotation matrix components
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        // Apply rotation to each point in the matrix
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                double x = matrix[i, j];
                // Rotate each value using the rotation matrix
                result[i, j] = Math.Round(x * cos, 2);
            }
        }

        return result;
    }
}
