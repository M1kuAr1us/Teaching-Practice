using System.Text;

namespace Day3;

public class TextJustification
{
    static int INF = int.MaxValue;
    
    static int CalculateCost(string[] words, int i, int j, int maxWidth)
    {
        int len = -1;
        for (int k = i; k <= j; k++)
            len += words[k].Length + 1;

        if (len > maxWidth)
            return INF;

        return (int)Math.Pow(maxWidth - len, 3);
    }
    
    public static List<string> JustifyDP(string[] words, int maxWidth, out int totalCost)
    {
        int n = words.Length;
        int[] dp = new int[n + 1];
        int[] result = new int[n];
        dp[n] = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            dp[i] = INF;
            for (int j = i; j < n; j++)
            {
                int cost = CalculateCost(words, i, j, maxWidth);
                if (cost == INF) break;
                if (dp[i] > cost + dp[j + 1])
                {
                    dp[i] = cost + dp[j + 1];
                    result[i] = j + 1;
                }
            }
        }

        totalCost = dp[0];
        var justified = new List<string>();
        int index = 0;

        while (index < n)
        {
            int next = result[index];
            justified.Add(string.Join(" ", words[index..next]));
            index = next;
        }

        return justified;
    }
    
    public static List<string> JustifyGreedy(string[] words, int maxWidth, out int totalCost)
    {
        var justified = new List<string>();
        totalCost = 0;

        for (int i = 0; i < words.Length;)
        {
            int j = i;
            int lineLen = -1;

            while (j < words.Length && lineLen + words[j].Length + 1 <= maxWidth)
            {
                lineLen += words[j].Length + 1;
                j++;
            }

            justified.Add(string.Join(" ", words[i..j]));
            totalCost += CalculateCost(words, i, j - 1, maxWidth);
            i = j;
        }

        return justified;
    }

    public static void TextJustificationMain()
    {
        string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue diam turpis," +
                      " sed maximus erat viverra eu. Aliquam erat volutpat. Aliquam metus ipsum, lobortis" +
                      " ut neque in, hendrerit porta erat. Sed dignissim turpis ac tempus egestas. Sed sem" +
                      " odio, aliquam non semper in, bibendum quis odio. Nunc enim urna, lacinia ut orci" +
                      " venenatis, eleifend vestibulum erat. Donec a augue luctus, lacinia nisi nec," +
                      " ullamcorper lorem. Mauris fermentum, tortor sit amet dignissim vulputate, est" +
                      " turpis pellentesque ipsum, mollis sollicitudin metus purus ac mauris. Aenean" +
                      " in ante condimentum, semper ligula iaculis, tempus diam. Nulla facilisi.";
                      
        string[] words = text.Split(' ');
        int maxWidth = 27;

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("== Dynamic programming ==");
        var dpResult = JustifyDP(words, maxWidth, out int dpCost);
        foreach (var line in dpResult)
            Console.WriteLine(line);
        Console.WriteLine($"Total cost: {dpCost}");

        Console.WriteLine("\n== Greedy approach ==");
        var greedyResult = JustifyGreedy(words, maxWidth, out int greedyCost);
        foreach (var line in greedyResult)
            Console.WriteLine(line);
        Console.WriteLine($"Total cost: {greedyCost}");
    }
}