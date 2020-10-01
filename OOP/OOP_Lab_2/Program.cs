using System;

namespace OOP_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(1, 1, 1, 2, 2, 2, 2, 1);
            Console.WriteLine(rect);
            rect.InputRectangle();
            Console.WriteLine(rect);
            Console.ReadKey();
        }
    }
}
