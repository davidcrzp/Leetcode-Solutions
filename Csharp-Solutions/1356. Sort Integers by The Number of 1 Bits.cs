using System;
using System.Linq;
using System.Collections.Generic;

namespace Sort_Integers_by_The_Number_of_1_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr2 = { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
            int[] arr3 = { 8848, 4205, 113, 3764, 2376, 6352, 6372, 9927, 2990, 4286, 7783, 2121, 3749, 7800, 7479, 2723, 8305, 8276, 3598, 5776, 8016, 5053, 3113, 4395, 3595, 5079, 3065, 3158, 6141, 4187, 1328, 4900, 2120, 3239, 6474, 2218, 4892, 7993 };
            var result = SortByBits(arr1);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        static int[] SortByBits(int[] arr)
        {
            List<List<String>> matrix = new List<List<String>>();
            for (int i = 0; i < arr.Length; i++)
            {
                matrix.Add(new List<String>());
                matrix[i].Add(arr[i].ToString());
                matrix[i].Add(Convert.ToString(arr[i], 2).Count(x => x == '1').ToString());
                Console.WriteLine(matrix[i].ElementAt(1));
            }
            var orderedResult = matrix.OrderBy(x => int.Parse(x[1]));
            var result = new List<int>();
            foreach (var item in orderedResult)
            {
                result.Add(Convert.ToInt32(item.ElementAt(1)));
            }
            return result.ToArray();
        }
    }
}