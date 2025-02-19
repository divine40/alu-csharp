using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        [Test]
        public void Add_PositiveAndNegativeNumber_ReturnsSum()
        {
            Assert.AreEqual(1, Operations.Add(3, -2));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }

        [Test]
        public void Add_NumberWithZero_ReturnsSameNumber()
        {
            Assert.AreEqual(7, Operations.Add(7, 0));
            Assert.AreEqual(-4, Operations.Add(-4, 0));
        }
    }
}