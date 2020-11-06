using System;
namespace OOP_Lab_2
{
    public class TCircleF : IComparable<TCircleF>
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


        public TCircleF()
        {
            radius = 1;
        }


        public TCircleF(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius can't be less than 0");
            }
            this.radius = radius;
        }


        public TCircleF(TCircleF other)
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


        public int CompareTo(TCircleF other)
        {
            return this.radius.CompareTo(other.radius);
        }


        public static TCircleF operator +(TCircleF first, TCircleF second)
        {
            return new TCircleF(first.radius + second.radius);
        }


        public static TCircleF operator -(TCircleF first, TCircleF second)
        {
            return new TCircleF(Math.Abs(first.radius - second.radius));
        }


        public static TCircleF operator *(TCircleF circle, double multiplier)
        {
            return new TCircleF(circle.radius * multiplier);
        }


        public static TCircleF operator *(double multiplier, TCircleF circle)
        {
            return new TCircleF(circle.radius * multiplier);
        }


        public override bool Equals(object obj)
        {
            return radius.Equals((obj as TCircleF).radius);
        }


        public override int GetHashCode()
        {
            return radius.GetHashCode();
        }
    }
}
