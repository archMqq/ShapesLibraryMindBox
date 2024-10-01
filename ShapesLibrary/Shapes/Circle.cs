using ShapesLibrary.Shapes.Interfaces;

namespace ShapesLibrary.Shapes
{
    public class Circle : IShape, IVolumeCalculatable
    {
        private readonly double _radius;
        private double? _volume;
        public double Volume
        {
            get
            {
                if (_volume is null)
                    CalculateVolume();
                return (double)_volume;
            }
            private set
            {
                _volume = value;
            }

        }

        public Circle(double radius)
        {
            _radius = radius;
        }

        private void CalculateVolume()
        {
            Volume = double.Pi * Math.Pow(_radius, 2);
        }
    }
}
