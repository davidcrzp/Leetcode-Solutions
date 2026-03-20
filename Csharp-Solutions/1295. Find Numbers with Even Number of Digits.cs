using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 2, 3, 0, 4, 5, 0 };
            DuplicateZeros(arr);
        }
        public static void DuplicateZeros(int[] arr)
        {
            var list = new List<int>();
            foreach (var n in arr)
            {
                list.Add(n);
                if (n == 0) list.Add(0);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = list[i];
            }
        }
    }
}