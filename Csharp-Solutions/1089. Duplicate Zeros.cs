using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 12, 345, 2, 6, 7896 };
            Console.WriteLine(FindNumbers(nums));
        }
        public static int FindNumbers(int[] nums)
        {
            int num = 0;
            foreach (var n in nums)
            {
                if (n.ToString().Length % 2 == 0) num++;
            }
            return num;
        }
    }
}