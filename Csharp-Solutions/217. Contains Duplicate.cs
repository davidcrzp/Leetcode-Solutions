using System;
using System.Collections;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(ContainsDuplicate(nums));
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> ht = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!ht.TryAdd(nums[i], 1)) return true;
            }
            return false;
        }
    }
}