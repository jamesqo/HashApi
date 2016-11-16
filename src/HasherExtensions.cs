using System.Collections.Generic;

namespace System.Numerics
{
    public static class HasherExtensions
    {
        public static Hasher<int, TCombiner> Combine<TCombiner, T>(this Hasher<int, TCombiner> hasher, T item)
            where TCombiner : IHashCombiner<int>
        {
            return hasher.Combine(EqualityComparer<T>.Default.GetHashCode(item));
        }
    }
}