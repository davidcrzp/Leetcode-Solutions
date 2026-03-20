using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(16);
        }
        public bool IsPowerOfFour(int n)
        {
            double d = n;
            while (d > 1) d /= 2;
            return d == 1;
        }
    }
}