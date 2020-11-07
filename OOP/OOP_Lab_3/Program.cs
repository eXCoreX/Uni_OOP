using System;

namespace OOP_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mtx1 =
            {
                {1, 1, 1 },
                {2, 3, 4 },
                {3, 1, 0 }
            };
            double[,] mtx2 =
            {
                {1, 1 },
                {2, 0 }
            };
            double[,] mtx3 =
            {
                {1, 1 },
                {0, 2 }
            };
            MyMatrix a = new MyMatrix(mtx1);
            MyMatrix b = new MyMatrix(a);

            Console.WriteLine(b);
            Console.WriteLine();
            MyMatrix c = new MyMatrix(b.ToString());
            Console.WriteLine(c);
            Console.WriteLine();
            MyMatrix m1 = new MyMatrix(mtx2);
            MyMatrix m2 = new MyMatrix(mtx3); 
            Console.WriteLine(m1*m2);
            Console.WriteLine();
            Console.WriteLine(m2*m1);
            Console.WriteLine();

            double[,] mtx4 =
            {
                {1, 2, 3 },
                {1, 0, -1 }
            };
            MyMatrix M1 = new MyMatrix(mtx4);
            Console.WriteLine(M1);
            Console.WriteLine();
            M1.TransponeMe();
            Console.WriteLine(M1);
            return;
        }
    }
}
