using System;

/// <summary>
/// Class containing matrix mathematical operations
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Shears a 2D square matrix by a given factor in either X or Y direction.
    /// </summary>
    /// <param name="matrix">The input 2D square matrix to be sheared</param>
    /// <param name="direction">The direction of shear ('x' or 'y')</param>
    /// <param name="factor">The shear factor to be applied</param>
    /// <returns>
    /// The sheared matrix if successful, or a matrix containing -1 if:
    /// - The input matrix is not square
    /// - The direction is not 'x' or 'y'
    /// </returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Check if matrix is null
        if (matrix == null)
            return new double[,] { { -1 } };

        // Get matrix dimensions
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if matrix is square
        if (rows != cols)
            return new double[,] { { -1 } };

        // Check if direction is valid
        direction = char.ToLower(direction);
        if (direction != 'x' && direction != 'y')
            return new double[,] { { -1 } };

        // Create result matrix
        double[,] result = new double[rows, cols];

        // Apply shear transformation
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (direction == 'x')
                {
                    // X-direction shear: x' = x + factor * y
                    result[i, j] = matrix[i, j] + (factor * i);
                }
                else
                {
                    // Y-direction shear: y' = y + factor * x
                    result[i, j] = matrix[i, j] + (factor * j);
                }
            }
        }

        return result;
    }
}
