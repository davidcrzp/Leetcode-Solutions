using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            Console.WriteLine(SearchInsert(nums, 5));
        }
        public static int SearchInsert(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;
            int mid;
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) max = mid - 1;
                else min = mid + 1;
            }
            return min;
        }
    }
}