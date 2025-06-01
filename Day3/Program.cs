using System;
using System.Globalization;
using System.Text;

namespace Day3;

class Program
{
    static void Main(string[] args)
    {
        KnapsackProblem.KnapsackDynamicMain();
        ConsoleSeparator();
        KnapsackProblem.KnapsackGreedyMain();
        ConsoleSeparator();
        ActivitySelection.GreedyRecursiveActivityMain();
        ConsoleSeparator();
        ActivitySelection.DynamicActivityMain();
        ConsoleSeparator();
        BrightestAreaFinder.BrightestAreaFinderMain();
        ConsoleSeparator();
        TextJustification.TextJustificationMain();

        PrintTimeStamp("Іван Завалій");
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