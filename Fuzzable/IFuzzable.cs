namespace Asjc.Fuzzable
{
    public interface IFuzzable : IComparable
    {
        public IComparable Value { get; }

        public IComparable Min { get; }

        public IComparable Max { get; }
    }

    public interface IFuzzable<T> : IComparable<T> where T : IComparable
    {
        public T Value { get; }

        public T Min { get; }

        public T Max { get; }
    }
}
