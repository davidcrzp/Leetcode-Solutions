using System;
using System.Linq;

namespace Remove_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int num = 2;
            Console.WriteLine(RemoveElement(ref array, num));
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        static int RemoveElement(ref int[] nums, int val)
        {
            int j = 0;
            foreach (int i in nums)
            {
                if (i != val)
                {
                    nums[j++] = i;
                }
            }

            return j;
        }
    }
}