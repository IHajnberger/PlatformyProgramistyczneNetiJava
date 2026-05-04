using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temat_3
{
    class MatrixMultiplierThread
    {
        public static Matrix Multiply(Matrix A, Matrix B, int threadCount)
        {
            if (A.Cols != B.Rows)
                throw new Exception("Nieprawidłowe wymiary macierzy.");

            Matrix result = new(A.Rows, B.Cols);

            Thread[] threads = new Thread[threadCount];

            int rowsPerThread = A.Rows / threadCount;

            for (int t = 0; t < threadCount; t++)
            {
                int startRow = t * rowsPerThread;
                int endRow = (t == threadCount - 1) ? A.Rows : startRow + rowsPerThread;

                threads[t] = new Thread(() =>
                {
                    for (int i = startRow; i < endRow; i++)
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
                    }
                });
            }

            // START
            foreach (var thread in threads)
                thread.Start();

            // WAIT
            foreach (var thread in threads)
                thread.Join();

            return result;
        }
    }
}
