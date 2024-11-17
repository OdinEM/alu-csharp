using System;

/// <summary>
/// Provides methods for performing mathematical operations on matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Shears a 2D matrix by given factors.
    /// </summary>
    /// <param name="matrix">The 2D matrix to shear.</param>
    /// <param name="factorX">The shear factor in the X direction.</param>
    /// <param name="factorY">The shear factor in the Y direction.</param>
    /// <returns>
    /// The sheared matrix, or a matrix containing -1 if the input matrix is not 2x2.
    /// </returns>
    public static double[,] Shear2D(double[,] matrix, double factorX, double factorY)
    {
        // Check if the matrix is 2x2
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        // Create the shear matrix
        double[,] shearMatrix = {
            { 1, factorX },
            { factorY, 1 }
        };

        // Create a new matrix to store the sheared values
        double[,] shearedMatrix = new double[2, 2];

        // Apply the shear transformation
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                shearedMatrix[i, j] = 0;
                for (int k = 0; k < 2; k++)
                {
                    shearedMatrix[i, j] += matrix[i, k] * shearMatrix[k, j];
                }
            }
        }

        return shearedMatrix;
    }
}
