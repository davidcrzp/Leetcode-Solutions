using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanWinNim(4));
        }
        public static bool CanWinNim(int n)
        {
            return n % 4 != 0;
        }
    }
}