using System;

/// <summary>
/// Provides methods for performing mathematical operations on matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians.
    /// </summary>
    /// <param name="matrix">The square 2D matrix to rotate.</param>
    /// <param name="angle">The angle in radians to rotate the matrix.</param>
    /// <returns>
    /// The rotated matrix, or a matrix containing -1 if the input matrix is not square.
    /// </returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if the matrix is square
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols)
        {
            return new double[,] { { -1 } };
        }

        // Create a new matrix to store the rotated values
        double[,] rotatedMatrix = new double[rows, cols];

        // Calculate the rotation matrix components
        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        // Apply the rotation to each element in the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                rotatedMatrix[i, j] = matrix[i, j] * cosAngle - matrix[i, j] * sinAngle;
            }
        }

        return rotatedMatrix;
    }
}
