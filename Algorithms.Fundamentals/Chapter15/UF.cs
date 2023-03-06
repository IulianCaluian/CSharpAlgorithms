using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter15
{
    public class UF
    {
        int _count;
        private int[] _comp;

        public UF(int n)
        {
            _comp = new int[n];
            _count = n;
        }

        public int find(int p)
        {
            while(p != _comp[p]) 
                p = _comp[p];
            return p;
        }

        public void union(int p, int q)
        {
            int i = find(p);
            int j = find(q);
            if (i == j) return;

            _comp[i] = j;
            _count--;
        }

        public int count()
        {
            return _count;
        }

        public bool connected(int p, int q)
        {
            int i = find(p);
            int j = find(q);
            if (i == j) return true;

            return false;
        }
    }
}
