using test.Interface;

namespace test
{
    /// <summary>
    /// Вычисление площади фигуры без знания типа фигуры в compile-time
    /// </summary>
    public class ShapeCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
