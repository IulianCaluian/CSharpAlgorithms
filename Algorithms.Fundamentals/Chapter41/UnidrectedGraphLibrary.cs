using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter41
{
    public static class UnidrectedGraphLibrary
    {
        public static int degree(Graph g, int v)
        {
            return g.adj(v).Count();
        }

        public static int maxDegree(Graph g)
        {
            int max = 0;
            for (int v = 0; v < g.V; v++)
                if (degree(g, v) > max)
                    max = degree(g, v);
            return max;
        }
        public static double averageDegree(Graph g)
        {
            return 2.0 * g.E / g.V;
        }
    }
}
