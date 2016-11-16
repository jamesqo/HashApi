using System;

namespace System.Numerics
{
    public struct Hasher<THash, TCombiner> where TCombiner : IHashCombiner<THash>
    {
        private THash _hash;
        private readonly TCombiner _combiner;

        internal Hasher(THash hash, TCombiner combiner)
        {
            // Allow the hash to be null; it can be an arbitrary object.

            if (combiner == null)
            {
                throw new ArgumentNullException(nameof(combiner));
            }

            _hash = hash;
            _combiner = combiner;
        }

        public Hasher<THash, TCombiner> Combine(THash hash)
        {
            var copy = this;
            _combiner.Combine(ref copy._hash, hash);
            return copy;
        }

        /// <summary>
        /// Convenience method for re-creating this hasher without having to specify type parameters.
        /// </summary>
        private static Hasher<THash, TCombiner> Create(THash hash, TCombiner combiner)
        {
            return new Hasher<THash, TCombiner>(hash, combiner);
        }
    }
}