using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Day1;

class Program
{
    static void Main(string[] args)
    {
        Sort.GnomeSortMain();
        ConsoleSeparator();
        ConvexHull.ConvexHullBruteForce();
        ConsoleSeparator();
        ConvexHull.ConvexHullJarvis();
        ConsoleSeparator();
        ConvexHull.ConvexHullGraham();
        ConsoleSeparator();
        KnightsTourProblem.KnightsTourMain();
        ConsoleSeparator();
        SudokuSolver.SudokuSolverMain();
        ConsoleSeparator();
        Maze.MazeMain();
        
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

class Sort
{
    private static void GnomeSort(int[] arr)
    {
        int index = 1;
        int nextIndex = index++;

        while (index < arr.Length)
        {
            if (arr[index - 1] < arr[index])
            {
                index = nextIndex;
                nextIndex++;
            }
            else
            {
                (arr[index - 1], arr[index]) = (arr[index], arr[index - 1]);
                index--;
                if (index == 0)
                {
                    index = nextIndex;
                    nextIndex++;
                }
            }
        }
    }

    public static void GnomeSortMain()
    {
        int[] arr = [8, 3, 6, 1, 10, 2, 7, 9, 5, 4];

        Console.WriteLine($"[{string.Join(", ", arr)}]\n");
        
        GnomeSort(arr);
        
        Console.WriteLine($"[{string.Join(", ", arr)}]");
    }

    public static void GnomeSortGraph()
    {
        int[] sizes = { 10, 25, 50, 100, 200, 500, 1000 };
        Dictionary<int, long> timings = new();

        foreach (int size in sizes)
        {
            int[] arr = GenerateRandomArray(size);
            Stopwatch sw = Stopwatch.StartNew();
            GnomeSort(arr);
            sw.Stop();
            timings[size] = sw.ElapsedTicks;
        }

        using (StreamWriter writer = new StreamWriter("timings.csv"))
        {
            writer.WriteLine("Size,Ticks");
            foreach (var kvp in timings)
            {
                writer.WriteLine($"{kvp.Key},{kvp.Value}");
            }
        }

        Console.WriteLine("Results saved to file 'timings.csv'");
    }
    
    private static int[] GenerateRandomArray(int size)
    {
        Random rnd = new();
        return Enumerable.Range(0, size).OrderBy(_ => rnd.Next()).ToArray();
    }
}

class ConvexHull
{
    static private List<Point> points = new List<Point>
    {
        new Point(0, 0),
        new Point(1, 1),
        new Point(2, 2),
        new Point(0, 2),
        new Point(2, 0),
        new Point(1, 0)
    };
    
    public static void ConvexHullBruteForce()
    {
        var results = new List<(Point, Point)>();

        foreach (var p1 in points)
        {
            foreach (var p2 in points)
            {
                if (p1 == p2) continue;

                int? side = null;
                bool valid = true;

                foreach (var p3 in points)
                {
                    if (p3 == p1 || p3 == p2) continue;

                    int a = p2.Y - p1.Y;
                    int b = p1.X - p2.X;
                    int c = p1.X * p2.Y - p1.Y * p2.X;

                    int result = a * p3.X + b * p3.Y - c;

                    int currentSide = result > 0 ? 1 : (result < 0 ? -1 : 0);

                    if (currentSide == 0) continue;

                    if (side == null)
                    {
                        side = currentSide;
                    }
                    else if (side != currentSide)
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    results.Add((p1, p2));
                }
            }
        }

        Console.WriteLine("Edges of the Convex Hull:");
        foreach (var edge in results)
        {
            Console.WriteLine($"({edge.Item1.X}, {edge.Item1.Y}) - ({edge.Item2.X}, {edge.Item2.Y})");
        }
    }
    
    public static void ConvexHullJarvis()
    {
        Point start = points[0];
        foreach (var p in points)
        {
            if (p.Y < start.Y || (p.Y == start.Y && p.X > start.X))
                start = p;
        }

        List<Point> hull = new List<Point>();
        Point current = start;

        do
        {
            hull.Add(current);
            Point next = points[0];

            foreach (var candidate in points)
            {
                if (candidate == current)
                    continue;

                double angle = Angle(current, next, candidate);

                if (next == current || angle < 0 || (angle == 0 && Distance(current, candidate) > Distance(current, next)))
                {
                    next = candidate;
                }
            }

            current = next;

        } while (current != start); 
        
        Console.WriteLine("Points on the Convex Hull (Jarvis Scan):");
        foreach (var pt in hull)
        {
            Console.WriteLine($"({pt.X}, {pt.Y})");
        }

        Console.WriteLine("\nPoints NOT on the Convex Hull:");
        foreach (var pt in points)
        {
            if (!hull.Contains(pt))
            {
                Console.WriteLine($"({pt.X}, {pt.Y})");
            }
        }
    }
    
    public static void ConvexHullGraham()
    {
        int n = points.Count;
        
        Point pivot = points[0];
        foreach (var pt in points)
        {
            if (pt.Y < pivot.Y || (pt.Y == pivot.Y && pt.X < pivot.X))
            {
                pivot = pt;
            }
        }
        
        var sorted = points.Where(p => p != pivot).OrderBy(p =>
        {
            double angle = Math.Atan2(p.Y - pivot.Y, p.X - pivot.X);
            return angle;
        }).ThenBy(p => DistanceSquaredGraham(pivot, p)).ToList();
        
        List<Point> sortedPoints = new List<Point> { pivot };
        sortedPoints.AddRange(sorted);
        
        Stack<Point> hull = new Stack<Point>();
        hull.Push(sortedPoints[0]);
        hull.Push(sortedPoints[1]);

        for (int i = 2; i < sortedPoints.Count; i++)
        {
            Point top = hull.Pop();
            while (hull.Count > 0 && OrientationGraham(hull.Peek(), top, sortedPoints[i]) <= 0)
            {
                top = hull.Pop();
            }
            hull.Push(top);
            hull.Push(sortedPoints[i]);
        }
        
        hull.Reverse().ToList();
        
        Console.WriteLine("Points on the Convex Hull (Graham Scan):");
        foreach (var pt in hull)
        {
            Console.WriteLine($"({pt.X}, {pt.Y})");
        }

        Console.WriteLine("\nPoints NOT on the Convex Hull:");
        foreach (var pt in points)
        {
            if (!hull.Contains(pt))
            {
                Console.WriteLine($"({pt.X}, {pt.Y})");
            }
        }
    }

    private static double Angle(Point a, Point b, Point c)
    {
        return (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X);
    }
    
    private static double Distance(Point a, Point b)
    {
        return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
    }
    
    private static int OrientationGraham(Point p, Point q, Point r)
    {
        return (q.X - p.X) * (r.Y - p.Y) - (q.Y - p.Y) * (r.X - p.X);
    }
    
    private static int DistanceSquaredGraham(Point p1, Point p2)
    {
        return (int)(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
    }
}

class KnightsTourProblem
{
    const int Size = 8;

    static int[,] sol = new int[Size, Size];
    
    static int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
    static int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };

    public static void KnightsTourMain()
    {
        if (StartKnightTour())
            PrintSolution();
        else
            Console.WriteLine("No solution found.");
    }

    static bool StartKnightTour()
    {
        for (int i = 0; i < Size; i++)
        for (int j = 0; j < Size; j++)
            sol[i, j] = -1;
        
        int startX = 0, startY = 0;
        sol[startX, startY] = 0;
        
        if (KnightTour(startX, startY, 1))
            return true;

        return false;
    }

    static bool KnightTour(int x, int y, int stepCount)
    {
        if (stepCount == Size * Size)
            return true;

        for (int k = 0; k < 8; k++)
        {
            int nextX = x + xMove[k];
            int nextY = y + yMove[k];

            if (IsValid(nextX, nextY))
            {
                sol[nextX, nextY] = stepCount;
                if (KnightTour(nextX, nextY, stepCount + 1))
                    return true;
                
                sol[nextX, nextY] = -1;
            }
        }

        return false;
    }

    static bool IsValid(int x, int y)
    {
        return (x >= 0 && x < Size && y >= 0 && y < Size && sol[x, y] == -1);
    }

    static void PrintSolution()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
                Console.Write(sol[i, j].ToString("D2") + " ");
            Console.WriteLine();
        }
    }
}

