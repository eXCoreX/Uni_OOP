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

            TCircle circle = new TCircle();
            circle.InputCircle();
            Console.WriteLine(circle);
            TCircle circle2 = new TCircle(circle);
            Console.WriteLine(circle2);
            Console.WriteLine(circle2.Area);
            Console.WriteLine(circle2.GetSectorArea(Math.PI/3.0));

            TSphere sphere = new TSphere(3.5);
            Console.WriteLine(sphere.Volume);
            TCircle sphereAsCircle = sphere as TCircle;
            Console.WriteLine(sphereAsCircle);
            Console.WriteLine(sphere.Length);

            TCircle circle3 = circle + sphereAsCircle;
            Console.WriteLine(circle3);
            Console.WriteLine(circle3 * 9);
            Console.WriteLine(circle3 - 1.5 * sphereAsCircle);
            Console.ReadKey();
        }
    }
}
