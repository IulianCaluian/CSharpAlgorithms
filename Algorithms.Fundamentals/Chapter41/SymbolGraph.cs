using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter41
{
    public class SymbolGraph
    {
        private Dictionary<string, int> st;
        private string[] keys;
        Graph G;

        public SymbolGraph(StreamReader inputStream, String sp)
        {


            st = new Dictionary<string, int>();
            while (true) // builds the index
{
                string? line = inputStream.ReadLine();

                if (line == null)
                    break;

                String[] a = line.Split(sp); // by reading strings
                for (int i = 0; i < a.Length; i++) // to associate each
                    if (!st.ContainsKey(a[i])) // distinct string
                        st.Add(a[i], st.Count); // with an index.
            }

            keys = new string[st.Count]; // Inverted index
            foreach (string name in st.Keys) // to get string keys
                keys[st[name]] = name; // is an array.
            
            G = new Graph(st.Count);

            while (true) // builds the index
            {
                string? line = inputStream.ReadLine();

                if (line == null)
                    break;

                String[] a = line.Split(sp); // by reading strings
                int v = st[a[0]]; // first vertex
                for (int i = 1; i < a.Length; i++) // on each line
                    G.addEdge(v, st[a[i]]); // to all the others.
            }
        }

    }
}
