using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine(Search(nums, 9));
        }
        static int Search(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;
            int mid;
            do
            {
                mid = (min + max) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) max = mid - 1;
                else min = mid + 1;
            } while (min <= max);
            return -1;
        }
    }
}