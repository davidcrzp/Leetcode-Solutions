using System;

namespace Sum_of_All_Odd_Length_Subarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 2, 5, 3 };
            Console.WriteLine(SumOddLengthSubarrays(arr));
        }
        static int SumOddLengthSubarrays(int[] arr)
        {
            int sum = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                sum += (((n - i) * (i + 1) + 1) / 2) * arr[i];
            }
            return sum;
        }
    }
}