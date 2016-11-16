using System.Collections.Generic;

namespace System.Numerics
{
    public static class HashCombinerExtensions
    {
        public static Hasher<THash, TCombiner> Combine<THash, TCombiner>(this TCombiner combiner, THash hash)
            where TCombiner : IHashCombiner<THash>
        {
            return new Hasher<THash, TCombiner>(hash, combiner);
        }

        public static Hasher<int, TCombiner> Combine<TCombiner, T>(this TCombiner combiner, T item)
            where TCombiner : IHashCombiner<int>
        {
            return combiner.Combine<int, TCombiner>(EqualityComparer<T>.Default.GetHashCode(item));
        }
    }
}