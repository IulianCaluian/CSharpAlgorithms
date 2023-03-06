using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter15
{
    public class UFTest
    {
        public static void MainExecute(String[] args)
        {
            Stack<String> ops = new Stack<String>();
            Stack<Double> vals = new Stack<Double>();

            string? line = Console.ReadLine();

            int N = Int32.Parse(line);

            UF uf = new UF(N); // Initialize N components.

            do
            {
                string? pStr = Console.ReadLine();
                if (string.IsNullOrEmpty(pStr))
                    break;

                string? qStr = Console.ReadLine();
                if (string.IsNullOrEmpty(qStr))
                    break;

                int p = Int32.Parse(pStr);
                int q = Int32.Parse(qStr);

                if (uf.connected(p, q)) continue; // Ignore if connected.
                uf.union(p, q); // Combine components

                Console.WriteLine(p + " " + q); // and print connection.

            } while (true);

            Console.WriteLine(uf.count() + " components");

 
         
        }
    }
}
