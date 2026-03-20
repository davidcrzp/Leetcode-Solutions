using System;

namespace Happy_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsHappy(19));
        }
        static bool IsHappy(int n)
        {
            while (n > 4)
            {
                int i = n, j = 0;
                while (i > 0)
                {
                    j += Convert.ToInt32(Math.Pow(i % 10, 2));
                    i /= 10;
                }
                n = j;
            }
            return n == 1;
        }
    }
}