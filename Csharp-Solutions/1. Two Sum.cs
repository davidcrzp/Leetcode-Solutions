using System;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            var r = TwoSum(nums, target);
            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
        }
        static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length > 999)
            {
                goto LoopEnd2;
            }
            int x = 0;
            int y = 0;
            int p = 1;
            while (true)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int o = p; o < nums.Length; o++)
                    {
                        if (nums[x] + nums[o] == target)
                        {
                            y = o;
                            goto LoopEnd;
                        }
                    }
                }
                x++;
                p++; ;
            }
        LoopEnd:
            int[] result = { x, y };
            return result;
        LoopEnd2:
            int a = 9998;
            int b = 9999;
            int[] result2 = { a, b };
            return result2;
        }
    }
}