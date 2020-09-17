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

        public static bool CanExist(double a, double b, double c)
        {
            return (a < b + c && b < a + c & c < a + b);
        }

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (CanExist(value, b, c))
                {
                    a = value;
                }
                else
                {
                    throw new ArgumentException("Attempted to make illegal triangle");
                }
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (CanExist(a, value, c))
                {
                    b = value;
                }
                else
                {
                    throw new ArgumentException("Attempted to make illegal triangle");
                }
            }
        }

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (CanExist(a, b, value))
                {
                    c = value;
                }
                else
                {
                    throw new ArgumentException("Attempted to make illegal triangle");
                }
            }
        }

        public double Perimeter
        {
            get
            {
                return a + b + c;
            }
        }

        public double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }
}
