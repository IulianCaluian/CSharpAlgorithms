using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter12
{
    public class Flips
    {
        public static void MainExecute(string[] args)
        {
            int T = int.Parse(args[0]);
            Counter heads = new Counter("heads");
            Counter tails = new Counter("tails");

            Random gen = new Random();
            for (int t = 0; t < T; t++)
                if (gen.Next(100) < 50)
                    heads.Increment();
                else tails.Increment();
            Console.WriteLine(heads);
            Console.WriteLine(tails);
            int d = heads.Tally() - tails.Tally();
            Console.WriteLine("delta: " + Math.Abs(d));
        }
    }
}
