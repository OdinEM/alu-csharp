using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_TwoPositiveIntegers_ReturnsCorrectSum()
        {
            Assert.That(Operations.Add(5, 7), Is.EqualTo(12));
        }

        [Test]
        public void Add_TwoNegativeIntegers_ReturnsCorrectSum()
        {
            Assert.That(Operations.Add(-5, -7), Is.EqualTo(-12));
        }

        [Test]
        public void Add_PositiveAndNegativeIntegers_ReturnsCorrectSum()
        {
            Assert.That(Operations.Add(5, -3), Is.EqualTo(2));
        }

        [Test]
        public void Add_ZeroAndPositiveInteger_ReturnsPositiveInteger()
        {
            Assert.That(Operations.Add(0, 5), Is.EqualTo(5));
        }

        [Test]
        public void Add_TwoZeros_ReturnsZero()
        {
            Assert.That(Operations.Add(0, 0), Is.EqualTo(0));
        }
    }
}
