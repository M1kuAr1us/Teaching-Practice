using System;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace Day3;

public class BrightestAreaFinder
{
    public static void BrightestAreaFinderMain()
    {
        var image = new Image<Gray, byte>("astronomical_image.jpg");
        
        var brightnessMatrix = new double[image.Height, image.Width];
        double sum = 0;
        for (int i = 0; i < image.Height; i++)
        {
            for (int j = 0; j < image.Width; j++)
            {
                brightnessMatrix[i, j] = image.Data[i, j, 0];
                sum += brightnessMatrix[i, j];
            }
        }
        
        double mean = sum / (image.Height * image.Width);
        
        for (int i = 0; i < image.Height; i++)
        {
            for (int j = 0; j < image.Width; j++)
            {
                brightnessMatrix[i, j] -= mean;
            }
        }
        
        var result = FindMaxSumSubmatrix(brightnessMatrix);

        Console.WriteLine($"Brightest area: Upper left corner ({result.top}, {result.left})," +
                          $" Lower right corner ({result.bottom}, {result.right}), Brightness sum: {result.maxSum}");
    }

    static (int top, int left, int bottom, int right, double maxSum) FindMaxSumSubmatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double maxSum = double.MinValue;
        int finalLeft = 0, finalRight = 0, finalTop = 0, finalBottom = 0;

        for (int left = 0; left < cols; left++)
        {
            var temp = new double[rows];

            for (int right = left; right < cols; right++)
            {
                for (int i = 0; i < rows; i++)
                {
                    temp[i] += matrix[i, right];
                }

                var (sum, start, end) = Kadane(temp);

                if (sum > maxSum)
                {
                    maxSum = sum;
                    finalLeft = left;
                    finalRight = right;
                    finalTop = start;
                    finalBottom = end;
                }
            }
        }

        return (finalTop, finalLeft, finalBottom, finalRight, maxSum);
    }

    static (double maxSum, int start, int end) Kadane(double[] arr)
    {
        double maxSum = arr[0];
        double currentSum = arr[0];
        int start = 0, end = 0, tempStart = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = arr[i];
                tempStart = i;
            }
            else
            {
                currentSum += arr[i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = tempStart;
                end = i;
            }
        }

        return (maxSum, start, end);
    }
}