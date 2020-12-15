using System;
using System.Diagnostics.CodeAnalysis;

namespace OOP_Lab_5
{
    public class MyComplex : IMyNumber<MyComplex>, IEquatable<MyComplex>
    {
        // Fields

        private double re, im;

        // Properties

        public double Re
        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }
        }


        public double Im
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }

        // Constuctors

        public MyComplex()
        {
            re = 0;
            im = 0;
        }


        public MyComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        // Public Methods

        public MyComplex Add(MyComplex b)
        {
            return new MyComplex(re + b.re, im + b.im);
        }


        public MyComplex Divide(MyComplex b)
        {
            double denom = b.re * b.re + b.im * b.im;
            if (denom == 0)
            {
                throw new DivideByZeroException();
            }
            return new MyComplex((re * b.re + im * b.im) / denom, (im * b.re - re * b.im) / denom);
        }


        public MyComplex Multiply(MyComplex b)
        {
            return new MyComplex(re * b.re - im * b.im, im * b.re + re * b.im);
        }


        public MyComplex Subtract(MyComplex b)
        {
            return new MyComplex(re - b.re, im - b.im);
        }


        public override string ToString()
        {
            return string.Format("{0}" + (im < 0 ? "" : "+") + "{1}i", re, im);
        }


        public bool Equals([AllowNull] MyComplex other)
        {
            if (other is null)
            {
                return false;
            }

            return (re == other.re) && (im == other.im);
        }


        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (obj is MyComplex)
            {
                return this == obj as MyComplex;
            }
            else
            {
                return false;
            }
        }


        public override int GetHashCode()
        {
            return re.GetHashCode() + 31 * im.GetHashCode();
        }

        // Static Methods

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return a.Add(b);
        }


        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            return a.Divide(b);
        }


        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return a.Multiply(b);
        }


        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return a.Subtract(b);
        }


        public static bool operator ==(MyComplex a, MyComplex b)
        {
            return a.Equals(b);
        }


        public static bool operator !=(MyComplex a, MyComplex b)
        {
            return !a.Equals(b);
        }
    }
}
