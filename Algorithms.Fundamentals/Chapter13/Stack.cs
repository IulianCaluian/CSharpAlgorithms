using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter13
{
    public class Stack<Item> : IEnumerable<Item>
    {
        private Node? first; // top of stack (most recently added node)
        private int N; // number of items
        private class Node
        { // nested class to define nodes
            public Item item { get; private set; }
            public Node? next { get; set; }

            public Node(Item item)
            {
                this.item = item;  
            }
        }
        public bool isEmpty() { return first == null; }
        public int size() { return N; }
        public void push(Item item)
        { // Add item to top of stack.
            Node? oldfirst = first;
            first = new Node(item);
            first.next = oldfirst;
            N++;
        }
        public Item pop()
        { // Remove item from top of stack.
            if (first == null)
                throw new NotSupportedException();

            Item item = first.item;
            first = first.next;
            N--;
            return item;

        }

        public IEnumerator<Item> GetEnumerator()
        {
            return new LinkedListIterator(first);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        private class LinkedListIterator : IEnumerator<Item>
        {

            private Node _current;

            public Item Current => _current.item;

            object IEnumerator.Current => this.Current;

            public LinkedListIterator(Node first)
            {
                _current = new Node(default(Item));
                _current.next = first;
               
            }

            public void Dispose()
            {
                // do nothing
            }

            public bool MoveNext()
            {
                if (_current.next == null)
                    return false;

                _current = _current.next;
                return true;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }
        }



    }
}
