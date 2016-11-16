using System;

namespace System.Numerics
{
    public struct DefaultInt64HashCombiner : IHashCombiner<long>
    {
        public void Combine(ref long seed, long hash)
        {
            // Insert a good 64-bit hashing algorithm here... 
        }
    }
}