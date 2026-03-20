using System;

namespace Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 2, 2, 5, 6, 7 };
            Console.WriteLine(RemoveDuplicates(nums));
        }
        static int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            var list = new List<int>();
            foreach (int d in nums)
            {
                if (list.Contains(d) != true)
                {
                    list.Add(d);
                    nums[i++] = d;
                }
            }
            return i;
        }
    }
}