class SudokuSolver
{
    const int Size = 9;

    public static void SudokuSolverMain()
    {
        int[,] grid = new int[9, 9]
        {
            {4, 0, 3, 0, 0, 2, 0, 0, 0},
            {5, 0, 0, 0, 6, 0, 1, 2, 0},
            {9, 0, 0, 0, 0, 0, 0, 0, 4},
            {0, 0, 8, 0, 7, 0, 0, 0, 0},
            {0, 0, 0, 2, 0, 3, 0, 0, 8},
            {0, 3, 6, 0, 0, 0, 7, 0, 0},
            {0, 7, 0, 9, 2, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 5, 0, 9, 6},
            {0, 0, 0, 8, 0, 4, 5, 0, 0}
        };

        if (Solve(grid))
            PrintGrid(grid);
        else
            Console.WriteLine("It is impossible to solve Sudoku.");
    }

    static bool Solve(int[,] grid)
    {
        for (int row = 0; row < Size; row++)
        {
            for (int col = 0; col < Size; col++)
            {
                if (grid[row, col] == 0)
                {
                    for (int digit = 1; digit <= 9; digit++)
                    {
                        if (IsValid(grid, row, col, digit))
                        {
                            grid[row, col] = digit;
                            if (Solve(grid))
                                return true;
                            grid[row, col] = 0;
                        }
                    }
                    return false;
                }
            }
        }
        return true;
    }

