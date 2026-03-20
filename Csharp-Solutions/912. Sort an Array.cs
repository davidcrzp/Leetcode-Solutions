using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = SortArray(new int[] { 5, 2, 3, 1 });
            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
        }
        static int[] SortArray(int[] nums)
        {
            Array.Sort(nums);
            return nums;
        }
    }
}