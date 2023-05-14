using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Test
{
    public class ChildCalculationTest
    {
        [Fact]
        public void TestChildCalculatorFrench_Addition()
        {
            // Arrange
            string input = "5 plus 3";
            int expectedSum = 8;

            // Act
            int actualSum = ChildCalculator.Calculate(input);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void TestChildCalculatorFrench_Subtraction()
        {
            // Arrange
            string input = "10 moins 4";
            int expectedDifference = 6;

            // Act
            int actualDifference = ChildCalculator.Calculate(input);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Fact]
        public void TestChildCalculatorFrench_Multiplication()
        {
            // Arrange
            string input = "3 multiplié par 6";
            int expectedProduct = 18;

            // Act
            int actualProduct = ChildCalculator.Calculate(input);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void TestChildCalculatorFrench_Division()
        {
            // Arrange
            string input = "15 divisé par 3";
            int expectedDivision = 5;

            // Act
            int actualDivision = ChildCalculator.Calculate(input);

            // Assert
            Assert.Equal(expectedDivision, actualDivision);
        }

        [Fact]
        public void TestChildCalculatorEnglish_Addition()
        {
            // Arrange
            string input = "5 plus 3";
            int expectedSum = 8;

            // Act
            int actualSum = ChildCalculator.Calculate(input, new CultureInfo("en-US"));

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void TestChildCalculatorEnglish_Subtraction()
        {
            // Arrange
            string input = "10 minus 4";
            int expectedDifference = 6;

            // Act
            int actualDifference = ChildCalculator.Calculate(input, new CultureInfo("en-US"));

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Fact]
        public void TestChildCalculatorEnglish_Multiplication()
        {
            // Arrange
            string input = "3 times 6";
            int expectedProduct = 18;

            // Act
            int actualProduct = ChildCalculator.Calculate(input, new CultureInfo("en-US"));

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void TestChildCalculatorEnglish_Division()
        {
            // Arrange
            string input = "15 divided by 3";
            int expectedDivision = 5;

            // Act
            int actualDivision = ChildCalculator.Calculate(input, new CultureInfo("en-US"));

            // Assert
            Assert.Equal(expectedDivision, actualDivision);
        }
    }

}