    static bool IsValid(int[,] grid, int row, int col, int digit)
    {
        for (int i = 0; i < Size; i++)
        {
            if (grid[row, i] == digit || grid[i, col] == digit)
                return false;
        }

        int startRow = row / 3 * 3;
        int startCol = col / 3 * 3;

        for (int r = 0; r < 3; r++)
            for (int c = 0; c < 3; c++)
                if (grid[startRow + r, startCol + c] == digit)
                    return false;

        return true;
    }

    static void PrintGrid(int[,] grid)
    {
        for (int row = 0; row < Size; row++)
        {
            for (int col = 0; col < Size; col++)
            {
                Console.Write(grid[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
 
class Maze
{
    static int N;
    static int startI, startJ;
    static int endI, endJ;

    static bool IsValid(int[,] maze, int x, int y, bool[,] visited)
    {
        return x >= 0 && x < N &&
               y >= 0 && y < N &&
               maze[x, y] == 1 &&
               !visited[x, y];
    }

    public static bool SolveMaze(int[,] maze)
    {
        N = maze.GetLength(0);
        int[,] sol = new int[N, N];
        bool[,] visited = new bool[N, N];

        if (!FindMazePath(maze, startI, startJ, sol, visited))
        {
            Console.WriteLine("There is no solution.");
            return false;
        }

        PrintSolution(sol);
        return true;
    }

    static bool FindMazePath(int[,] maze, int x, int y, int[,] sol, bool[,] visited)
    {
        if (x == endI && y == endJ && maze[x, y] == 1)
        {
            sol[x, y] = 1;
            return true;
        }

        if (IsValid(maze, x, y, visited))
        {
            visited[x, y] = true;
            sol[x, y] = 1;

            if (FindMazePath(maze, x + 1, y, sol, visited)) return true;
            if (FindMazePath(maze, x, y + 1, sol, visited)) return true;
            if (FindMazePath(maze, x - 1, y, sol, visited)) return true;
            if (FindMazePath(maze, x, y - 1, sol, visited)) return true;

            sol[x, y] = 0;
            visited[x, y] = false;
        }

        return false;
    }

    static void PrintSolution(int[,] sol)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(sol[i, j] + " ");
            Console.WriteLine();
        }
    }

    public static void MazeMain()
    {
        int[,] maze = {
            {1, 1, 0, 0, 0, 1, 1},
            {0, 1, 1, 1, 1, 1, 1},
            {1, 0, 0, 1, 0, 1, 1},
            {0, 1, 1, 1, 0, 0, 1},
            {0, 1, 0, 1, 1, 1, 1},
            {0, 1, 0, 0, 1, 0, 0},
            {1, 0, 1, 0, 1, 1, 1}
        };

        N = maze.GetLength(0);
        
        startI = 0; startJ = 0;
        endI = 6; endJ = 6;

        if (!IsValid(maze, startI, startJ, new bool[N, N]) ||
            !IsValid(maze, endI, endJ, new bool[N, N]))
        {
            Console.WriteLine("The starting or ending point is not available.");
            return;
        }

        SolveMaze(maze);
    }
}
