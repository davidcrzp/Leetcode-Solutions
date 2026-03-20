using System;

namespace Power_of_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = IsPowerOfThree(246);
            Console.WriteLine(x);
        }
        static bool IsPowerOfThree(int n)
        {
            if (n < 1) return false;
            while (n % 3 == 0)
                n /= 3;
            return n == 1;
        }
    }
}