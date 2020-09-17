using System;

namespace OOP_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            b = int.Parse(Console.ReadLine());

            if (b < a)
            {
                Console.WriteLine("b should be equal or greater than a");
                return;
            }

            Random r = new Random();
            int n = (r.Next() % (b - a + 1)) + a;
        }
    }
}
