using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter41
{
    public class TwoColor
    {
        private bool[] marked;
        private bool[] color;
        private bool isTwoColorable;
        public TwoColor(Graph G)
        {
            marked = new bool[G.V];
            color = new bool[G.V];
            for (int s = 0; s < G.V; s++)
                if (!marked[s])
                    dfs(G, s);
        }

        private void dfs(Graph G, int v)
        {
            marked[v] = true;
            foreach(int w in G.adj(v))
                if (!marked[w])
                {
                    color[w] = !color[v];
                    dfs(G, w);
                }
                else if (color[w] == color[v]) isTwoColorable = false;
        }
        public bool isBipartite()
        { return isTwoColorable; }
    }
}
