using System;

namespace Matrix_Diagonal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat =
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9},
            };
            int[][] mat2 =
            {
                new int[] {1,1,1,1},
                new int[] {1,1,1,1},
                new int[] {1,1,1,1},
                new int[] {1,1,1,1},
            };
            int[][] mat3 =
            {
                new int[] {7,3,1,9},
                new int[] {3,4,6,9},
                new int[] {6,9,6,6},
                new int[] {9,5,8,5},
            };
            Console.WriteLine(DiagonalSum(mat3));
        }
        static int DiagonalSum(int[][] mat)
        {
            int x = mat[0].Length - 1;
            int y = mat.Length;
            int sum = 0;
            for (int i = 0; i < y; i++)
            {
                if (i == x - i) { sum += mat[i][i]; continue; }
                sum += mat[i][i] + mat[i][x - i];
            }
            return sum;
        }
    }
}