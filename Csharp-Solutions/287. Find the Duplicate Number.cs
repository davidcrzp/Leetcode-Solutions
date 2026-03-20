using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 2, 2 };
            Console.WriteLine(FindDuplicate(nums));
        }
        public static int FindDuplicate(int[] nums)
        {
            HashSet<int> finder = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!finder.Add(nums[i])) return nums[i];
            }
            return -1;
        }
    }
}