using System;

namespace Count_Odd_Numbers_in_an_Interval_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int low = 3, high = 7;
            int result = CountOdds(low, high); // Expected output 3
            Console.WriteLine(result); // Explanation: The odd numbers between 3 and 7 are [3,5,7]
        }
        public static int CountOdds(int low, int high)
        {
            int count = 0;
            for (int i = low; i <= high; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}