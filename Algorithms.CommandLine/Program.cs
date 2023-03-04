using Algorithms.Fundamentals;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        string line = Console.ReadLine();
        string[] argsLine = new string[] { line };
        Flips.MainExecute(argsLine);
    }


}