using NUnit.Framework;
using MyMath;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrix_DividesCorrectly()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int num = 10;
            int[,] expected = { { 1, 2 }, { 3, 4 } };

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ByZero_ReturnsNull()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int num = 0;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 2);

            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NegativeNumber_DividesCorrectly()
        {
            int[,] matrix = { { -8, 16 }, { -24, 32 } };
            int num = -8;
            int[,] expected = { { 1, -2 }, { 3, -4 } };

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ZeroesInMatrix_ReturnsMatrixOfZeroes()
        {
            int[,] matrix = { { 0, 0 }, { 0, 0 } };
            int num = 5;
            int[,] expected = { { 0, 0 }, { 0, 0 } };

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }
    }
}