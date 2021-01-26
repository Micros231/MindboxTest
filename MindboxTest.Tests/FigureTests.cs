using NUnit.Framework;
using System;

namespace MindboxTest.Tests
{
    [TestFixture]
    public class FigureTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSquareCircle()
        {
            var radius = 5;
            var circle = new Circle(radius);
            var square = circle.Square();

            float squareTest = MathF.PI * MathF.Pow(radius, 2);
            Assert.AreEqual(square, squareTest);
        }
        [Test]
        public void TestSquareTriangle()
        {
            var sideA = 5;
            var sideB = 3;
            var sideC = 6;
            var triangle = new Triangle(sideA, sideB, sideC);
            var p = (sideA + sideB + sideC) / 2;
            float squareTest = p * (p - sideA) * (p - sideB) * (p - sideC);
            squareTest = MathF.Sqrt(squareTest);
            var square = triangle.Square();
            Assert.AreEqual(square, squareTest);
        }
        [Test]
        public void TestTriangleIsRectangular()
        {
            var sideA = 5;
            var sideB = 3;
            var sideC = 4;
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.IsTrue(triangle.IsRectangular());
        }
    }
}