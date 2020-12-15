using System;
using Xunit;
using OOP_Lab_5;

namespace OOP_Lab_5_Tests
{
    public class AddTestFrac
    {
        [Fact]
        public void TestAddFrac()
        {
            MyFrac f1 = new MyFrac(1, 2);
            MyFrac f2 = new MyFrac(3, 4);
            var sum = f1 + f2;
            Assert.True(sum == f1.Add(f2));
            Assert.True(sum.Num == 5);
            Assert.True(sum.Denom == 4);
        }
    }


    public class AddTestComplex
    {
        [Fact]
        public void TestAddComplex()
        {
            MyComplex f1 = new MyComplex(1, 2);
            MyComplex f2 = new MyComplex(3, 4);
            var sum = f1 + f2;
            Assert.True(sum == f1.Add(f2));
            Assert.True(sum.Re == 4);
            Assert.True(sum.Im == 6);
        }
    }


    public class SubTestFrac
    {
        [Fact]
        public void TestSubFrac()
        {
            MyFrac f1 = new MyFrac(1, 2);
            MyFrac f2 = new MyFrac(3, 4);
            var diff = f1 - f2;
            Assert.True(diff == f1.Subtract(f2));
            Assert.True(diff.Num == -1);
            Assert.True(diff.Denom == 4);
        }
    }


    public class SubTestComplex
    {
        [Fact]
        public void TestSubComplex()
        {
            MyComplex f1 = new MyComplex(1, 2);
            MyComplex f2 = new MyComplex(3, 4);
            var diff = f1 - f2;
            Assert.True(diff == f1.Subtract(f2));
            Assert.True(diff.Re == -2);
            Assert.True(diff.Im == -2);
        }
    }


    public class MulTestFrac
    {
        [Fact]
        public void TestMulFrac()
        {
            MyFrac f1 = new MyFrac(1, 2);
            MyFrac f2 = new MyFrac(3, 4);
            var prod = f1 * f2;
            Assert.True(prod == f1.Multiply(f2));
            Assert.True(prod.Num == 3);
            Assert.True(prod.Denom == 8);
        }
    }


    public class MulTestComplex
    {
        [Fact]
        public void TestMulComplex()
        {
            MyComplex f1 = new MyComplex(1, 2);
            MyComplex f2 = new MyComplex(3, 4);
            var prod = f1 * f2;
            Assert.True(prod == f1.Multiply(f2));
            Assert.True(prod.Re == -5);
            Assert.True(prod.Im == 10);
        }
    }


    public class DivTestFrac
    {
        [Fact]
        public void TestDivFrac()
        {
            MyFrac f1 = new MyFrac(1, 2);
            MyFrac f2 = new MyFrac(3, -4);
            var quot = f1 / f2;
            Assert.True(quot == f1.Divide(f2));
            Assert.True(quot.Num == -2);
            Assert.True(quot.Denom == 3);
        }
    }


    public class DivTestComplex
    {
        [Fact]
        public void TestDivComplex()
        {
            MyComplex f1 = new MyComplex(1, 2);
            MyComplex f2 = new MyComplex(3, -4);
            var quot = f1 / f2;
            Assert.True(quot == f1.Divide(f2));
            Assert.True(quot.Re == -5/25.0);
            Assert.True(quot.Im == 10/25.0);
        }
    }


    public class DivZeroConstructorTestFrac
    {
        [Fact]
        public void TestDivZeroConstructorFrac()
        {
            Assert.Throws<ArgumentException>(() => new MyFrac(1, 0));
        }
    }


    public class DivZeroTestFrac
    {
        [Fact]
        public void TestDivZeroFrac()
        {
            MyFrac a = new MyFrac(1, 2);
            MyFrac b = new MyFrac();
            Assert.Throws<DivideByZeroException>(() => a.Divide(b));
        }
    }


    public class DivZeroTestComplex
    {
        [Fact]
        public void TestDivZeroComplex()
        {
            MyComplex a = new MyComplex(1, 2);
            MyComplex b = new MyComplex();
            Assert.Throws<DivideByZeroException>(() => a.Divide(b));
        }
    }


    public class NullTestFrac
    {
        [Fact]
        public void TestNullFrac()
        {
            MyFrac a = new MyFrac(1, 2);
            Assert.False(a == null);
            Assert.NotNull(a);
            Assert.False(((object)a).Equals(null));
        }
    }


    public class NullTestComplex
    {
        [Fact]
        public void TestNullComplex()
        {
            MyComplex a = new MyComplex(1, 2);
            Assert.False(a == null);
            Assert.NotNull(a);
            Assert.False(((object)a).Equals(null));
        }
    }


    public class ToStringTestFrac
    {
        [Fact]
        public void TestToStringFrac()
        {
            MyFrac a = new MyFrac(1, 2);
            Assert.Equal("1/2", a.ToString());
            MyFrac b = new MyFrac(1, -2);
            Assert.Equal("-1/2", b.ToString());
        }
    }


    public class ToStringTestComplex
    {
        [Fact]
        public void TestToStringComplex()
        {
            MyComplex a = new MyComplex(1, 2);
            Assert.Equal("1+2i", a.ToString());
            MyComplex b = new MyComplex(1, -2);
            Assert.Equal("1-2i", b.ToString());
        }
    }
}
