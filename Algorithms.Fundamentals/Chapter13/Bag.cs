using System.Collections;

namespace Algorithms.Fundamentals.Chapter13
{
    internal class Bag<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        internal void add(double v)
        {
            throw new NotImplementedException();
        }

        internal int size()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}