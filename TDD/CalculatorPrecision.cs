using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class CalculatorPrecision
    {
        public static decimal Add(decimal x, decimal y, int precision)
        {
            decimal sum = x + y;
            return Math.Round(sum, precision);
        }

        public static decimal Multiply(decimal x, decimal y, int precision)
        {
            decimal sum = x * y;
            return Math.Round(sum, precision);
        }

        public static decimal Divide(decimal x, decimal y, int precision)
        {
            decimal sum = x / y;
            return Math.Round(sum, precision);
        }

        public static decimal Subtract(decimal x, decimal y, int precision)
        {
            decimal sum = x - y;
            return Math.Round(sum, precision);
        }
    }
}
