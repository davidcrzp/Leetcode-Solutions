using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] matrix = { new int[] { 23, 18, 20, 26, 25 }, new int[] { 23, 18, 20, 26, 25 }, new int[] { 23, 18, 20, 26, 25 }, new int[] { 23, 18, 20, 26, 25 } };
        var list = SpiralOrder(matrix);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        HashSet<int> hs = new HashSet<int>();
        IList<int> ls = new List<int>();
        int height = 0, length = 0;
        int sign = 1;
        while (ls.Count != matrix.Length * matrix[0].Length)
        {
            while (hs.Add(height * 10 + length))
            {
                ls.Add(matrix[height][length]);
                length += sign;
                if (length > matrix[0].Length - 1 || length < 0) break;
            }
            if (sign == 1) { length--; height++; if (height > matrix.Length - 1) return ls; }
            else { length++; height--; }

            while (hs.Add(height * 10 + length))
            {
                ls.Add(matrix[height][length]);
                height += sign;
                if (height > matrix.Length - 1 || height < 0) break;
            }
            if (sign == 1) { length--; height--; }
            else { length++; height++; }

            sign *= -1;
        }
        return ls;
    }
}
