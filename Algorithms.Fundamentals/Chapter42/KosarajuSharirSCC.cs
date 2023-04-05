using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter42
{
    internal class KosarajuSharirSCC
    {
        private bool[] marked;
        private int[] id;
        private int count;
        public KosarajuSharirSCC(Digraph g)
        {
            marked = new bool[g.V];
            id = new int[g.V];

            DepthFirstOrder order = new DepthFirstOrder(g.reverse());

            foreach (int s in order.ReversePost())
            {
                if (!marked[s])
                    dfs(g, s);
            }
        }
        private void dfs(Digraph G, int v)
        {
            marked[v] = true;
            id[v] = count;
            foreach (int w in G.adj(v))
                if (!marked[w])
                    dfs(G, w);
        }

        public bool stlronglyConnected(int v, int w)
        { return id[v] == id[w]; }
        public int Id(int v)
        { return id[v]; }
        public int Count()
        { return count; }

    }

}
