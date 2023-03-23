using Algorithms.Fundamentals.Chapter13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter42
{
    public class Digraph
    {
        public int V { get; }
        public int E { get; private set; }

        private LinkedList<int>[] _adj;

        public Digraph(int v)
        {
            V = v;
            E = 0;
            _adj = new LinkedList<int>[V];
            for (int i = 0; i < V; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
        }

        public void addEdge(int v, int w)
        {
            _adj[v].AddLast(w);
            E++;
        }
        public IEnumerable<int> adj(int v)
        { 
            return _adj[v]; 
        }

        public Digraph reverse()
        {
            Digraph R = new Digraph(V);
            for (int v = 0; v < V; v++)
                foreach (int w in _adj[v])
                    R.addEdge(w, v);
            return R;
        }
    }
}
