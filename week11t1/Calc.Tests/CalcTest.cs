using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CalcProj;
using Xunit;
using Xunit.Abstractions;

namespace Calc.Tests
{

    public class CalcTest
    {
        private CalcClass calcClass;

        public CalcTest()
        {
            calcClass = new CalcClass();
        }

        [Theory]
        [InlineData(3, 7, 10)]
        [InlineData(5, 9.2, 14.2)]
        [InlineData(6.00, 6.3, 12.3)]
        [InlineData(3, 0, 3)]
        [InlineData(0, 9.2, 9.2)]
        [InlineData(-5, 5, 0)]
        [InlineData(-5, -5, -10)]
        [InlineData(5, -5, 0)]
        [Trait("Category", "Add")]
        public void TestAdd(decimal a, decimal b, decimal c)
        {
            Assert.Equal(c, calcClass.Add(a, b));

        }

        [Theory]
        [InlineData(3, 7, 21)]
        [InlineData(5, 9.2, 46)]
        [InlineData(6.00, 6.3, 37.8)]
        [InlineData(3, 0, 0)]
        [InlineData(0, 9.2, 0)]
        [InlineData(-5, 5, -25)]
        [InlineData(-5, -5, 25)]
        [InlineData(5, -5, -25)]
        [Trait("Category", "Mul")]
        public void TestMul(decimal a, decimal b, decimal c)
        {
            Assert.Equal(c, calcClass.Mul(a, b));

        }

        [Theory]
        [InlineData(3, 7, -4)]
        [InlineData(9.2, 9, 0.2)]
        [InlineData(6.00, 6, 0)]
        [InlineData(3, 0, 3)]
        [InlineData(0, 9.2, -9.2)]
        [InlineData(-5, 5, -10)]
        [InlineData(-5, -5, 0)]
        [InlineData(5, -5, 10)]
        [Trait("Category", "Sub")]
        public void TestSub(decimal a, decimal b, decimal c)
        {
            Assert.Equal(c, calcClass.Sub(a, b));

        }

        [Theory]
        [InlineData(21, 7, 3)]
        [InlineData(24.5, 7, 3.5)]
        [InlineData(-5, 5, -1)]
        [InlineData(5, -5, -1)]
        [InlineData(-5, -5, 1)]
        [Trait("Category", "Sub")]
        public void TestDiv(decimal a, decimal b, decimal c)
        {
            Assert.Equal(c, calcClass.Div(a, b));
        }

        [Theory]
        [InlineData(3, 0)]
        [Trait("Category", "DevideByZero")]
        public void DevideByZero(decimal a, decimal b)
        {

            Assert.Throws<DivideByZeroException>(() => calcClass.Div(a, b));
        }
    }
}
