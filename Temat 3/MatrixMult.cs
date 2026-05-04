using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Temat_3
{
    // 
    class MatrixMultiplier
    {
        public static Matrix Multiply(Matrix A, Matrix B, int maxThreads) 
        {
            if (A.Cols != B.Rows)
                throw new Exception("Nieprawidłowe wymiary macierzy.");

            Matrix result = new(A.Rows, B.Cols);

            ParallelOptions options = new()
            {
                MaxDegreeOfParallelism = maxThreads
            };
            // 
            Parallel.For(0, A.Rows, options, i =>
            {
                for (int j = 0; j < B.Cols; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < A.Cols; k++)
                    {
                        sum += A.Data[i, k] * B.Data[k, j];
                    }
                    result.Data[i, j] = sum;
                }
            });

            return result;
        }
    }
}
