using System;
using System.Linq;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Array.ForEach(CountBits(5), x => Console.WriteLine(x));
        }
        public static int[] CountBits(int n)
        {
            int[] bitArray = new int[n + 1];
            bitArray[0] = 0;
            for (int i = 1; i < n + 1; i++)
            {
                bitArray[i] = NumberofBits(i);
            }
            return bitArray;
        }
        public static int NumberofBits(int n)
        {
            int result = 0;
            int length = Convert.ToString(n, 2).Length;
            for (int i = 0; i < length; i++)
            {
                if ((n & 1) == 1)
                    result++;
                n = n >> 1;
            }
            return result;
        }
    }
}