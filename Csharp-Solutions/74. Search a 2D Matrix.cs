using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[][] { new int[4] { 1, 3, 5, 7 }, new int[4] { 10, 11, 16, 20 }, new int[4] { 23, 30, 34, 60 } };
            SearchMatrix(matrix, 2);
            SearchMatrix(matrix, 94);
            SearchMatrix(matrix, 23);
        }
        static bool SearchMatrix(int[][] matrix, int target)
        {
            return matrix.Any(i => i.Contains(target));
        }
    }
}