using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(536870912);
        }
        public bool IsPowerOfTwo(int n)
        {
            double d = n;
            while (d > 1) d /= 2;
            return d == 1;
        }
    }
}