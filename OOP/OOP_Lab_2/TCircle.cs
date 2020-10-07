using System;
using System.Diagnostics.CodeAnalysis;

namespace OOP_Lab_2
{
    public class TCircle : IComparable<TCircle>
    {
        protected double radius;


        public double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }


        public double Length
        {
            get
            {
                return 2 * Math.PI * radius;
            }
        }


        public TCircle()
        {
            radius = 1;
        }


        public TCircle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius can't be less than 0");
            }
            this.radius = radius;
        }


        public TCircle(TCircle other)
        {
            this.radius = other.radius;
        }


        public override string ToString()
        {
            return string.Format("Circle, radius = {0}", radius);
        }


        public void InputCircle()
        {
            Console.Write("Enter radius: ");
            double tmp = double.Parse(Console.ReadLine());
            if (tmp < 0)
            {
                throw new ArgumentException("Radius can't be less than 0");
            }
            this.radius = tmp;
        }


        public double GetSectorArea(double angle)
        {
            return Math.Abs(angle * radius * radius / 2.0);
        }


        public int CompareTo(TCircle other)
        {
            return this.radius.CompareTo(other.radius);
        }


        public static TCircle operator +(TCircle first, TCircle second)
        {
            return new TCircle(first.radius + second.radius);
        }


        public static TCircle operator -(TCircle first, TCircle second)
        {
            return new TCircle(Math.Abs(first.radius - second.radius));
        }


        public static TCircle operator *(TCircle circle, double multiplier)
        {
            return new TCircle(circle.radius * multiplier);
        }


        public static TCircle operator *(double multiplier, TCircle circle)
        {
            return new TCircle(circle.radius * multiplier);
        }
    }
}
