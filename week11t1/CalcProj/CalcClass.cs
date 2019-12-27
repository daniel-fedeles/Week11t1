using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcProj
{
    public class CalcClass
    {
        public decimal Add(decimal a, decimal b)
        {
            decimal x = a + b;
            return x;
        }
        public decimal Mul(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Sub(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Div(decimal a, decimal b)
        {
            if (b == 0) throw new DivideByZeroException(nameof(b));

            return a / b;
        }
    }
}
