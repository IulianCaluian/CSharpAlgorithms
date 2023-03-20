using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter41
{
    internal class Cycle
    {
        private bool[] marked;
        private bool hasCycle;
        public Cycle(Graph g)
        {
            marked = new bool[g.V];
            for (int v = 0; v < g.V; v++)
                if (!marked[v])
                    dfs(g, v, v);
        }

        private void dfs(Graph G, int v, int u)
        {
            marked[v] = true;
            foreach(int w in G.adj(v))
                if (!marked[w])
                    dfs(G, w, v);
                else if (w != u) 
                    hasCycle = true;
        }

        public bool HasCycle()
        {
            return hasCycle;
        }
    }
}
