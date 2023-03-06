using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Fundamentals.Chapter13
{
    public class Evaluate
    {
        public static void MainExecute(String[] args)
        {
            Stack<String> ops = new Stack<String>();
            Stack<Double> vals = new Stack<Double>();

            do
            {
                string? s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                    break;

                if (s.Equals("(")) ;
                else if (s.Equals("+")) ops.push(s);
                else if (s.Equals("-")) ops.push(s);
                else if (s.Equals("*")) ops.push(s);
                else if (s.Equals("/")) ops.push(s);
                else if (s.Equals("sqrt")) ops.push(s);
                else if (s.Equals(")"))
                { // Pop, evaluate, and push result if token is ")".
                    String op = ops.pop();
                    double v = vals.pop();
                    if (op.Equals("+")) v = vals.pop() + v;
                    else if (op.Equals("-")) v = vals.pop() - v;
                    else if (op.Equals("*")) v = vals.pop() * v;
                    else if (op.Equals("/")) v = vals.pop() / v;
                    else if (op.Equals("sqrt")) v = Math.Sqrt(v);
                    vals.push(v);
                } // Token not operator or paren: push double value.
                else vals.push(Double.Parse(s));
            } while(true);
            Console.WriteLine(vals.pop());
        }
    }
}
