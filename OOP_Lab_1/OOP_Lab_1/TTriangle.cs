using System;
namespace OOP_Lab_1
{
    public class TTriangle
    {
        protected double a, b, c; // sides

        public TTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be of positive length");
            }
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("Bad triangle");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double getA()
        {
            return a;
        }

        public double getB()
        {
            return b;
        }

        public double getC()
        {
            return c;
        }

        public TTriangle()
        {
        }
    }
}
