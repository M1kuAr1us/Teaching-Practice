namespace Day2;

public class CountingSorting
{
    public static void CountingSortMain()
    {
        int[] array = [1, 34, 12, 11, 42, 10, 14, 28, 11, 7, 16, 30, 50, 25, 18];
        int k = 50;

        Console.WriteLine("Counting sort:");
        Console.WriteLine(string.Join(", ", array) + "\n");
        CountingSort(array, k);
        Console.WriteLine(string.Join(", ", array));
    }

    private static void CountingSort(int[] A, int k)
    {
        int n = A.Length;
        int[] B = new int[n];
        int[] C = new int[k + 1];
        
        for (int i = 0; i <= k; i++)
        {
            C[i] = 0;
        }
        
        for (int j = 0; j < n; j++)
        {
            C[A[j]]++;
        }
        
        for (int i = 1; i <= k; i++)
        {
            C[i] = C[i] + C[i - 1];
        }
        
        for (int j = n - 1; j >= 0; j--)
        {
            B[C[A[j]] - 1] = A[j];
            C[A[j]]--;
        }
        
        for (int i = 0; i < n; i++)
        {
            A[i] = B[i];
        }
    }
}

public class RadixSorting
{
    public static void RadixSortMain()
    {
        int[] array = [1, 34, 12, 11, 42, 10, 14, 28, 11, 7, 16, 30, 50, 25, 18];
        int k = 50;

        Console.WriteLine("Radix sort:");
        Console.WriteLine(string.Join(", ", array) + "\n");
        RadixSort(array);
        Console.WriteLine(string.Join(", ", array));
    }
    
    private static int GetMax(int[] array)
    {
        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
                max = num;
        }
        return max;
    }

    private static void CountingSortByDigit(int[] array, int exp)
    {
        int n = array.Length;
        int[] output = new int[n];
        int[] count = new int[10];
        
        for (int i = 0; i < n; i++)
        {
            int digit = (array[i] / exp) % 10;
            count[digit]++;
        }
        
        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }
        
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (array[i] / exp) % 10;
            output[count[digit] - 1] = array[i];
            count[digit]--;
        }
        
        for (int i = 0; i < n; i++)
        {
            array[i] = output[i];
        }
    }
    
    private static void RadixSort(int[] array)
    {
        int max = GetMax(array);
        
        for (int exp = 1; max / exp > 0; exp *= 10)
        {
            CountingSortByDigit(array, exp);
        }
    }
}

public class BucketSoting()
{
    public static void BucketSortMain()
    {
        double[] array = { 0.78, 0.17, 0.39, 0.26, 0.72, 0.94, 0.21, 0.12, 0.23, 0.68 };
        int k = 50;

        Console.WriteLine("Bucket sort:");
        Console.WriteLine(string.Join(", ", array) + "\n");
        BucketSort(array);
        Console.WriteLine(string.Join(", ", array));
    }
    
    static void BucketSort(double[] A)
    {
        int n = A.Length;
        if (n <= 0)
            return;

        List<double>[] B = new List<double>[n];
        for (int i = 0; i < n; i++)
        {
            B[i] = new List<double>();
        }

        for (int i = 0; i < n; i++)
        {
            int index = (int)(n * A[i]);
            B[index].Add(A[i]);
        }

        for (int i = 0; i < n; i++)
        {
            InsertionSort(B[i]);
        }

        int k = 0;
        for (int i = 0; i < n; i++)
        {
            foreach (double value in B[i])
            {
                A[k++] = value;
            }
        }
    }

    static void InsertionSort(List<double> list)
    {
        for (int i = 1; i < list.Count; i++)
        {
            double key = list[i];
            int j = i - 1;
            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j--;
            }
            list[j + 1] = key;
        }
    }
}