using System;

/// <summary>
/// Contains methods for performing matrix operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Shears a 2D square matrix by a given shear factor and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">A 2x2 matrix to be sheared.</param>
    /// <param name="direction">The direction of the shear: 'x' or 'y'.</param>
    /// <param name="factor">The shear factor to apply.</param>
    /// <returns>
    /// A new matrix representing the result of the shear transformation, 
    /// or a matrix containing -1 if invalid input is provided.
    /// </returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Check for valid 2x2 matrix
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        // Validate direction
        if (direction != 'x' && direction != 'y')
            return new double[,] { { -1 } };

        // Shear transformation logic
        double[,] result = new double[2, 2];
        if (direction == 'x')
        {
            // Shearing in the x-direction: [1, factor; 0, 1]
            result[0, 0] = matrix[0, 0] + factor * matrix[0, 1];
            result[0, 1] = matrix[0, 1];
            result[1, 0] = matrix[1, 0] + factor * matrix[1, 1];
            result[1, 1] = matrix[1, 1];
        }
        else if (direction == 'y')
        {
            // Shearing in the y-direction: [1, 0; factor, 1]
            result[0, 0] = matrix[0, 0];
            result[0, 1] = matrix[0, 1] + factor * matrix[0, 0];
            result[1, 0] = matrix[1, 0];
            result[1, 1] = matrix[1, 1] + factor * matrix[1, 0];
        }

        return result;
    }
}
