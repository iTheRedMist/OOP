using System.Diagnostics;

namespace LAB15
{
    internal class Program
    {
        static void PrintNumbers()
        {
            for (int i = 1; i <= 500; i++)
            {
                Console.Write($"{i} ");
                if (i % 25 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        static long CalculateFactorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факторіал {n} = {result}");
            return result;
        }
        static void task1()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Parallel.Invoke(
                () => PrintNumbers(),
                () => CalculateFactorial(10)
            );

            stopwatch.Stop();
            Console.WriteLine($"Час виконання: {stopwatch.ElapsedMilliseconds} мс");
        }

        static void task2()
        {
            int counter = 0;
            Parallel.For(0, 1000, i =>
            {
                Interlocked.Increment(ref counter);
            });
            Console.WriteLine($"Результат (by Interlocked): {counter}");
        }

        static void Main()
        {
            Console.WriteLine("=== 1 завдання ===");
            task1();
            Console.WriteLine("=== 2 завдання === \n");
            task2();
        }
    }
}
