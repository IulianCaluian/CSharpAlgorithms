using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    private static void Main(string[] args)
    {
        solveProblem(new List<int>());
        Console.ReadLine();


        // read the string filename
        string filename = "filetest.txt";
            string[] lines = File.ReadAllLines(filename);

        List<string> gifs = new List<string>();

            foreach (var line in lines)
            {
                string[] parts = line.Split('"');

                string request = parts[1];
                string[] p1 = request.Split(" ");
                string reqType = p1[0];

                string path = p1[1];
                string[] p3 = path.Split("/");
                string filen = p3.Last();


            Console.WriteLine(parts[2]);

               string[] p2 = parts[2].Trim().Split(" ");
                int httpResponseCode = Int32.Parse(p2[0]);

            if (httpResponseCode == 200 && request.StartsWith("GET"))
                if (filen.EndsWith(".gif") || filen.EndsWith(".GIF"))
            {
                Console.WriteLine("Yes");
                gifs.Add(filen);
            }
            }

        string filenameOut = "gifs_" + filename;

 

        using (StreamWriter writer = new StreamWriter(filenameOut))
        {
           foreach(var gif in gifs)
            {
                writer.WriteLine(gif);
            }
        }
    }

    private static  int solveProblem(List<int> score)
    {
        int m = score.Count;
        int[] left = new int[m];
        int[] right = new int[m];
        int candies = 0;
        
        left[0] = 1;
        for (int i = 1; i < m; i++)
            if (score[i] > score[i - 1])
                left[i] = left[i - 1] + 1;
            else left[i] = 1;
        
        right[m - 1] = 1;
        for (int i = m - 2; i >= 0; i--)
            if (score[i] > score[i + 1])
                right[i] = right[i + 1] + 1;
            else
                right[i] = 1;
        
        for (int i = 0; i < m; i++)
            candies += Math.Max(left[i], right[i]);
        
        return candies;
    }

}