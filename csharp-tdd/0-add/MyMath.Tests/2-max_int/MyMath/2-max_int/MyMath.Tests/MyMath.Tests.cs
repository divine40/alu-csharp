using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_WithPositiveNumbers_ReturnsMaxValue()
        {
            List<int> nums = new List<int> { 1, 3, 5, 7, 9 };
            Assert.AreEqual(9, Operations.Max(nums));
        }

        [Test]
        public void Max_WithNegativeNumbers_ReturnsMaxValue()
        {
            List<int> nums = new List<int> { -10, -5, -3, -1 };
            Assert.AreEqual(-1, Operations.Max(nums));
        }

        [Test]
        public void Max_WithMixedNumbers_ReturnsMaxValue()
        {
            List<int> nums = new List<int> { -10, 0, 5, 3 };
            Assert.AreEqual(5, Operations.Max(nums));
        }

        [Test]
        public void Max_WithEmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            Assert.AreEqual(0, Operations.Max(nums));
        }

        [Test]
        public void Max_WithNullList_ReturnsZero()
        {
            List<int> nums = null;
            Assert.AreEqual(0, Operations.Max(nums));
        }

        [Test]
        public void Max_WithSingleElementList_ReturnsThatElement()
        {
            List<int> nums = new List<int> { 42 };
            Assert.AreEqual(42, Operations.Max(nums));
        }
    }
}