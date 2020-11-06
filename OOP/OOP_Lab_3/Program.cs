using System;

namespace OOP_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mtx =
            {
                {1, 1, 1 },
                {2, 3, 4 },
                {3, 1, 0 }
            };
            MyMatrix a = new MyMatrix(mtx);
            MyMatrix b = new MyMatrix(a);

            Console.WriteLine(b);
            MyMatrix c = new MyMatrix(b.ToString());
            Console.WriteLine(c);
            return;
        }
    }
}
