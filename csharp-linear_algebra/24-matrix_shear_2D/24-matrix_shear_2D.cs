using System;

namespace MatrixShear2D
{
    /// <summary>
    /// This class provides methods for matrix operations, specifically for 2D shear transformations.
    /// </summary>
    public class MatrixMath
    {
        /// <summary>
        /// Applies a shear transformation to a 2D square matrix.
        /// </summary>
        /// <param name="matrix">A 2x2 matrix to shear.</param>
        /// <param name="direction">The direction of shearing ('x' or 'y').</param>
        /// <param name="factor">The shear factor.</param>
        /// <returns>The sheared matrix, or a matrix containing -1 for invalid inputs.</returns>
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
                result[0, 0] = Math.Round(matrix[0, 0] + factor * matrix[0, 1], 2);
                result[0, 1] = Math.Round(matrix[0, 1], 2);
                result[1, 0] = Math.Round(matrix[1, 0] + factor * matrix[1, 1], 2);
                result[1, 1] = Math.Round(matrix[1, 1], 2);
            }
            else if (direction == 'y')
            {
                // Shearing in the y-direction: [1, 0; factor, 1]
                result[0, 0] = Math.Round(matrix[0, 0], 2);
                result[0, 1] = Math.Round(matrix[0, 1] + factor * matrix[0, 0], 2);
                result[1, 0] = Math.Round(matrix[1, 0], 2);
                result[1, 1] = Math.Round(matrix[1, 1] + factor * matrix[1, 0], 2);
            }

            return result;
        }
    }
}
