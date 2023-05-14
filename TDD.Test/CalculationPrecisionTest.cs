using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Test
{
    public class CalculationPrecisionTest
    {
        [Fact]
        public void TestDecimalAddition()
        {
            // Arrange
            decimal x = 2.5m;
            decimal y = 3.7m;
            int precision = 2;
            decimal expectedSum = 6.2m;

            // Act
            decimal actualSum = CalculatorPrecision.Add(x, y, precision);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void TestDecimalMultiplication()
        {
            // Arrange
            decimal x = 2.5m;
            decimal y = 3.7m;
            int precision = 3;
            decimal expectedProduct = 9.25m;

            // Act
            decimal actualProduct = CalculatorPrecision.Multiply(x, y, precision);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void TestDecimalDivision()
        {
            // Arrange
            decimal x = 10.5m;
            decimal y = 3.2m;
            int precision = 4;
            decimal expectedDivision = 3.2812m;

            // Act
            decimal actualDivision = CalculatorPrecision.Divide(x, y, precision);

            // Assert
            Assert.Equal(expectedDivision, actualDivision);
        }

        [Fact]
        public void TestDecimalSubtraction()
        {
            // Arrange
            decimal x = 8.7m;
            decimal y = 3.2m;
            int precision = 1;
            decimal expectedDifference = 5.5m;

            // Act
            decimal actualDifference = CalculatorPrecision.Subtract(x, y, precision);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }
    }
}
