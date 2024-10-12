using Xunit;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = Operations.Add(3, 5);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            int result = Operations.Add(10, -3);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            int result = Operations.Add(-4, -6);
            Assert.Equal(-10, result);
        }
    }
}
