using System;
using System.Numerics;

namespace Number_of_1_Bits
{
    class Progrma
    {
        static void Main(string[] args)
        {
            uint n = 00000000000000000000000000001011;
            int result = HammingWeight(n);
            Console.WriteLine(result);
        }
        public static int HammingWeight(uint n)
        {
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & 1) == 1)
                    result++;
                n = n >> 1;
            }
            return result;
        }
    }
}