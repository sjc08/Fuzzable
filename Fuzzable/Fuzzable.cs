namespace Asjc.Fuzzable
{
    public class Fuzzable<T> : IFuzzable<T>, IFuzzable where T : IComparable
    {
        public Fuzzable(T min, T max)
        {
            Value = min;
            Min = min;
            Max = max;
        }

        public T Value { get; set; }

        public T Min { get; set; }

        public T Max { get; set; }

        IComparable IFuzzable.Value => Value;
        IComparable IFuzzable.Min => Min;
        IComparable IFuzzable.Max => Max;

        public int CompareTo(T? other)
        {
            if (Min.CompareTo(other) > 0)
                return 1;
            if (Max.CompareTo(other) > 0)
                return 0;
            return -1;
        }

        public int CompareTo(object? obj)
        {
            if (Min.CompareTo(obj) > 0)
                return 1;
            if (Max.CompareTo(obj) > 0)
                return 0;
            return -1;
        }

        public static bool operator <(Fuzzable<T> left, T right) => left.CompareTo(right) < 0;
        public static bool operator >(Fuzzable<T> left, T right) => left.CompareTo(right) > 0;
        public static bool operator <=(Fuzzable<T> left, T right) => left.CompareTo(right) <= 0;
        public static bool operator >=(Fuzzable<T> left, T right) => left.CompareTo(right) >= 0;

        public static implicit operator T(Fuzzable<T> value) => value.Value;
    }
}
