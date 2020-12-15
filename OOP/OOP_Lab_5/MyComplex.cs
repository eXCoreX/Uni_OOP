using System;
namespace OOP_Lab_5
{
    public class MyComplex : IMyNumber<MyComplex>
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

        // Private methods

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
    }
}
