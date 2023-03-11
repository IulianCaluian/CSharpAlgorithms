using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter41
{
    internal class DepthFirstPaths
    {
        private bool[] marked; // Has dfs() been called for this vertex?
        private int[] edgeTo; // last vertex on known path to this vertex
        private readonly int s; // source
        public DepthFirstPaths(Graph G, int s)
        {
            marked = new bool[G.V];
            edgeTo = new int[G.V];
            this.s = s;
            dfs(G, s);
        }
        private void dfs(Graph G, int v)
        {
            marked[v] = true;
            foreach (int w in G.adj(v))
                if (!marked[w])
                {
                    edgeTo[w] = v;
                    dfs(G, w);
                }
        }
        public bool hasPathTo(int v)
        { return marked[v]; }
        public IEnumerable<int> pathTo(int v)
        {
            if (!hasPathTo(v)) return null;
            Stack<int> path = new Stack<int>();
            for (int x = v; x != s; x = edgeTo[x])
                path.Push(x);
            path.Push(s);
            return path;
        }
    }
}
