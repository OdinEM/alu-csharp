using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Check if the matrix is a 2x2 square matrix
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        // Check if the direction is valid (either 'x' or 'y')
        if (direction != 'x' && direction != 'y')
            return new double[,] { { -1 } };

        // Create the shear matrix
        double[,] shearMatrix;
        if (direction == 'x')
        {
            shearMatrix = new double[,] { { 1, factor }, { 0, 1 } };
        }
        else // direction == 'y'
        {
            shearMatrix = new double[,] { { 1, 0 }, { factor, 1 } };
        }

        // Perform the matrix multiplication
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
