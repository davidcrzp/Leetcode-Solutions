using System;

namespace Reshape_the_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat =
            {
                new int[] {1,2},
                new int[] {3,4},
            };
            int[][] newMat = MatrixReshape(mat, 4, 1);
            foreach (var item in newMat)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }

        }
        static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (mat.Length * mat[0].Length != r * c) return mat;
            int[][] newMat = new int[r][];
            for (int i = 0; i < r; i++)
            {
                newMat[i] = new int[c];
            }
            int j = 0, k = 0;
            foreach (var i1 in mat)
            {
                foreach (var i2 in i1)
                {
                    newMat[j][k] = i2;
                    k++;
                    if (k == c) { j++; k = 0; }
                }
            }
            return newMat;
        }
    }
}