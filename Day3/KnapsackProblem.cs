namespace Day3;

public class KnapsackProblem
{
    public static void KnapsackDynamicMain()
    {
        int W = 10;
        int[] values = [10, 20, 20, 40, 60];
        int[] weights = [1, 1, 3, 2, 5];
        int n = values.Length;

        int[,] M = new int[n + 1, W + 1];
        
        for (int i = 1; i <= n; i++)
        {
            for (int w = 1; w <= W; w++)
            {
                if (weights[i - 1] <= w)
                {
                    M[i, w] = Math.Max(M[i - 1, w],
                        M[i - 1, w - weights[i - 1]] + values[i - 1]);
                }
                else
                {
                    M[i, w] = M[i - 1, w];
                }
            }
        }
        
        Console.WriteLine("Maximum value: " + M[n, W]);
        
        Console.WriteLine("Selected items (indexes from 1):");
        int remainingWeight = W;
        for (int i = n; i > 0 && remainingWeight > 0; i--)
        {
            if (M[i, remainingWeight] != M[i - 1, remainingWeight])
            {
                Console.WriteLine($"Item {i} (price: {values[i - 1]}, weight: {weights[i - 1]})");
                remainingWeight -= weights[i - 1];
            }
        }
    }
    
    public static void KnapsackGreedyMain()
    {
        int[] values = [10, 20, 20, 40, 60];
        int[] weights = [1, 1, 3, 2, 5];
        int W = 10;
        int totalValue = 0;

        int n = values.Length;
        double[] ratio = new double[n];
        int[] indices = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            ratio[i] = (double)values[i] / weights[i];
            indices[i] = i;
        }
        
        Array.Sort(indices, (a, b) => ratio[b].CompareTo(ratio[a]));

        int[] solution = new int[n];
        int cumWeight = 0;
        
        foreach (int i in indices)
        {
            if (cumWeight + weights[i] <= W)
            {
                solution[i] = 1;
                cumWeight += weights[i];
            }
            else
            {
                solution[i] = 0;
            }
        }
        
        Console.WriteLine("Included items:");
        for (int i = 0; i < n; i++)
        {
            if (solution[i] == 1)
            {
                Console.WriteLine($"Item {i + 1} (price: {values[i]}, weight: {weights[i]})");
                totalValue += values[i];
            }
        }
        Console.WriteLine($"Total Value: {totalValue}");
    }
}