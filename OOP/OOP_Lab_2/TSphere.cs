﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace OOP_Lab_2
{
    public class TSphere : TCircleF, IComparable<TSphere>
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

        public TSphere()
        {
            this.radius = 1;
            this.Color = "None";
        }


        public TSphere(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius can't be less than 0");
            }
            this.radius = radius;
            this.Color = "None";
        }


        public TSphere(double radius, string color)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius can't be less than 0");
            }
            this.radius = radius;
            this.Color = color;
        }


        public TSphere(TSphere other)
        {
            this.radius = other.radius;
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

        public int CompareTo(TSphere other)
        {
            return this.radius.CompareTo(other.radius);
        }


        public static TSphere operator +(TSphere first, TSphere second)
        {
            return new TSphere(first.radius + second.radius);
        }


        public static TSphere operator -(TSphere first, TSphere second)
        {
            return new TSphere(Math.Abs(first.radius - second.radius));
        }


        public static TSphere operator *(TSphere circle, double multiplier)
        {
            return new TSphere(circle.radius * multiplier);
        }


        public static TSphere operator *(double multiplier, TSphere circle)
        {
            return new TSphere(circle.radius * multiplier);
        }
    }
}
