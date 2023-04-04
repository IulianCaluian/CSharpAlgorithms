using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter42
{
    internal class DepthFirstOrder
    {
        private bool[] marked;
        private Queue<int> pre;
        private Queue<int> post;
        private Stack<int> reversePost;

        public DepthFirstOrder(Digraph G)
        {
            pre = new Queue<int>();
            post = new Queue<int>();
            reversePost = new Stack<int>();
            marked = new bool[G.V];
            for (int v = 0; v < G.V; v++)
                if (!marked[v]) dfs(G, v);
        }
        private void dfs(Digraph G, int v)
        {
            pre.Enqueue(v);
            marked[v] = true;
            foreach (int w in G.adj(v))
                if (!marked[w])
                {
                    dfs(G, w);
                }

            post.Enqueue(v);
            reversePost.Push(v);
        }
        public IEnumerable<int> Pre()
        { return pre; }
        public IEnumerable<int> Post()
        { return post; }
        public IEnumerable<int> ReversePost()
        { return reversePost; }
    }
}
