using System;

namespace Find_Nearest_Point_That_Has_the_Same_X_or_Y_Coordinate
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int[][] points =
            {
                new int[] {1, 2},
                new int[] {3, 1},
                new int[] {2, 4},
                new int[] {2, 3},
                new int[] {4, 4}
            };
            int x2 = 2;
            int y2 = 1;
            int[][] points2 =
            {
                new int[] {2, 1},
                new int[] {2, 1},
                new int[] {2, 2},
                new int[] {1, 2},
                new int[] {1, 2},
                new int[] {2, 2},
                new int[] {1, 1},
                new int[] {2, 2},
                new int[] {1, 2},
                new int[] {1, 2},
                new int[] {1, 1},
                new int[] {2, 2},
                new int[] {2, 2}
            };
            Console.WriteLine(NearestValidPoint(x, y, points));
        }
        static int NearestValidPoint(int x, int y, int[][] points)
        {
            int[] manhattanDistance = new int[points.Length];
            int c = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i][0] == x || points[i][1] == y)
                {
                    manhattanDistance[i] = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);
                    c++;
                }
                else manhattanDistance[i] = -1;
            }
            if (c == 0)
            {
                return -1;
            }
            return Array.IndexOf(manhattanDistance, manhattanDistance.Where(x => x != -1).DefaultIfEmpty().Min());
        }
    }
}