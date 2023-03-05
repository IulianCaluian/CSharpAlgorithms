using System.Diagnostics.Metrics;
using System.Reflection;

namespace Algorithms.Fundamentals.Chapter12
{
    public interface ICounter
    {
        /// <summary>
        /// increment the counter by one
        /// </summary>
        void Increment();

        /// <summary>
        /// number of increments since creation
        /// </summary>
        /// <returns></returns>
        int Tally();

    }
    public class Counter : ICounter
    {
        private int _counter;
        public Counter(string name)
        {

        }

        public void Increment()
        {
            _counter++;
        }

        public int Tally()
        {
            return _counter;
        }
    }
}