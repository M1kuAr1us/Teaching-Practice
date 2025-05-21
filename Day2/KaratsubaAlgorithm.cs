using System.Diagnostics;
using System.Numerics;

namespace Day2;

public class KaratsubaAlgorithm
{
    public static void KaratsubaMain()
    {
        int digits = 10000;
        
        BigInteger bigNum1 = GenerateBigInteger(digits);
        BigInteger bigNum2 = GenerateBigInteger(digits);
        
        // Naive multiplication
        Stopwatch stopwatchNative = Stopwatch.StartNew();
        BigInteger resultNaive = NaiveMultiply(bigNum1, bigNum2);
        stopwatchNative.Stop();
        Console.WriteLine($"Naive multiplication: {stopwatchNative.ElapsedMilliseconds} ms");
        
        // Karatsuba
        Stopwatch stopwatchKaratsuba = Stopwatch.StartNew();
        BigInteger resultKaratsuba = KaratsubaMultiplication(bigNum1, bigNum2);
        stopwatchKaratsuba.Stop();
        Console.WriteLine($"Karatsuba multiplication: {stopwatchKaratsuba.ElapsedMilliseconds} ms");
        
        Console.WriteLine($"Do the results match?: {resultNaive == resultKaratsuba}");
    }
    
    private static BigInteger GenerateBigInteger(int digits)
    {
        Random rnd = new Random();
        string numStr = rnd.Next(1, 10).ToString();
        for (int i = 1; i < digits; i++)
            numStr += rnd.Next(0, 10).ToString();

        return BigInteger.Parse(numStr);
    }
    
    private static BigInteger NaiveMultiply(BigInteger a, BigInteger b) // .NET already has good optimization
    {
        return a * b;
    }

    private static BigInteger KaratsubaMultiplication(BigInteger a, BigInteger b)
    {
        if (a < 10 || b < 10)
        {
            return a * b;
        }

        decimal m = Math.Min(a.ToString().Length, b.ToString().Length);
        int m2 = Convert.ToInt32(Math.Floor(m / 2));
        
        BigInteger high1 = a / BigInteger.Pow(10, m2);
        BigInteger low1 = a % BigInteger.Pow(10, m2);
        BigInteger high2 = b / BigInteger.Pow(10, m2);
        BigInteger low2 = b % BigInteger.Pow(10, m2);

        BigInteger z0 = KaratsubaMultiplication(low1, low2);
        BigInteger z1 = KaratsubaMultiplication(low1 + high1, low2 + high2);
        BigInteger z2 = KaratsubaMultiplication(high1, high2);

        return z2 * BigInteger.Pow(10, 2 * m2) + 
               (z1 - z2 - z0) * BigInteger.Pow(10, m2) + z0;
    }
}