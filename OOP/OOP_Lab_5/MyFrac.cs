using System;
using System.Numerics;

namespace OOP_Lab_5
{
    public class MyFrac : IMyNumber<MyFrac>
    {
        // Fields

        private BigInteger num, denom;

        // Properties

        public BigInteger Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
                Normalize();
            }
        }


        public BigInteger Denom
        {
            get
            {
                return denom;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator can't be zero");
                }
                else
                {
                    denom = value;
                    Normalize();
                }
            }
        }

        // Constuctors

        public MyFrac()
        {
            num = 0;
            denom = 1;
        }


        public MyFrac(BigInteger num, BigInteger denom)
        {
            this.num = num;
            Denom = denom;
        }


        public MyFrac(int num, int denom)
        {
            this.num = num;
            Denom = denom;
        }

        // Private methods

        private BigInteger GCD()
        {
            BigInteger a = Num, b = Denom;
            while (a != 0 && b != 0)
            {
                a %= b;
                if (a == 0)
                {
                    return b;
                }
                b %= a;
            }
            return BigInteger.Max(a, b);
        }


        private void Normalize()
        {
            var gcd = GCD();
            Num /= gcd;
            Denom /= gcd;
        }

        // Public Methods

        public MyFrac Add(MyFrac b)
        {
            return new MyFrac(Num * b.Denom + Denom * b.Num, Denom * b.Denom);
        }


        public MyFrac Divide(MyFrac b)
        {
            if (b.Num == 0)
            {
                throw new DivideByZeroException();
            }
            return new MyFrac(Num * b.Denom, Denom * b.Num);
        }


        public MyFrac Multiply(MyFrac b)
        {
            return new MyFrac(Num * b.Num, Denom * b.Denom);
        }


        public MyFrac Subtract(MyFrac b)
        {
            return new MyFrac(Num * b.Denom - Denom * b.Num, Denom * b.Denom);
        }


        public override string ToString()
        {
            return string.Format("{0}/{1}", num, denom);
        }

        // Static Methods

        public static MyFrac operator +(MyFrac a, MyFrac b)
        {
            return a.Add(b);
        }


        public static MyFrac operator /(MyFrac a, MyFrac b)
        {
            return a.Divide(b);
        }


        public static MyFrac operator *(MyFrac a, MyFrac b)
        {
            return a.Multiply(b);
        }


        public static MyFrac operator -(MyFrac a, MyFrac b)
        {
            return a.Subtract(b);
        }
    }
}
