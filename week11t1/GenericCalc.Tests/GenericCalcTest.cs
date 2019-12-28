using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GenericCalc.Tests
{
    public class GenericCalcTest
    {
        private GenCalc<decimal> calcClass;
        private GenCalc<string> strGenCalc;

        public GenericCalcTest()
        {
            calcClass = new GenCalc<decimal>();
            strGenCalc = new GenCalc<string>();
        }


        [Theory]
        [InlineData(3, 7, 10)]
        [InlineData(5, 9.2, 14.2)]
        [InlineData(6.00, 6.3, 12.3)]
        [InlineData(3, 0, 3)]
        [InlineData(0, 9.2, 9.2)]
        [InlineData(-5, 5, 0)]
        [InlineData(-5, -5, -10)]
        // [InlineData(5, -5, 0)]
        [Trait("Category", "Add")]
        public void TestAdd(decimal a, decimal b, decimal c)
        {
            Assert.Equal(c, calcClass.Add(a, b));

        }

        [Theory]
        [InlineData("3", "7")]
        [Trait("Category", "Add")]
        public void TestStrAdd(string a, string b)
        {
            Assert.Throws<NotANumberException>(() => strGenCalc.Add(a, b));

        }
    }
}
