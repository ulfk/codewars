using System;

namespace Codewars
{
    public static class MatrixDeterminant
    {
        public static int Determinant(int[][] matrix)
        {
            var dim = matrix.GetLength(0);
            if (dim == 1)
                return matrix[0][0];

            if (dim == 2)
                return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];

            var sign = 1;
            var result = 0;
            for (var col = 0; col < dim; col++)
            {
                result += sign * matrix[0][col] * Determinant(GetSubMatrix(matrix, col));
                sign *= -1;
            }

            return result;
        }

        public static int[][] GetSubMatrix(int[][] matrix, int colToSkip)
        {
            var dim = matrix.GetLength(0);
            var result = CreateMatrix(dim - 1);
            for (var r = 1; r < dim; r++)
            {
                var cSub = 0;
                for (var c = 0; c < dim; c++)
                {
                    if (c == colToSkip) continue;
                    result[r - 1][cSub] = matrix[r][c];
                    cSub++;
                }
            }
            return result;
        }

        public static int[][] CreateMatrix(int dim)
        {
            var result = new int[dim][];
            for (var idx = 0; idx < dim; idx++)
                result[idx] = new int[dim];

            return result;
        }
    }
}
