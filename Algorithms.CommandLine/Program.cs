using Algorithms.Fundamentals.Chapter12;
using Algorithms.Fundamentals.Chapter13;
using Algorithms.Fundamentals.Chapter41;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        /*
        string line = Console.ReadLine();
        string[] argsLine = new string[] { line };
        Flips.MainExecute(argsLine);
        */

        // Evaluate.MainExecute(args);

        TestSearch.MainExecute(new string[] { "Chapter41/tinyG.txt", "9" });

    }


}