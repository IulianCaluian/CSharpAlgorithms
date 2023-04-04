using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter42
{
    internal class Topological
    {
        private IEnumerable<int>? order = null;
        public Topological(Digraph d) {

            DirectedCycle dc = new DirectedCycle(d);

          

            if (!dc.hasCycle())
            {
                DepthFirstOrder dfs = new DepthFirstOrder(d);
                order = dfs.ReversePost();
            }
        }

        bool isDAG()
        {
            return (order != null);
        }

        public IEnumerable<int>? Order()
        {
            return order;
        }
    }
}
