using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3 };
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
        }
        static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums = nums1.Concat(nums2).OrderBy(x => x).ToArray();
            if (nums.Length % 2 != 0) return nums[nums.Length / 2];
            return (nums[nums.Length / 2] + nums[nums.Length / 2 - 1]) / 2d;
        }
    }
}