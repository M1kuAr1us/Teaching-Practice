namespace Day2;

public class UnsortedArray
{
     public static int[] unsortedArray = [10, 14, 28, 11, 7, 16, 30, 50, 25, 18];
}

public class MergeSorting : UnsortedArray
{
    public static void MergeSortMain()
    {
        int[] array = unsortedArray;
        
        Console.WriteLine(string.Join(", ", array) + "\n");
        MergeSort(array, 0, array.Length - 1);
        Console.WriteLine(string.Join(", ", array) + "\n");
    }
    
    private static void MergeSort(int[] A, int p, int r)
    {
        if (p < r)
        {
            int q = (p + r) / 2;
            MergeSort(A, p, q);
            MergeSort(A, q + 1, r);
            Merge(A, p, q, r);
        }
    }

    private static void Merge(int[] A, int p, int q, int r)
    {
        int n1 = q - p + 1;
        int n2 = r - q;

        int[] L = new int[n1 + 1];
        int[] R = new int[n2 + 1];

        for (int i = 0; i < n1; i++)
            L[i] = A[p + i];
        for (int j = 0; j < n2; j++)
            R[j] = A[q + 1 + j];
        
        L[n1] = int.MaxValue;
        R[n2] = int.MaxValue;

        int iIndex = 0, jIndex = 0;

        for (int k = p; k <= r; k++)
        {
            if (L[iIndex] <= R[jIndex])
            {
                A[k] = L[iIndex];
                iIndex++;
            }
            else
            {
                A[k] = R[jIndex];
                jIndex++;
            }
        }
    }
}

public class HeapSorting : UnsortedArray
{
    public static void HeapSortMain()
    {
        int[] array = unsortedArray;
        
        Console.WriteLine(string.Join(", ", array) + "\n");
        HeapSort(array);
        Console.WriteLine(string.Join(", ", array) + "\n");
    }
    
    private static void HeapSort(int[] A)
    {
        int heapSize = A.Length;

        BuildMaxHeap(A, heapSize);

        for (int i = A.Length - 1; i >= 1; i--)
        {
            (A[0], A[i]) = (A[i], A[0]); 
            heapSize--;
            MaxHeapify(A, 0, heapSize);
        }
    }

    private static void BuildMaxHeap(int[] A, int heapSize)
    {
        for (int i = heapSize / 2 - 1; i >= 0; i--)
        {
            MaxHeapify(A, i, heapSize);
        }
    }

    private static void MaxHeapify(int[] A, int i, int heapSize)
    {
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        int largest = i;

        if (left < heapSize && A[left] > A[largest])
        {
            largest = left;
        }

        if (right < heapSize && A[right] > A[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            (A[i], A[largest]) = (A[largest], A[i]);
            MaxHeapify(A, largest, heapSize);
        }
    }
}

public class QuickSorting : UnsortedArray
{
    public static void QuickSortMain()
    {
        int[] array = unsortedArray;
        
        Console.WriteLine(string.Join(", ", array) + "\n");
        QuickSort(array, 0, array.Length - 1);
        Console.WriteLine(string.Join(", ", array) + "\n");
    }
    
    static void QuickSort(int[] A, int p, int r)
    {
        if (p < r)
        {
            int q = Partition(A, p, r);
            QuickSort(A, p, q - 1);
            QuickSort(A, q + 1, r);
        }
    }

    static int Partition(int[] A, int p, int r)
    {
        int x = A[r];
        int i = p - 1;

        for (int j = p; j <= r - 1; j++)
        {
            if (A[j] <= x)
            {
                i++;
                (A[i], A[j]) = (A[j], A[i]);
            }
        }
        
        (A[i + 1], A[r]) = (A[r], A[i + 1]);
        return i + 1;
    }

}