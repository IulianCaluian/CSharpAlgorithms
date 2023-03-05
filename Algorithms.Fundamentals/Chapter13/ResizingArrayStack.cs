using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter13
{
    public class ResizingArrayStack<Item> : IEnumerable<Item>
    {
        private Item?[] a = new Item?[1];
        private int N = 0;

        public IEnumerator<Item> GetEnumerator()
        {
            return new ReverseArrayIterator(a, N);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool isEmpty() { return N == 0; }
        public int size() { return N; }
        private void resize(int max)
        { // Move stack to a new array of size max.
            Item[] temp = new Item[max];
            for (int i = 0; i < N; i++)
                temp[i] = a[i];
            a = temp;
        }
        public void push(Item item)
        { // Add item to top of stack.
            if (N == a.Length) 
                resize(2 * a.Length);
            a[N++] = item;
        }
        public Item pop()
        { // Remove item from top of stack.
            Item item = a[--N];
            a[N] = default(Item); // Avoid loitering (see text).
            if (N > 0 && N == a.Length / 4) 
                resize(a.Length / 2);
            return item;
        }

        private class ReverseArrayIterator : IEnumerator<Item>
        {
            private int _i;
            private Item?[] _a;

            private Item _current;

            public Item Current => _current;

            object IEnumerator.Current => this.Current;

            public ReverseArrayIterator(Item?[] a, int N)
            {
                _a = a;
                _i = N ;
                _current = default(Item);
            }

            public void Dispose()
            {
                // do nothing
            }

            public bool MoveNext()
            {
                if (_i == 0) 
                    return false;
                _current = _a[--_i];
                return true;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }
        }



    }
}
