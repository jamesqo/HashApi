using System;

namespace System.Numerics
{
    public struct DefaultHashCombiner : IHashCombiner<int>
    {
        public void Combine(ref int seed, int hash)
        {
            uint rol5 = ((uint)seed << 5) | ((uint)seed >> 27);
            seed = ((int)rol5 + seed) ^ hash;
        }
    }
}