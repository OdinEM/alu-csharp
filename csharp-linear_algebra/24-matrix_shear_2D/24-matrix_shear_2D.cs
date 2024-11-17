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

        // Define the shear matrix
        double[,] shearMatrix;
        if (direction == 'x')
            shearMatrix = new double[,] { { 1, factor }, { 0, 1 } };
        else
            shearMatrix = new double[,] { { 1, 0 }, { factor, 1 } };

        // Perform matrix multiplication
        double[,] result = new double[2, 2];
        for (int i = 0; i < 2; i++) // Rows
        {
            for (int j = 0; j < 2; j++) // Columns
            {
                result[i, j] = 0;
                for (int k = 0; k < 2; k++) // Inner dimension
                {
                    result[i, j] += matrix[i, k] * shearMatrix[k, j];
                }
            }
        }

        return result;
    }
}
