using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter13
{
    public class Stats
    {
        public static void MainExecute(string[] args)
        {
            Bag<Double> numbers = new Bag<Double>();
            
            do
            {
                string? line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;
                numbers.add(Double.Parse(line));
            } while (true);
               


            int N = numbers.size();
            double sum = 0.0;
            foreach(Double x in numbers) 
                sum += x;
            double mean = sum / N;
            sum = 0.0;
            foreach (Double x in numbers)
                sum += (x - mean) * (x - mean);
            double std = Math.Sqrt(sum / (N - 1));
            Console.WriteLine("Mean: %.2f\n", mean);
            Console.WriteLine("Std dev: %.2f\n", std);
        }
    }
}
