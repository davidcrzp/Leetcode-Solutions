using System;

namespace Check_If_It_Is_a_Straight_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] coordinates =
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 4, 5 },
                new int[] { 5, 6 },
                new int[] { 6, 7 }
            };
            int[][] coordinates2 =
            {
                new int[] { 0, 0 },
                new int[] { 0, 1 },
                new int[] { 0, -1 }
            };
            int[][] coordinates3 =
            {
                new int[] { 1, 1 },
                new int[] { 2, 2 },
                new int[] { 3, 4 },
                new int[] { 4, 5 },
                new int[] { 5, 6 },
                new int[] { 7, 7 }
            };
            int[][] coordinates4 =
            {
                new int[] { 2, 1 },
                new int[] { 4, 2 },
                new int[] { 6, 3 }
            };
            int[][] coordinates5 =
            {
                new int[] { -5, 13 },
                new int[] { 3, -3 }
            };
            Console.WriteLine(CheckStraightLine(coordinates4));
        }
        static bool CheckStraightLine(int[][] coordinates)
        {
            decimal x1, y1;
            decimal x = x1 = coordinates[0][0], x2 = coordinates[1][0];
            decimal y = y1 = coordinates[0][1], y2 = coordinates[1][1];
            decimal m;
            if (x2 - x == 0)
            {
                for (int i = 0; i < coordinates.Length; i++)
                {
                    if (coordinates[i][0] != x)
                    {
                        return false;
                    }
                }
                return true;
            }
            else m = (y2 - y1) / (x2 - x1);
            decimal b = y - m * x;
            for (int i = 2; i < coordinates.Length; i++)
            {
                if (coordinates[i][1] != ((m * coordinates[i][0]) + b))
                {
                    return false;
                }
            }
            return true;
        }
    }
}