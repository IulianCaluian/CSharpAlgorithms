using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter41
{
    internal class BreadthFirstPaths
    {
        private bool[] marked; // Is a shortest path to this vertex known?
        private int[] edgeTo; // last vertex on known path to this vertex
        private readonly int s; // source
        public BreadthFirstPaths(Graph G, int s)
        {
            marked = new bool[G.V];
            edgeTo = new int[G.V];
            this.s = s;
            bfs(G, s);
        }
        private void bfs(Graph G, int s)
        {
            Queue<int> queue = new Queue<int>();
            marked[s] = true; // Mark the source
            queue.Enqueue(s); // and put it on the queue.
            while (queue.Count > 0)
            {
                int v = queue.Dequeue(); // Remove next vertex from the queue.
                foreach (int w in G.adj(v))
                    if (!marked[w]) // For every unmarked adjacent vertex,
                    {
                        edgeTo[w] = v; // save last edge on a shortest path,
                        marked[w] = true; // mark it because path is known,
                        queue.Enqueue(w); // and add it to the queue.
                    }
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
