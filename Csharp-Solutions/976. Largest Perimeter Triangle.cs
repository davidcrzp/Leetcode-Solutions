using System;

namespace Largest_Perimeter_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 6, 2, 3 }; // 2, 3, 3, 6
            int[] nums2 = { 1, 2, 2 }; // 1, 2, 2
            int[] nums3 = { 1, 2, 1, 10 }; // 1, 1, 2, 10
            int[] nums4 = { 3, 2, 3, 4 }; // 2, 3, 3, 4
            Console.WriteLine(LargestPerimeter(nums4));
        }
        static public int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            int n = 0;
            int result = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                n = nums[i] + nums[i + 1];
                if (n > nums.Last())
                {
                    result = n + nums.Last();
                }
                if (n > nums[i + 2])
                {
                    result = n + nums[i + 2];
                }
            }
            return result;
        }
    }
}