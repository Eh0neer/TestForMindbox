using Microsoft.VisualStudio.TestTools.UnitTesting;
using test.Figures;

namespace test.Tests
{
    /// <summary>
    /// Unit tests for IShape
    /// </summary>
    [TestClass]
    public class IShapeTests
    {
        [TestMethod]
        public void Circle_AreaCalculation()
        {
            // Arrange
            Circle circle = new Circle(3);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(Math.PI * 9, area);
        }

        [TestMethod]
        public void Triangle_AreaCalculation()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }
    }
}
