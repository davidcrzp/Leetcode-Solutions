using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][] { new int[] { 1, 4, 7, 11, 15 }, new int[] { 2, 5, 8, 12, 19 }, new int[] { 3, 6, 9, 16, 22 }, new int[] { 10, 13, 14, 17, 24 }, new int[] { 18, 21, 23, 26, 30 } };
            Console.WriteLine(SearchMatrix(matrix, 5));
        }
        static bool SearchMatrix(int[][] matrix, int target)
        {
            for (int i = 0; i < matrix.Length; i++)
                if (Array.BinarySearch(matrix[i], target) >= 0) return true;
            return false;
        }
    }
}