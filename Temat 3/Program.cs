using System.Diagnostics;
using Temat_3;

class Program
{
    static long MeasureParallel(Matrix A, Matrix B, int threads, int repeats = 6)
    {
        long total = 0;
        for (int i = 0; i < repeats; i++)
        {
            var sw = Stopwatch.StartNew();
            MatrixMultiplier.Multiply(A, B, threads);
            sw.Stop();
            total += sw.ElapsedMilliseconds;
        }
        return total / repeats;
    }

    static long MeasureThread(Matrix A, Matrix B, int threads, int repeats = 6)
    {
        long total = 0;
        for (int i = 0; i < repeats; i++)
        {
            var sw = Stopwatch.StartNew();
            MatrixMultiplierThread.Multiply(A, B, threads);
            sw.Stop();
            total += sw.ElapsedMilliseconds;
        }
        return total / repeats;
    }

    static void RunTest(int size)
    {
        Console.WriteLine($"\n===== Rozmiar: {size}x{size} =====");

        Matrix A = new(size, size, true);
        Matrix B = new(size, size, true);

        int maxThreads = Environment.ProcessorCount * 2;

        long baseline = MeasureParallel(A, B, 1);

        Console.WriteLine("Wątki\tParallel(ms)\tThread(ms)\tPrzyspieszenie Parallel\tPrzyspieszenie Thread");

        for (int t = 1; t <= maxThreads; t++)
        {
            long pTime = MeasureParallel(A, B, t);
            long tTime = MeasureThread(A, B, t);

            double pSpeed = (double)baseline / pTime;
            double tSpeed = (double)baseline / tTime;

            Console.WriteLine($"{t}\t{pTime}\t\t{tTime}\t\t{pSpeed:F2}\t\t{tSpeed:F2}");
        }
    }

    static void Main()
    {
        int[] sizes = { 300, 500, 700 };

        foreach (var size in sizes)
        {
            RunTest(size);
        }
    }
}