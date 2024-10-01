using Newtonsoft.Json.Linq;
using ShapesLibrary.Calculators;
using ShapesLibrary.Calculators.Interfaces;
using ShapesLibrary.Shapes;
using ShapesLibrary.Shapes.Interfaces;

namespace ShapesLibraryTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleTest()
        {
            IVolumeCalculatable circle = new Circle(2);
            double realVolume = 12.5663706;

            double calculatedVolume = circle.Volume;

            Assert.AreEqual(realVolume, calculatedVolume, 1e-6);
        }

        [Test]
        public void TriangleTest()
        {
            IVolumeCalculatable triangle = new Triangle(3, 4, 5);
            double realVolume = 6;

            double calculatedVolume = triangle.Volume;

            Assert.AreEqual(realVolume, calculatedVolume, 1e-6);
        }

        [Test]
        public void RightAngleTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var calculator = new RightAngleTriangleCalculator();

            bool isRectangled = calculator.Calculate(triangle);

            Assert.That(isRectangled,Is.EqualTo(true));
        }
    }
}