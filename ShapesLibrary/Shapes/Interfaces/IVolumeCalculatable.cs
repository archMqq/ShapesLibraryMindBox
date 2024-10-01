namespace ShapesLibrary.Shapes.Interfaces
{
    public interface IVolumeCalculatable
    {
        public double Volume { get; }
        private void CalculateVolume() { }
    }
}
