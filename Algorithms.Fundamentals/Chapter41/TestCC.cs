using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter41
{
    public class TestCC
    {
        public static void MainExecute(string[] args)
        {
            Graph G;
            using (StreamReader sr = new StreamReader(args[0]))
            {
                G = new Graph(sr);
            }


 
            CC cc = new CC(G);
            int M = cc.Count();
            Console.WriteLine(M + " components");
            Queue<int>[] components;
            components = new Queue<int>[M];
            for (int i = 0; i < M; i++)
                components[i] = new Queue<int>();
            for (int v = 0; v < G.V; v++)
                components[cc.Id(v)].Enqueue(v);
            for (int i = 0; i < M; i++)
            {
                foreach (int v in components[i])
                    Console.Write(v + " ");
                Console.WriteLine();
            }

         
        }
    }
}
