using ShapesLibrary.Shapes.Interfaces;

namespace ShapesLibrary.Shapes
{
    public class Triangle : IShape, IVolumeCalculatable
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;
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

        public double[] getSides()
        {
            return new double[] { _firstSide, _secondSide, _thirdSide };
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        private void CalculateVolume()
        {
            double p = (_firstSide + _secondSide + _thirdSide) / 2;
            Volume = Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
        }
    }
}
