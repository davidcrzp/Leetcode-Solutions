using System;

namespace Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(4));
        }
        static int MySqrt(int x)
        {
            return Convert.ToInt32(Math.Floor(Math.Sqrt(x)));
        }
    }
}