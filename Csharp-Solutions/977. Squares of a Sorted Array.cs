using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -4, -1, 0, 3, 10 };
            Console.WriteLine(SortedSquares(nums));
        }
        public static int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Math.Pow(nums[i], 2));
            }
            Array.Sort(nums);
            return nums;
        }
    }
}