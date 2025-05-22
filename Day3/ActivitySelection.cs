namespace Day3;

public class ActivitySelection
{
    public static void GreedyRecursiveActivityMain()
    {
        int[] start = { 1, 3, 0, 5, 8, 5 };
        int[] finish = { 2, 4, 6, 7, 9, 9 };
        int n = start.Length;
        
        int[] indices = new int[n];
        for (int i = 0; i < n; i++) indices[i] = i;
        HeapSortByFinishTime(indices, finish);
        
        int[] s = new int[n + 1];
        int[] f = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            s[i + 1] = start[indices[i]];
            f[i + 1] = finish[indices[i]];
        }

        Console.WriteLine("Selected activities (greedy approach):");
        RecursiveActivitySelector(s, f, 0, n);
    }
    
    public static void DynamicActivityMain()
    {
        int[] start = { 1, 3, 0, 5, 8, 5 };
        int[] finish = { 2, 4, 6, 7, 9, 9 };
        int n = start.Length;
        int[] indices = new int[n];
        for (int i = 0; i < n; i++) indices[i] = i;
        
        HeapSortByFinishTime(indices, finish);
        
        int[] s = new int[n + 2];
        int[] f = new int[n + 2];
        for (int i = 0; i < n; i++)
        {
            s[i + 1] = start[indices[i]];
            f[i + 1] = finish[indices[i]];
        }

        s[0] = f[0] = 0;
        s[n + 1] = f[n + 1] = int.MaxValue;

        int[,] c = new int[n + 2, n + 2];
        int[,] act = new int[n + 2, n + 2];

        DynamicActivitySelector(s, f, n, c, act);
        Console.WriteLine("The set contains:");
        PrintActivities(c, act, 0, n + 1);
    }
    
    static void RecursiveActivitySelector(int[] s, int[] f, int k, int n)
    {
        int m = k + 1;
        while (m <= n && s[m] < f[k])
        {
            m++;
        }
        if (m <= n)
        {
            Console.WriteLine("Activity " + m);
            RecursiveActivitySelector(s, f, m, n);
        }
    }
    
    static void DynamicActivitySelector(int[] s, int[] f, int n, int[,] c, int[,] act)
    {
        for (int l = 2; l <= n + 1; l++)
        {
            for (int i = 0; i <= n + 1 - l; i++)
            {
                int j = i + l;
                c[i, j] = 0;
                for (int k = j - 1; k > i; k--)
                {
                    if (f[i] <= s[k] && f[k] <= s[j])
                    {
                        int q = c[i, k] + c[k, j] + 1;
                        if (q > c[i, j])
                        {
                            c[i, j] = q;
                            act[i, j] = k;
                        }
                    }
                }
            }
        }

        Console.WriteLine("A maximum size set of mutually compatible activities has size " + c[0, n + 1]);
    }

    static void PrintActivities(int[,] c, int[,] act, int i, int j)
    {
        if (c[i, j] > 0)
        {
            int k = act[i, j];
            Console.WriteLine("Activity " + k);
            PrintActivities(c, act, i, k);
            PrintActivities(c, act, k, j);
        }
    }

    static void HeapSortByFinishTime(int[] indices, int[] finish)
    {
        int heapSize = indices.Length;
        BuildMaxHeap(indices, finish, heapSize);

        for (int i = indices.Length - 1; i >= 1; i--)
        {
            (indices[0], indices[i]) = (indices[i], indices[0]);
            heapSize--;
            MaxHeapify(indices, finish, 0, heapSize);
        }
    }

    static void BuildMaxHeap(int[] indices, int[] finish, int heapSize)
    {
        for (int i = heapSize / 2 - 1; i >= 0; i--)
        {
            MaxHeapify(indices, finish, i, heapSize);
        }
    }

    static void MaxHeapify(int[] indices, int[] finish, int i, int heapSize)
    {
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        int largest = i;

        if (left < heapSize && finish[indices[left]] > finish[indices[largest]])
            largest = left;

        if (right < heapSize && finish[indices[right]] > finish[indices[largest]])
            largest = right;

        if (largest != i)
        {
            (indices[i], indices[largest]) = (indices[largest], indices[i]);
            MaxHeapify(indices, finish, largest, heapSize);
        }
    }
}