using System;
using System.Numerics;

namespace OOP_Lab_5
{
    public class Frac : IMyNumber<Frac>
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
                }
            }
        }

        // Constuctors

        public Frac()
        {
            num = 0;
            denom = 1;
        }


        public Frac(BigInteger num, BigInteger denom)
        {
            Num = num;
            Denom = denom;
            Normalize();
        }


        public Frac(int num, int denom)
        {
            Num = num;
            Denom = denom;
            Normalize();
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

        public Frac Add(Frac b)
        {
            return new Frac(Num * b.Denom + Denom * b.Num, Denom * b.Denom);
        }


        public Frac Divide(Frac b)
        {
            if (b.Num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Frac(Num * b.Denom, Denom * b.Num);
        }


        public Frac Multiply(Frac b)
        {
            return new Frac(Num * b.Num, Denom * b.Denom);
        }


        public Frac Subtract(Frac b)
        {
            return new Frac(Num * b.Denom - Denom * b.Num, Denom * b.Denom);
        }

        // Static Methods

        public static Frac operator +(Frac a, Frac b)
        {
            return a.Add(b);
        }


        public static Frac operator /(Frac a, Frac b)
        {
            return a.Divide(b);
        }


        public static Frac operator *(Frac a, Frac b)
        {
            return a.Multiply(b);
        }


        public static Frac operator -(Frac a, Frac b)
        {
            return a.Subtract(b);
        }
    }
}
