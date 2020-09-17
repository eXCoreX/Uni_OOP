using System;

namespace OOP_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = (r.Next() % 40) + 10; // [10; 50]
            int total = n * n;

            Console.WriteLine($"Total number of elements is {total}");

            int a, b;
            Console.Write("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            b = int.Parse(Console.ReadLine());

            if (a < 1)
            {
                Console.WriteLine("a should be a natural number");
            }
            if (b < a)
            {
                Console.WriteLine("b should be equal or greater than a");
                return;
            }
            if (b > total)
            {
                Console.WriteLine($"b should be less than total number of elements ({total})");
            }

            int rowsCnt = 0;
            int[][] C = new int[total][];
            int left = total;
            int i = 0;
            while (left > 0)
            {
                rowsCnt++;
                int currentNumOfCols = Math.Min(left, (r.Next() % (b - a + 1)) + a); // [a; b]
                C[i] = new int[currentNumOfCols];
                for (int j = 0; j < currentNumOfCols; j++)
                {
                    C[i][j] = (r.Next() % 2001) - 1000; // [-1000; 1000]
                }
                left -= currentNumOfCols;
                i++;
            }

            Console.WriteLine("\nMatrix C:");
            Console.Write("[");
            for (int ii = 0; ii < rowsCnt; ii++)
            {
                Console.Write("[");
                for (int j = 0; j < C[ii].Length; j++)
                {
                    Console.Write(C[ii][j]);
                    if (j != C[ii].Length - 1)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.Write("]");
                    }
                }
                if (ii != rowsCnt -1)
                {
                    Console.WriteLine(",");
                }
                else
                {
                    Console.WriteLine("]");
                }
            }

            int[] F = new int[total];
            i = 0;
            for (int ii = 0; ii < rowsCnt; ii++)
            {
                for (int j = 0; j < C[ii].Length; j++)
                {
                    F[i++] = C[ii][j];
                }
            }

            Array.Sort(F);

            Console.WriteLine("\nSorted F:");

            Console.Write("[");
            for (int ii = 0; ii < total; ii++)
            {
                if (ii != total - 1)
                {
                    Console.Write($"{F[ii]}, ");
                }
                else
                {
                    Console.WriteLine($"{F[ii]}]");
                }
            }
            i = 0;
            int[][] Q = new int[n][];
            for (int ii = 0; ii < n; ii++)
            {
                Q[ii] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    Q[ii][j] = F[i++];
                }
            }

            Console.WriteLine("\nMatrix Q:");
            Console.Write("[");
            for (int ii = 0; ii < n; ii++)
            {
                Console.Write("[");
                for (int j = 0; j < Q[ii].Length; j++)
                {
                    Console.Write(Q[ii][j]);
                    if (j != Q[ii].Length - 1)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.Write("]");
                    }
                }
                if (ii != n - 1)
                {
                    Console.WriteLine(",");
                }
                else
                {
                    Console.WriteLine("]");
                }
            }
        }
    }
}
