using System;

namespace MatrixRotation
{
    /// <summary>
    /// Provides methods for performing matrix operations.
    /// </summary>
    public class MatrixMath
    {
        /// <summary>
        /// Rotates a 2D matrix by the specified angle in radians.
        /// </summary>
        /// <param name="matrix">The input matrix.</param>
        /// <param name="angle">The angle of rotation in radians.</param>
        /// <returns>The rotated matrix.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the input matrix is null.</exception>
        /// <exception cref="ArgumentException">Thrown if the matrix is not square.</exception>
        public static double[,] Rotate2D(double[,] matrix, double angle)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int n = matrix.GetLength(0);
            if (n != matrix.GetLength(1))
            {
                throw new ArgumentException("Matrix must be square.");
            }

            double[,] rotatedMatrix = new double[n, n];
            double cosTheta = Math.Cos(angle);
            double sinTheta = Math.Sin(angle);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double x = i - n / 2.0;
                    double y = j - n / 2.0;

                    double xRotated = x * cosTheta - y * sinTheta + n / 2.0;
                    double yRotated = x * sinTheta + y * cosTheta + n / 2.0;

                    // Handle edge cases to prevent out-of-bounds indices
                    int newI = (int)Math.Round(xRotated);
                    int newJ = (int)Math.Round(yRotated);

                    if (newI >= 0 && newI < n && newJ >= 0 && newJ < n)
                    {
                        rotatedMatrix[newI, newJ] = matrix[i, j];
                    }
                }
            }

            return rotatedMatrix;
        }
    }
}
