using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 0, 1, 1, 1 };
            Console.WriteLine(FindMaxConsecutiveOnes(nums));
        }
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int con = 0;
            var max = new List<int>();
            foreach (var item in nums)
            {
                if (item == 0)
                {
                    max.Add(con);
                    con = 0;
                    continue;
                }
                else con++;
            }
            max.Add(con);
            return max.Max();
        }
    }
}