using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace OOP_Lab_5
{
    public class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>, IEquatable<MyFrac>
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
            BigInteger a = num, b = denom;
            while (a != 0 && b != 0)
            {
                a %= b;
                if (a == 0)
                {
                    return b;
                }
                b %= a;
            }
            a = BigInteger.Abs(a);
            b = BigInteger.Abs(b);
            return BigInteger.Max(a, b);
        }


        private void Normalize()
        {
            var gcd = GCD();
            num /= gcd;
            denom /= gcd;
            if (denom < 0)
            {
                num = -num;
                denom = -denom;
            }
        }

        // Public Methods

        public MyFrac Add(MyFrac b)
        {
            return new MyFrac(num * b.denom + denom * b.num, denom * b.denom);
        }


        public MyFrac Divide(MyFrac b)
        {
            if (b.num == 0)
            {
                throw new DivideByZeroException();
            }
            return new MyFrac(num * b.denom, denom * b.num);
        }


        public MyFrac Multiply(MyFrac b)
        {
            return new MyFrac(num * b.num, denom * b.denom);
        }


        public MyFrac Subtract(MyFrac b)
        {
            return new MyFrac(num * b.denom - denom * b.num, denom * b.denom);
        }


        public override string ToString()
        {
            return string.Format("{0}/{1}", num, denom);
        }


        public int CompareTo(MyFrac other)
        {
            return (this - other).num.CompareTo(0);
        }


        public bool Equals([AllowNull] MyFrac other)
        {
            if (other is null)
            {
                return false;
            }

            return (num == other.num) && (denom == other.denom);
        }


        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (obj is MyFrac)
            {
                return this == obj as MyFrac;
            }
            else
            {
                return false;
            }
        }


        public override int GetHashCode()
        {
            return num.GetHashCode() + 31 * denom.GetHashCode();
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


        public static bool operator ==(MyFrac a, MyFrac b)
        {
            if (a is null)
            {
                return b is null;
            }
            return a.Equals(b);
        }


        public static bool operator !=(MyFrac a, MyFrac b)
        {
            if (a is null)
            {
                return !(b is null);
            }
            return !a.Equals(b);
        }
    }
}
