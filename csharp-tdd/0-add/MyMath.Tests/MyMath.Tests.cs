using Xunit;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Fact]
        public void Add_ShouldReturnSumOfTwoIntegers()
        {
            // Arrange
            int a = 5;
            int b = 10;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Add_ShouldReturnNegativeSum_WhenAddingNegativeNumbers()
        {
            // Arrange
            int a = -5;
            int b = -3;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.Equal(-8, result);
        }

        [Fact]
        public void Add_ShouldReturnZero_WhenAddingZeroes()
        {
            // Arrange
            int a = 0;
            int b = 0;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
