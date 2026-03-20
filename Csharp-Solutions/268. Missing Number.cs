using System;

namespace Missing_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            int result = MissingNumber(nums);
            Console.WriteLine(result);
        }
        static int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            int i = 1;
            bool arraycheck;
            while (i <= nums.Length)
            {
                arraycheck = Array.Exists(nums, x => x == i);
                if (arraycheck == false) return i;
                i++;
            }
            return 0;
        }
    }
}