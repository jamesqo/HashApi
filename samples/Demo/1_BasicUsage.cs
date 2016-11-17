using System;
using System.Numerics;

namespace Demo
{
    public class SomeClass
    {
        private readonly string _someString;
        private readonly int _someInt;
        private readonly byte _someByte;

        public override int GetHashCode()
        {
            return Hash.DefaultCombiner()
                .Combine(_someString)
                .Combine(_someInt)
                .Combine(_someByte);
        }
    }
}