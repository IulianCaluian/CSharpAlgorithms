using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter41
{
    internal class Search
    {
        DepthFirstPaths _dfs;
        public Search(Graph g, int s) {

            _dfs = new DepthFirstPaths(g, s);


        }

        internal int count()
        {
            throw new NotImplementedException();
        }

        internal bool marked(int v)
        {
            return _dfs.hasPathTo(v);
        }
    }
}
