using System.Globalization;
using System.Numerics;
using System.Text;

namespace Day2;

class Program
{
    static void Main(string[] args)
    {
        KaratsubaAlgorithm.KaratsubaMain();
        ConsoleSeparator();
        MergeSorting.MergeSortMain();
        ConsoleSeparator();
        HeapSorting.HeapSortMain();
        ConsoleSeparator();
        QuickSorting.QuickSortMain();
        
        PrintTimeStamp("Завалій Іван");
    }
    
    public static void PrintTimeStamp(string name)
    {
        Console.OutputEncoding = Encoding.UTF8;
        DateTime localDate = DateTime.Now;
        var culture = new CultureInfo("uk-UA");
        Console.WriteLine("\n   Дата та час компіляції: {0}", localDate.ToString(culture));
        Console.WriteLine("   Автор: {0}", name);
    }
    
    static void ConsoleSeparator()
    {
        Console.WriteLine("\n====================================\n");
    }
}