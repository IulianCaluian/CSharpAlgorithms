using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter41
{
    public class Graph
    {
        public  int V { get; }
        public int E { get; private set; }

        private LinkedList<int>[] _adj;

        public Graph(int v) {
            V = v;
            E = 0;
            _adj = new LinkedList<int>[V];
            for (int i = 0; i < V; i++) {
                _adj[i] = new LinkedList<int>();    
            }
        }

        public Graph(StreamReader inputStream) : this(Int32.Parse(inputStream.ReadLine()))
        {

            int E = Int32.Parse(inputStream.ReadLine()); // Read E.
            for (int i = 0; i < E; i++)
            { // Add an edge.

                string line = inputStream.ReadLine();

                string[] strs = line.Split(" ");

                int v = Int32.Parse(strs[0]); // Read a vertex,
                int w = Int32.Parse(strs[1]); // read another vertex,
                addEdge(v, w); // and add edge connecting them.
            }
        }

        public void addEdge(int v, int w)
        {
            _adj[v].AddLast(w);
            _adj[w].AddLast(v);
            E++;
        }
        

        public IEnumerable<int> adj(int v)
        {
            return _adj[v];
        }

        public override string ToString()
        {
            String s = V + " vertices, " + E + " edges\n";
            for (int v = 0; v < V; v++)
            {
                s += v + ": ";
                foreach (int w in this.adj(v))
                    s += w + " ";
                s += "\n";
            }
            return s;
        }



    }
}
