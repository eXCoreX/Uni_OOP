using System;
using System.Diagnostics.CodeAnalysis;

namespace OOP_Lab_2
{
    public class TSphereF : TCircleF, IComparable<TSphereF>
    {
        public string Color
        {
            get;
            set;
        }

        public double Volume
        {
            get
            {
                return 4.0 / 3.0 * Math.PI * radius * radius * radius;
            }
        }

        public TSphereF()
        {
            this.radius = 1;
            this.Color = "None";
        }


        public TSphereF(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius can't be less than 0");
            }
            this.radius = radius;
            this.Color = "None";
        }


        public TSphereF(double radius, string color)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius can't be less than 0");
            }
            this.radius = radius;
            this.Color = color;
        }


        public TSphereF(TSphereF other)
        {
            this.radius = other.radius;
            Color = (string)other.Color.Clone();
        }


        public override string ToString()
        {
            return string.Format("Sphere, radius = {0}, color is {1}", radius, Color);
        }


        public void InputSphere()
        {
            base.InputCircle();
            Console.Write("Enter color: ");
            Color = Console.ReadLine();
        }

        public int CompareTo(TSphereF other)
        {
            return this.radius.CompareTo(other.radius);
        }


        public static TSphereF operator +(TSphereF first, TSphereF second)
        {
            return new TSphereF(first.radius + second.radius);
        }


        public static TSphereF operator -(TSphereF first, TSphereF second)
        {
            return new TSphereF(Math.Abs(first.radius - second.radius));
        }


        public static TSphereF operator *(TSphereF sphere, double multiplier)
        {
            return new TSphereF(sphere.radius * multiplier);
        }


        public static TSphereF operator *(double multiplier, TSphereF sphere)
        {
            return new TSphereF(sphere.radius * multiplier);
        }


        public override bool Equals(object obj)
        {
            var objSp = obj as TSphereF;
            return base.Equals(objSp) && (Color == objSp.Color);
        }


        public override int GetHashCode()
        {
            return base.GetHashCode() + Color.GetHashCode() * 31;
        }
    }
}
