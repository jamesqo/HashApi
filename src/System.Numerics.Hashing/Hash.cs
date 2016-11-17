using System;

namespace System.Numerics
{
    public static class Hash
    {
        public static DefaultHashCombiner DefaultCombiner()
        {
            return new DefaultHashCombiner();
        }

        public static DefaultInt64HashCombiner DefaultInt64HashCombiner()
        {
            return new DefaultInt64HashCombiner();
        }
    }
}