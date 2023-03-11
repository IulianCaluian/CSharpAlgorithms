using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter41
{
    public static class TestSearch
    {
        public static void MainExecute(string[] args)
        {
            Graph G;
            using (StreamReader sr = new StreamReader(args[0]))
            {
                 G = new Graph(sr);
            }

            int s = Int32.Parse(args[1]);
            Search search = new Search(G, s);
            for (int v = 0; v < G.V; v++)
                if (search.marked(v))
                    Console.WriteLine(v + " ");
            Console.WriteLine();
            //if (search.count() != G.V)
            //    Console.WriteLine("NOT ");
            //Console.WriteLine("connected");
        }
    }
}
