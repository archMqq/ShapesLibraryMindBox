using ShapesLibrary.Calculators.Interfaces;
using ShapesLibrary.Shapes;

namespace ShapesLibrary.Calculators
{
    public class RightAngleTriangleCalculator : ICalculator<bool, Triangle>
    {
        public RightAngleTriangleCalculator() { }
        public bool Calculate(Triangle triangle)
        {
            double[] sides = triangle.getSides();
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
