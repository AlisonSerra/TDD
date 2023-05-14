namespace TDD.Test
{
    public class CalculationTest
    {
        [Fact]
        public void TestAddition()
        {
            // Arrange
            int x = 2;
            int y = 3;
            int expectedSum = 5;

            // Act
            int actualSum = Calculator.Addition(x, y);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void TestMultiplication()
        {
            // Arrange
            int x = 5;
            int y = 3;
            int expectedProduct = 15;

            // Act
            int actualProduct = Calculator.Multiply(x, y);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void TestDivision()
        {
            // Arrange
            int x = 10;
            int y = 3;
            int expectedDivision = 3;

            // Act
            int actualDivision = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expectedDivision, actualDivision);
        }

        [Fact]
        public void TestSubtraction()
        {
            // Arrange
            int x = 8;
            int y = 3;
            int expectedDifference = 5;

            // Act
            int actualDifference = Calculator.Subtraction(x, y);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }

    }
}