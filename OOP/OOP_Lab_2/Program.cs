using System;
using System.Collections.Generic;

namespace OOP_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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
            TCircleF sphereAsCircle = sphere as TCircleF;
            Console.WriteLine(sphereAsCircle);
            Console.WriteLine(sphere.Length);

            TCircle circle3 = circle + circle2;
            Console.WriteLine(circle3);
            Console.WriteLine(circle3 * 9);
            Console.WriteLine(circle3 - 1.5 * circle);

            */
            // Additional task

            HashSet<TCircle> circleHS = new HashSet<TCircle>();
            TCircle first = new TCircle(2.00);
            circleHS.Add(first);
            TCircle second = new TCircle(2.00);
            Console.WriteLine(circleHS.Contains(second));

            HashSet<TCircleF> circleFHS = new HashSet<TCircleF>();
            TCircleF firstF = new TCircleF(2.00);
            circleFHS.Add(firstF);
            TCircleF secondF = new TCircleF(2.00);
            Console.WriteLine(circleFHS.Contains(secondF));

            HashSet<TCircleF> circleFHS2 = new HashSet<TCircleF>();
            TCircleF firstF2 = new TCircleF(2.00);
            circleFHS.Add(firstF2);
            TCircleF secondF2 = new TCircleF(2.01);
            Console.WriteLine(circleFHS.Contains(secondF2));

            HashSet<TSphere> sphereHS = new HashSet<TSphere>();
            sphereHS.Add(new TSphere(1.00, "Red"));
            sphereHS.Add(new TSphere(1.00, "Green"));
            sphereHS.Add(new TSphere(1.00, "Blue"));
            sphereHS.Add(new TSphere(1.00, "Teal"));
            sphereHS.Add(new TSphere(1.00, "Red"));
            Console.WriteLine(sphereHS.Count);

            HashSet<TSphereF> sphereFHS = new HashSet<TSphereF>();
            sphereFHS.Add(new TSphereF(1.00, "Red"));
            sphereFHS.Add(new TSphereF(1.00, "Green"));
            sphereFHS.Add(new TSphereF(1.00, "Blue"));
            sphereFHS.Add(new TSphereF(1.00, "Teal"));
            sphereFHS.Add(new TSphereF(1.00, "Red"));
            Console.WriteLine(sphereFHS.Count);



            Console.ReadKey();
        }
    }
}
