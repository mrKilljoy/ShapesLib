using NUnit.Framework;
using ShapesLib;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(1, true)]
        [TestCase(3.2, true)]
        [TestCase(0, false)]
        [TestCase(-5, false)]
        public void IsCircleValid(double radius, bool isValid)
        {
            IShape circle;
            TestDelegate td = () => circle = new Circle(radius);
            if (isValid)
                Assert.DoesNotThrow(td);
            else
                Assert.Throws(typeof(ArgumentException), td);
        }

        [Test]
        [TestCase(1, 2, 3, false)]
        [TestCase(4, 2, 0, false)]
        [TestCase(16, 12, 20, true)]
        [TestCase(8, 4, 5, true)]
        public void IsTriangleValid(double a, double b, double c, bool isValid)
        {
            IShape triangle;
            TestDelegate td = () => triangle = new Triangle(a, b, c);

            if (isValid)
                Assert.DoesNotThrow(td);
            else
                Assert.Throws(typeof(ArgumentException), td);
        }

        [Test]
        [TestCase(5, 4, 2, false)]
        [TestCase(16, 12, 20, true)]
        [TestCase(6, 6, 3, false)]
        public void IsTriangleRight(double a, double b, double c, bool isValid)
        {
            IShape triangle = new Triangle(a, b, c);

            Assert.AreEqual(isValid, ((Triangle)triangle).IsRight());
        }
    }
}