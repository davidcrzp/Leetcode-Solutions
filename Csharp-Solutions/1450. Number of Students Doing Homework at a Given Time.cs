using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startTime = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] endTime = { 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            int queryTime = 5;
            Console.WriteLine(BusyStudent(startTime, endTime, queryTime));
        }
        public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int count = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if (queryTime >= startTime[i] && queryTime <= endTime[i]) count++;
            }
            return count;
        }
    }
}