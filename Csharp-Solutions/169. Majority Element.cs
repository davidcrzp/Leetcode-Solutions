using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(MajorityElement(nums));
        }
        static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                try
                {
                    dict.Add(item, 1);
                }
                catch
                {
                    dict[item] = (int)dict[item] + 1;
                }
            }
            dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return dict.Last().Key;
        }
    }
}