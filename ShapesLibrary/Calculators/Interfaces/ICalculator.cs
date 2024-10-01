namespace ShapesLibrary.Calculators.Interfaces
{
    public interface ICalculator<TRes, TInner>
    {
        public TRes Calculate(TInner inner);
    }
}
