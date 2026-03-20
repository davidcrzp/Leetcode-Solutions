using System;

namespace Move_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);
        }
        static void MoveZeroes(int[] nums)
        {
            int[] noZeroArray = nums.Where(x => x != 0).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < noZeroArray.Length) nums[i] = noZeroArray[i];
                else nums[i] = 0;
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}