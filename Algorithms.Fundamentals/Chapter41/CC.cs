using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter41
{
    public class CC
    {
        private bool[] marked;
        private int[] id;
        private int count;

        // preprocessing constructor
        public CC(Graph G)
        {
            marked = new bool[G.V];
            this.id = new int[G.V];
            for (int s = 0; s < G.V; s++)
                if (!marked[s])
                {
                    dfs(G, s);
                    count++;
                }
        }

        private void dfs(Graph G, int v)
        {
            marked[v] = true;
            id[v] = count ;
            foreach (int w in G.adj(v))
                if (!marked[w])
                {
                    dfs(G, w);
                }
        }


        public bool connected(int v, int w)
        {
            return id[v] == id[w];
        }

        public int Count()
        {
            return count;
        }

        public int Id(int v)
        {
            return id[v];
        }
    }
}
