using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_ValidList_ReturnsMaxValue()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            int result = Operations.Max(nums);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int> { };
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            List<int> nums = null;
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_SingleElementList_ReturnsElement()
        {
            List<int> nums = new List<int> { 42 };
            int result = Operations.Max(nums);
            Assert.AreEqual(42, result);
        }

        [Test]
        public void Max_ListWithNegativeNumbers_ReturnsMaxValue()
        {
            List<int> nums = new List<int> { -10, -5, -1, -20 };
            int result = Operations.Max(nums);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Max_ListWithDuplicates_ReturnsMaxValue()
        {
            List<int> nums = new List<int> { 3, 7, 7, 2, 7 };
            int result = Operations.Max(nums);
            Assert.AreEqual(7, result);
        }
    }
}