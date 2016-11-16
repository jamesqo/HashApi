namespace System.Numerics
{
    public interface IHashCombiner<THash>
    {
        void Combine(ref THash seed, THash hash);
    }
}