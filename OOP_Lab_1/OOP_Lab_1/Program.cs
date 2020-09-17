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

            Console.WriteLine("Matrix C:");
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
                if (ii == rowsCnt -1)
                {
                    Console.WriteLine("]");
                }
                else
                {
                    Console.WriteLine(",");
                }
            }
        }
    }
}
